using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WarframeToDo.Objects.Items;
using WarframeToDo.ViewModels.Item;

namespace WarframeToDo.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            // Load the list of warframes
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string jsonString = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "WarframeItemsJson\\Warframes.json"));
            List<Warframe> warframes = JsonConvert.DeserializeObject<List<Warframe>>(jsonString);

            // Initialize the ViewModel
            ViewModelItemIndex viewModelItemIndex = new ViewModelItemIndex(warframes);

            return View(viewModelItemIndex);
        }
    }
}