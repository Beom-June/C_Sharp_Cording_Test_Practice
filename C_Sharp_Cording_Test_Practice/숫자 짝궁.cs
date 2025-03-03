using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 정수 X, Y의 임의의 자리에서 공통으로 나타나는 정수 k(0 ≤ k ≤ 9)들을 이용하여 
 * 만들 수 있는 가장 큰 정수를 두 수의 짝꿍이라 합니다(단, 공통으로 나타나는 정수 중 
 * 서로 짝지을 수 있는 숫자만 사용합니다). X, Y의 짝꿍이 존재하지 않으면, 짝꿍은 -1입니다. 
 * 
 * X, Y의 짝꿍이 0으로만 구성되어 있다면, 짝꿍은 0입니다.
 * 
 * 예를 들어, X = 3403이고 Y = 13203이라면, X와 Y의 짝꿍은 
 * X와 Y에서 공통으로 나타나는 3, 0, 3으로 만들 수 있는 가장 큰 정수인 330입니다. 
 * 
 * 다른 예시로 X = 5525이고 Y = 1255이면 X와 Y의 짝꿍은 
 * X와 Y에서 공통으로 나타나는 2, 5, 5로 만들 수 있는 가장 큰 정수인 552입니다
 * (X에는 5가 3개, Y에는 5가 2개 나타나므로 남는 5 한 개는 짝 지을 수 없습니다.
 * 
 * 두 정수 X, Y가 주어졌을 때, X, Y의 짝꿍을 return하는 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public string solution(string X, string Y)
        {
            string answer = "";
            int _x = int.Parse(X);
            int _y = int.Parse(Y);

            List<int> _listX = new List<int>();
            List<int> _listY = new List<int>();

            foreach (var i in X)
            {
            }

            return answer;
        }
    }
    class 숫자_짝궁
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _x01 = "100";
            string _x02 = "12321";
            string _x03 = "5525";

            string _y01 = "2345";
            string _y02 = "203045";
            string _y03 = "123450";
            string _y04 = "42531";
            string _y05 = "1255";

            Console.WriteLine(_solution.solution(_x01, _y01));      //  "-1"
            Console.WriteLine(_solution.solution(_x01, _y02));      //  "0"
            Console.WriteLine(_solution.solution(_x01, _y03));      //  "10"
            Console.WriteLine(_solution.solution(_x02, _y04));      //  "321"
            Console.WriteLine(_solution.solution(_x03, _y05));      //  "552"
        }
    }
}