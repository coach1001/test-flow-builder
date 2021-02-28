using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Models
{
    public class StepElement: BaseElement
    {
        public string BackButtonLabel { get; set; } = "Back";
        public string NextButtonLabel { get; set; } = "Next";
        public string SaveButtonLabel { get; set; } = "Save";
        public bool HideNavigationButtons { get; set; } = false;
    }
}
