using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy.Models
{
    public class Graph
    {
        public Graph()
        {
            points = new List<Point>();
        }

        public List<Point> points { get; set; }

        public List<Point> Init()
        {

            points.Add(new Point("Start", 0, 0));
            points.Add(new Point("First", 0, 0));
            points.Add(new Point("Second", 0, 0));
            points.Add(new Point("Third", 0, 0));
            points.Add(new Point("Fourth", 0, 0));
            points.Add(new Point("Fifth", 0, 0));
            points.Add(new Point("Sixth", 0, 0));
            points.Add(new Point("Seventh", 0, 0));
            points.Add(new Point("Eighth", 0, 0));
            points.Add(new Point("Ninth", 0, 0));
            points.Add(new Point("Tenth", 0, 0));

            return points;
        }

    }
}