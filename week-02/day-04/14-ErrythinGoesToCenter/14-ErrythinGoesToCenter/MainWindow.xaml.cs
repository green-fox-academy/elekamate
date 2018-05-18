using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _14_ErrythinGoesToCenter
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            int input_x = 30;
            int input_y = 30;
            double lineDensity = 20; // in pixel
            double actualSideLength = 0;
            double actualSideProgress = 0;
            double actualSideremainder = 0;

            Dictionary<double, List<double>> listOfSidesPlusX = new Dictionary<double, List<double>>();
            Dictionary<double, double> listOfSidesPlusY = new Dictionary<double, double>();

            listOfSidesPlusX.Add(canvas.Width,0);
            List<double> actualList = new List<double>();
            actualList.Add(canvas.Width);
            actualList.Add(0);
            actualList.Add(0);
            listOfSidesPlusX.Add(0, actualList);

            actualList.Clear();

            actualList.Add(canvas.Height);
            actualList.Add(canvas.Width);
            actualList.Add(0);
            listOfSidesPlusX.Add(1, actualList);

            actualList.Clear();

            actualList.Add(canvas.Width);
            actualList.Add(canvas.Width);
            actualList.Add(canvas.Height);
            listOfSidesPlusX.Add(2, actualList);

            actualList.Clear();

            actualList.Add(canvas.Height);
            actualList.Add(0);
            actualList.Add(canvas.Height);
            listOfSidesPlusX.Add(3, actualList);

            foreach (var xItem in listOfSidesPlusX.)
            {
                actualSideLength = listOfSides[i];
                actualSideProgress = actualSideremainder;

                input_x *= 0;
                input_y *= 0;

                while (actualSideProgress + lineDensity < actualSideLength)
                {
                    if (i % 2==0)
                    {
                        input_x *= 0;
                        input_y *= 0;
                    }
                    else
                    {
                        input_x *= 0;
                        input_y *= 2;
                    }
                    DrawLineToCenter(input_x, input_y);
                }


                if (actualSideProgress + lineDensity != actualSideLength)
                {
                    actualSideremainder = actualSideProgress + lineDensity - actualSideLength;
                }
                else
                {
                    actualSideremainder = 0;
                }
            }
        }

        public void DrawLineToCenter(int x, int y)
        {
            var foxDraw = new FoxDraw(canvas);

            var startPoint = new Point(x, y);
            var endPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.SetStrokeThickness(2);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
