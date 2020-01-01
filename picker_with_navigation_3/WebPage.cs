using System;
using System.Collections.Generic;
using System.Text;

namespace UltimateConvertor
{
    public class WebPage
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public string GetTitle()
        {
            return Title;
        }

        public string GetName()
        {
            return Name;
        }

    }
}
