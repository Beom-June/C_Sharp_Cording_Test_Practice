using System;
using System.Collections.Generic;

/* Retry
 * 햄버거 가게에서 일을 하는 상수는 햄버거를 포장하는 일을 합니다. 
 * 함께 일을 하는 다른 직원들이 햄버거에 들어갈 재료를 조리해 주면 조리된 순서대로 상수의 앞에 아래서부터 위로 쌓이게 되고,
 * 상수는 순서에 맞게 쌓여서 완성된 햄버거를 따로 옮겨 포장을 하게 됩니다. 
 * 상수가 일하는 가게는 정해진 순서(아래서부터, 빵 – 야채 – 고기 - 빵)로 쌓인 햄버거만 포장을 합니다. 
 * 상수는 손이 굉장히 빠르기 때문에 상수가 포장하는 동안 속 재료가 추가적으로 들어오는 일은 없으며, 
 * 재료의 높이는 무시하여 재료가 높이 쌓여서 일이 힘들어지는 경우는 없습니다.
 * 
 * 예를 들어, 상수의 앞에 쌓이는 재료의 순서가 [야채, 빵, 빵, 야채, 고기, 빵, 야채, 고기, 빵]일 때, 
 * 상수는 여섯 번째 재료가 쌓였을 때, 세 번째 재료부터 여섯 번째 재료를 이용하여 햄버거를 포장하고, 
 * 아홉 번째 재료가 쌓였을 때, 두 번째 재료와 일곱 번째 재료부터 아홉 번째 재료를 이용하여 햄버거를 포장합니다. 
 * 즉, 2개의 햄버거를 포장하게 됩니다.
 * 
 * 상수에게 전해지는 재료의 정보를 나타내는 정수 배열 ingredient가 주어졌을 때, 상수가 포장하는 햄버거의 개수를 
 * return 하도록 solution 함수를 완성하시오.
 * 
 * 1 : 빵, 2 : 야채, 3: 고기
 * 즉, 1 2 3 1 이 되어야 햄버거 포장 가능
 */
namespace C_Sharp_Cording_Test_Practice
{

    /*
    public class Solution
    {
        public int solution(int[] ingredient)
        {
            int answer = 0;
            List<int> _wrap = new List<int>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                _wrap.Add(ingredient[i]); // 재료 추가

                // 리스트에 최소 4개 이상 쌓였을 때 햄버거 패턴이 있는지 확인
                if (_wrap.Count >= 4)
                {
                    int _last = _wrap.Count - 1;

                    // 가장 최근 4개의 원소가 1 2 3 1인지 검사
                    if (_wrap[_last - 3] == 1 && _wrap[_last - 2] == 2 && _wrap[_last - 1] == 3 && _wrap[_last] == 1)
                    {
                        // 햄버거 포장 → 리스트에서 제거
                        _wrap.RemoveRange(_last - 3, 4);
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
    class 햄버거_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _ingredient01 = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };
            int[] _ingredient02 = { 1, 3, 2, 1, 2, 1, 3, 1, 2 };

            Console.WriteLine(_solution.solution(_ingredient01));       //  2
            Console.WriteLine(_solution.solution(_ingredient02));       //  0
        }
    }
    */
}