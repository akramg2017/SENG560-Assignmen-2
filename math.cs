using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
      public class Calculate
        {

            //Operations
     //       private static int _getRadix(Base @base)
       //     {
         //       int radix = 0; // default to decimal
           //     switch (@base)
             //   {
               //     case BINARY:
               //         radix = 2;
               //         break;
                //    case OCTAL:
                //        radix = 8;
                //        break;
                //    case HEX:
                //        radix = 16;
                 //       break;
                 //   default:
                 //       radix = 10;
                 //       break;
              //  }

             //   return radix;
          //  }

          //  private static string _getNumberString(int num, Base @base)
           // {
           //     string str = "";
          //      switch (@base)
          //      {
          //          case BINARY:
           //             str = Integer.toBinaryString(num);
           //             break;
          //          case OCTAL:
          //              str = Integer.toOctalString(num);
          //              break;
          //          case HEX:
          //              str = num.ToString("x");
          //              break;
          //          default:
          //              str = Convert.ToString(num);
          //              break;
         //       }
         //       return str;
        //    }

            //Addition
            public static int Add(int a, int b)
            {
                return (a + b);
            }
            public static long Add(long a, long b)
            {
                return (a + b);
            }
            public static float Add(float a, float b)
            {
                return (a + b);
            }
            public static double Add(double a, double b)
            {
                return (a + b);
            }

            //Subtraction
            public static int Subtract(int a, int b)
            {
                return (a - b);
            }
            public static long Subtract(long a, long b)
            {
                return (a - b);
            }
            public static float Subtract(float a, float b)
            {
                return (a - b);
            }
            public static double Subtract(double a, double b)
            {
                return (a - b);
            }


            //Multiplication
            public static int Product(int a, int b)
            {
                return (a * b);
            }
            public static long Product(long a, long b)
            {
                return (a * b);
            }
            public static float Product(float a, float b)
            {
                return (a * b);
            }
            public static double Product(double a, double b)
            {
                return (a * b);
            }

            //Division
            public static int Quotient(int a, int b)
            {
                return (a / b);
            }
            public static long Quotient(long a, long b)
            {
                return (a / b);
            }
            public static float Quotient(float a, float b)
            {
                return (a / b);
            }
            public static double Quotient(double a, double b)
            {
                return (a / b);
            }

            //Square root
            public static int Sqrt(int a)
            {
                return (int)Math.Sqrt(a);
            }
            public static long Sqrt(long a)
            {
                return (long)Math.Sqrt(a);
            }
            public static float Sqrt(float a)
            {
                return (float)Math.Sqrt(a);
            }
            public static double Sqrt(double a)
            {
                return Math.Sqrt(a);
            }

            //Logarithmic
            public static int Exp(int a, int b)
            {
                return (int)Math.Pow(a, b);
            }
            public static long Exp(long a, long b)
            {
                return (long)Math.Pow(a, b);
            }
            public static float Exp(float a, float b)
            {
                return (float)Math.Pow(a, b);
            }
            public static double Exp(double a, double b)
            {
                return Math.Pow(a, b);
            }

            //Base Conversion
      //      public static string ConvertToBinary(int val, Base @base)
      //      {
                //		String bin = Integer.toBinaryString(val);
                //		int ret_val = Integer.parseInt(bin, 2);
     //           return Convert.ToString(Integer.parseInt(_getNumberString(val, @base), _getRadix(@base)), 2);
     //       }
     //       public static string ConvertToBinary(string val, Base @base)
       //     {
     //           //		String bin = Integer.toBinaryString(val);
                //		int ret_val = Integer.parseInt(bin, 2);
         //       return Convert.ToString(Integer.parseInt(val, _getRadix(@base)), 2);
        //    }
         //   public static string ConvertToHexadecimal(int val, Base @base)
       //     {

                //		String bin = Integer.toString(val, 16);
     //           //		int ret_val = Integer.parseInt(bin, 16);
      //          return Convert.ToString(Integer.parseInt(_getNumberString(val, @base), _getRadix(@base)), 16).ToUpper();
     //       }
       //     public static string ConvertToHexadecimal(string val, Base @base)
         //   {

                //		String bin = Integer.toString(val, 16);
                //		int ret_val = Integer.parseInt(bin, 16);
           //     return Convert.ToString(Integer.parseInt(val, _getRadix(@base)), 16).ToUpper();
         //   }
        //    public static string ConvertToOctal(int val, Base @base)
       //     {
                //		String bin = Integer.toOctalString(val);
                //		int ret_val = Integer.parseInt(bin, 8);
         //       return Convert.ToString(Integer.parseInt(_getNumberString(val, @base), _getRadix(@base)), 8);
        //    }
        //    public static string ConvertToOctal(string val, Base @base)
       //     {
                //		String bin = Integer.toOctalString(val);
                //		int ret_val = Integer.parseInt(bin, 8);
        //        return Convert.ToString(Integer.parseInt(val, _getRadix(@base)), 8);
        //    }
        //    public static int ConvertToDecimal(int val)
       //     {
        //        string bin = Convert.ToString(val, 10);
       //         int ret_val = Convert.ToInt32(bin, 10);
      //          return ret_val;
      //      }


        }
    }

