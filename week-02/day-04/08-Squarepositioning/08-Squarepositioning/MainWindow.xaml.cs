using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _08_Squarepositioning
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            DrawRectangle(10, 100);
            DrawRectangle(20, 300);
            DrawRectangle(30, 200);
            DrawRectangle(200, 0);
        }
        public void DrawRectangle(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(
                x,
                y,
                50,
                50
            );


        }
    }

}
