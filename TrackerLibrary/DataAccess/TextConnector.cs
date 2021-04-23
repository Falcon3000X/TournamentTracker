using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Wire up the CreatePrizefor the text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load th etext file and convert to List<PrizeModels>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the 
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
