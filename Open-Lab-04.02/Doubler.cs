using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string og = "";
            for (int a = 0; a <= original.Length - 1; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    og = og + original[a];
                }
            }return (og);
        }
    }
}
