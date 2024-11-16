using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Models.ViewModel
{
    public class VillaPaginadoViewModel
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public string Previous { get; set; } = "disabled";
        public string Siguiente { get; set; } = "";
        public IEnumerable<VillaDTO> VillaList { get; set; }
    }
}
