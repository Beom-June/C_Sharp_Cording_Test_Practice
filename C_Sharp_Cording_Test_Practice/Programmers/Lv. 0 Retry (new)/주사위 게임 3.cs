using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 1부터 6까지 숫자가 적힌 주사위가 네 개 있습니다. 네 주사위를 굴렸을 때 나온 숫자에 따라 다음과 같은 점수를 얻습니다.
 * 
 * 네 주사위에서 나온 숫자가 모두 p로 같다면 1111 × p점을 얻습니다.
 * 세 주사위에서 나온 숫자가 p로 같고 나머지 다른 주사위에서 나온 숫자가 q(p ≠ q)라면 (10 × p + q)^2 점을 얻습니다.
 * 주사위가 두 개씩 같은 값이 나오고, 나온 숫자를 각각 p, q(p ≠ q)라고 한다면 (p + q) × |p - q|점을 얻습니다.
 * 어느 두 주사위에서 나온 숫자가 p로 같고 나머지 두 주사위에서 나온 숫자가 각각 p와 다른 q, r(q ≠ r)이라면 q × r점을 얻습니다.
 * 네 주사위에 적힌 숫자가 모두 다르다면 나온 숫자 중 가장 작은 숫자 만큼의 점수를 얻습니다.
 * 
 * 네 주사위를 굴렸을 때 나온 숫자가 정수 매개변수 a, b, c, d로 주어질 때, 
 * 얻는 점수를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int a, int b, int c, int d)
        {
            int answer = 0;

            List<int> _inputList = new List<int>() { a, b, c, d };
            List<int> _countList = _inputList.Distinct().ToList();

            switch (_countList.Count)
            {
                //  모두 p로 같다면 1111 * p
                case 1:
                    answer = a * 1111;
                    break;
                //  세 숫자 p로 같고, q가 다르면 (10 * p + q)^2
                case 2:
                    int _p2 = _countList[0];
                    int _q2 = _countList[1];

                    int _pCount = _inputList.Where(n => n == _p2).Count();

                    if (_pCount == 3)
                        answer = (10 * _p2 + _q2) * (10 * _p2 + _q2);
                    else if (_pCount == 2)
                        answer = (_p2 + _q2) * Math.Abs(_p2 - _q2);
                    else
                        answer = (10 * _q2 + _p2) * (10 * _q2 + _p2);
                    break;
                //  두 개씩 같은 값, 나온 숫자를 각각 p, q라고 하면, (p + q) * |p - q|
                case 3:
                    List<int> _duplication = _inputList.GroupBy(x => x).Where(n => n.Count() > 1)
                                        .Select(x => x.Key).ToList();
                    int _p3 = _duplication[0];

                    _countList.Remove(_p3);
                    int _q3 = _countList[0];
                    int _r3 = _countList[1];

                    answer = _q3 * _r3;
                    break;
                //  모두 다르면 가장 작은 숫자
                case 4:
                    answer = _inputList.Min();
                    break;
            }
            return answer;
        }
    }
    class 주사위_게임_3
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(2, 2, 2, 2));      //  2222
            Console.WriteLine(_solution.solution(4, 1, 4, 1));      //  1681
            Console.WriteLine(_solution.solution(6, 3, 3, 6));      //  27
            Console.WriteLine(_solution.solution(2, 5, 2, 6));      //  30
            Console.WriteLine(_solution.solution(6, 4, 2, 5));      //  2
        }
    }
    */
}