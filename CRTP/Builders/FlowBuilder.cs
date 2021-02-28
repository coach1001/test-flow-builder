using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class FlowBuilder<TElementData, TContextData> 
        : BaseBuilder<FlowBuilder<TElementData, TContextData>, FlowElement, TElementData, TContextData>
    {
        public FlowBuilder(string route, string containerComponent) : base(route)
        {
            Element.Route.Add(new RoutePath(route));
            Element.ContainerComponent = containerComponent;
        }

        public StepBuilder<TElementData, TContextData, FlowBuilder<TElementData, TContextData>> 
            AddStep<TChildStepData>(Expression<Func<TElementData, TChildStepData>> property, string name)
        {
            var stepBuilder = CreateChildBuilder<StepBuilder<TElementData,TContextData,FlowBuilder<TElementData,TContextData>>, StepElement, TElementData>(property, name);
            stepBuilder.ParentBuilder = this;
            return stepBuilder;
        }

    }
}
