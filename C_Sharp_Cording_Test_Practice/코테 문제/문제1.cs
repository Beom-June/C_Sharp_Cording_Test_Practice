using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* n 명의 사람들이 나누먹기 위해 반반 피자 상품 주문
 * 
 * 토핑은 m가지 종류가 있음.
 * Ex :  A B C D E 다섯가지 토핑이 있을때 피자의 반쪽에는 A, B / 다른 반쪽에는 A C E 와 같이 토핑을 골라 넣을 수 있음
 * 
 * n명의 사람들은 각각 선호하는 토핑과 불호하는 토핑이 있음. 
 * 피자의 두 부분 중 자신의 토핑 선호도와 일치하는 부분이 있다면 그 사람은 주문에 만족함
 * 
 * 토핑 선호도가 일치한다는 것은 해당 부분에 선호하는 토핑이 모두 포함되어 있으면서 불호하는 토핑이 모두 제외되어 있음을 의미함
 * 
 * -1 : 불호 / 0 : 상관 없음 / 1 : 선호
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 문제1
    {
        public class Solution
        {
            public int solution(int n, int m, int[,] preferences)
            {
                int answer = 0;
                for (int i = 0; i < preferences.Length; i++)
                {

                    for (int j = 0; j < preferences.GetLength(i); j++)
                    {
                        int _half01 = preferences[i, 0];
                        int _half02 = preferences[i, j];

                        if (_half01 != _half02)
                            answer++;
                    }
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _preferences01 = { { 1, 1, 0, 1 - 1 }, { 0, 1, 1, -1 }, { 1, 01, -1, -1 }, { 1, 0, 0, 1 } };
            int[,] _preferences02 = { { 1, 1, 1, 0, 0, }, { 0, 1, 1, 1, 0 }, { 0, 0, 1, 1, 1 }, { -1, -1, -1, -1, 0 }, { 0, -1, -1, -1, -1 } };
            int[,] _preferences03 = { { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } };
            int[,] _preferences04 = { { 0, 1, 1, 0 }, { 1, 1, -1, -1 }, { -1, 0, 1, 1 }, { -1, -1, -1, 1 }, { 1, 1, 0, -1 } };

            Console.WriteLine(_solution.solution(4, 4, _preferences01));      //  3
            Console.WriteLine(_solution.solution(5, 5, _preferences02));      //  5
            Console.WriteLine(_solution.solution(4, 2, _preferences03));      //  2
            Console.WriteLine(_solution.solution(5, 4, _preferences04));      //  4
        }
    }
    */
}
