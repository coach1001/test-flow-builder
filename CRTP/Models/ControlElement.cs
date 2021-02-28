using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Models
{
    public class ControlElement : BaseElement
    {
        public Dictionary<string, object> Metadata { get; set; } = new Dictionary<string, object>();
        public bool CreateFormControl { get; set; } = true;
        public ControlElement()
        {
        }
    }
}
