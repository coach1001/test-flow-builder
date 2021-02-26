using CRTP.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CRTP.Builders
{
    public class BaseBuilder<TElementData, TContextData, TParentBuilder>
    {
        public BaseElement Element { get; set; }
        public TParentBuilder Parent { get; set; }

        public BaseBuilder(string name, TParentBuilder parent)
        {
            Element = new BaseElement();
            Element.Name = name;
            Parent = parent;
        }

        public BaseBuilder(string name)
        {
            Element = new BaseElement();
            Element.Name = name;
        }

        public TParentBuilder EndElement()
        {
            return Parent;
        }
    }
}
