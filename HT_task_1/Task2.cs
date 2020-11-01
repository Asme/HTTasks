using System;
using System.Collections.Generic;
using System.Linq;

namespace HT_task_1
{
    class Task2
    {
        private int[] Numbers = { 1, 9, 4, 6, 8, 10, 7, 44, 22, 6, 2, 1, 3, 7, 2, 3, 4, 5, 7, 6, 4, 3, 2, 1, 8, 9, 11, 22, 33, 45, 5, 10, 3, 2 };

        private int EvenNumbers()
        {
            int EvenNumbers = 0;

            foreach (var i in Numbers)                                  
            {
                if (i%2 == 0)                                                                                   // Decides if a number is even if its divisible by 2.
                {
                    EvenNumbers += 1;                                   
                }
            }

            return EvenNumbers; 
        }

        private void NumberFrequency(Dictionary<int, int> FrequencyDictionary)
        {
            for (int i = 0; i < Numbers.Length; i++)                                                            // Goes through the array.
            {
                if (FrequencyDictionary.ContainsKey(Numbers[i]))                                                // If the number is already in the dictionary, add a
                {
                    var value = FrequencyDictionary[Numbers[i]];
                    FrequencyDictionary.Remove(Numbers[i]);
                    FrequencyDictionary.Add(Numbers[i], value + 1);
                }
                else
                {
                    FrequencyDictionary.Add(Numbers[i], 1);                                                    // If the number isn't in the dictioanry already, add it and set its value to 1.
                }
            }
        }

        public void IterateArray()
        {
            int Sum;
            double Avg;
            int EvenNumbersAmount;
            int OddNumbersAmount;

            Sum = Numbers.Sum();                                                                                // Finds the sum of all the numbers in the array
            Console.WriteLine("Sum: " + Sum);

            Avg = Numbers.Average();                                                                            // Finds the average of all the numbers in the array
            Console.WriteLine("Average: " + Avg);

            EvenNumbersAmount = EvenNumbers();                                                           // Finds amount of even numbers in the array
            Console.WriteLine("Amount of Even Numbers: " + EvenNumbersAmount);

            OddNumbersAmount = Numbers.Length - EvenNumbersAmount;                                              // Finds amount of odd numbers in the array
            Console.WriteLine("Amount of Odd Numbers: " + OddNumbersAmount);

            Dictionary<int, int> FrequencyDictionary = new Dictionary<int, int>();
            NumberFrequency(FrequencyDictionary);                                                      // calculates frequency of each number
            for (int i = 0; i < FrequencyDictionary.Count; i++)                                                 // prints the frequency of each number to console.
            {
                Console.WriteLine("Number: {0}, Frequency: {1}", FrequencyDictionary.ElementAt(i).Key, FrequencyDictionary.ElementAt(i).Value);
            }
        }

    }
}
