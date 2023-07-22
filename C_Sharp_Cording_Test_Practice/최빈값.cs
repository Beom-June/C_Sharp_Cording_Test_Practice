using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] array)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // 배열의 원소를 순회하며 등장 횟수를 세어줍니다.
            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int maxFrequency = 0;
            int mostFrequentNumber = -1;

            // 등장 횟수가 가장 많은 값을 찾습니다.
            foreach (var kvp in frequencyMap)
            {
                int number = kvp.Key;
                int frequency = kvp.Value;

                if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                    mostFrequentNumber = number;
                }
                else if (frequency == maxFrequency)
                {
                    // 최빈값이 여러 개면 -1을 반환합니다.
                    mostFrequentNumber = -1;
                }
            }

            return mostFrequentNumber;
        }
    }
    class 최빈값
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] numbers1 = { 1, 2, 3, 3, 3, 4 };
            int[] numbers2 = { 1, 1, 2, 2 };

            Console.WriteLine("Test 1 : " + solution.solution(numbers1));
            Console.WriteLine("Test 2 : " + solution.solution(numbers2));
        }
    }
    */
}
