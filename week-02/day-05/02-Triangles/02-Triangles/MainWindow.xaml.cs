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

            points.Clear();
            points.Add(new Point(10, 10));
            points.Add(new Point(40, 210));
            points.Add(new Point(170, 190));
            foxDraw.FillColor(Colors.Green);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);
        }
    }

}
