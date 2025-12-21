namespace Tutorials.Models
{
    public class Unicodes
    {
        private readonly int _value; 

        public string Code
        {
            get
            {
                if (string.IsNullOrEmpty(_code))
                {
                    int power = 16 * 16 * 16;
                    int digit4 = (int)(_value / power);
                    int left = _value % power;
                    power = 16 * 16;
                    int digit3 = (int)(left / power);
                    left = left % power;
                    power = 16;
                    int digit2 = (int)(left / power);
                    int digit1 = left % power;
                    _code = $"{Translate(digit4)}{Translate(digit3)}{Translate(digit2)}{Translate(digit1)}";
                }
                return _code;
            }
        }
        private string _code ="";

        public string Valeur1 => char.ConvertFromUtf32(_value);

        public string Valeur2 => char.ConvertFromUtf32(_value+1);

        public string Valeur3 => char.ConvertFromUtf32(_value+2);

        public string Valeur4 => char.ConvertFromUtf32(_value+3);

        public string Valeur5 => char.ConvertFromUtf32(_value+4);

        public string Valeur6 => char.ConvertFromUtf32(_value+5);

        public string Valeur7 => char.ConvertFromUtf32(_value+6);

        public string Valeur8 => char.ConvertFromUtf32(_value+7);

        public string Valeur9 => char.ConvertFromUtf32(_value+8);

        public string Valeur10 => char.ConvertFromUtf32(_value+9);

        public string Valeur11 => char.ConvertFromUtf32(_value+10);

        public string Valeur12 => char.ConvertFromUtf32(_value+11);

        public string Valeur13 => char.ConvertFromUtf32(_value+12);

        public string Valeur14 => char.ConvertFromUtf32(_value+13);

        public string Valeur15 => char.ConvertFromUtf32(_value+14);

        public string Valeur16 => char.ConvertFromUtf32(_value+15);


        public Unicodes(int code)
        {
            _value = code;
        }

        private string Translate(int digit)
        {
            string result = "0";
            switch (digit)
            {
                case 1: result = "1"; break;
                case 2: result = "2"; break;
                case 3: result = "3"; break;
                case 4: result = "4"; break;
                case 5: result = "5"; break;
                case 6: result = "6"; break;
                case 7: result = "7"; break;
                case 8: result = "8"; break;
                case 9: result = "9"; break;
                case 10: result = "A"; break;
                case 11: result = "B"; break;
                case 12: result = "C"; break;
                case 13: result = "D"; break;
                case 14: result = "E"; break;
                case 15: result = "F"; break;
            }
            return result;
        }
    }
}
