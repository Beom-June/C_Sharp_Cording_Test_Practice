using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string과 이차원 정수 배열 queries가 매개변수로 주어집니다. 
 * queries의 원소는 [s, e] 형태로, my_string의 
 * 인덱스 s부터 인덱스 e까지를 뒤집으라는 의미입니다.
 * my_string에 queries의 명령을 순서대로 처리한 후의 
 * 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int[,] queries)
        {
            char[] charArray = my_string.ToCharArray();

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];

                while (start < end)
                {
                    char temp = charArray[start];
                    charArray[start] = charArray[end];
                    charArray[end] = temp;

                    start++;
                    end--;
                }
            }

            return new string(charArray);
        }
    }
    class 문자열_여러_번_뒤집기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "rermgorpsam";
            int[,] _queries = { { 2, 3 }, { 0, 7 }, { 5, 9 }, { 6, 10 } };

            Console.WriteLine(_solution.solution(_my_string, _queries));
        }
    }
    */
}
