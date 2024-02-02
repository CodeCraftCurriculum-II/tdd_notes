namespace example
{

    class RomanNumerals
    {

        public static string Convert(int number)
        {
            string output = "";
            while (number > 0)
            {
                int diff = 0;

                if (number >= 10)
                {
                    output += "X";
                    diff = 10;
                }
                else if (number >= 9)
                {
                    output += "IX";
                    diff = 9;
                }
                else if (number >= 5)
                {
                    output += "V";
                    diff = 5;
                }
                else if (number >= 4)
                {
                    output += "IV";
                    diff = 4;
                }
                else if (number < 4)
                {
                    output += "I";
                    diff = 1;
                }

                number -= diff;
            }

            return output;
        }

    }




}

