using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview.Model
{
    internal class Wine : Entity
    {
        public string Maker { get; set; }
        public string WineName { get; set; }
        public string YearOfHarvest { get; set; }
        public float Price { get; set; }
    }
}
