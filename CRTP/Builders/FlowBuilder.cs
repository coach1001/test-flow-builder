using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class FlowBuilder<TElementData, TContextData> : BaseBuilder<TElementData, TContextData, FlowBuilder<TElementData, TContextData>>
    {
        public FlowBuilder(string name) : base(name)
        {
        }

        public StepBuilder<TChildData, TContextData> AddStep<TChildData>(Expression<Func<TElementData, TChildData>> property, string name)
        {
            var stepBuilder = new StepBuilder<TChildData, TContextData>(name);
            if (Element.ChildElements == null) Element.ChildElements = new List<BaseElement>();
            Element.ChildElements.Add(stepBuilder.Element);
            return stepBuilder;
        }

    }
}
