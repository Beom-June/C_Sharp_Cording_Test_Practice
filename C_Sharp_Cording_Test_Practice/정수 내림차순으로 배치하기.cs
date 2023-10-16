using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 함수 solution은 정수 n을 매개변수로 입력받습니다. 
 * n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 
 * 예를들어 n이 118372면 873211을 리턴하면 됩니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public long solution(long n)
        {
            // 숫자를 문자열로 변환하여 각 자릿수를 배열로 분리하고 큰 순서대로 정렬
            char[] _charArray = n.ToString().ToCharArray();
            Array.Sort(_charArray);
            Array.Reverse(_charArray);

            // 정렬된 문자 배열을 다시 문자열로 합치고 long 형으로 변환하여 반환
            return long.Parse(new string(_charArray));
        }
    }
    class 정수_내림차순으로_배치하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            long _n = 118372;

            Console.WriteLine(_solution.solution(_n));
        }
    }
    */
}
