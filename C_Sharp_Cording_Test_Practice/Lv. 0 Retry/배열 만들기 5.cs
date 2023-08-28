using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 배열 intStrs와 정수 k, s, l가 주어집니다. 
 * intStrs의 원소는 숫자로 이루어져 있습니다.
 * 
 * 배열 intStrs의 각 원소마다 s번 인덱스에서 시작하는 길이 l짜리 부분 문자열을 
 * 잘라내 정수로 변환합니다. 
 * 이때 변환한 정수값이 k보다 큰 값들을 담은 배열을 return 하는 
 * solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string[] intStrs, int k, int s, int l)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < intStrs.Length; i++)
            {
                int target = Convert.ToInt32(intStrs[i].Substring(s, l));

                if (k < target)
                    answer.Add(target);
            }

            return answer.ToArray();
        }
    }
    class 배열_만들기_5
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _intStrs = { "0123456789", "9876543210", "9999999999999" };
            int _k = 50000;
            int _s = 5;
            int _l = 5;

            foreach (var _out in _solution.solution(_intStrs, _k, _s, _l))
            {
                Console.Write(_out + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
