using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 my_string과 정수 배열 indices가 주어질 때, 
 * my_string에서 indices의 원소에 해당하는 인덱스의 글자를 지우고 
 * 이어 붙인 문자열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string my_string, int[] indices)
        {
            char[] chars = my_string.ToCharArray();
            for (int i = 0; i < indices.Length; i++)
            {
                int sIdx = indices[i];
                chars[sIdx] = ' ';
            }

            return new string(chars).Replace(" ", "");
        }
    }
    class 글자_지우기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string = "apporoograpemmemprs";
            int[] _indices = { 1, 16, 6, 15, 0, 10, 11, 3 };

            Console.WriteLine(_solution.solution(_my_string, _indices));
        }
    }
    */
}
