using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _02_Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var points = new List<Point>();

            double triangleWidth = 25;
            double triangleHeight = 30;
            int patternMaxTrianglesInALine = 10;
            int patternActualTrianglesInALine = patternMaxTrianglesInALine;

            double triangleP1X = 0;
            double triangleP1Y = canvas.Height;
            double triangleP2X = triangleWidth;
            double triangleP2Y = canvas.Height;
            double triangleP3X = triangleWidth/2;
            double triangleP3Y = canvas.Height-triangleHeight;

            double triangleP1X_orig = 0;
            double triangleP1Y_orig = canvas.Height;
            double triangleP2X_orig = triangleWidth;
            double triangleP2Y_orig = canvas.Height;
            double triangleP3X_orig = triangleWidth / 2;
            double triangleP3Y_orig = canvas.Height - triangleHeight;

            for (int j = patternActualTrianglesInALine; j > 0; j--)
            {
                for (int i = 0 ; i < patternActualTrianglesInALine; i++)
                {
                    points.Clear();
                    points.Add(new Point(triangleP1X, triangleP1Y));
                    points.Add(new Point(triangleP2X, triangleP2Y));
                    points.Add(new Point(triangleP3X, triangleP3Y));
                    foxDraw.FillColor(Colors.Green);
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawPolygon(points);

                    triangleP1X = triangleP1X + triangleWidth;
                    triangleP2X = triangleP2X + triangleWidth;
                    triangleP3X = triangleP3X + triangleWidth;
                }
                triangleP1X = triangleP1X_orig+  triangleWidth / 2* (patternMaxTrianglesInALine - j+1);
                triangleP2X = triangleP1X + triangleWidth;
                triangleP3X = triangleP1X + triangleWidth / 2;
                triangleP1Y -= triangleHeight;
                triangleP2Y -= triangleHeight;
                triangleP3Y -= triangleHeight;
                patternActualTrianglesInALine -= 1;
            }
        }
    }

}
