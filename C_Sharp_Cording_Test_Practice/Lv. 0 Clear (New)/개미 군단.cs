using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 개미 군단이 사냥을 나가려고 합니다. 
 * 개미군단은 사냥감의 체력에 딱 맞는 병력을 데리고 나가려고 합니다. 
 * 
 * 장군개미는 5의 공격력을, 병정개미는 3의 공격력을 일개미는 1의 공격력을 가지고 있습니다. 
 * 예를 들어 체력 23의 여치를 사냥하려고 할 때, 일개미 23마리를 데리고 가도 되지만, 
 * 장군개미 네 마리와 병정개미 한 마리를 데리고 간다면 더 적은 병력으로 사냥할 수 있습니다. 
 * 
 * 사냥감의 체력 hp가 매개변수로 주어질 때, 
 * 사냥감의 체력에 딱 맞게 최소한의 병력을 구성하려면 몇 마리의 개미가 필요한지를 
 * return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int hp)
        {
            int _Ant5 = 5;
            int _Ant3 = 3;
            int _Ant1 = 1;

            int answer = 0;

            // 장군개미 사용
            answer += hp / _Ant5;
            hp %= _Ant5;

            // 병정개미 사용
            answer += hp / _Ant3;
            hp %= _Ant3;

            // 일개미 사용
            answer += hp / _Ant1;
            hp %= _Ant1;

            return answer;
        }
    }
    class 개미_군단
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(23));      //  5
            Console.WriteLine(_solution.solution(24));      //  6
            Console.WriteLine(_solution.solution(999));     //  201
        }
    }
    */
}