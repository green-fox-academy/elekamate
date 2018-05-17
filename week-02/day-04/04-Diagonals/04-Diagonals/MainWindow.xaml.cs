using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _04_Diagonals
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            var startPoint1 = new Point(0, 0);
            var endPoint1 = new Point(canvas.Width, canvas.Height);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(canvas.Width, 0);
            var endPoint2 = new Point(0, canvas.Height);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }

}
