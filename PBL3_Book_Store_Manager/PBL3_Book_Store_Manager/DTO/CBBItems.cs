using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Layers.DTO
{
    public class CBBItems
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
