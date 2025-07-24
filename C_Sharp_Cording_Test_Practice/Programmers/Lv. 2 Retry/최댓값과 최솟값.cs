using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 문자열 s에는 공백으로 구분된 숫자들이 저장되어 있습니다. 
 * str에 나타나는 숫자 중 최소값과 최대값을 찾아 이를 
 * "(최소값) (최대값)"형태의 문자열을 반환하는 함수, solution을 완성하세요.
 * 
 * 예를들어 s가 "1 2 3 4"라면 "1 4"를 리턴하고, "-1 -2 -3 -4"라면 "-4 -1"을 리턴하면 됩니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            int[] _arr = s.Split(' ').Select(int.Parse).ToArray();
            answer = _arr.Min().ToString() + " " + _arr.Max().ToString();
            return answer;
        }
    }
    class 최댓값과_최솟값
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            string _s1 = "1 2 3 4";
            string _s2 = "-1 -2 -3 -4";
            string _s3 = "-1 -1";

            Console.WriteLine(_solution.solution(_s1));     //  1 4
            Console.WriteLine(_solution.solution(_s2));     //  -4 -1
            Console.WriteLine(_solution.solution(_s3));     //  -1 -1
        }
    }
    */
}