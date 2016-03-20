using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy.Models
{
    public class Point
    {
        public Point(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public Point()
        {
            Name = string.Empty;
            X = 0;
            Y = 0;
        }

        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int Rank { get; set; }
        public double Distance { get; set; }
    }
}