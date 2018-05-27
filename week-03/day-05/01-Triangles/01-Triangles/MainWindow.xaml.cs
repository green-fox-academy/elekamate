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
            


            // Drawing big triangle
            double triangleOriginalWidth = 300;
            double triangleOriginalHeight = CalcTriangleHeight(triangleOriginalWidth);
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

            var trianglePositionNames = new List<string>();
            trianglePositionNames.Add("Left");
            trianglePositionNames.Add("Right");
            trianglePositionNames.Add("Bottom");

            CalcRelativeTrianglePoints(argPoints, "Left");


            if (Math.Abs(argPoints[1].X - argPoints[2].X) > 3)
            {
                foreach (var xItem in trianglePositionNames)
                {
                    tempPoints.Clear();
                    tempPoints = CalcRelativeTrianglePoints(argPoints, xItem);
                    foxDraw.FillColor(Colors.White);
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawPolygon(tempPoints);
                    DrawTrinaglesIntoTriangles(tempPoints);
                }
            } 
        }

        private List<Point> CalcRelativeTrianglePoints(List<Point> argPoints, string argSideToDraw)
        {
            double triangleOriginalWidth = argPoints[1].X-argPoints[2].X;
            double triangleOriginalHeight = CalcTriangleHeight(triangleOriginalWidth);

            double triangleNewWidth = triangleOriginalWidth / 2;
            double triangleNewHeight = CalcTriangleHeight(triangleNewWidth);

            var newPoints = new List<Point>();
            double triangleNewPoint0X;
            double triangleNewPoint0Y;

            double triangleNewPoint1X;
            double triangleNewPoint1Y;

            double triangleNewPoint2X;
            double triangleNewPoint2Y;

            if (argSideToDraw == "Left")
            {
                triangleNewPoint2X = argPoints[2].X - triangleNewWidth / 2;
                triangleNewPoint2Y = argPoints[2].Y - triangleNewHeight;
            }
            else if (argSideToDraw == "Right")
            {
                triangleNewPoint2X = argPoints[2].X + triangleNewWidth * 1.5;
                triangleNewPoint2Y = argPoints[2].Y - triangleNewHeight;
            }
            else if (argSideToDraw == "Bottom")
            {
                triangleNewPoint2X = argPoints[2].X + triangleNewWidth / 2;
                triangleNewPoint2Y = argPoints[2].Y + triangleNewHeight;
            }
            else
            {
                throw new Exception("Error during drawing a triangle. The side must be" +
                    "Left, Right or Bottom");
            }

            triangleNewPoint1X = triangleNewPoint2X + triangleNewWidth;
            triangleNewPoint1Y = triangleNewPoint2Y;
            triangleNewPoint0X = triangleNewPoint2X + triangleNewWidth / 2;
            triangleNewPoint0Y = triangleNewPoint2Y - triangleNewHeight;

            newPoints.Add(new Point(triangleNewPoint0X, triangleNewPoint0Y));
            newPoints.Add(new Point(triangleNewPoint1X, triangleNewPoint1Y));
            newPoints.Add(new Point(triangleNewPoint2X, triangleNewPoint2Y));
            return newPoints;
        }

        private double CalcTriangleHeight(double triangleWidth)
        {
            return 0.5 * Math.Sqrt(3) * triangleWidth;
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
