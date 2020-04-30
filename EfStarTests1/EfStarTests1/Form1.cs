using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace EfStarTests1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDump200_Click(object sender, EventArgs e)
        {
            using (var ctx = new StarModel1())
            {
                var x = from s in ctx.Stars
                        where s.RaHours == 0
                        select s;
                var lst = x.ToList();
                for (int i = 0; i < 200; i++)
                {
                    Dump(lst[i].Id + "  " + lst[i].DecimalRa);
                }
            }
        }

        private void Dump(string msg)
        {
            txtOutput.Text += msg + Environment.NewLine;
        }

        private void cmdFindNear1_Click(object sender, EventArgs e)
        {
            float raCenter = 180;
            float decCenter = 0;
            float fov = 20;
            double raMin = 170 / 15;
            float raMax = 190 / 15;
            float decMin = -10;
            float decMax = 10;

            using (var ctx = new StarModel1())
            {
                int sum = 0;
                int count = 1;
                for (int ra = 0; ra <= 340; ra += 20)
                {
                    for (int dec = -90; dec <= 70; dec += 20)
                    {
                        var r = new Region();
                        r.MinRa = ra;
                        r.MaxRa = ra + 20;
                        r.MinDec = dec;
                        r.MaxDec = dec + 20;
                        ctx.Regions.Add(r);
                        ctx.SaveChanges();
                        var qry = from s in ctx.Stars
                                  where s.DecimalRa >= ra && s.DecimalRa <= ra + 20 &&
                                        s.DecimalDec >= dec && s.DecimalDec <= dec + 20
                                  select s;

                        sum += qry.Count();
                        //Dump(qry.Count() + "  ,  " + sum);
                        Dump(string.Format("{5}   Ra Min:{0}, Ra Max:{1}, Dec Min:{2}, Dec Max:{3},  Count ={4}",
                            ra, ra + 20, dec, dec + 20, qry.Count(), count));
                        Dump("");
                        count++;
                        foreach (var item in qry)
                        {
                            item.Region = r.Id;


                        }
                    }

                }
                ctx.SaveChanges();
            }
        }

        private void cmdFindMinMax_Click_1(object sender, EventArgs e)
        {
            double raMin = Convert.ToDouble(txtRaMin.Text);
            double raMax = Convert.ToDouble(txtRaMax.Text);
            double decMin = Convert.ToDouble(txtDecMin.Text);
            double decMax = Convert.ToDouble(txtDecMax.Text);
            using (var ctx = new StarModel1())
            {
                var qry = from s in ctx.Stars
                          where s.DecimalRa >= raMin && s.DecimalRa <= raMax &&
                                s.DecimalDec >= decMin && s.DecimalDec <= decMax
                          select s;
                var count = qry.ToList().Count();
                Dump(string.Format("Stars in region  RA {0}-{1},  Dec {2}-{3}   {4}",
                    raMin, raMax, decMin, decMax, count));
            }

        }

        private void Import_Click_1(object sender, EventArgs e)
        {
            string file = @"C:\Users\Chris\Documents\Star Catalogs\Stars4.csv";
            //string[] lines = File.ReadAllLines(file);
            //foreach (var line in lines)
            //{

            //}
            using (var ctx = new StarModel1())
            {
                using (TextFieldParser parser = new TextFieldParser(file))
                {

                    parser.Delimiters = new string[] { "," };
                    string[] parts = parser.ReadFields();

                    while (true)
                    {
                        parts = parser.ReadFields();
                        if (parts == null)
                        {
                            break;
                        }
                        try
                        {
                            var newStar = new Star();
                            newStar.Id = Convert.ToInt32(parts[0]);
                            newStar.RaHours = Convert.ToDouble(parts[1]);
                            newStar.RaMinutes = Convert.ToDouble(parts[2]);
                            newStar.RaSeconds = Convert.ToDouble(parts[3]);
                            newStar.DecDegrees = Convert.ToDouble(parts[4]);
                            newStar.DecMinutes = Convert.ToDouble(parts[5]);
                            newStar.DecSeconds = Convert.ToDouble(parts[6]);
                            newStar.DecimalRa = Convert.ToDouble(parts[8]);
                            newStar.DecimalDec = Convert.ToDouble(parts[9]);
                            newStar.Magnitude = Convert.ToDouble(parts[10]);
                            newStar.Brightness = Convert.ToDouble(parts[11]);

                            ctx.Stars.Add(newStar);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("error");
                        }


                        //Console.WriteLine("{0} field(s)", parts[0]);
                    }
                }
                ctx.SaveChanges();
            }

        }

        private void cmdEmptyStars_Click_1(object sender, EventArgs e)
        {

            using (var ctx = new StarModel1())
            {
                var stars = from s in ctx.Stars
                            where s.Id > 0
                            select s;
                ctx.Stars.RemoveRange(stars);

                var regions = from g in ctx.Regions
                              select g;
                ctx.Regions.RemoveRange(regions);

                ctx.SaveChanges();


            }
        }

        private void cmdDumpByQuadrant_Click_1(object sender, EventArgs e)
        {

            using (var ctx = new StarModel1())
            {
                foreach (var r in ctx.Regions)
                {
                    //Console.WriteLine("REgion: " + r.Id);
                    Console.WriteLine(string.Format("ID:{0}  minRa:{1},maxRa:{2}   minDec:{3}, maxDec{4}",
                            r.Id, r.MinRa, r.MaxRa, r.MinDec, r.MaxDec));
                    var qry = from s in ctx.Stars
                              where s.Region == r.Id
                              select s;
                    var lst = qry.ToList().OrderByDescending(x => x.Brightness);
                    foreach (var star in lst)
                    {
                        Console.WriteLine(string.Format("      Id:{0}, Ra:{1}   Dec:{2}   Brightness:{3}",
                            star.Id, star.DecimalRa, star.DecimalDec, star.Brightness));

                    }
                    Quads1(lst.ToList());
                }
            }
        }
        public void Quads1(List<Star> stars)
        {
            var xlist = from s in stars
                        select s.DecimalRa;
            double xMin = xlist.Min();
            double xMax = xlist.Max();

            var ylist = from s in stars
                        select s.DecimalDec;
            double yMin = ylist.Min();
            double yMax = ylist.Max();

            Console.WriteLine("    **  {0},{1}  --  {2},{3}", xMin, yMin, xMax, yMax);
            Console.WriteLine("    **  DeltaX:{0}    DeltaY{1}", xMax - xMin, yMax - yMin);

        }

        private void cmdFindMinMax_Click(object sender, EventArgs e)
        {
            double raMin = Convert.ToDouble(txtRaMin.Text);
            double raMax = Convert.ToDouble(txtRaMax.Text);
            double decMin = Convert.ToDouble(txtDecMin.Text);
            double decMax = Convert.ToDouble(txtDecMax.Text);
            using (var ctx = new StarModel1())
            {
                var qry = from s in ctx.Stars
                          where s.DecimalRa >= raMin && s.DecimalRa <= raMax &&
                                s.DecimalDec >= decMin && s.DecimalDec <= decMax
                          select s;
                DrawCircles(qry.ToList());
                var count = qry.ToList().Count();
                //Dump(string.Format("Number of Stars in Region: {0}", count));
                Dump(string.Format("{4}    Stars in region  RA {0} - {1},  Dec {2} - {3}   ",
                    raMin, raMax, decMin, decMax, count));

                var xlist = from s in qry
                            select s.DecimalRa;
                double xMin = xlist.Min();
                double xMax = xlist.Max();

                var ylist = from s in qry
                            select s.DecimalDec;
                double yMin = ylist.Min();
                double yMax = ylist.Max();
                Dump(string.Format("    **  DeltaX:{0}    DeltaY:{1}", xMax - xMin, yMax - yMin));
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void cmdDraw1_Click(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 1);
            Rectangle rect = new Rectangle(80, 80, 3, 3);
            // e.Graphics.DrawEllipse(redPen, rect);
            pbImage.CreateGraphics().DrawEllipse(redPen, rect);

            Point[] OpenPoints =
                {
                    new Point(74, 20),
                    new Point(97, 61),
                    new Point(134, 41),
                    new Point(100, 120),
                    new Point(24, 87),
                    new Point(9, 36),
                    new Point(63, 57),
                };
            pbImage.CreateGraphics().DrawLines(redPen, OpenPoints);
        }

        public void DrawCircles(List<Star> stars)
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

            stars = stars.OrderByDescending(x => x.Brightness).ToList();
            List<Point> points = new List<Point>();
            Color color = Color.Green;
            foreach (var star in stars)
            {
                int x = (int)Math.Round((star.DecimalRa - xMin) * deltaX);
                int y = (int)Math.Round((star.DecimalDec - yMin) * deltaY);
                //points.Add(new Point(x, y));
                DrawCircle(x, y, 2, color);
                color = Color.Red;
            }

            Point[] OpenPoints = new Point[4];
            //for (int i = 25; i < 26; i++)
            //{
            //    int x1 = (int)Math.Round((stars[i].DecimalRa - xMin) * deltaX);
            //    int y1 = (int)Math.Round((stars[i].DecimalDec - yMin) * deltaY);

            //    int x2 = (int)Math.Round((stars[i+1].DecimalRa - xMin) * deltaX);
            //    int y2 = (int)Math.Round((stars[i+1].DecimalDec - yMin) * deltaY);

            //    int x3 = (int)Math.Round((stars[i+2].DecimalRa - xMin) * deltaX);
            //    int y3 = (int)Math.Round((stars[i+2].DecimalDec - yMin) * deltaY);

            //    int x4 = (int)Math.Round((stars[i+3].DecimalRa - xMin) * deltaX);
            //    int y4 = (int)Math.Round((stars[i+3].DecimalDec - yMin) * deltaY);

            //    OpenPoints[0] = new Point(x1, y1);
            //    OpenPoints[0] = new Point(x2, y2);
            //    OpenPoints[0] = new Point(x3, y3);
            //    OpenPoints[0] = new Point(x4, y4);
            //    Pen redPen = new Pen(Color.Red, 1);
            //pbImage.CreateGraphics().DrawPolygon(redPen, OpenPoints);

            //}

            Quad q1 = new Quad(stars);
            Dump(string.Format("---Showing King:{0},{1}", q1.King.X, q1.King.Y));
            Dump(string.Format("---Showing Queen:{0},{1}", q1.Queen.X, q1.Queen.Y));
            Dump(string.Format("---Showing P3:{0},{1}", q1.P3.X, q1.P3.Y));
            Dump(string.Format("---Showing P4:{0},{1}", q1.P4.X, q1.P4.Y));
            Dump("");
            OpenPoints[0] = q1.King;
            OpenPoints[1] = q1.Queen;
            OpenPoints[2] = q1.P3;
            OpenPoints[3] = q1.P4;
            Pen redPen = new Pen(Color.Red, 1);
            Pen bluePen = new Pen(Color.Blue, 1);
            Pen yellowPen = new Pen(Color.Yellow, 1);
            Pen greenPen = new Pen(Color.Green, 1);
            pbImage.CreateGraphics().DrawPolygon(greenPen, OpenPoints);
            OpenPoints = new Point[4];

            Queue<Star> queue1 = new Queue<Star>(stars);
            queue1.Dequeue();
            List<Star> l1 = queue1.ToList();

            Quad q2 = new Quad(l1);
            Dump(string.Format("---Showing King:{0},{1}", q2.King.X, q2.King.Y));
            Dump(string.Format("---Showing Queen:{0},{1}", q2.Queen.X, q2.Queen.Y));
            Dump(string.Format("---Showing P3:{0},{1}", q2.P3.X, q2.P3.Y));
            Dump(string.Format("---Showing P4:{0},{1}", q2.P4.X, q2.P4.Y));
            Dump("");
            OpenPoints[0] = q2.King;
            OpenPoints[1] = q2.Queen;
            OpenPoints[2] = q2.P3;
            OpenPoints[3] = q2.P4;
            pbImage.CreateGraphics().DrawPolygon(redPen, OpenPoints);
            OpenPoints = new Point[4];

            Queue<Star> queue2 = new Queue<Star>(stars);
            queue2.Dequeue();
            List<Star> l2 = queue2.ToList();
            Quad q3 = new Quad(l2);
            Dump(string.Format("---Showing King:{0},{1}", q3.King.X, q3.King.Y));
            Dump(string.Format("---Showing Queen:{0},{1}", q3.Queen.X, q3.Queen.Y));
            Dump(string.Format("---Showing P3:{0},{1}", q3.P3.X, q3.P3.Y));
            Dump(string.Format("---Showing P4:{0},{1}", q3.P4.X, q3.P4.Y));
            Dump("");
            OpenPoints[0] = q3.King;
            OpenPoints[1] = q3.Queen;
            OpenPoints[2] = q3.P3;
            OpenPoints[3] = q3.P4;
            pbImage.CreateGraphics().DrawPolygon(bluePen, OpenPoints);
            OpenPoints = new Point[4];


            Queue<Star> queue4 = new Queue<Star>(stars);
            queue4.Dequeue();
            List<Star> l4 = queue4.ToList();
            Quad q4 = new Quad(l4);
            Dump(string.Format("---Showing King:{0},{1}", q4.King.X, q4.King.Y));
            Dump(string.Format("---Showing Queen:{0},{1}", q4.Queen.X, q4.Queen.Y));
            Dump(string.Format("---Showing P3:{0},{1}", q4.P3.X, q4.P3.Y));
            Dump(string.Format("---Showing P4:{0},{1}", q4.P4.X, q4.P4.Y));
            Dump("");
            OpenPoints[0] = q4.King;
            OpenPoints[1] = q4.Queen;
            OpenPoints[2] = q4.P3;
            OpenPoints[3] = q4.P4;
            pbImage.CreateGraphics().DrawPolygon(yellowPen, OpenPoints);
        }

        public void DrawCircle(int x, int y, int width, Color color)
        {
            Pen redPen = new Pen(color, 1);
            Rectangle rect = new Rectangle(x, y, width, width);
            pbImage.CreateGraphics().DrawEllipse(redPen, rect);
        }


    }
}
