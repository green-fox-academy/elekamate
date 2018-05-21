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
            double textureStartingPointX = 400;
            double textureStartingPointY = 25;
            double hexagonSideSize = 15;
            double hexagonHeight = hexagonSideSize / 2 * Math.Sqrt(3) * 2;
            int i_StartIndexToDrawTextureSides = textureDiagonalSize - 1;

            // First step draw middle diagonal of the texture
            DrawPolygonColumn
            (
                textureStartingPointX,
                textureStartingPointY,
                textureDiagonalSize,
                hexagonSideSize,
                hexagonHeight
            );

            // Now let`s draw the side columns of hexagons as well to get the whole texture
            for (int i = i_StartIndexToDrawTextureSides; i > textureSideSize-1; i--)
            {
                DrawPolygonColumn
                (
                    textureStartingPointX+ hexagonSideSize*1.5 - (textureDiagonalSize + 1-i) * hexagonSideSize*1.5,
                    textureStartingPointY- hexagonHeight /2+ (textureDiagonalSize + 1 - i) * hexagonHeight/2,
                    i,
                    hexagonSideSize,
                    hexagonHeight
                );

                DrawPolygonColumn
                (
                    textureStartingPointX- hexagonSideSize*1.5 + (textureDiagonalSize + 1 - i) * hexagonSideSize*1.5,
                    textureStartingPointY- hexagonHeight /2+ (textureDiagonalSize + 1 - i) * hexagonHeight / 2,
                    i,
                    hexagonSideSize,
                    hexagonHeight
                );
            }
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