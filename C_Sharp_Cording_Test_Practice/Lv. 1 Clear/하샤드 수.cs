using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 양의 정수 x가 하샤드 수이려면 x의 자릿수의 합으로 x가 나누어져야 합니다. 
 * 예를 들어 18의 자릿수 합은 1+8=9이고, 18은 9로 나누어 떨어지므로 18은 하샤드 수입니다. 
 * 자연수 x를 입력받아 x가 하샤드 수인지 아닌지 검사하는 함수, solution을 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    //public class Solution
    //{
    //    public bool solution(int x)
    //    {
    //        bool answer = false;
    //        int _X = x;
    //        int _sum = 0;

    //        do
    //        {
    //            _sum += x % 10;
    //            x /= 10;
    //        } while (x > 0);

    //        if(_X % _sum == 0)
    //        {
    //            answer = true;
    //        }
    //        return answer;
    //    }
    //}
    //class 하샤드_수
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution _solution = new Solution();

    //        int x1 = 10, x2 = 12, x3 = 11, x4 = 13;
    //        Console.WriteLine(_solution.solution(x1));
    //        Console.WriteLine(_solution.solution(x2));
    //        Console.WriteLine(_solution.solution(x3));
    //        Console.WriteLine(_solution.solution(x4));
    //    }
    //}
}
