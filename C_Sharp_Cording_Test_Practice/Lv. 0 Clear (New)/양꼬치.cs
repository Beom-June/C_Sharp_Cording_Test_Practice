using System;

/* 머쓱이네 양꼬치 가게는 10인분을 먹으면 음료수 하나를 서비스로 줍니다. 
 * 
 * 양꼬치는 1인분에 12,000원, 음료수는 2,000원입니다. 
 * 정수 n과 k가 매개변수로 주어졌을 때, 양꼬치 n인분과 음료수 k개를 먹었다면 
 * 
 * 총얼마를 지불해야 하는지 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        //  n : 양꼬치, k : 음료
        public int solution(int n, int k)
        {
            int answer = 0;
            int _freeDrink = n/10;
            int _paidDrink = k - _freeDrink;

            if (_paidDrink < 0) 
                _paidDrink = 0;

            answer = (n * 12000) + (_paidDrink * 2000);
            return answer;
        }
    }
    class 양꼬치
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(10, 3));
            Console.WriteLine(_solution.solution(64, 6));
        }
    }
    */
}