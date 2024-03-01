using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain
{
    public class Evento
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string Local { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataEvento { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string Tema { get; set; }
        [Column(TypeName = "int")]
        public int QtdPessoas { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string ImagemURL { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Telefone { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }

    }
}