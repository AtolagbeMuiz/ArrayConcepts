using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int [] evenNumbers = new int [3];
        //    evenNumbers[0] = 2;
        //    evenNumbers[1] = 4;
        //     evenNumbers[2] = 6;
        //     //evenNumbers[3] = 8;

        //     System.Console.WriteLine(evenNumbers [2]);


        // string [] students = new string [4];
        //     students[0] = "Elijah";
        //     students[1] = "Muiz";
        //     students[2] = "Sarah";
        //     students[3] = "Segun";
        //     //evenNumbers[3] = 8;

        //     System.Console.WriteLine(students[2]);

        // string [] students = {"Elijah", "Ekene", "Precious", "Andrew"};

        // foreach(var student in students)
        // {
        //     System.Console.WriteLine(student);
        // }

        //To jump values in the Array;; usig or loop
        // string [] students = {"muiz", "paul", "micheal", "ife", "Bernice", "emma", "Mubarak", "Andrew"};

        //     for(int i=0; i<8; i+=2)
        //     {
        //         System.Console.WriteLine(students[i]);
        //     }


        //Multi-Dimensional Array; row comes first folowed by Column R.C    
            int[,] goodNumbers = new int [4,4] {  {0, 1, 2, 3},
                                        {4, 5, 6, 7},
                                        {8, 9, 10, 11},
                                        {12, 13, 14, 15} };

                for(int i=0; i<4; i++)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("This is row" + i);
                    
                    for(int j=0; j<4; j++)
                    {
                        System.Console.WriteLine(goodNumbers[i,j]);
                    }
                }
        }
    }
}
