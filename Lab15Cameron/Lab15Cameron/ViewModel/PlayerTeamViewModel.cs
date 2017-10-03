using Lab15Cameron.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15Cameron.ViewModel
{
    public class PlayerTeamViewModel
    {
        public List<Players> ballPlayer;
        public SelectList teamCity;
        public string playerCity { get; set; }
    }
}
