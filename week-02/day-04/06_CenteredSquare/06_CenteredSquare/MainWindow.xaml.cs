using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _06_CenteredSquare
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Draw a green 10x10 square to the canvas' center.

            double middleX = canvas.Width / 2;
            double middleY = canvas.Height / 2;

            var startPoint1 = new Point(middleX-5, middleY-5);
            var endPoint1 = new Point(middleX+5, middleY - 5);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(middleX + 5, middleY - 5);
            var endPoint2 = new Point(middleX + 5, middleY+5);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPoint2, endPoint2);

            var startPoint3 = new Point(middleX + 5, middleY + 5);
            var endPoint3 = new Point(middleX - 5, middleY + 5);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(startPoint3, endPoint3);

            var startPoint4 = new Point(middleX - 5, middleY + 5);
            var endPoint4 = new Point(middleX - 5, middleY - 5);
            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }

}
