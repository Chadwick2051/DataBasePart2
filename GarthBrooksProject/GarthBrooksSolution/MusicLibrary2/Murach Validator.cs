using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary2
{
    public class Murach_Validator
    {
        public bool checkForNonEmptyFields(string Name, string Artist, string Desc, string URL, string year)
        {
            int AlbumYear;
            if (Name=="" && Artist=="" && Desc=="" && URL=="")
            {
                return false;
            }
            bool result = Int32.TryParse(year, out AlbumYear);
            if (!result)
            {
                return false;
            }

            return true;
        }
    }
}
