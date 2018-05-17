using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _07_FourRectangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // draw four different size and color rectangles.
            // avoid code duplication.


            DrawRectangle(1,Colors.Red);
            DrawRectangle(2,Colors.Purple);
            DrawRectangle(3,Colors.Magenta);
            DrawRectangle(4,Colors.MediumTurquoise);
        }
        public void DrawRectangle(int rectangleSizeMultiplier, Color rectangleColor)
        {
            var foxDraw = new FoxDraw(canvas);

            double middleX = canvas.Width / 2;
            double middleY = canvas.Height / 2;

            foxDraw.FillColor(rectangleColor);
            foxDraw.DrawRectangle(
                middleX - 400 / rectangleSizeMultiplier,
                middleY - 400 / rectangleSizeMultiplier,
                400/ rectangleSizeMultiplier,
                400/ rectangleSizeMultiplier
            );


        }
    }

}
