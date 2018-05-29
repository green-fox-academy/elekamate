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

            // Drawing big triangle
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

            // Drawing smaller triangle to it
            triangleOriginalWidth = points[1].X - points[0].X;
            triangleOriginalHeight = 0.5 * Math.Sqrt(3) * triangleOriginalWidth;

            double triangleP1X = (points[1].X > points[0].X) ?
                points[0].X + (points[1].X - points[0].X) / 2 :
                points[1].X + (points[0].X - points[1].X) / 2;

            double triangleP1Y = (points[1].Y > points[0].Y) ?
                points[0].Y + (points[1].Y - points[0].Y) / 2 :
                points[1].Y + (points[0].Y - points[1].Y) / 2;

            double triangleP2X = (points[1].X > points[2].X) ?
                points[2].X + (points[1].X - points[2].X) / 2 :
                points[1].X + (points[2].X - points[1].X) / 2;

            double triangleP2Y = (points[2].Y > points[1].Y) ?
                points[1].Y + (points[2].Y - points[1].Y) / 2 :
                points[2].Y + (points[1].Y - points[2].Y) / 2;

            double triangleP3X = (points[2].X > points[0].X) ?
                points[0].X + (points[2].X - points[0].X) / 2 :
                points[2].X + (points[0].X - points[2].X) / 2;

            double triangleP3Y = (points[0].Y > points[2].Y) ?
                points[2].Y + (points[0].Y - points[2].Y) / 2 :
                points[0].Y + (points[2].Y - points[0].Y) / 2;

            points.Clear();
            points.Add(new Point(triangleP1X, triangleP1Y));
            points.Add(new Point(triangleP2X, triangleP2Y));
            points.Add(new Point(triangleP3X, triangleP3Y));
            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);

            DrawTrinaglesIntoTriangles(points);
        }

        private void DrawTrinaglesIntoTriangles(List<Point> argPoints)
        {
            var foxDraw = new FoxDraw(canvas);
            var tempPoints = new List<Point>();

            double triangleOriginalWidth = (argPoints[1].X - argPoints[0].X);
            double triangleOriginalHeight = 0.5* Math.Sqrt(3) * triangleOriginalWidth;

            double triangleNewWidth = triangleOriginalWidth/2;
            double triangleNewHeight =  0.5 * Math.Sqrt(3) * triangleNewWidth;

            double triangle1P2X = (argPoints[1].X > argPoints[0].X) ?
                argPoints[0].X + (argPoints[1].X - argPoints[0].X) / 2 :
                argPoints[1].X + (argPoints[0].X - argPoints[1].X) / 2;

            double triangle1P2Y = (argPoints[1].Y > argPoints[0].Y) ?
                argPoints[0].Y + (argPoints[1].Y - argPoints[0].Y) / 2 :
                argPoints[1].Y + (argPoints[0].Y - argPoints[1].Y) / 2;

            double triangle1P1X= triangle1P2X+triangleNewWidth;
            double triangle1P1Y= triangle1P2Y-triangleNewHeight;

            double triangle1P3X= triangle1P2X+ triangleNewWidth;
            double triangle1P3Y= triangle1P2Y;

            double triangle2P1X = (argPoints[1].X > argPoints[2].X) ?
                argPoints[2].X+ (argPoints[1].X - argPoints[2].X)/2:
                argPoints[1].X + (argPoints[2].X - argPoints[1].X) / 2;

            double triangle2P1Y = (argPoints[2].Y > argPoints[1].Y) ?
                argPoints[1].Y + (argPoints[2].Y - argPoints[1].Y)/2:
                argPoints[2].Y + (argPoints[1].Y - argPoints[2].Y) / 2;

            double triangle2P2X= triangle2P1X+triangleNewWidth;
            double triangle2P2Y= triangle2P1Y+triangleNewHeight;

            double triangle2P3X= triangle2P2X-triangleNewWidth;
            double triangle2P3Y= triangle2P2Y;

            double triangle3P3X = (argPoints[2].X > argPoints[0].X) ?
                argPoints[0].X + (argPoints[2].X - argPoints[0].X) / 2:
                argPoints[2].X + (argPoints[0].X - argPoints[2].X) / 2;

            double triangle3P3Y = (argPoints[0].Y > argPoints[2].Y) ?
                argPoints[2].Y+(argPoints[0].Y - argPoints[2].Y)/2:
                argPoints[0].Y + (argPoints[2].Y - argPoints[0].Y) / 2;

            double triangle3P2X= triangle3P3X-triangleNewWidth;
            double triangle3P2Y= triangle3P3Y;

            double triangle3P1X= triangle3P3X-triangleNewWidth;
            double triangle3P1Y= triangle3P3Y-triangleNewHeight;

            if (Math.Abs(triangle1P2X- triangle1P3X) > 3)
            {
                tempPoints.Clear();
                tempPoints.Add(new Point(triangle1P1X, triangle1P1Y));
                tempPoints.Add(new Point(triangle1P2X, triangle1P2Y));
                tempPoints.Add(new Point(triangle1P3X, triangle1P3Y));
                foxDraw.FillColor(Colors.White);
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawPolygon(tempPoints);
                DrawTrinaglesIntoTriangles(tempPoints);

                tempPoints.Clear();
                tempPoints.Add(new Point(triangle2P1X, triangle2P1Y));
                tempPoints.Add(new Point(triangle2P2X, triangle2P2Y));
                tempPoints.Add(new Point(triangle2P3X, triangle2P3Y));
                foxDraw.FillColor(Colors.White);
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawPolygon(tempPoints);
                DrawTrinaglesIntoTriangles(tempPoints);

                tempPoints.Clear();
                tempPoints.Add(new Point(triangle3P1X, triangle3P1Y));
                tempPoints.Add(new Point(triangle3P2X, triangle3P2Y));
                tempPoints.Add(new Point(triangle3P3X, triangle3P3Y));
                foxDraw.FillColor(Colors.White);
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.DrawPolygon(tempPoints);
                DrawTrinaglesIntoTriangles(tempPoints);
            } 
        }

        private void DrawTrinangle(List<Point> argPoints)
        {
            var foxDraw = new FoxDraw(canvas);
            var points = new List<Point>();

            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);
        }
    }
}
