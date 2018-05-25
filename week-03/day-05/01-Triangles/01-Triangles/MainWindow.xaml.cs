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

            double triangleP1X = triangleOriginalIndent;
            double triangleP1Y = triangleOriginalIndent;
            double triangleP2X = triangleP1X + triangleOriginalWidth;
            double triangleP2Y = triangleOriginalIndent;
            double triangleP3X = triangleOriginalIndent + triangleOriginalWidth / 2;
            double triangleP3Y = triangleOriginalIndent + triangleOriginalHeight;

            points.Clear();
            points.Add(new Point(triangleP1X, triangleP1Y));
            points.Add(new Point(triangleP2X, triangleP2Y));
            points.Add(new Point(triangleP3X, triangleP3Y));
            foxDraw.FillColor(Colors.Green);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);

            DrawTrinaglesIntoTriangles(points);
        }

        private void DrawTrinaglesIntoTriangles(List<Point> argPoints)
        {
            double triangleOriginalWidth = argPoints[1].X - argPoints[0].X;
            double triangleOriginalHeight = 0.5 * Math.Sqrt(3) * triangleOriginalWidth;


            double triangleP1X = triangleOriginalIndent +;
            double triangleP1Y = triangleOriginalIndent;
            double triangleP2X = triangleP1X + triangleOriginalWidth;
            double triangleP2Y = triangleOriginalIndent;
            double triangleP3X = triangleOriginalIndent + triangleOriginalWidth / 2;
            double triangleP3Y = triangleOriginalIndent + triangleOriginalHeight;
        }
    }
}
