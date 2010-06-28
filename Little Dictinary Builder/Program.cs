using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CsP.Little_Dictinary_Builder
{
    static class Program
    {
        /** 
         * <summary>
         * The main entry point for the application.</summary>
         */
        public static Dictionary d;
        [STAThread]
        static void Main()
        {
            d = new Dictionary("a", "b", "c");
            d.AddKey("b", "b");
            d.AddKey("d", "d");
            d.AddKey("dʒ", "dzs");
            d.AddKey("f", "f");
            d.AddKey("g", "g");
            d.AddKey("h", "h");
            d.AddKey("k", "k");
            d.AddKey("l", "l");
            d.AddKey("m", "m");
            d.AddKey("n", "n");
            d.AddKey("ŋ", "ng");
            d.AddKey("p", "p");
            d.AddKey("r", "r");
            d.AddKey("s", "sz");
            d.AddKey("ʃ", "s");
            d.AddKey("t", "t");
            d.AddKey("tʃ", "cs");
            d.AddKey("θ", "th");
            d.AddKey("ð", "dh");
            d.AddKey("v", "v");
            d.AddKey("w", "v");
            d.AddKey("ʰw", "vh");
            d.AddKey("y", "j");
            d.AddKey("z", "z");
            d.AddKey("ʒ", "zs");
            d.AddKey("æ", "e");
            d.AddKey("eɪ", "é");
            d.AddKey("ɑ", "a");
            d.AddKey("ɛər", "er");
            d.AddKey("ɔ", "ó");
            d.AddKey("aʊər", "áúr");
            d.AddKey("ɛ", "e");
            d.AddKey("i", "í");
            d.AddKey("ɪər", "ír");
            d.AddKey("ər", "ör");
            d.AddKey("ɜr", "ör");
            d.AddKey("ɪ", "i");
            d.AddKey("aɪ", "áj");
            d.AddKey("aɪər", "ájör");
            d.AddKey("ɒ", "a");
            d.AddKey("oʊ", "ú");
            d.AddKey("u", "u");
            d.AddKey("ʊ", "oj");
            d.AddKey("ɔɪ", "áu");
            d.AddKey("aʊ", "a");
            //d.AddKey("ʌ", "Z");
            d.AddKey("ə", "o");
            //d.AddKey("a", "Z");
            //d.AddKey("ə", "Z");
            //d.AddKey("œ", "Z");
            //d.AddKey("r", "Z");
            //d.AddKey("ü", "Z");
            //d.AddKey("x", "Z");
            //d.AddKey("ɛ̃", "Z");
            //d.AddKey("ɑ̃", "Z");
            //d.AddKey("ɔ̃", "Z");
            //d.AddKey("œ̃", "Z");
            //d.AddKey("ĩ", "Z");
            //d.AddKey("ɪ̃", "Z");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
           
        }


       
    }
}
