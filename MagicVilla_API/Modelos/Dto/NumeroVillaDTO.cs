﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class NumeroVillaDTO
    {
        [Required]
        public int VillaNumero { get; set; }

        [Required]
        public int VillaId { get; set; }
        public string DetalleEspecial { get; set; }

        public VillaDTO Villa { get; set; }
    }
}
