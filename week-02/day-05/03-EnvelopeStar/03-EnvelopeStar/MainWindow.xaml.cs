using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _03_EnvelopeStar
{

    public partial class MainWindow : Window
    {
        decimal linePlayFieldSize = 25;
        decimal linePlayFieldsInOneRow = 0;
        decimal linePlayCanvasWidth = 0;

        decimal actualLineStartXPosition = 0;
        decimal actualLineStartYPosition = 0;
        decimal actualLineEndXPosition = 0;
        decimal actualLineEndYPosition = 0;


        Color checkboardTableColor1 = Colors.Black;
        Color checkboardTableColor2 = Colors.White;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Calculating how many fields should be in row by checking the size of the canvas
            linePlayFieldsInOneRow = CalculatingLinePlayFieldsInOneRow(linePlayFieldSize)/2;

            //Calculating the drawing canvas for the lineplay picture
            linePlayCanvasWidth = linePlayFieldsInOneRow * linePlayFieldSize;

            // Drawing the lineplay from scratch
            for (int i = 0; i < linePlayFieldsInOneRow; i++)
            {
                actualLineStartXPosition = linePlayFieldSize * i;
                actualLineStartYPosition = linePlayCanvasWidth;
                actualLineEndXPosition = linePlayCanvasWidth;
                actualLineEndYPosition = linePlayCanvasWidth - linePlayFieldSize * i;

                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(
                    (double)actualLineStartXPosition,
                    (double)actualLineStartYPosition,
                    (double)actualLineEndXPosition,
                    (double)actualLineEndYPosition
                );
            }

            for (int i = 0; i < linePlayFieldsInOneRow; i++)
            {
                actualLineStartXPosition = linePlayCanvasWidth * 2 - linePlayFieldSize * i;
                actualLineStartYPosition = linePlayCanvasWidth;
                actualLineEndXPosition = linePlayCanvasWidth;
                actualLineEndYPosition = linePlayCanvasWidth - linePlayFieldSize * i;

                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(
                    (double)actualLineStartXPosition,
                    (double)actualLineStartYPosition,
                    (double)actualLineEndXPosition,
                    (double)actualLineEndYPosition
                );
            }

            // Drawing the lineplay from scratch
            for (int i = 0; i < linePlayFieldsInOneRow; i++)
            {
                actualLineStartXPosition = linePlayFieldSize * i;
                actualLineStartYPosition = linePlayCanvasWidth;
                actualLineEndXPosition = linePlayCanvasWidth;
                actualLineEndYPosition = linePlayCanvasWidth + linePlayFieldSize * i;

                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(
                    (double)actualLineStartXPosition,
                    (double)actualLineStartYPosition,
                    (double)actualLineEndXPosition,
                    (double)actualLineEndYPosition
                );
            }

            for (int i = 0; i < linePlayFieldsInOneRow; i++)
            {
                actualLineStartXPosition = linePlayCanvasWidth * 2 - linePlayFieldSize * i;
                actualLineStartYPosition = linePlayCanvasWidth;
                actualLineEndXPosition = linePlayCanvasWidth;
                actualLineEndYPosition = linePlayCanvasWidth + linePlayFieldSize * i;

                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(
                    (double)actualLineStartXPosition,
                    (double)actualLineStartYPosition,
                    (double)actualLineEndXPosition,
                    (double)actualLineEndYPosition
                );
            }
        }

        public decimal CalculatingLinePlayFieldsInOneRow(decimal argLinePlayFieldSize)
        {
            if (canvas.Height < canvas.Width)
            {
                return Math.Floor((decimal)canvas.Height / argLinePlayFieldSize);
            }
            else
            {
                return Math.Floor((decimal)canvas.Width / argLinePlayFieldSize);
            }
        }
    }

}
