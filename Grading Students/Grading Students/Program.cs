using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int[] gradingStudents(int[] grades)
    {
        for (int i = 0; i < grades.Count(); i++)
        {
            if((grades[i]+2) % 5 == 0 && grades[i] > 37)
            {
                grades[i] = grades[i] + 2;
            }
        }
        return grades;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int[n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        Console.WriteLine(string.Join("\n", result));
    }
}
