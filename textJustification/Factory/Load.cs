using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Factory
{
    class Load
    {
        public void test()
        {
            string[] words = { "When", "I", "was", "just", "a", "little", "girl", "I", "asked", "my", "mother", "what", "will", "I", "be", "Will", "I", "be", "pretty", "Will", "I", "be", "rich", "Here's", "what", "she", "said", "to", "me", "Que", "sera", "sera", "Whatever", "will", "be", "will", "be", "The", "future's", "not", "ours", "to", "see", "Que", "sera", "sera", "When", "I", "was", "just", "a", "child", "in", "school", "I", "asked", "my", "teacher", "what", "should", "I", "try", "Should", "I", "paint", "pictures", "Should", "I", "sing", "songs", "This", "was", "her", "wise", "reply", "Que", "sera", "sera", "Whatever", "will", "be", "will", "be", "The", "future's", "not", "ours", "to", "see", "Que", "sera", "sera", "When", "I", "grew", "up", "and", "fell", "in", "love", "I", "asked", "my", "sweetheart", "what", "lies", "ahead", "Will", "there", "be", "rainbows", "day", "after", "day", "Here's", "what", "my", "sweetheart", "said", "Que", "sera", "sera", "Whatever", "will", "be", "will", "be", "The", "future's", "not", "ours", "to", "see", "Que", "sera", "sera", "What", "will", "be,", "will", "be", "Que", "sera", "sera..." };

            var maxWidth = 20;



            var liso = FullJustify(words, maxWidth);

            foreach (var item in liso)
            {
                Console.WriteLine(item);
            }

          
        }

        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> wordList = new List<string>(words);
            var retList = new List<string>();
            if (string.Concat(words).Length < 1)
            {
                
                var rt = "";
                for (int i = 0; i < maxWidth; i++)
                {
                    rt += " ";
                }
                retList.Add(rt);
                return retList;
            }

            while (true)
            {

                var charCount = 0;
                var calcList = new List<string>();

                for (int i = 0; i < wordList.Count(); i++)
                {
                    if (charCount < maxWidth)
                    {
                        charCount += wordList[i].Length;
                        charCount++;
                        calcList.Add(wordList[i]);
                        if (wordList.Count > 1)
                        {
                            if (wordList.Count() - i != 1)
                            {
                                

                                if (wordList[i + 1].Length + charCount > maxWidth)
                                {
                                    break;
                                }
                            }

                        }

                    }

                }

                for (int i = 0; i < calcList.Count; i++)
                {
                    wordList.RemoveAt(0);
                }

                if (wordList.Count < 1)
                {
                    var what = string.Join(" ", calcList);
                    calcList.Clear();
                    calcList.Add(what);
                }

                while (string.Concat(calcList).Length < maxWidth)
                {
                    for (int i = 0; i < calcList.Count; i++)
                    {
                        
                        
                        if (i != calcList.Count - 1)
                        {
                            calcList[i] = calcList[i] + " ";
                            if (string.Concat(calcList).Length + 1 > maxWidth)
                            {
                                break;
                            }

                        }
                        if (calcList.Count == 1)
                        {
                            calcList[i] = calcList[i] + " ";
                            if (string.Concat(calcList).Length + 1 > maxWidth)
                            {
                                break;
                            }
                        }
                    }
                }

                var finString = string.Join("", calcList);
                retList.Add(finString);

                if (wordList.Count < 1)
                {
                    break;
                }
            }

            return retList;
        }
    }
}




