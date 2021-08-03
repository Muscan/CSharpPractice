using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class Strings
    {
        public static int NrCharTxt(String text, char characterWeAreSearchingFor)
        {
            /*A text of up to 255 characters is considered.
            Create a program that displays:
            a.The number of occurrences of a letter in the text. 
            b.How many vowels appear in the read text
            
            a.2; b.8; c.2 */
            int countNrOfAppearanceInText = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == characterWeAreSearchingFor)
                {

                    countNrOfAppearanceInText++;
                }
            }
            return countNrOfAppearanceInText;
        }

        //Nr. of vowels
        public static bool IsVowel(char x)
        {

            string vowels = "AEIOUaeiou";

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == x)
                {
                    return true;
                }
            }
            return false;

        }

        public static int CountVowelsTxt(String text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        /*c.The number of occurrences of a syllable in the text.
        The syllable will be the keyboard reading.
        Example: for the letter 'a', the syllable "re" with the text: "Ina has many apples"
            will be displayed: 2*/
        
        public static int CountSyllabe(string text, string syllabe)
        {

            int count = 0;

            int position = text.IndexOf(syllabe);

            while (position >= 0)
            {

                count++;

                text = text.Substring(position + syllabe.Length);

                position = text.IndexOf(syllabe);
            }


            return count;
        }

        public static string EraseFirstLetter(string word)
        {
                /*It is considered a word consisting of small and large letters of the English alphabet.
             Create a program that allows you to delete all the occurrences of the first letter in that word.
            Example: Pt.mamamie, it will be displayed aaie */

           string newSavedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[0] != word[i]//if first letter != current letter(itterated letter)
                             && word[0] - 32 != word[i]//If it`s capital letter it changes to lowercase -unicode 32
                             && word[i] - 32 != word[0])
                {
                    newSavedWord += word[i];
                }
            }
            return newSavedWord;
        }

        public static string ErasePos(string word, int poz)
        {
            //Deletes a char from a word
            if (poz == 0)
            {
                return word.Substring(poz + 1);
            }
            return word.Substring(0, poz - 1) + word.Substring(poz + 1);

        }
    }
}
