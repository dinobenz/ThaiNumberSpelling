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
            StringBuilder ret = new StringBuilder();
            string[] digits = { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
            string[] units = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };

            for (int i = 0; i < value.ToString().Length; i++)
            {
                if (value.ToString()[i].ToString() != "0")
                {
                    if (i == value.ToString().Length - 1)
                    {
                        switch (value.ToString()[i].ToString())
                        {
                            case "1":
                                if (ret.Length > 0)
                                {
                                    if (value.ToString()[i - 1].ToString() == "0")
                                    {
                                        ret.Append(digits[Convert.ToInt32(value.ToString()[i].ToString())]);
                                    }
                                    else
                                    {
                                        ret.Append("เอ็ด");
                                    }
                                }
                                else
                                {
                                    ret.Append(digits[Convert.ToInt32(value.ToString()[i].ToString())]);
                                }
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(value.ToString()[i].ToString())]);
                                break;
                        }
                    }
                    else if (i == value.ToString().Length - 2 || i == value.ToString().Length % 6 - 2)
                    {
                        switch (value.ToString()[i].ToString())
                        {
                            case "1":
                                ret.Append("");
                                break;
                            case "2":
                                ret.Append("ยี่");
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(value.ToString()[i].ToString())]);
                                break;
                        }
                    }
                    else
                    {
                        ret.Append(digits[Convert.ToInt32(value.ToString()[i].ToString())]);
                    }

                    if (value.ToString().Length - 1 - i >= units.Length)
                    {
                        ret.Append(units[value.ToString().Length % units.Length - i]);
                    }
                    else
                    {
                        ret.Append(units[value.ToString().Length - 1 - i]);
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
