using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _01_Triangles
{
       //          point[0]
       //             /\
       //            /  \
       //           /    \
       //point[2]  --------  point[1]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var triangleOriginalPoints = new List<Point>();
            var triangleSecondPoints = new List<Point>();

            Dictionary<string,double> triangleOriginalParameters = new Dictionary<string,double>();

            triangleOriginalParameters.Add("triangleOriginalWidth", 300);
            triangleOriginalParameters.Add("triangleOriginalIndent", 25);

            triangleOriginalPoints = CalcTriangleOriginalPoints(triangleOriginalParameters);
            DrawTrinangle(triangleOriginalPoints);

            triangleSecondPoints = CalcTriangleSecondPoints(triangleOriginalPoints);
            DrawTrinangle(triangleSecondPoints);

            DrawTrinaglesIntoTriangles(triangleSecondPoints);
        }

        private List<Point> CalcTriangleSecondPoints(List<Point> argTriangleOriginalPoints)
        {
            var triangleSecondPoints = new List<Point>();

            double triangleSecondP0X = (argTriangleOriginalPoints[1].X > argTriangleOriginalPoints[0].X) ?
                argTriangleOriginalPoints[0].X + (argTriangleOriginalPoints[1].X - argTriangleOriginalPoints[0].X) / 2 :
                argTriangleOriginalPoints[1].X + (argTriangleOriginalPoints[0].X - argTriangleOriginalPoints[1].X) / 2;

            double triangleSecondP0Y = (argTriangleOriginalPoints[1].Y > argTriangleOriginalPoints[0].Y) ?
                argTriangleOriginalPoints[0].Y + (argTriangleOriginalPoints[1].Y - argTriangleOriginalPoints[0].Y) / 2 :
                argTriangleOriginalPoints[1].Y + (argTriangleOriginalPoints[0].Y - argTriangleOriginalPoints[1].Y) / 2;

            double triangleSecondP1X = (argTriangleOriginalPoints[1].X > argTriangleOriginalPoints[2].X) ?
                argTriangleOriginalPoints[2].X + (argTriangleOriginalPoints[1].X - argTriangleOriginalPoints[2].X) / 2 :
                argTriangleOriginalPoints[1].X + (argTriangleOriginalPoints[2].X - argTriangleOriginalPoints[1].X) / 2;

            double triangleSecondP1Y = (argTriangleOriginalPoints[2].Y > argTriangleOriginalPoints[1].Y) ?
                argTriangleOriginalPoints[1].Y + (argTriangleOriginalPoints[2].Y - argTriangleOriginalPoints[1].Y) / 2 :
                argTriangleOriginalPoints[2].Y + (argTriangleOriginalPoints[1].Y - argTriangleOriginalPoints[2].Y) / 2;

            double triangleSecondP2X = (argTriangleOriginalPoints[2].X > argTriangleOriginalPoints[0].X) ?
                argTriangleOriginalPoints[0].X + (argTriangleOriginalPoints[2].X - argTriangleOriginalPoints[0].X) / 2 :
                argTriangleOriginalPoints[2].X + (argTriangleOriginalPoints[0].X - argTriangleOriginalPoints[2].X) / 2;

            double triangleSecondP2Y = (argTriangleOriginalPoints[0].Y > argTriangleOriginalPoints[2].Y) ?
                argTriangleOriginalPoints[2].Y + (argTriangleOriginalPoints[0].Y - argTriangleOriginalPoints[2].Y) / 2 :
                argTriangleOriginalPoints[0].Y + (argTriangleOriginalPoints[2].Y - argTriangleOriginalPoints[0].Y) / 2;

            triangleSecondPoints.Add(new Point(triangleSecondP0X, triangleSecondP0Y));
            triangleSecondPoints.Add(new Point(triangleSecondP1X, triangleSecondP1Y));
            triangleSecondPoints.Add(new Point(triangleSecondP2X, triangleSecondP2Y));

            return triangleSecondPoints;
        }

        private List<Point> CalcTriangleOriginalPoints(Dictionary<string, double> triangleOriginalParameters)
        {
            List<Point> points = new List<Point>();

            double triangleOriginalIndent = triangleOriginalParameters["triangleOriginalIndent"];
            double triangleOriginalWidth = triangleOriginalParameters["triangleOriginalWidth"];
            double triangleOriginalHeight = CalcTriangleHeight(triangleOriginalWidth);

            double triangleOriginalP0X = triangleOriginalIndent;
            double triangleOriginalP0Y = triangleOriginalIndent;
            double triangleOriginalP1X = triangleOriginalP0X + triangleOriginalWidth;
            double triangleOriginalP1Y = triangleOriginalIndent;
            double triangleOriginalP2X = triangleOriginalIndent + triangleOriginalWidth / 2;
            double triangleOriginalP2Y = triangleOriginalIndent + triangleOriginalHeight;

            points.Add(new Point(triangleOriginalP0X, triangleOriginalP0Y));
            points.Add(new Point(triangleOriginalP1X, triangleOriginalP1Y));
            points.Add(new Point(triangleOriginalP2X, triangleOriginalP2Y));
            return points;
        }

        private void DrawTrinaglesIntoTriangles(List<Point> argPoints)
        {
            var tempPoints = new List<Point>();

            var trianglePositionNames = new List<string>();
            trianglePositionNames.Add("Left");
            trianglePositionNames.Add("Right");
            trianglePositionNames.Add("Bottom");

            if (Math.Abs(argPoints[1].X - argPoints[2].X) > 3)
            {
                foreach (var xItem in trianglePositionNames)
                {
                    tempPoints.Clear();
                    tempPoints = CalcTriangleRelativePoints(argPoints, xItem);
                    DrawTrinangle(tempPoints);
                    DrawTrinaglesIntoTriangles(tempPoints);
                }
            } 
        }

        private List<Point> CalcTriangleRelativePoints(List<Point> argPoints, string argSideToDraw)
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

            foxDraw.FillColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(argPoints);
        }

    }
}
