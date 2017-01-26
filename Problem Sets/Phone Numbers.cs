//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;
///// <summary>
///// http://acm.timus.ru/problem.aspx?space=1&num=1002
///// Example http://www.cnblogs.com/skyivben/archive/2008/12/09/1351119.html
///// 1002. Phone Numbers
////Time limit: 2.0 second
////Memory limit: 64 MB
////In the present world you frequently meet a lot of call numbers and they are going to be longer and longer.You need to remember such a kind of numbers. One method to do it in an easy way is to assign letters to digits as shown in the following picture:
////1 ij    2 abc   3 def
////4 gh    5 kl    6 mn
////7 prs   8 tuv   9 wxy
////        0 oqz
////This way every word or a group of words can be assigned a unique number, so you can remember words instead of call numbers.It is evident that it has its own charm if it is possible to find some simple relationship between the word and the person itself.So you can learn that the call number 941837296 of a chess playing friend of yours can be read as WHITEPAWN, and the call number 2855304 of your favourite teacher is read BULLDOG.
////Write a program to find the shortest sequence of words (i.e.one having the smallest possible number of words) which corresponds to a given number and a given list of words.The correspondence is described by the picture above.
////Input
////Input contains a series of tests.The first line of each test contains the call number, the transcription of which you have to find. The number consists of at most 100 digits.The second line contains the total number of the words in the dictionary (maximum is 50 000). Each of the remaining lines contains one word, which consists of maximally 50 small letters of the English alphabet.The total size of the input doesn't exceed 300 KB. The last line contains call number −1.
////Output
////Each line of output contains the shortest sequence of words which has been found by your program. The words are separated by single spaces.If there is no solution to the input data, the line contains text “No solution.”. If there are more solutions having the minimum number of words, you can choose any single one of them.

////Sample

////input   

////7325189087
////5
////it
////your
////reality
////real
////our
////4294967296
////5
////it
////your
////reality
////real
////our
////-1

////output

////reality our
////No solution.
////Problem Source: Central European Olympiad in Informatics 1999
////Tags: none  (hide tags for unsolved problems)


////CURRENT OUTPUT
////reality
////real
/////Still not working!

///// </summary>
//namespace Algorithms
//{
//    sealed class Phone_Numbers
//    {
//        Dictionary<char, char> _dictionary = null;
//        //static readonly string[] alphabet = { "oqz", "ij", "abc", "def", "gh", "kl", "mn", "prs", "tuv", "wxy" };
//        Dictionary<char, char> Dictionary
//        {
//            get
//            {
//                if (_dictionary == null)
//                {
//                    _dictionary = new Dictionary<char, char>();
//                    for (int i = 0; i < 26; i++)
//                        _dictionary.Add((char)('a' + i), "22233344115566070778889990"[i]);
//                }
//                return _dictionary;
//            }
//        }

//        void Run(TextReader reader, TextWriter writer)
//        {
//            while (true)
//            {
//                string number = reader.ReadLine();
//                if (number.Equals("-1")) break;
//                string[] words = new string[int.Parse(reader.ReadLine())];
//                string[] numbers = new string[words.Length];
//                for (int i = 0; i < words.Length; i++)
//                    numbers[i] = WordToNumber(words[i] = reader.ReadLine());
//                //int[] idx = GetMatchIndexes(number, numbers);
//            }
//        }
//        string WordToNumber(string word)
//        {
//            char[] number = new char[word.Length];
//            for (int i = 0; i < word.Length; i++) number[i] = Dictionary[word[i]];
//            return new string(number);
//        }

//        public static void Main()
//        {
//            new Phone_Numbers().Run(Console.In, Console.Out);

//            List<string> dictionary = new List<string>();
//            int count = 0;

//            string[]
//                fullInput = Console.In.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

//            List<char> call_number = fullInput[count].ToCharArray().ToList();

//            while (true)
//            {
//                count++;
//                string currInput = fullInput[count];

//                if (currInput.Equals("-1"))
//                    break;
//                else
//                {
//                    dictionary.Add(currInput);
//                }
//            }


//            //sort dictionary
//            SortDictionary(dictionary);

//            List<string> results = new List<string>();

//            for (int l = 0; l < call_number.Count; l++)
//            {
//                for (int j = 0; j < dictionary.Count; j++)
//                {
//                    if (SeekWord(call_number, dictionary[j], l))
//                    {
//                        if (!results.Where(x => x == dictionary[j]).Any())
//                            results.Add(dictionary[j]);
//                    }
//                }
//            }

//            if (results.Count > 0)
//                foreach (string r in results) Console.Write(r + " ");
//            else Console.WriteLine("No Solution");
//        }
//        public static bool SeekWord(List<char> call_number, string word, int index)
//        {
//            char[] currLetters = alphabet[int.Parse(call_number[index].ToString())].ToCharArray();

//            for (int j = 0; j < currLetters.Length; j++)
//            {
//                char letter = currLetters[j];

//                char[] chars = word.ToCharArray();
//                if (chars.Length > index)
//                {
//                    char currChar = chars[index];
//                    if (letter == currChar)
//                    {
//                        if (SeekWord(call_number, word, ++index))
//                        {
//                            return true;
//                        }
//                    }
//                }
//            }
//            return false;
//        }

//        public static List<string> SortDictionary(List<string> dictionary)
//        {
//            for (int i = 0; i < dictionary.Count - 1; i++)
//            {
//                string A = dictionary[i],
//                B = dictionary[i + 1];
//                if (String.Compare(A, B, true, CultureInfo.InvariantCulture) > 0)
//                {
//                    dictionary[i + 1] = A;
//                    dictionary[i] = B;
//                }
//            }
//            return dictionary;
//        }
//    }

//}
