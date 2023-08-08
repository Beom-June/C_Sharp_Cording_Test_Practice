using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 우주여행을 하던 머쓱이는 엔진 고장으로 PROGRAMMERS-962 행성에 불시착하게 됐습니다. 
 * 입국심사에서 나이를 말해야 하는데, PROGRAMMERS-962 행성에서는 나이를 알파벳으로 말하고 있습니다. 
 * a는 0, b는 1, c는 2, ..., j는 9입니다. 예를 들어 23살은 cd, 51살은 fb로 표현합니다. 
 * 나이 age가 매개변수로 주어질 때 PROGRAMMER-962식 나이를 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(int age)
        {
            string answer = "";

            while (age != 0)
            {
                answer = (char)(age % 10 + 97) + answer;
                age /= 10;
            }
            return answer;
        }
    }
    class 외계행성의_나이
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _age = 23;
            Console.WriteLine(_age + " " + _solution.solution(_age));
        }
    }
    */
}
