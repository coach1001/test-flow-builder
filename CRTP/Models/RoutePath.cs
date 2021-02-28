using System;
using System.Collections.Generic;
using System.Text;

namespace CRTP.Models
{
    public class RoutePath
    {
        public string Path { get; set; }
        
        public RoutePath(string path)
        {
            Path = path;
        }
    }
}
