using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain
{
    public class Lote
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string Nome { get; set; }
        [Column(TypeName = "float"), Required]
        public decimal Preco { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFim { get; set; }
        [Column(TypeName = "int")]
        public int Quantidade { get; set; }
        [Column(TypeName = "int")]
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}