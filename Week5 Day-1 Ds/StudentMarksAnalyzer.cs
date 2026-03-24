using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1_Ds
{
    internal class StudentMarksAnalyzer
    {
        static void Main()
        {
            List<int> marks = new List<int> { 78, 85, 90, 67, 88 };
            int threshold = 80;

            AnalyzeScores(marks, threshold);
        }

        static void AnalyzeScores(List<int> marks, int threshold)
        {
            int totalMarks = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                totalMarks += marks[i];
            }

            double averageMarks = (double)totalMarks / marks.Count;

            int highestScore = marks[0];
            for (int i = 1; i < marks.Count; i++)
            {
                if (marks[i] > highestScore)
                {
                    highestScore = marks[i];
                }
            }

            List<int> aboveThreshold = new List<int>();
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i] > threshold)
                {
                    aboveThreshold.Add(marks[i]);
                }
            }

            List<string> subjects = new List<string>
        {
            "Math", "Science", "English", "History", "Computer"
        };

            Dictionary<string, int> subjectMap = new Dictionary<string, int>();

            for (int i = 0; i < marks.Count; i++)
            {
                subjectMap[subjects[i]] = marks[i];
            }

            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: " + averageMarks);
            Console.WriteLine("Students above " + threshold + ": " + aboveThreshold.Count);
            Console.WriteLine("Highest Score: " + highestScore);

            Console.WriteLine("\nSubject-wise Marks (Dictionary):");
            foreach (var entry in subjectMap)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
