using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class NumeroVillaCreateDTO
    {
        [Required]
        public int VillaNumero { get; set; }

        [Required]
        public int VillaId { get; set; }
        public string DetalleEspecial { get; set; }
    }
}
