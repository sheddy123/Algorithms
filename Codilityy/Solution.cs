namespace Codilityy
{
    public class Solution
        {
            public string solution(string S)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                S = removeNonDigits(S);
                return phoneNumberFormat(S, numberSize(S));
            }

            private bool numberSize(string phoneNumber)
            {
                return phoneNumber.Length % 3 == 1;
            }

            private string removeNonDigits(string digits)
            {
                return digits.Replace("[^0-9]", "");
            }
            private string phoneNumberFormat(string digit, bool lastInstance)
            {
                string tempNum = "";
                int dashCounter = 0;
                for (int i = 0; i < digit.Length; i++)
                {
                    if (dashCounter < 3)
                    {
                        var conCatSubString = digit[i];
                        tempNum = tempNum + conCatSubString;
                        dashCounter++;
                    }
                    else if (dashCounter == 3)
                    {
                        tempNum = tempNum + "-";
                        var conCatSubString2 = digit[i];
                        tempNum = tempNum + conCatSubString2;
                        dashCounter = 1;
                    }
                }

                if (lastInstance)
                {
                    char[] _temp = tempNum.ToCharArray();
                    _temp[_temp.Length - 2] = _temp[_temp.Length - 3];
                    _temp[_temp.Length - 3] = '-';
                    tempNum = new string(_temp);
                }
                return tempNum;
            }
        }

    }
