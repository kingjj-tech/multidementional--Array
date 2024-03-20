using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int numOfStudents = 3;
            const int StudentInfor = 3;  


            string[,,] studentArray = new string[numOfStudents, StudentInfor,1];

            for (int i = 0; i < numOfStudents; i++)
            {
                // prompt the user for info

                Console.WriteLine($" please eneter information about the student please{i +1} ");

                Console.WriteLine(" Name :");
                string name = Console.ReadLine();
                studentArray[i,0,0] = name;

                Console.WriteLine(" Gender :");
                string gender = Console.ReadLine();
                studentArray[i,1,0] = gender;

                Console.WriteLine(" Date of birth: ");
                string DOB = Console.ReadLine();
                studentArray[i,2,0] = DOB;


            }
            // SHOWNG STUDENT INFORMATION 
            Console.WriteLine(" SHOWINGG STUDENT INFORMATION ");

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Name: {studentArray[i, 0, 0]}");
                Console.WriteLine($"Gender: {studentArray[i, 1, 0]}");
                Console.WriteLine($"Date of Birth: {studentArray[i, 2, 0]}");
                Console.WriteLine();
            }
            
        }
    }
}
