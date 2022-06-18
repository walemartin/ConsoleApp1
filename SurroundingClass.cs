﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SurroundingClass
    {
        public static string changeToWords(string numb)
        {
            string val = "";
            string wholeNo = numb;
            string points = "";
            string andStr = "";
            string pointStr = "";
            string endStr = "";
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "point";
                        // just to separate whole numbers from points
                        pointStr = translateCents(points);
                    }
                }
                val = string.Format("{0} {1} {2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch
            {
            }
            return val + "Naira Only.";
        }

        public static string translateWholeNumber(string number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;
                // tests for 0XX
                bool isDone = false;
                // test if already translated
                double dblAmt = (Convert.ToDouble(number));
                // if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {
                    // test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    int pos = 0;
                    // store digit grouping
                    string place = "";
                    // digit grouping name:hundres,thousand,etc...
                    switch (numDigits)
                    {
                        case 1:
                            {
                                // ones' range
                                word = ones(number);
                                isDone = true;
                                break;
                                
                            }

                        case 2:
                            {
                                // tens' range
                                word = tens(number);
                                isDone = true;
                                break;
                                
                            }

                        case 3:
                            {
                                // hundreds' range
                                pos = (numDigits % 3) + 1;
                                place = " Hundred ";
                                break;
                                
                            }

                        case 4:
                        case 5:
                        case 6:
                            {
                                pos = (numDigits % 4) + 1;
                                place = " Thousand ";
                                break;
                                
                            }

                        case 7:
                        case 8:
                        case 9:
                            {
                                pos = (numDigits % 7) + 1;
                                place = " Million ";
                                break;
                                
                            }

                        case 10:
                            {
                                // Billions's range
                                pos = (numDigits % 10) + 1;
                                place = " Billion ";
                                break;
                                
                            }

                        default:
                            {
                                // add extra case options for anything above Billion...
                                isDone = true;
                                break;
                                
                            }
                    }
                    if (!isDone)
                    {
                        // if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        // check for trailing zeros
                        if (beginsZero)
                            word = " and " + word.Trim();
                    }
                    // ignore digit grouping names
                    if (word.Trim().Equals(place.Trim()))
                        word = "";
                }
            }
            catch
            {
            }
            return word.Trim();
        }

        public static string tens(string digit)
        {
            int digt = Convert.ToInt32(digit);
            string name = null;
            switch (digt)
            {
                case 10:
                    {
                        name = "Ten";
                        break;
                        
                    }

                case 11:
                    {
                        name = "Eleven";
                        break;
                      
                    }

                case 12:
                    {
                        name = "Twelve";
                        break;
                     
                    }

                case 13:
                    {
                        name = "Thirteen";
                        break;
                        
                    }

                case 14:
                    {
                        name = "Fourteen";
                        break;
                        
                    }

                case 15:
                    {
                        name = "Fifteen";
                        break;
                      
                    }

                case 16:
                    {
                        name = "Sixteen";
                        break;
                     
                    }

                case 17:
                    {
                        name = "Seventeen";
                        break;
                     
                    }

                case 18:
                    {
                        name = "Eighteen";
                        break;
                     
                    }

                case 19:
                    {
                        name = "Nineteen";
                        break;
                       
                    }

                case 20:
                    {
                        name = "Twenty";
                        break;
                       
                    }

                case 30:
                    {
                        name = "Thirty";
                        break;
                       
                    }

                case 40:
                    {
                        name = "Fourty";
                        break;
                      
                    }

                case 50:
                    {
                        name = "Fifty";
                        break;
                    
                    }

                case 60:
                    {
                        name = "Sixty";
                        break;
                      
                    }

                case 70:
                    {
                        name = "Seventy";
                        break;
                     
                    }

                case 80:
                    {
                        name = "Eighty";
                        break;
                    
                    }

                case 90:
                    {
                        name = "Ninety";
                        break;
                     
                    }

                default:
                    {
                        if (digt > 0)
                            name = (tens(digit.Substring(0, 1) + "0") + " ") + ones(digit.Substring(1));
                        break;
                       
                    }
            }
            return name;
        }

        public static string ones(string digit)
        {
            int digt = Convert.ToInt32(digit);
            string name = "";
            switch (digt)
            {
                case 1:
                    {
                        name = "One";
                        break;
                    
                    }

                case 2:
                    {
                        name = "Two";
                        break;
                        
                    }

                case 3:
                    {
                        name = "Three";
                        break;
                      
                    }

                case 4:
                    {
                        name = "Four";
                        break;
                      
                    }

                case 5:
                    {
                        name = "Five";
                        break;
                        
                    }

                case 6:
                    {
                        name = "Six";
                        break;
                     
                    }

                case 7:
                    {
                        name = "Seven";
                        break;
                      
                    }

                case 8:
                    {
                        name = "Eight";
                        break;
                     
                    }

                case 9:
                    {
                        name = "Nine";
                        break;
                      
                    }
            }
            return name;
        }

        public static string translateCents(string cents)
        {
            string cts = "";
            string digit = "";
            string engOne = "";
            for (int i = 0; i <= cents.Length - 1; i++)
            {
                digit = cents[i].ToString();
                if (digit.Equals("0"))
                    engOne = "Zero";
                else
                    engOne = ones(digit);
                cts += " " + engOne;
            }
            return cts;
        }
    }
}
