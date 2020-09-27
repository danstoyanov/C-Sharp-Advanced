using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            var studentDict = new Dictionary<string, List<decimal>>();

            StudentsInput(students, studentDict);
            GradesPrint(studentDict);
        }


        public static void StudentsInput(int students, Dictionary<string, List<decimal>> studentDict)
        {
            for (int currStudent = 1; currStudent <= students; currStudent++)
            {
                var studentInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (!studentDict.ContainsKey(studentInfo[0]))
                {
                    studentDict.Add(studentInfo[0], new List<decimal>());
                    studentDict[studentInfo[0]].Add(decimal.Parse(studentInfo[1]));
                }
                else
                {
                    studentDict[studentInfo[0]].Add(decimal.Parse(studentInfo[1]));
                }
            }
        }
        public static void GradesPrint(Dictionary<string, List<decimal>> studentDict)
        {
            foreach (var pair in studentDict)
            {
                string pairGrades = string.Join(" ", pair.Value.Select(x => x.ToString("F2")));
                Console.WriteLine($"{pair.Key} -> {pairGrades} (avg: {pair.Value.Average():F2})");
            }
        }
    }
}
