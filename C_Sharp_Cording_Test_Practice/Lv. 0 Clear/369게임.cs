﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 머쓱이는 친구들과 369게임을 하고 있습니다. 
 * 369게임은 1부터 숫자를 하나씩 대며 3, 6, 9가 들어가는 
 * 숫자는 숫자 대신 3, 6, 9의 개수만큼 박수를 치는 게임입니다. 
 * 머쓱이가 말해야하는 숫자 order가 매개변수로 주어질 때, 
 * 머쓱이가 쳐야할 박수 횟수를 return 하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int order)
        {
            int answer = 0;

            for (; order > 0; order /= 10)
            {
                if ((order % 10) % 3 == 0 && order % 10 != 0)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
    class _369게임
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int _order1 = 3;
            int _order2 = 29423;

            Console.WriteLine(_solution.solution(_order1));
            Console.WriteLine(_solution.solution(_order2));
        }
    }
    */
}
