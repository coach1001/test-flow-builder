using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class StepBuilder<TElementData, TContextData, TParentBuilder>
        : BaseBuilder<StepBuilder<TElementData, TContextData, TParentBuilder>, StepElement, TElementData, TContextData>
    {
        public TParentBuilder ParentBuilder { get; set; }
        public StepBuilder(string name) : base(name)
        {
        }

        public StepBuilder()
        {

        }

        public StepBuilder<TElementData, TContextData,TParentBuilder>
            SetNavigationButtonLabels(string backButtonLabel = null, string nextButtonLabel = null, string saveButtonLabel = null)
        {
            Element.BackButtonLabel = backButtonLabel;
            Element.NextButtonLabel = nextButtonLabel;
            Element.SaveButtonLabel = saveButtonLabel;
            return this;
        }

        public ControlBuilder<TElementData, TContextData, StepBuilder<TElementData, TContextData, TParentBuilder>>
        AddControl<TChildControlData>(Expression<Func<TElementData, TChildControlData>> property, string renderedElement = "control")
        {
            var controlBuilder = CreateChildBuilder<ControlBuilder<TElementData,TContextData,StepBuilder<TElementData,TContextData,TParentBuilder>>, ControlElement, TElementData>(property, renderedElement);
            controlBuilder.ParentBuilder = this;
            return controlBuilder;
        }


        public TParentBuilder EndStep()
        {
            return ParentBuilder;
        }
    }
}
