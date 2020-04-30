using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EfStarTests1
{
    public class Quad
    {
        public Point King { get; set; }
        public Point Queen { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }

        public Quad(List<Star> stars)
        {
            double raMin = 0;
            double raMax = 0;
            double decMin = 0;
            double decMax = 0;

            var xlist = from s in stars
                        select s.DecimalRa;
            double xMin = xlist.Min();
            double xMax = xlist.Max();

            var ylist = from s in stars
                        select s.DecimalDec;
            double yMin = ylist.Min();
            double yMax = ylist.Max();

            double deltaX = xMax - xMin;
            double deltaY = yMax - yMin;

            List<Star> sortedStars = stars.OrderByDescending(x => x.Brightness).ToList();
            //Queue<Star> qStars = new Queue<Star>(sortedStars);
            King = new Point((int)Math.Round((sortedStars[0].DecimalRa-xMin)*deltaX), (int)Math.Round((sortedStars[0].DecDegrees-yMin)*deltaY));
            Queen = new Point((int)Math.Round((sortedStars[1].DecimalRa-xMin)*deltaX), (int)Math.Round((sortedStars[1].DecDegrees-yMin)*deltaY));
            //P3 = new Point((int)Math.Round(sortedStars[13].DecimalRa), (int)Math.Round(sortedStars[2].DecDegrees));
            //P4 = new Point((int)Math.Round(sortedStars[40].DecimalRa), (int)Math.Round(sortedStars[3].DecDegrees));

            //qStars.Dequeue();
            int l = sortedStars.Count()-1;
            Random rand = new Random(6476);
            int queenIndex = 0;
            int p3Index = 0;
            int p4Index = 0;
            int index = 0;
            while ((p3Index == 0) || (p3Index == queenIndex))
            {
                
                p3Index = (int)Math.Round(rand.NextDouble() * l);
            }
            P3 = new Point((int)Math.Round((sortedStars[p3Index].DecimalRa-xMin)*deltaX), (int)Math.Round((sortedStars[p3Index].DecDegrees-yMin)*deltaY));

            while ((p4Index == 0) || (p4Index == p3Index) || (p4Index == p3Index))
            {
                p4Index = (int)Math.Round(rand.NextDouble() * l);
            }
            P4 = new Point((int)Math.Round((sortedStars[p4Index].DecimalRa-xMin)*deltaX), (int)Math.Round((sortedStars[p4Index].DecDegrees-yMin)*deltaY));



        }

        public double Distance(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return result;
        }
    }
}
