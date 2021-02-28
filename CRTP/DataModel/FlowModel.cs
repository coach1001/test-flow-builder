using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.DataModel
{
    public class FlowModel: FlowElement
    {
        public StepOneModel StepOne { get; set; }
        public StepTwoModel StepTwo { get; set; }

    }
}
