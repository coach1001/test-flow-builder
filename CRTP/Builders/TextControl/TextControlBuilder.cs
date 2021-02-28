using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Builders.TextControl
{
    public class TextControlBuilder<TElementdata, TContextData, TParentBuilderType>
    {
        ControlBuilder<TElementdata, TContextData, TParentBuilderType> ControlBuilder { get; set; }

        public TextControlBuilder(ControlBuilder<TElementdata, TContextData, TParentBuilderType> controlBuilder, string renderedElement)
        {
            ControlBuilder = controlBuilder;
            controlBuilder.Element.RenderedElement = renderedElement;
        }

        public ControlBuilder<TElementdata, TContextData, TParentBuilderType> EndTextcontrol()
        {
            return ControlBuilder;
        }
    }
}
