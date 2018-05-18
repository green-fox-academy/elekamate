using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _13_Checkboard
{

    public partial class MainWindow : Window
    {
        decimal checkboardFieldSize=10m;
        decimal checkboardFieldsInOneRow=0;

        decimal actualRectangleStartXPosition = 0;
        decimal actualRectangleStartYPosition = 0;

        Color checkboardTableColor1 = Colors.Black;
        Color checkboardTableColor2 = Colors.White;

        public MainWindow()
        {
            InitializeComponent();

            // Calculating how many fields should be in row by checking the size of the canvas
            checkboardFieldsInOneRow = CalculatingCheckboardFieldsInOneRow(checkboardFieldSize);

            // Drawing the board from scratch
            CreatingCheckboard();
        }

        public decimal CalculatingCheckboardFieldsInOneRow(decimal argCheckboardFieldSize)
        {
            if (canvas.Height < canvas.Width)
            {
                return Math.Floor((decimal)canvas.Height / argCheckboardFieldSize);
            }
            else
            {
                return Math.Floor((decimal)canvas.Width / argCheckboardFieldSize);
            }
        }

        public void CreatingCheckboard()
        {
            Color actualColor = checkboardTableColor1;

            for (int i = 0; i < checkboardFieldsInOneRow; i++)
            {
                for (int j = 0; j < checkboardFieldsInOneRow; j++)
                {
                    DrawingOneCheckboardField(i, j, actualColor);
                    // Changing color without conditions.
                    actualColor = ChangingFieldColor(actualColor);
                }
                // The row color of next row depends on the number of fields in one row: even or odd number.
                actualColor = SettingStartingColorForNextRow(actualColor);
            }
        }

        private Color SettingStartingColorForNextRow(Color actualColor)
        {
            if (checkboardFieldsInOneRow % 2 == 0)
            {
                if (actualColor == checkboardTableColor1)
                {
                    return checkboardTableColor2;
                }
                else
                {
                    return checkboardTableColor1;
                }
            }
            else
            {
                return actualColor;
            }
        }

        private Color ChangingFieldColor(Color argactualColor)
        {
            if (argactualColor == checkboardTableColor1)
            {
                return checkboardTableColor2;
            }
            else
            {
                return checkboardTableColor1;
            }
        }

        private void DrawingOneCheckboardField(int argi, int argj, Color argActualColor)
        {
            // First cycle is 0, so it will start from (0, 0) point.
            actualRectangleStartXPosition = argi * checkboardFieldSize;
            actualRectangleStartYPosition = argj * checkboardFieldSize;

            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(argActualColor);
            foxDraw.DrawRectangle(
                (double)actualRectangleStartXPosition,
                (double)actualRectangleStartYPosition,
                (double)checkboardFieldSize,
                (double)checkboardFieldSize
            );
        }
    }
}
