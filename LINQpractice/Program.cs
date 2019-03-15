using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    class Word
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            ////var words = new ;
            //var thWords = words.Where(m => m.Contains("th"));


            //foreach(var word in thWords)
            //{
            //    Console.WriteLine(word);

            //}

            //Console.ReadKey();


            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            //var newNames = names.Distinct();

            //foreach(var name in newNames)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadKey();

            
            
                List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

                for (int i = 0; i <= classGrades.Count - 1; i++)
                {
                    List<int> splitGrades = classGrades[i].Split(',').Select(int.Parse).ToList();
                    IEnumerable<int> topFourGrades = splitGrades.OrderByDescending(grade => grade).Take(4);
                    double firstAverage = topFourGrades.Average();
                    classGrades[i] = firstAverage.ToString();
                }

            //double finalAverage = classGrades.Average();
            

            

            

        }
    }
}
