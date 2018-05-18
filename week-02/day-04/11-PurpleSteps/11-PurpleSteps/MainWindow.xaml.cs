using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _11_PurpleSteps
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            int squareSize = 20;
            int numberOfBoxes = 15;
            int squarePositionDelta = squareSize;

            int squarePositionX = -20;
            int squarePositionY = -20;

            foxDraw.FillColor(Colors.Purple);

            for (int i = 0; i < numberOfBoxes; i++)
            {
                squarePositionY += squarePositionDelta;
                squarePositionX += squarePositionDelta;
                foxDraw.DrawRectangle(squarePositionX, squarePositionY, squareSize, squareSize);
            }

            
        }
    }

}
