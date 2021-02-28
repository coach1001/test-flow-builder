using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CRTP.Models
{
    public class BaseElement
    {
        public string Name { get; set; }
        [JsonIgnore]
        public Type ElementType { get; set; }
        public string Label { get; set; }
        public List<BaseElement> ChildElements { get; set; }
        public IList<RoutePath> Route { get; set; } = new List<RoutePath>();
        public IList<BaseElement> Elements { get; set; } = new List<BaseElement>();
        public string RenderedElement { get; set; }
    }
}
