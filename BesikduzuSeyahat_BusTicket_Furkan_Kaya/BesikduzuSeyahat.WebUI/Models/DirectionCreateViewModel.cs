using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BesikduzuSeyahat.WebUI.Models
{
    public class DirectionCreateViewModel
    {
        public string Start { get; set; }
        public string direction1 { get; set; }
        public string direction2 { get; set; }
        public string direction3 { get; set; }
        public string Finish { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }

        public double Price { get; set; }
        public SelectList CitySelectList { get; set; }
    }
}
