using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class ControlBuilder<TElementData, TContextData, TParentBuilderType> : 
        BaseBuilder<ControlBuilder<TElementData, TContextData, TParentBuilderType>,ControlElement, TElementData,TContextData>
    {
        public ControlBuilder(string name): base(name){}
        public ControlBuilder() { }

        public TParentBuilderType ParentBuilder { get; set; }


        public TParentBuilderType EndControl()
        {
            return ParentBuilder;
        }
    }
}
