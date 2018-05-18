using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _12_PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Reproduce this:
            // [https://github.com/green-fox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps-3d/r4.png]

            decimal squareSizeMultiplier = 1.4m;
            decimal squareSizeMultiplierIncrease = 1.02m;
            int numberOfBoxes = 6;
            decimal squareSize = 10 * 1 / squareSizeMultiplier;
            decimal squarePositionDelta = squareSize;


            decimal squarePositionX = 0;
            decimal squarePositionY = 0;

            foxDraw.FillColor(Colors.Purple);

            for (int i = 0; i < numberOfBoxes; i++)
            {
                squareSizeMultiplier= squareSizeMultiplier * squareSizeMultiplierIncrease;
                squarePositionDelta *= squareSizeMultiplier;
                squarePositionY += squareSize;
                squarePositionX += squareSize;
                squareSize *= squareSizeMultiplier;

                foxDraw.DrawRectangle((double)squarePositionX, (double)squarePositionY,(double) squareSize, (double) squareSize);
            }
        }
    }

}
