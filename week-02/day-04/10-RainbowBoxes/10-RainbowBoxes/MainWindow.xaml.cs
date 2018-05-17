using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _10_RainbowBoxes
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares,
            // all squares should be centered, but growing in size

            DrawSquare(100,Colors.Red);
            DrawSquare(60, Colors.Blue);
            DrawSquare(30, Colors.Magenta);
            DrawSquare(10, Colors.Maroon);
        }
        public void DrawSquare(int squareSize, Color squareColor)
        {
            var foxDraw = new FoxDraw(canvas);

            double middleX = canvas.Width / 2;
            double middleY = canvas.Height / 2;


            foxDraw.FillColor(squareColor);
            foxDraw.DrawRectangle(middleX-(squareSize/2), middleY - (squareSize / 2), squareSize, squareSize);
        }
    }
}
