using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace CsP.Little_Dictinary_Builder
{
    /** 
     * <summary>
     * Class for translating between an IPA and another language.</summary>
     */
    class Dictionary
    {
        /**
         * <summary>
         * Language</summary>
         */
        private string _sourceLanguage;

        
        /**
         * <summary>
         * Language</summary>
         */
        private string _destinationLanguage;
        
        /**
         * <summary>
         * The source of the IPA keys.</summary>
         */
        private string _source;

        
        private StringDictionary _soundMap;
        


        public Dictionary(string sourceLanguage, string destinationLanguage, string source)
        {
            _sourceLanguage = sourceLanguage;
            _destinationLanguage = destinationLanguage;
            _source = source;
            _soundMap = new StringDictionary();
        }

        /**
         * <summary>
         * Adds a key to the key table.</summary>
         */
        public void AddKey(string key, string value)
        {
            try
            {
                _soundMap.Add(key, value);
            }
            catch(ArgumentException e)
            {
                throw e; // TODO
            }
        }

       

        public string translateWord(string sourceWord)
        {
            int i = 0;
            string destinationWord = "";
            string s;
            while (i < sourceWord.Length)
            {
               
                if ((i + 4 <= sourceWord.Length) && (_soundMap.ContainsKey(s = sourceWord.Substring(i, 4))))
                {
                    destinationWord += _soundMap[s];
                    i += 4;
                }
                else
                {
                    if ((i + 3 <= sourceWord.Length) && (_soundMap.ContainsKey(s = sourceWord.Substring(i, 3))))
                    {
                        destinationWord += _soundMap[s];
                        i += 3;
                    }
                    else
                    {
                        if ((i + 2 <= sourceWord.Length) && (_soundMap.ContainsKey(s = sourceWord.Substring(i, 2))))
                        {
                            destinationWord += _soundMap[s];
                            i += 2;
                        }
                        else
                        {
                            if (_soundMap.ContainsKey(sourceWord[i].ToString()))
                            {
                                destinationWord += _soundMap[sourceWord[i].ToString()];
                                i++;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }
            }
            return destinationWord;
        }



    }
}
