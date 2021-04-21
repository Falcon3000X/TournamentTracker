using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {

        /// <summary>
        /// Return path to text file with data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FullFilePath(string fileName) //PrizeModels.csv
        {
            // E:\data\TournamentTracker
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";
        }












    }
}
