using System;
using System.Text;
using System.Globalization;

namespace ATMPINValidator
{/// <summary>
/// TryParse(strComing, ///clas///NumberStyles.SomeCommand, ///provider/// null, out valueParsed)
/// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var pin = "+762345";

            Console.WriteLine(ValidatePIN(pin));
        }

        private static bool ValidatePIN(string pin)
        {
            var pinNumber = 0;
            var IsValidPIN = int.TryParse(pin, NumberStyles.None, null, out pinNumber) && (pin.Length == 4 || pin.Length == 6);
            return IsValidPIN;
        }
    }
}
