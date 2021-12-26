using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepOne
{
    internal class GenSetting
    {
        readonly string digits = "1234567890";
        readonly string EngLetters = "abcdefghijklmnopqrstuvwxyz";
        readonly string CapEngLatters = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        readonly string RuLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        readonly string CapRuLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToUpper();
        readonly string SpecialChar = @"#$%^&*";

        public bool engLetterCheck { get; set; }
        public bool CapEngLettersCheck { get; set; }
        public bool SpecialSymbolsCheck { get; set; }
        public bool RuLattersCheck { get; set; }
        public bool CapRuLattersCheck { get; set; }
        public bool NumbersCheck { get; set; }
        public bool AllCheck { get; set; }

        string _randomstring;
        string _result;
        public int lengthPasword { get; set; }

        Random random;
        public GenSetting()
        {
            init();
        }
        public string Run()
        { 
            AddChars();
            return GeneratorChar();
        }
        private void init()
        {    
            random = new Random();
        }
        private string AddChars()
        {

            if (AllCheck)
            {
                engLetterCheck = CapEngLettersCheck = SpecialSymbolsCheck = RuLattersCheck = CapRuLattersCheck = NumbersCheck = AllCheck;
            }
            if (engLetterCheck)
            {
                _randomstring += EngLetters;
            }
            if (CapEngLettersCheck)
            {
                _randomstring += CapEngLatters;
            }
            if (SpecialSymbolsCheck)
            {
                _randomstring += SpecialChar;
            }
            if (RuLattersCheck)
            {
                _randomstring += RuLetters;
            }
            if (CapRuLattersCheck)
            {
                _randomstring += CapRuLetters;
            }
            if (NumbersCheck)
            {
                _randomstring += digits;
            }
            if (!NumbersCheck && !CapRuLattersCheck && !RuLattersCheck && !SpecialSymbolsCheck && !CapEngLettersCheck && !engLetterCheck)
            {
                _randomstring = "?????";
            }
            return _randomstring;
        }
        public string GeneratorChar()
        {
            for (int i = 0; i < lengthPasword; i++)
            {
                _result += _randomstring[random.Next(0, _randomstring.Length)];
            }
            return _result;
        }
    }
}
