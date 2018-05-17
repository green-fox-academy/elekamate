using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _01_LineInTheMiddle
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(0, canvas.Height/2);
            var endPoint = new Point(canvas.Width/2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.Green);
            var startPoint2 = new Point(canvas.Width / 2, canvas.Height);
            var endPoint2 = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }

}
