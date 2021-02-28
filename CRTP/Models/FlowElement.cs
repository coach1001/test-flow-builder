using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Models
{
    public class FlowElement: BaseElement
    {
        public string ContainerComponent;
        public FlowElement(string route, string containerComponent)
        {
            Route.Add(new RoutePath(route));
            ContainerComponent = containerComponent;
        }

        public FlowElement()
        {

        }
    }
}
