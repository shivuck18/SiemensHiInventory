using System.Collections.Generic;
using Inventory.Data;
using Inventory.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Inventory.UI.Controllers
{
    public class PlatformController : Controller
    {

        //private readonly IPlatformService _platformService;

        // created object of platformService 

        //public PlatformController(IPlatformService platformService)
        //{
        //    _platformService = platformService;
        //}


        List<PlatformDto> platforms = new List<PlatformDto>();

        public IActionResult Index()
        {
            //return View(_platformService.GettAll());

            PopulateData();
            return View(platforms);
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(PlatformDto PlatformDto)
        {
            //databaseContext.HiInventory.Add(PlatformDto);
            //databaseContext.SaveChanges();

            // IPlatformService.Add(platofrmDto); // TODO Call Business Service

            //_platformService.add(PlatformDto);
            platforms.Add(PlatformDto);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            //it will call _platformService interface method and edit with respect to id
            // _platformService.edit(id);
            PopulateData();
            var platform = platforms.FirstOrDefault(x => x.Id == id);
            return View("Add", platform);
        }

        public IActionResult Delete(int id)
        {
            //it will call _platformService interface method and delete with respect to id
            //_platformService.delete(id);
            //below line will redirect to main page
            return RedirectToAction(nameof(Index));
        }

        private void PopulateData()
        {
            platforms.Add(new PlatformDto()
            {
                Id = 1,
                PlatformName = "Test Platform",
                IcType = "Test Ic Type"
            });

            platforms.Add(new PlatformDto()
            {
                Id = 2,
                PlatformName = "Test Platform 2",
                IcType = "Test Ic Type 2"
            });

            platforms.Add(new PlatformDto()
            {
                Id = 3,
                PlatformName = "Test Platform 3",
                IcType = "Test Ic Type 3"
            });
        }

    }
}