using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _13_Checkboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            decimal checkboardFieldSize = 10m;
            int checkboardFieldsInOneRow = 0;

            List<Color> fieldColors = new List<Color>();
            fieldColors.Add(Colors.Black);
            fieldColors.Add(Colors.White);
            Color actualColor = fieldColors[0];

            InitializeComponent();

            checkboardFieldsInOneRow = CalcCheckboardFieldsInOneRow(checkboardFieldSize);

            for (int i = 0; i < checkboardFieldsInOneRow; i++)
            {
                for (int j = 0; j < checkboardFieldsInOneRow; j++)
                {
                    DrawOneCheckboardField(i, j, actualColor, checkboardFieldSize);
                    actualColor = ChangFieldColor(actualColor, fieldColors);
                }

<<<<<<< HEAD
        private Color SettingStartingColorForNextRow(Color actualColor)
        {
            Color colorToReturn= actualColor;

            if (checkboardFieldsInOneRow % 2 == 0)
            {
                colorToReturn = (actualColor == checkboardTableColor1) ? checkboardTableColor2 : checkboardTableColor1;
            }

            return colorToReturn;
=======
                if (checkboardFieldsInOneRow % 2 == 0)
                {
                    ChangFieldColor(actualColor, fieldColors);
                }
            }
>>>>>>> 3d4b707dd4b91b83c6ac0b820eb57686c02f6c84
        }

        public int CalcCheckboardFieldsInOneRow(decimal argCheckboardFieldSize)
        {
<<<<<<< HEAD
            return (argactualColor == checkboardTableColor1) ? checkboardTableColor2 : checkboardTableColor1;
=======
            decimal canvasSizeOfSmallerSide = (canvas.Height < canvas.Width) ? (decimal) canvas.Height : (decimal) canvas.Width;
            return (int) Math.Floor(canvasSizeOfSmallerSide / argCheckboardFieldSize);
>>>>>>> 3d4b707dd4b91b83c6ac0b820eb57686c02f6c84
        }

        private Color ChangFieldColor(Color argactualColor, List<Color> argfieldColors)
        {
            return (argactualColor == argfieldColors[0]) ? argfieldColors[1] : argfieldColors[0];
        }

        private void DrawOneCheckboardField(int argi, int argj, Color argActualColor, decimal argcheckboardFieldSize)
        {
            decimal actualRectangleStartXPosition = argi * argcheckboardFieldSize;
            decimal actualRectangleStartYPosition = argj * argcheckboardFieldSize;

            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(argActualColor);
            foxDraw.DrawRectangle(
                (double)actualRectangleStartXPosition,
                (double)actualRectangleStartYPosition,
                (double)argcheckboardFieldSize,
                (double)argcheckboardFieldSize
            );
        }

    }
}
