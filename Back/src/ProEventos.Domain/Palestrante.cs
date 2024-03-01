using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string MiniCurriculo { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string ImagemURL { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Telefone { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}