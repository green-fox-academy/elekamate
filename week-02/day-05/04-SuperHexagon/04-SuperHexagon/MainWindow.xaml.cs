using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace _04_SuperHexagon
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // texture - is the final shape,  which is the group of many hexagons
            // textreSideSize - one side of the texture contains this many hexagons
            // textureStartingPoint - the middle point of the lowest side of the lowest hexagon

            int textureSideSize = 4;
            int textureDiagonalSize = textureSideSize * 2 - 1;
            int actualNumberOfHexagons= textureDiagonalSize;
            double textureStartingPointX = 400;
            double textureStartingPointY = 25;
            double hexagonSideSize = 15;
            double hexagonHeight = hexagonSideSize / 2 * Math.Sqrt(3);



            // First step draw middle diagonal
            
        }



        public static void DrawPolygonColumn
        (
            FoxDraw foxDraw,
            double argTextureStartingPointX,
            double argTextureStartingPointY,
            int argNumberOfHexagons,
            double argHexagonSideSize,
            double hexagonHeight
        )
        {


            var points = new List<Point>();
            points.Add(new Point(argTextureStartingPointX- argHexagonSideSize/2, argTextureStartingPointY));
            points.Add(new Point(argTextureStartingPointX - argHexagonSideSize, argTextureStartingPointY- hexagonHeight));
            points.Add(new Point(argTextureStartingPointX - argHexagonSideSize/2, argTextureStartingPointY- hexagonHeight));
            points.Add(new Point(argTextureStartingPointX - argHexagonSideSize, argTextureStartingPointY - hexagonHeight));
            points.Add(new Point(argTextureStartingPointX - argHexagonSideSize, argTextureStartingPointY - hexagonHeight));
            points.Add(new Point(argTextureStartingPointX - argHexagonSideSize, argTextureStartingPointY - hexagonHeight));


            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }

}
