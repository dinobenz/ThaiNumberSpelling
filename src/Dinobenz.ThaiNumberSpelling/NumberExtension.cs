using System;
using System.Text;

namespace Dinobenz.ThaiNumberSpelling
{
    /// <summary>
    /// The number extension class.
    /// </summary>
    public static class NumberExtension
    {
        /// <summary>
        /// Convert number to Thai spelling word.
        /// </summary>
        /// <param name="value">The number</param>
        /// <returns>The Thai spelling word</returns>
        public static string ToThaiSpelling(this int value)
        {
            string valueText = value.ToString();
            StringBuilder ret = new StringBuilder();
            string[] digits = { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
            string[] units = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };

            for (int i = 0; i < valueText.Length; i++)
            {
                if (valueText[i] != '0')
                {
                    if (i == valueText.Length - 1)
                    {
                        switch (valueText[i].ToString())
                        {
                            case "1":
                                if (ret.Length > 0)
                                {
                                    if (valueText[i - 1] == '0')
                                    {
                                        ret.Append(digits[Convert.ToInt32(valueText[i])]);
                                    }
                                    else
                                    {
                                        ret.Append("เอ็ด");
                                    }
                                }
                                else
                                {
                                    ret.Append(digits[Convert.ToInt32(valueText[i])]);
                                }
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(valueText[i])]);
                                break;
                        }
                    }
                    else if (i == valueText.Length - 2 || i == valueText.Length % 6 - 2)
                    {
                        switch (valueText[i])
                        {
                            case '1':
                                ret.Append("");
                                break;
                            case '2':
                                ret.Append("ยี่");
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(valueText[i])]);
                                break;
                        }
                    }
                    else
                    {
                        ret.Append(digits[Convert.ToInt32(valueText[i])]);
                    }

                    if (valueText.Length - 1 - i >= units.Length)
                    {
                        ret.Append(units[valueText.Length % units.Length - i]);
                    }
                    else
                    {
                        ret.Append(units[valueText.Length - 1 - i]);
                    }
                }
                else
                {
                    if (ret.Length == 0)
                    {
                        ret.Append("ศูนย์");
                    }
                }
            }

            return ret.ToString();
        }
    }
}
