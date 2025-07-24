using System;

/* Retry
 * 두 정수 X, Y의 임의의 자리에서 공통으로 나타나는 정수 k(0 ≤ k ≤ 9)들을 이용하여 
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
    /*
    public class Solution
    {
        public string solution(string X, string Y)
        {
            string answer = "";

            //  각 숫자(0~9)에 대한 등장 횟수를 저장할 배열
            int[] _xCount = new int[10];
            int[] _yCount = new int[10];

            // X 문자열을 순회하면서 각 숫자의 등장 횟수를 countX에 저장
            foreach (var i in X)
            {
                _xCount[i - '0']++;
            }

            // Y 문자열을 순회하면서 각 숫자의 등장 횟수를 countY에 저장
            foreach (var i in Y)
            {
                _yCount[i - '0']++;
            }

            // 9부터 0까지 숫자를 내려가며 확인
            // 두 수에 공통으로 존재하는 숫자가 있다면,
            // 최소 등장 횟수만큼 해당 숫자를 answer에 추가
            for (int i = 9; i >= 0; i--)
            {
                // X와 Y에서 공통으로 등장하는 횟수만큼 반복
                int common = Math.Min(_xCount[i], _yCount[i]);

                // 해당 숫자를 공통 개수만큼 answer에 반복 추가
                answer += new string((char)(i + '0'), common);
            }

            // 이때 큰 숫자부터 추가해야 내림차순 정렬이 된다

            // 공통 숫자가 없다면 answer는 빈 문자열이므로 "-1"을 리턴
            if(answer == "")
            {
                return "-1";
            }

            // answer가 모두 0으로만 구성되어 있다면 "0"을 리턴
            if (answer[0] =='0')
            {
                return "0";
            }

            // 그 외에는 완성된 answer를 그대로 리턴
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
    */
}