namespace DesafioDIO_SistemaAgendamentoTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public DateTime Data {  get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
