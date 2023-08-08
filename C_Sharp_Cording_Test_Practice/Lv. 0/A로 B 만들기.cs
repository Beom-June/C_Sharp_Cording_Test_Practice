using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 before와 after가 매개변수로 주어질 때, 
 * before의 순서를 바꾸어 after를 만들 수 있으면 1을, 
 * 만들 수 없으면 0을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string before, string after)
        {
            int answer = 0;

            // 두개를 순서대로 만들고
            char[] _arrayBefore = before.ToCharArray();
            char[] _arrayafter = after.ToCharArray();

            // 집어 넣고
            Array.Sort(_arrayBefore);
            Array.Sort(_arrayafter);

            // 두개를 비교
            if (_arrayafter.SequenceEqual(_arrayBefore))
            {
                // 맞으면 return 1
                answer = 1;
            }
            else
            {
                // 아니면 0
                answer = 0;
            }
            return answer;
        }
    }
    class A로_B_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _before1 = "olleh";
            string _before2 = "allpe";

            string _after1 = "hello";
            string _after2 = "apple";

            Console.WriteLine(_solution.solution(_before1, _after1));
            Console.WriteLine(_solution.solution(_before2, _after2));
        }
    }
    */
}
