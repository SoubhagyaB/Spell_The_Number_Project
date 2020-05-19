using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spell_The_Number
{
    public class SpellTheNumber
    {
        public String ConvertToWords(string num)
        {
            String val = "", wholeNo = num;

            try
            {
                int isDecimal = num.IndexOf(".");
                if (isDecimal < 0)
                {
                    val = ConvertWholeNumber(wholeNo);
                    if (val.Contains("Hundred"))
                    {
                       val = ReplaceLastOccurrence(val, "Hundred", "Hundred And");
                    }
                }
                else throw new NullReferenceException("Only whole number is allowed");
            }
            catch(Exception ex) { throw; }           
            return val;
        }
        private String ConvertWholeNumber(String WholeNumb)
        {
            string word = "";
            try
            {
                bool isDone = false;
                double dblDigit = (Convert.ToDouble(WholeNumb));
                if (dblDigit > 0) //Ignores negative number
                {
                    int numDigits = WholeNumb.Length;
                    int pos = 0;
                    String place = "";
                    switch (numDigits)
                    {
                        case 1://ones' range
                            word = Ones(WholeNumb);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = Tens(WholeNumb);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10://Billions's range
                        case 11:
                        case 12:

                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        //add extra case options for anything above Billion...
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone) //Recursive
                    {
                        if (WholeNumb.Substring(0, pos) != "0" && WholeNumb.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(WholeNumb.Substring(0, pos)) + place + ConvertWholeNumber(WholeNumb.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(WholeNumb.Substring(0, pos)) + ConvertWholeNumber(WholeNumb.Substring(pos));
                        }

                    }
                    if (word.Trim().Equals(place.Trim())) word = "";


                }
                else throw new NullReferenceException("Only whole number is allowed");
            }
            catch { }
            return word.Trim();
        }
        private String Tens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = Tens(Number.Substring(0, 1) + "0") + " " + Ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }
        private String Ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
        private string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
    }
}
