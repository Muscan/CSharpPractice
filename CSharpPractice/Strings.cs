using System;

namespace CSharpPractice
{
    partial class Strings
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

        
        public static bool IsVowel(char x)
        {   //Nr. of vowels

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
            return word.Substring(0, poz) + word.Substring(poz + 1);

        }
      
        public static int StickedVowels(string text)
        {
            /* a.How many groups next to the same small vowel has the string read from the keyboard?
              Ex : Andreea started working with Boolean numbers.
               Displaying: 2(because we have "ee" and "oo") */
            int count = 0;
            string pairVowels = "";
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (IsVowelLowerCase(text[i])
                    && text[i] == text[i + 1])
                {
                    pairVowels += text[i] + "" + text[i + 1];
                    //"" it converts to string. 
                    // Otherwise it will display the ascii decimal result
                    count++;
                }
            }
            return count;
        }

        public static bool IsVowelLowerCase(char c)
        {
            string vowels = "aeiou";
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == c)
                {
                    return true;
                }
            }
            return false;
        }



        public static int SumAsciiUpperConsonant(string text)
        {       /*b. What is the sum of all the ASCII codes 
                 * of the large consonants in the string?*/

            int sum = 0;
            string ascii = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (IsUpperConsonant(text[i]) == true)
                {
                    sum += text[i];

                }
            }
            return sum;

        }

        public static bool IsVowelUpperCase(char c)
        {
            string upperVowels = "AEIOU";
            for (int i = 0; i < upperVowels.Length; i++)
            {
                if (upperVowels[i] == c)
                {
                    return true;
                }
            }
            return false;

        }


        public static bool IsUpperConsonant(char c)
        {

            return Char.IsUpper(c) && IsVowelUpperCase(c) == false;
        }




        public static string DeleteWordsWithVowelsAtTheBeginAndEnd(string text)
        {
            /*c. Delete all words that start and end with a vowel.
             * If it does not exist, a corresponding message will be marked.*/
            string[] word = text.Split(" ");
            string newWordWithoutVowels = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (FirstLastIsVowel(word[i]) == false)
                {
                    newWordWithoutVowels += word[i];
                }
            }
            return newWordWithoutVowels;
        }

        public static bool FirstLastIsVowel(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[0]) && IsVowel(text[text.Length - 1]))
                {
                    return true;
                }
            }
            return false;
        }

        //Transform James Field into J.F.
        public static string TransformNameIntoInitials(string names)
        {
            string newName = "";
            string[] oneByOneName = names.Split(" ");
            for (int i = 0; i < oneByOneName.Length; i++)
            {
                newName += oneByOneName[i][0] +""+'.';
            }
            return newName;

        }

    }
}
