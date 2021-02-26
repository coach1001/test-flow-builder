using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Models
{
    public class BaseElement
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public List<BaseElement> ChildElements { get; set; }
    }
}
