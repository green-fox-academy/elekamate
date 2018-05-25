using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _12_SquaredRecursivePicture
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int deepnessOfPicture=0;


            RecursiveSquarePictureDraw(deepnessOfPicture);
        }

        private void RecursiveSquarePictureDraw(int argDeepnessOfPicture)
        {
            
        }
    }

}
