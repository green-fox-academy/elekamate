using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _01_Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var points = new List<Point>();
            Point testpoint = new Point(1,2);

            double triangleOriginalWidth = 300;
            double triangleOriginalHeight = 0.5 * Math.Sqrt(3) * triangleOriginalWidth;
            double triangleOriginalIndent = 25;

            double triangleOriginalP1X = triangleOriginalIndent;
            double triangleOriginalP1Y = triangleOriginalIndent;
            double triangleOriginalP2X = triangleOriginalP1X + triangleOriginalWidth;
            double triangleOriginalP2Y = triangleOriginalIndent;
            double triangleOriginalP3X = triangleOriginalIndent + triangleOriginalWidth / 2;
            double triangleOriginalP3Y = triangleOriginalIndent + triangleOriginalHeight;

            points.Clear();
            points.Add(new Point(triangleOriginalP1X, triangleOriginalP1Y));
            points.Add(new Point(triangleOriginalP2X, triangleOriginalP2Y));
            points.Add(new Point(triangleOriginalP3X, triangleOriginalP3Y));
            foxDraw.FillColor(Colors.Green);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);

            DrawTrinaglesIntoTriangles(points);
        }

        private void DrawTrinaglesIntoTriangles(List<Point> argPoints)
        {
            var points = new List<Point>();
            var foxDraw = new FoxDraw(canvas);

            double triangleOriginalWidth = argPoints[1].X - argPoints[0].X;
            double triangleOriginalHeight = 0.5 * Math.Sqrt(3) * triangleOriginalWidth;

            double triangleP1X = (argPoints[1].X > argPoints[0].X) ?
                argPoints[0].X + (argPoints[1].X - argPoints[0].X) / 2 :
                argPoints[1].X + (argPoints[0].X - argPoints[1].X) / 2;

            double triangleP1Y = (argPoints[1].Y > argPoints[0].Y) ?
                argPoints[0].Y + (argPoints[1].Y - argPoints[0].Y) / 2 :
                argPoints[1].Y + (argPoints[0].Y - argPoints[1].Y) / 2;

            double triangleP2X = (argPoints[1].X > argPoints[2].X) ?
                argPoints[2].X+ (argPoints[1].X - argPoints[2].X)/2:
                argPoints[1].X + (argPoints[2].X - argPoints[1].X) / 2;

            double triangleP2Y = (argPoints[2].Y > argPoints[1].Y) ?
                argPoints[1].Y + (argPoints[2].Y - argPoints[1].Y)/2:
                argPoints[2].Y + (argPoints[1].Y - argPoints[2].Y) / 2;

            double triangleP3X = (argPoints[2].X > argPoints[0].X) ?
                argPoints[0].X + (argPoints[2].X - argPoints[0].X) / 2:
                argPoints[2].X + (argPoints[0].X - argPoints[2].X) / 2;

            double triangleP3Y = (argPoints[0].Y > argPoints[2].Y) ?
                argPoints[2].Y+(argPoints[0].Y - argPoints[2].Y)/2:
                argPoints[0].Y + (argPoints[2].Y - argPoints[0].Y) / 2;

            points.Clear();
            points.Add(new Point(triangleP1X, triangleP1Y));
            points.Add(new Point(triangleP2X, triangleP2Y));
            points.Add(new Point(triangleP3X, triangleP3Y));
            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);

            if (triangleOriginalWidth > 30)
            {
                DrawTrinaglesIntoTriangles(points);
            }
        }
    }
}
