using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Builders.TextControl
{
    public static class TextControlBuilderExtensions
    {
        public static TextControlBuilder<TElementData,TContextData,TParentBuilderType> 
            TextControl<TElementData, TContextData, TParentBuilderType>(
            this ControlBuilder<TElementData,TContextData,TParentBuilderType> controlBuilder, 
            string renderedElement = "text-control")
        {
            return new TextControlBuilder<TElementData, TContextData, TParentBuilderType>(controlBuilder,renderedElement);
        }
    }
}
