using System;

namespace FooBaa
{
    public class ConversorFooBaa
    {
        private int número;

        public ConversorFooBaa()
        {

        }

        public string Converter(int num)
        {
            if (num % 3 == 0 && num % 5 != 0 ) return "Foo";

            if (num % 5 == 0 && num % 3 != 0) return "Baa";

            if (num % 3 == 0 && num % 5 == 0) return "FooBaa";

            return "";
        }
    }
}