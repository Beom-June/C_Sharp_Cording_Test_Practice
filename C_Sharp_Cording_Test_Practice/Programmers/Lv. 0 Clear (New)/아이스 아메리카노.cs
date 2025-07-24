using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 머쓱이는 추운 날에도 아이스 아메리카노만 마십니다. 
 * 아이스 아메리카노는 한잔에 5,500원입니다. 
 * 
 * 머쓱이가 가지고 있는 돈 money가 매개변수로 주어질 때, 
 * 머쓱이가 최대로 마실 수 있는 아메리카노의 잔 수와 남는 돈을 
 * 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int money)
        {
            int _coffee = 5500;     //  커피 값
            int _numCoffee = money / _coffee;
            int _extra = money % _coffee;
            int[] answer = new int[] { _numCoffee, _extra };

            return answer;
        }
    }
    class 아이스_아메리카노
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(String.Join(", ", _solution.solution(5500)));
            Console.WriteLine(String.Join(", ", _solution.solution(15000)));
        }
    }
    */
}
