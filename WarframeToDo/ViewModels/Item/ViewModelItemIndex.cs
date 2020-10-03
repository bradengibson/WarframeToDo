using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarframeToDo.Objects.Items;

namespace WarframeToDo.ViewModels.Item
{
    public class ViewModelItemIndex
    {
        public List<Warframe> Warframes;

        public ViewModelItemIndex()
        {
            Warframes = new List<Warframe>();
        }

        public ViewModelItemIndex(List<Warframe> wf)
        {
            Warframes = wf;
        }
    }
}