using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_7_ushapant12345
{
    public partial class Form1 : Form


    {



        int[] integerSetPrint = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        double[] doubleSetPrint = { 10.1, 10.2, 10.3, 10.4, 10.5 };

        float[] floatSetPrint = { 11.6f, 21.5f, 31.4f, 41.3f, 51.2f, 61.1f };

        int[] numsToFind = { 62, 33, 18, 29, 45, 9, 82, 27, 88, 16, 68 };
        int numFound;
        public Form1()
        {
            InitializeComponent();

            int[] someIntegers = new int[5];
            someIntegers[1] = 78632;
            someIntegers[4] = 61;
            someIntegers[0] = 302;
            someIntegers[3] = 39876;
            someIntegers[2] = 49;

            double[] someDoubles = new double[5];

            someDoubles[3] = 7.8632;
            someDoubles[0] = 73.2;
            someDoubles[4] = 18.72;
            someDoubles[2] = 92.621;
            someDoubles[1] = 3.141259;

            string[] someStrings = new string[5];
            someStrings[2] = "Hello";
            someStrings[4] = "World";
            someStrings[1] = "Cruel";
            someStrings[3] = "Planet";
            someStrings[0] = "Adios";

            bool[] someBools = new bool[5];

            someBools[4] = true;
            someBools[0] = false;
            someBools[2] = true;
            someBools[1] = false;
            someBools[3] = true;

            char[] someChars = new char[5];
            someChars[0] = 'a';
            someChars[1] = 'b';
            someChars[2] = 'c';
            someChars[3] = 'd';
            someChars[4] = 'e';

            int value26 = someIntegers[3];
            someIntegers[1] = value26;

            int value27 = someIntegers[0];
            someIntegers[4] = value27;

            int value28 = someIntegers[4];
            someIntegers[0] = value28;

            int value29 = someIntegers[2];
            someIntegers[3] = value29;

            double value30 = someDoubles[1];
            someDoubles[0] = value30;

            double value31 = someDoubles[2];
            someDoubles[1] = value31;

            char value32 = someChars[3];
            someChars[0] = value32;


            char value33 = someChars[2];
            someChars[4] = value33;

            bool value34 = someBools[4];
            someBools[1] = value34;



            char value35 = someChars[2];
            someChars[0] = value35;


            int value36 = someIntegers[3];
            someIntegers[3] = someIntegers[1];
            someIntegers[1] = value26;

            int value37 = someIntegers[0];
            someIntegers[0] = someIntegers[4];
            someIntegers[4] = value37;


            int value38 = someIntegers[4];
            someIntegers[4] = someIntegers[0];
            someIntegers[0] = value38;

            int value39 = someIntegers[2];
            someIntegers[2] = someIntegers[3];
            someIntegers[3] = value39;


            double value40 = someDoubles[1];
            someDoubles[1] = someDoubles[0];
            someDoubles[0] = value40;


            double value41 = someDoubles[2];
            someDoubles[2] = someDoubles[1];
            someDoubles[1] = value41;



            char value42 = someChars[3];
            someChars[3] = someChars[0];
            someChars[0] = value42;


            char value43 = someChars[2];
            someChars[2] = someChars[4];
            someChars[4] = value43;


            bool value44 = someBools[4];
            someBools[4] = someBools[1];
            someBools[1] = value44;


            bool value45 = someBools[2];
            someBools[2] = someBools[0];
            someBools[0] = value45;


            string strFor46 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 0; ndx < integerSetPrint.Length; ndx++)
            {
                strFor46 += integerSetPrint[ndx] + "-";
            }
            MessageBox.Show(strFor46);


            string strFor47 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 1; ndx < integerSetPrint.Length; ndx++)
            {
                strFor47 += integerSetPrint[ndx] + "*";
            }
            MessageBox.Show(strFor47);



            string strFor48 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 0; ndx < integerSetPrint.Length-1; ndx++)
            {
                strFor48 += integerSetPrint[ndx] + "-*-";
            }
            MessageBox.Show(strFor48);

            string strFor49 = "";
            for (int ndx = integerSetPrint.Length; ndx > 0; ndx--)
            {
                strFor49 += integerSetPrint[ndx - 1] + "|";
            }
            MessageBox.Show(strFor49);


            string strFor50 = "";
            for (int ndx = integerSetPrint.Length; ndx >1 ; ndx--)
            {
                strFor50 += integerSetPrint[ndx - 1] + "#";
            }
            MessageBox.Show(strFor50);


            string strFor51 = "";
            for (int ndx = integerSetPrint.Length-1; ndx > 0; ndx--)
            {
                strFor51 += integerSetPrint[ndx - 1] + "@";
            }
            MessageBox.Show(strFor51);


            string strFor52 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 0; ndx < doubleSetPrint.Length; ndx++)
            {
                strFor52 += doubleSetPrint[ndx] + " ";
            }
            MessageBox.Show(strFor52);


            string strFor53 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 0; ndx < doubleSetPrint.Length-1; ndx++)
            {
                strFor53 += doubleSetPrint[ndx] + "*";
            }
            MessageBox.Show(strFor53);


            string strFor54 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx =doubleSetPrint.Length-1;ndx>=0; ndx--)
            {
                strFor54 += doubleSetPrint[ndx] + "|";
            }
            MessageBox.Show(strFor54);


            string strFor55 = "";
            // you should always do things based on array.Length not a set number.
            for (int  ndx =0; ndx < floatSetPrint.Length; ndx++)
            {
                strFor55 += floatSetPrint[ndx] + "-";
            }
            MessageBox.Show(strFor55);


            string strFor56 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 0; ndx < floatSetPrint.Length-1; ndx++)
            {
                strFor56 += floatSetPrint[ndx] + "*";
            }
            MessageBox.Show(strFor56);


            string strFor57 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = 2; ndx < floatSetPrint.Length-1; ndx++)
            {
                strFor57 += floatSetPrint[ndx] + "-";
            }
            MessageBox.Show(strFor57);

            string strFor58 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx= floatSetPrint.Length-1;ndx>=0 ; ndx--)
            {
                strFor58 += floatSetPrint[ndx] + "^";
            }
            MessageBox.Show(strFor58);



            string strFor59 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = floatSetPrint.Length - 1; ndx >=1 ; ndx--)
            {
                strFor59 += floatSetPrint[ndx] + "-*-";
            }
            MessageBox.Show(strFor59);

            string strFor60 = "";
            // you should always do things based on array.Length not a set number.
            for (int ndx = floatSetPrint.Length - 1; ndx >= 0; ndx--)
            {
                strFor60 += floatSetPrint[ndx] + "C"+"|";
            }
            MessageBox.Show(strFor60);


            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 30 && numCheck < 38)
                {
                    numFound = numCheck;
                }
            }


            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 16 && numCheck < 25)
                {
                    numFound = numCheck;
                }
            }



            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 10 && numCheck <=16)
                {
                    numFound = numCheck;
                }
            }



            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 60 && numCheck < 70 && numCheck!=62)
                {
                    numFound = numCheck;
                }
            }


            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 30 && numCheck < 68 && numCheck % 2==0)
                {
                    numFound = numCheck;
                }
            }



            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 80 && numCheck < 98 && numCheck % 8 == 0)
                {
                    numFound = numCheck;
                }
            }


            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > 10 && numCheck < 33 && numCheck % 3==0 && numCheck %2 !=0)
                {
                    numFound = numCheck;
                }
            }



            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > numsToFind[2] && numCheck < numsToFind[1])
                {
                    numFound = numCheck;
                }
            }



            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > numsToFind[6] && numCheck < numsToFind[1])
                {
                    numFound = numCheck;
                }
            }


            for (int ndx = 0; ndx < numsToFind.Length; ndx++)
            {
                int numCheck = numsToFind[ndx];
                if (numCheck > numsToFind[9] && numCheck < numsToFind[4] && numCheck % numsToFind[5] ==0 )
                {
                    numFound = numCheck;
                }
            }

           

        }

        public int[] SquareThese(int[] values)
        {
            // inner code is not required but gets rid of syntax errors.
            return new int[1];
        }



        public int[] ArrayOne(int[] values, int num)
        {
            // inner code is not required but gets rid of syntax errors.
            return new int[5];
        }



        public double SquareThese(double[] values,double num)
        {
            // inner code is not required but gets rid of syntax errors.
            return num;
        }

        public double[] SquareThese(int[] values, int num)
        {
            // inner code is not required but gets rid of syntax errors.
            return new double[5];
        }


        public void values(int[] values,int num)
        {
            // inner code is not required but gets rid of syntax errors.
            
        }


        public string arrayTwo(char[] values)
        {
            // inner code is not required but gets rid of syntax errors.
            return values+" ";
        }


        public double SquareThese(int valueone, double[] valuetwo)
        {
            // inner code is not required but gets rid of syntax errors.
            return valueone;
        }

        public bool[] Check(double[] valueone, double valuetwo)
        {
            // inner code is not required but gets rid of syntax errors.
            return new bool[10];
        }


        public String [] SquareThese(int[] values, string name)
        {
            // inner code is not required but gets rid of syntax errors.
            return new string [10];
        }

        public char[] SquareThese(int[] values, string[] names)
        {
            // inner code is not required but gets rid of syntax errors.
            return new char [10];
        }


    }
}
