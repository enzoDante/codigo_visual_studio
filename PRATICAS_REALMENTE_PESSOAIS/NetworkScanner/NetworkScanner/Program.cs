using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

public class NetworkScanner
{
    // Método para obter informações detalhadas da rede local
    public static (string LocalIP, string SubnetMask, string DefaultGateway) GetNetworkInfo()
    {
        foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (netInterface.OperationalStatus == OperationalStatus.Up)
            {
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation ipInfo in ipProps.UnicastAddresses)
                {
                    if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        string localIP = ipInfo.Address.ToString();
                        string subnetMask = ipInfo.IPv4Mask.ToString();
                        string defaultGateway = ipProps.GatewayAddresses.Count > 0
                            ? ipProps.GatewayAddresses[0].Address.ToString()
                            : "N/A";

                        return (localIP, subnetMask, defaultGateway);
                    }
                }
            }
        }
        throw new Exception("Não foi possível obter informações de rede");
    }

    // Método de varredura de rede aprimorado
    public static async Task ScanNetworkAdvanced()
    {
        var (localIP, subnetMask, gateway) = GetNetworkInfo();
        Console.WriteLine($"IP Local: {localIP}");
        Console.WriteLine($"Máscara de Sub-rede: {subnetMask}");
        Console.WriteLine($"Gateway Padrão: {gateway}");

        // Gerar range de IPs baseado na sub-rede
        string[] ipParts = localIP.Split('.');
        List<string> ipRange = new List<string>();

        // Gerar IPs para varredura
        for (int i = 1; i <= 254; i++)
        {
            string testIP = $"{ipParts[0]}.{ipParts[1]}.{ipParts[2]}.{i}";
            if (testIP != localIP) // Evitar testar o próprio IP
            {
                ipRange.Add(testIP);
            }
        }

        // Realizar varredura simultânea
        var tasks = ipRange.Select(ip => ScanHostAdvanced(ip));
        var results = await Task.WhenAll(tasks);

        // Apresentar resultados
        Console.WriteLine("\nDispositivos na Rede:");
        for (int i = 0; i < ipRange.Count; i++)
        {
            if (results[i].IsOnline)
            {
                Console.WriteLine($"IP: {ipRange[i]} - Status: Online");
                Console.WriteLine($"  Hostname: {results[i].Hostname}");
                Console.WriteLine($"  MAC: {results[i].MacAddress}");
            }
        }
    }

    // Método de varredura avançado de host
    private static async Task<HostInfo> ScanHostAdvanced(string ip)
    {
        var result = new HostInfo { IP = ip };

        // Tentativa de Ping
        try
        {
            using (Ping ping = new Ping())
            {
                PingReply reply = await ping.SendPingAsync(ip, 1000);
                result.IsOnline = reply.Status == IPStatus.Success;
            }
        }
        catch
        {
            result.IsOnline = false;
        }

        // Tentar obter hostname
        if (result.IsOnline)
        {
            try
            {
                result.Hostname = Dns.GetHostEntry(ip).HostName;
            }
            catch
            {
                result.Hostname = "Desconhecido";
            }

            // Tentar obter endereço MAC
            result.MacAddress = GetMacAddress(ip);
        }

        return result;
    }

    // Método para obter endereço MAC
    private static string GetMacAddress(string ipAddress)
    {
        try
        {
            // Usar ARP para obter endereço MAC
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "arp",
                Arguments = $"-a {ipAddress}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (var process = System.Diagnostics.Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Processar saída do ARP para extrair MAC
                string[] lines = output.Split('\n');
                foreach (string line in lines)
                {
                    if (line.Trim().StartsWith(ipAddress))
                    {
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 2)
                        {
                            return parts[1];
                        }
                    }
                }
            }
        }
        catch
        {
            // Silenciosamente tratar falha na obtenção do MAC
        }

        return "N/A";
    }

    // Classe para armazenar informações do host
    private class HostInfo
    {
        public string IP { get; set; }
        public bool IsOnline { get; set; }
        public string Hostname { get; set; }
        public string MacAddress { get; set; }
    }

    static async Task Main(string[] args)
    {
        await ScanNetworkAdvanced();
    }

}