using System;
using System.Windows;
using System.Windows.Controls;

namespace GreenFox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
        }
    }
}