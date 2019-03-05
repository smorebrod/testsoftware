using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace testsoftware
{
    public class stringUtilities

    {
        public int countOfOcurrance(string stringToChek, string stringToFInd)
        {

            int countResult = -1;

           // countResult = stringToChek.Count(x =>char.ToUpperInvariant(stringToFInd[0]) == char.ToUpperInvariant(x));

            if (stringToChek != null) 
            {
                countResult = stringToChek.Count(x => char.ToUpperInvariant(stringToFInd[0]) == char.ToUpperInvariant(x));
            }
            //else
            //{
            //    return countResult;
            //}


            return countResult;

        }

    }
}
