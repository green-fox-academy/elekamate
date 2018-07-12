using System;
using System.Collections.Generic;
using System.IO;

namespace _02_MostProductiveYear
{
    public class MostProductiveYear
    {
        /**
        * Write a method that helps you find the most productive year for a film studio.
        * The method should take one argument, which is the name of the film studio.
        * The method should try to open the related data file named `studioname`.csv,
        * which is a comma separated file with 3 columns: name of the movie, release year, director
        *
        *  - If we do not have any data about the studio, the method should return an error message.
        *  - If we have found data, the method should return an information message about the most productive year for that studio.
        *
        * Examples:
        *
        * If we call the method with 'marvel':
        * should return 'marvel has made the most movies in 2017.'
        *
        * If we call the method with 'ghibli':
        * should print 'Cannot find studio, please try again later.'
        *
        * Hint:
        *  - You can find some example files in this folder (marvel.csv and paramount.csv)
        *  - Most productive year: The year in which the studio has made the most movies.
        */
        public static string GetMostProdYear(string studioName)
        {
            string InputFolderPath = @"csv files/";
            string inputFullPath = $"{InputFolderPath}{studioName}.csv";
            try
            {
                string[] csvData = File.ReadAllLines(inputFullPath);
                Dictionary<int, int> moviesPerYear = CreateMoiesPerYear(csvData);
                return FindMostProdYear(moviesPerYear);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot find studio, please try again later.");
            }
            return null;
        }

        private static Dictionary<int, int> CreateMoiesPerYear(string[] csvData)
        {
            Dictionary<int, int> moviesPerYear = new Dictionary<int, int>();
            string[] actualLine;
            int actualYear;
            foreach (string xLine in csvData)
            {
                actualLine = xLine.Split(',');
                actualYear = Int32.Parse(actualLine[1]);
                if (moviesPerYear.ContainsKey(actualYear))
                {
                    moviesPerYear[actualYear]++;
                }
                else
                {
                    moviesPerYear.Add(actualYear, 1);
                }
            }
            return moviesPerYear;
        }

        private static string FindMostProdYear(Dictionary<int, int> moviesPerYear)
        {
            KeyValuePair<int, int> mostMovies = new KeyValuePair<int, int>(0, 0);
            foreach (KeyValuePair<int, int> yearMovieFreqPair in moviesPerYear)
            {
                if (yearMovieFreqPair.Value > mostMovies.Value)
                {
                    mostMovies = new KeyValuePair<int, int>(yearMovieFreqPair.Key, (yearMovieFreqPair.Value));
                }
            }
            return Convert.ToString(mostMovies.Key);
        }
    }
}
