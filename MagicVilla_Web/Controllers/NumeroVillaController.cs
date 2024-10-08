﻿using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla_Web.Controllers
{
    public class NumeroVillaController : Controller
    {

        private readonly INumeroVillaService _numeroVillaService;
        private readonly IMapper _mapper;

        public NumeroVillaController(INumeroVillaService numeroVillaService, IMapper mapper)
        {
            _numeroVillaService = numeroVillaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexNumeroVilla()
        {

            List<NumeroVillaDTO> numeroVillaList = new();

            var response = await _numeroVillaService.ObtenerTodos<APIResponse>();

            if(response != null && response.IsSuccesfull)
            {
                numeroVillaList = JsonConvert.DeserializeObject<List<NumeroVillaDTO>>(Convert.ToString(response.Result));
            }
            return View(numeroVillaList);
        }
    }
}
