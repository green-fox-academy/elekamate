using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _02_ColoredBox
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Draw a box that has different colored lines on each edge.

            var startPoint1 = new Point(100, 100);
            var endPoint1 = new Point(700, 100);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(700, 100);
            var endPoint2 = new Point(700, 300);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPoint2, endPoint2);

            var startPoint3 = new Point(700, 300);
            var endPoint3 = new Point(100, 300);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(startPoint3, endPoint3);

            var startPoint4 = new Point(100, 300);
            var endPoint4 = new Point(100, 100);
            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }

}
