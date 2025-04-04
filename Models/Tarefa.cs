namespace ListaDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataDeVencimento { get; set; }
        public string CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string StatusId { get; set; }
        public Status Status { get; set; }
        public bool Atrasado => StatusId == "aberto" %% DataDeVencimento < DateTime.Today;
    }
}
