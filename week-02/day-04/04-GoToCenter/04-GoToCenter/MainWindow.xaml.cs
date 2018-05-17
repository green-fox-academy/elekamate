using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _04_GoToCenter
{

    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();


            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.

            int input_x = 30;
            int input_y = 30;

            for (int i = 0; i < 3; i++)
            {
                input_x *=2;
                input_y *=2;
                DrawLineToCenter(input_x, input_y);
            }
        }

        public void DrawLineToCenter(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);

            var startPoint = new Point(x, y);
            var endPoint = new Point(canvas.Width/2, canvas.Height/2);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }

}
