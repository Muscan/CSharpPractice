using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class ExercicesMid
    {

        //1G11o2L
        public static string EncodedText(string encodedText)
        {
            string decodedText = "";
            int i = 0;
            while (i < encodedText.Length)
            {   //it checks if the next char after i, is digit
                if (char.IsDigit(encodedText[i+1]))
                {
                    //extract the numbers from the initial text
                    int doubleDigit = (int)char.GetNumericValue(encodedText[i]);
                    int singleDigit = (int)char.GetNumericValue(encodedText[i + 1]);
                    int formatNumberBeforeChar = doubleDigit * 10 + singleDigit;
                    //adding in the decodedText string char after the two digits, the value from formatNumberBeforeChar
                    //Eg. 11o=> (11) * 0 = ooooooooooo
                    
                    //The iteration will repeat for 11 times, the values from formatNumberBeforeChar
                    for (int j = 0; j < formatNumberBeforeChar; j++)
                    {
                        decodedText += encodedText[i + 2];
                    }
                    i += 3;
                   
                }
                //case with one digit
                else
                {
                    int formatNumberBeforeChar = (int)char.GetNumericValue(encodedText[i]);
                    for (int j = 0; j < formatNumberBeforeChar; j++)
                    {
                        decodedText += encodedText[i + 1];
                    }
                    i += 2;
                }
                
            }
            return decodedText;

        }

    }
}
