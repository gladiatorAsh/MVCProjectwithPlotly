using Dummy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy.Intermediate
{
    public class Distances
    {

        public double CalculateFromStart(Point start, Point point)
        {
            var x = Math.Pow(start.X - point.X, 2);
            var y = Math.Pow(start.Y - point.Y, 2);

            var sqrt = Math.Sqrt(x + y);
            return sqrt;
        }

        public List<Point> CalculateAllDistances(Point start, List<Point> points)
        {
            foreach (Point point in points)
            {
                point.Distance = CalculateFromStart(start, point);
            }

            return points;
        }

        internal List<Point> CalculateRanks(List<Point> points)
        {
            var temp = points.OrderBy(p => p.Distance);

            int i = 0;
            foreach (Point p in temp)
            {
                i++;
                p.Rank = i;
            }

            return temp.ToList();
        }
    }
}