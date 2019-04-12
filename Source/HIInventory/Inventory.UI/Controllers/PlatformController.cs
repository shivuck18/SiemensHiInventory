﻿using System.Collections.Generic;
using Inventory.Data;
using Inventory.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Inventory.Business.Contracts;

namespace Inventory.UI.Controllers
{
    public class PlatformController : Controller
    {

        private readonly IPlatformService _platformService;

       
        public PlatformController(IPlatformService platformService)
        {
               _platformService = platformService;
        }

        /// <summary>
        /// function to return list of platform 
        /// </summary>
        /// <returns>list of platform from database</returns>
        public IActionResult Index()
        {
            return View(_platformService.GetAll());
        }

        /// <summary>
        /// function for add 
        /// </summary>
        /// <returns>add page to add new platform</returns>
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(PlatformDto PlatformDto)
        {
            _platformService.Add(PlatformDto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
           var platform =_platformService.GetById(id);
             return View(platform);
        }

        [HttpPost]
        public IActionResult Save(PlatformDto platformDto)
        {
            _platformService.Update(platformDto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _platformService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}