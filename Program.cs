using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//This class or library contains the File methods we need to read in the data from the CSV

namespace ReadInFile
{
    internal class Program
    {
        //Global variables
        //Fileapth of the users.csv file which is stored in the BIN>DEDUB folder i.e. where the executable is run from
        static string filePath = "users.csv";

        //This is a 2D array
        static string[,] users = new string[3, 8];

        static void Main(string[] args)
        {
            readInFile();
            for(int i=0;i<3;i++)
            {
                Console.WriteLine();
                for(int j=0;j<8;j++)
                {
                    Console.Write(users[i,j]+",");  
                }
            }
            Console.ReadKey();

        }

        static void readInFile()
        {
            string[] rawData = new string[3];
            rawData = File.ReadAllLines(filePath);

            string[] tempUser = new string[8];
            for(int i=0;i<3;i++)
            {
                tempUser = rawData[i].Split(',');
                for(int j=0;j<8;j++)
                {
                    users[i,j] = tempUser[j];
                }
            }

            Console.WriteLine("Data has been successfully read in. Press any key to continue");
            Console.ReadKey();

        }
    }
}
