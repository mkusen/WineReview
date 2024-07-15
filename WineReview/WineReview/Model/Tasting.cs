using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview.Model
{
    internal class Tasting: Entity
    {
        public int IdReviewer { get; set; }
        public int IdWine { get; set; }
        public int EventPlace { get; set; }
        public string Review { get; set; }
        public DateTime EventDate { get; set; }

    }
}
