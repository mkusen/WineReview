using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview.Model
{
    internal class EventPlace : Entity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PlaceName { get; set; }
        public string EventName { get; set; }
    }
}
