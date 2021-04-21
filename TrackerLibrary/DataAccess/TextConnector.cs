using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {

        // TODO - Wire up the CreatePrizefor the text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
          // Load the text file
          //Convert the text to Liast<PrizeModel>
          //Find the ID
          //Add the new record with the new ID(max + 1)
          //Convert the prizes to list<string>
          //Save the list<string> to the text file
        }
    }
}
