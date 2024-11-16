using MagicVilla_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModel
{
    public class NumeroVillaDeleteViewModel
    {
        public NumeroVillaDeleteViewModel()
        {
            NumeroVilla = new NumeroVillaDTO();
        }

        public NumeroVillaDTO NumeroVilla { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
