using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Builders
{
    public class StepBuilder<TElementData, TContextData> : BaseBuilder<TElementData, TContextData, FlowBuilder<TElementData, TContextData>>
    {
        public StepBuilder(string name) : base(name)
        {
        }
    }
}
