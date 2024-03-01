using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string URL { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}