using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class ColorDto
    {
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public int Quantity { get; set; }
    }
}