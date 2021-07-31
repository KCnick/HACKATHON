using System;

namespace Exercise02
{
    public class Class1
    {
        public static string Towards( this int Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;  
                bool isDone = false;    
                double dblAmt = (Convert.ToDouble(Number));
                //if ((dblAmt > 0) && number.StartsWith("0"))    
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric    
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    String place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        // case 1://ones' range    

                        //     word = ones(Number);
                        //     isDone = true;
                        //     break;
                        // case 2://tens' range    
                        //     word = tens(Number);
                        //     isDone = true;
                        //     break;
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
                       
                        case 13:
                        case 14:
                        case 15:
                            pos = (numDigits % 12) + 1;
                            place = " trillion ";
                            break;
                        case 16:
                        case 17:
                        case 18:
                            pos = (numDigits % 15) + 1;
                            place = " quadrillion";
                            break;
                        
                        case 19:
                        case 20:
                        case 21: 
                            pos = (numDigits % 18) + 1;
                            place = " quintillion ";
                            break;
                         //add extra case options for anything above quintillion...    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)    
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = Towards(Number.Substring(0, pos)) + place + Towards(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = Towards(Number.Substring(0, pos)) + Towards(Number.Substring(pos));
                        }

                        //check for trailing zeros    
                        //if (beginsZero) word = " and " + word.Trim();    
                    }
                    //ignore digit grouping names    
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }
    }
}
