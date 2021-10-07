using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace CoreDemo.Models
{
    public class CityAndWriter
    {
        public List<Cities> Cities { get; set; }
        public List<Writer> Writers { get; set; }
    }
}
