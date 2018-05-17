using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _09_CenteredBoxes
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            DrawSquare(390);
            DrawSquare(200);
            DrawSquare(50);
            DrawSquare(10);
        }
        public void DrawSquare(int SquareSize)
        {
            var foxDraw = new FoxDraw(canvas);

            double middleX = canvas.Width / 2;
            double middleY = canvas.Height / 2;

            var startPoint1 = new Point(middleX - SquareSize/2, middleY - SquareSize/2);
            var endPoint1 = new Point(middleX + SquareSize/2, middleY - SquareSize/2);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(middleX + SquareSize/2, middleY - SquareSize/2);
            var endPoint2 = new Point(middleX + SquareSize/2, middleY + SquareSize/2);
            foxDraw.DrawLine(startPoint2, endPoint2);

            var startPoint3 = new Point(middleX + SquareSize/2, middleY + SquareSize/2);
            var endPoint3 = new Point(middleX - SquareSize/2, middleY + SquareSize/2);
            foxDraw.DrawLine(startPoint3, endPoint3);

            var startPoint4 = new Point(middleX - SquareSize/2, middleY + SquareSize/2);
            var endPoint4 = new Point(middleX - SquareSize/2, middleY - SquareSize/2);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }

}
