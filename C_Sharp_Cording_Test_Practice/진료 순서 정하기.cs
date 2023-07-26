using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 외과의사 머쓱이는 응급실에 온 환자의 응급도를 기준으로 진료 순서를 정하려고 합니다. 
 * 정수 배열 emergency가 매개변수로 주어질 때 응급도가 높은 순서대로 
 * 진료 순서를 정한 배열을 return하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
public class Solution
{
    public int[] solution(int[] emergency)
    {
        int[] answer = new int[emergency.Length];
        for (int i = 0; i < emergency.Length; i++)
        {
            for (int j = 0; j < emergency.Length; j++)
            {
                if (emergency[i] <= emergency[j])
                {
                    answer[i]++;
                }
            }
        }
        return answer;
    }
}
class 진료_순서_정하기
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        int[] _emergency = { 3, 76, 24 };

        int[] result = _solution.solution(_emergency);

        Console.WriteLine("Result:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
    */
}
