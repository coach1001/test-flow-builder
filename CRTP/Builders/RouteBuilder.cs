using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Builders
{
    public class RouteBuilder<TParentBuilder, TParentBuilderElement, TContextData>
        where TParentBuilderElement : BaseElement
    {
        public TParentBuilder ParentBuilder { get; set; }
        public TParentBuilderElement ParentBuilderElement { get; set; }

        public RouteBuilder(TParentBuilder parentBuilder, TParentBuilderElement parentBuilderElement)
        {
            ParentBuilder = parentBuilder;
            ParentBuilderElement = parentBuilderElement;
            ParentBuilderElement.Route.Clear();
        }

        public RouteBuilder<TParentBuilder, TParentBuilderElement, TContextData> AddStaticPath(string staticPath)
        {
            ParentBuilderElement.Route.Add(new RoutePath(staticPath));
            return this;
        }

        public TParentBuilder EndRoute()
        {
            return ParentBuilder;
        }
    }
}
