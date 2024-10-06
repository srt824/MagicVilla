using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexVilla()
        {

            List<VillaDTO> villaList = new();

            var response = await _villaService.ObtenerTodos<APIResponse>();

            if (response != null && response.IsSuccesfull)
            {
                villaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(villaList);
        }

        //Get
        public async Task<IActionResult> CrearVilla()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearVilla(VillaCreateDTO modelo)
        {
            if(ModelState.IsValid)
            {
                var response = await _villaService.Crear<APIResponse>(modelo);

                if(response != null && response.IsSuccesfull)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            return View(modelo);
        }

        public async Task<IActionResult> ActualizarVilla(int villaId)
        {
            var response = await _villaService.Obtener<APIResponse>(villaId);

            if(response != null && response.IsSuccesfull)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<VillaUpdateDTO>(model));
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ActualizarVilla(VillaUpdateDTO modelo)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaService.Actualizar<APIResponse>(modelo);

                if(response !=null && response.IsSuccesfull)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            return View(modelo);
        }

        public async Task<IActionResult> RemoverVilla(int villaId)
        {
            var response = await _villaService.Obtener<APIResponse>(villaId);

            if (response != null && response.IsSuccesfull)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverVilla(VillaDTO modelo)
        {
            
                var response = await _villaService.Remover<APIResponse>(modelo.Id);

                if (response != null && response.IsSuccesfull)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            
            return View(modelo);
        }
    }
}
