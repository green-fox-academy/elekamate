using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace FoxDraw_01
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawGreenPolygon(foxDraw);
        }

        public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(10, 10));
            points.Add(new Point(40, 210));
            points.Add(new Point(170, 190));
            points.Add(new Point(130, 40));
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }

}
