using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_mod
{
    public partial class Form1 : Form
    {
        Graphics graf;
        List<Point> points = new List<Point>();
        List<Point> new_figure = new List<Point>();
        List<Point> figure = new List<Point>();
        int n;
        int eps = 5;
        bool flag = false;
        bool ok = false;
        Point centre;
        Point A;
        Point B;
        int a;
        double t;
        double dt = 0.05;
        int pos;
        Pen pen = new Pen(Color.Blue);

        public Form1()
        {
            InitializeComponent();
            graf = CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            n = -1;
            if (e.Button == MouseButtons.Left && !flag)
            {
                points.Add(new Point(e.X, e.Y));
                graf.DrawRectangle(Pens.Red, e.X - 2, e.Y - 2, 5, 5);
            }
            if (e.Button == MouseButtons.Left && flag)
            {
                figure.Add(new Point(e.X, e.Y));
                graf.DrawRectangle(Pens.Red, e.X - 2, e.Y - 2, 5, 5);
            }
            if (e.Button == MouseButtons.Right && !flag)
            {
                for (int i = 0; i < points.Count(); i++)
                {
                    if (points[i].X < e.X + eps && points[i].X > e.X - eps && points[i].Y < e.Y + eps && points[i].Y > e.Y - eps)
                    {
                        n = i;
                    }
                }
            }
            if (e.Button == MouseButtons.Right && flag)
            {
                for (int i = 0; i < figure.Count(); i++)
                {
                    if (figure[i].X < e.X + eps && figure[i].X > e.X - eps && figure[i].Y < e.Y + eps && figure[i].Y > e.Y - eps)
                    {
                        n = i;
                    }
                }
            }
        }    private void DrawScene()
        {
            graf.Clear(Color.White);
            if (!timer1.Enabled)
            {
                for (int i = 0; i < points.Count(); i++)
                {
                    graf.DrawLine(Pens.Black, points[i], points[(i + 1) % points.Count()]);
                    graf.DrawRectangle(Pens.Red, points[i].X - 2, points[i].Y - 2, 5, 5);
                }
                for (int i = 0; i < figure.Count(); i++)
                {
                    graf.DrawRectangle(Pens.Red, figure[i].X - 2, figure[i].Y - 2, 5, 5);
                }
                if (ok)
                {
                    Point[] fig = new Point[figure.Count()];
                    for (int i = 0; i < figure.Count(); i++)
                        fig[i] = figure[i];
                    graf.FillPolygon(Brushes.Blue, fig);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene();
        }

        private void Flag_Click(object sender, EventArgs e)
        {
            flag = !flag;
        }

        private void drawfigure_Click(object sender, EventArgs e)
        {
            ok = true;
            DrawScene();
        }

        private void run_Click(object sender, EventArgs e)
        {
            new_figure.Clear();
            A = new Point(points[0].X, points[0].Y);
            B = new Point(points[1].X, points[1].Y);
            int sum_x = 0;
            int sum_y = 0;
            for (int i = 0; i < figure.Count(); i++)
            {
                new_figure.Add(new Point(figure[i].X, figure[i].Y));
                sum_x += figure[i].X;
                sum_y += figure[i].Y;
            }
            centre = new Point(sum_x / figure.Count(), sum_y / figure.Count());
            a = 0; t = 0; pos = 2;
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && !flag && n != -1)
            {
                points[n] = new Point(e.X, e.Y);
                DrawScene();
            }

            if (e.Button == MouseButtons.Right && flag && n != -1)
            {
                figure[n] = new Point(e.X, e.Y);
                DrawScene();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Сдвиг к началу координат + поворот
            for (int i = 0; i < new_figure.Count(); i++)
            {
                new_figure[i] = new Point(figure[i].X - centre.X, figure[i].Y - centre.Y);
                new_figure[i] = new Point((int)(new_figure[i].X * Math.Cos((double)(a) * Math.PI / 180) - new_figure[i].Y * Math.Sin((double)(a) * Math.PI / 180)),
                    (int)(new_figure[i].X * Math.Sin((double)(a) * Math.PI / 180) + new_figure[i].Y * Math.Cos((double)(a) * Math.PI / 180)));
            }

            // Сдвиг по прямой
            Point L = new Point((int)((1 - t) * A.X + t * B.X), (int)((1 - t) * A.Y + t * B.Y));
            for (int i = 0; i < new_figure.Count(); i++)
            {
                new_figure[i] = new Point(new_figure[i].X + L.X, new_figure[i].Y + L.Y);
            }

            // Перерисовка
            graf.Clear(Color.White);
            for (int i = 0; i < points.Count(); i++)
            {
                graf.DrawLine(Pens.Black, points[i], points[(i + 1) % points.Count()]);
                graf.DrawRectangle(Pens.Red, points[i].X - 2, points[i].Y - 2, 5, 5);
            }
            for (int i = 0; i < new_figure.Count(); i++)
            {
                graf.DrawRectangle(Pens.Red, new_figure[i].X - 2, new_figure[i].Y - 2, 5, 5);
            }
            Point[] fig = new Point[new_figure.Count()];
            for (int i = 0; i < new_figure.Count(); i++)
                fig[i] = new_figure[i];
            graf.FillPolygon(Brushes.Blue, fig);
            t += dt; a+=3;
            if (t > 1)
            {
                A = B;
                B = points[pos % points.Count()];
                pos++;
                t = 0;
            }
        }
    }
}
