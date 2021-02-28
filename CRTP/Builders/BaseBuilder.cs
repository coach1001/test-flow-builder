using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class BaseBuilder<TBuilderType, TElementType, TElementData, TContextData>
        where TBuilderType : BaseBuilder<TBuilderType, TElementType, TElementData, TContextData>
        where TElementType : BaseElement, new()
    {
        public TElementType Element { get; set; }

        public BaseBuilder(string name)
        {
            Element = new TElementType();
            Element.ElementType = typeof(TElementType);
            Element.Name = name;
        }

        public BaseBuilder()
        {

        }

        public TBuilderType Label(string label)
        {
            Element.Label = label;
            return (TBuilderType)this;
        }

        public RouteBuilder<TBuilderType, TElementType, TContextData> BuildRoute()
        {
            return new RouteBuilder<TBuilderType, TElementType, TContextData>((TBuilderType)this, (TElementType)Element);
        }

        public TChildBuilderType CreateChildBuilder<TChildBuilderType, TChildElementType, TChildElementData>(Expression expression, string renderedElement, string route = null)
            where TChildBuilderType: BaseBuilder<TChildBuilderType, TChildElementType, TChildElementData, TContextData>,new()
            where TChildElementType : BaseElement, new()
        {
                var childBuilder = new TChildBuilderType();
                if(Element.Elements == null)
                {
                Element.Elements = new List<BaseElement>();
                }
                Element.Elements.Add(childBuilder.Element);
                childBuilder.Element.RenderedElement = renderedElement;
                return childBuilder;
        }

        public TElementType Build()
        {
            return Element;
        }
    }
}
