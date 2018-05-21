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
            

            // texture - is the final shape,  which is the group of many hexagons
            // textreSideSize - one side of the texture contains this many hexagons
            // textureStartingPoint - the middle point of the lowest side of the lowest hexagon

            int textureSideSize = 4;
            int textureDiagonalSize = textureSideSize * 2 - 1;
            int actualNumberOfHexagons= textureDiagonalSize;
            double textureStartingPointX = 400;
            double textureStartingPointY = 25;
            double hexagonSideSize = 15;
            double hexagonHeight = hexagonSideSize / 2 * Math.Sqrt(3) * 2;



            // First step draw middle diagonal
            DrawPolygonColumn
            (
                textureStartingPointX,
                textureStartingPointY,
                actualNumberOfHexagons,
                hexagonSideSize,
                hexagonHeight
            );
        }



        public void DrawPolygonColumn
        (
            double argTextureStartingPointX,
            double argTextureStartingPointY,
            int argNumberOfHexagons,
            double argHexagonSideSize,
            double hexagonHeight
        )
        {

            for (int i = 0; i < argNumberOfHexagons; i++)
            {
                var foxDraw = new FoxDraw(canvas);

                var points = new List<Point>();
                points.Add(new Point(argTextureStartingPointX - argHexagonSideSize / 2, i * hexagonHeight+argTextureStartingPointY));
                points.Add(new Point(argTextureStartingPointX - argHexagonSideSize, i * hexagonHeight + argTextureStartingPointY + hexagonHeight / 2));
                points.Add(new Point(argTextureStartingPointX - argHexagonSideSize / 2, i * hexagonHeight + argTextureStartingPointY + hexagonHeight));
                points.Add(new Point(argTextureStartingPointX + argHexagonSideSize / 2, i * hexagonHeight + argTextureStartingPointY + hexagonHeight));
                points.Add(new Point(argTextureStartingPointX + argHexagonSideSize, i * hexagonHeight + argTextureStartingPointY + hexagonHeight / 2));
                points.Add(new Point(argTextureStartingPointX + argHexagonSideSize / 2, i * hexagonHeight + argTextureStartingPointY));

                foxDraw.FillColor(Colors.Green);
                foxDraw.DrawPolygon(points);
            }
            
        }
    }

}
