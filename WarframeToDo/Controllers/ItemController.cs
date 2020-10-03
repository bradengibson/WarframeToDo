using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WarframeToDo.Objects.Items;

namespace WarframeToDo.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            // Load warframes from file
            /*List<Warframe> warframes;
            using (StreamReader file = File.OpenText(@"..\WarframeItemsJson\Warframes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                warframes = serializer.Deserialize<List<Warframe>>(file);
            }*/
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            string jsonString = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "WarframeItemsJson\\Warframes.json"));
            List<Warframe> warframes = JsonConvert.DeserializeObject<List<Warframe>>(jsonString);


            return View();
        }
    }
}