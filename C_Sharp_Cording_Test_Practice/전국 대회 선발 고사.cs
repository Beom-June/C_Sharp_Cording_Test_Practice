using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 0번부터 n - 1번까지 n명의 학생 중 3명을 선발하는 전국 대회 선발 고사를 보았습니다. 
 * 등수가 높은 3명을 선발해야 하지만, 개인 사정으로 전국 대회에 참여하지 못하는 학생들이 
 * 있어 참여가 가능한 학생 중 등수가 높은 3명을 선발하기로 했습니다.
 * 
 * 각 학생들의 선발 고사 등수를 담은 정수 배열 rank와 전국 대회 참여 가능 여부가 
 * 담긴 boolean 배열 attendance가 매개변수로 주어집니다. 전국 대회에 선발된 
 * 학생 번호들을 등수가 높은 순서대로 각각 a, b, c번이라고 할 때 
 * 10000 × a + 100 × b + c를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] rank, bool[] attendance)
        {
            int answer = 0;
            int _cnt = 0; // 참여 가능한 등수 높은 3명을 세기 위한 변수

            for (int i = 1; i <= rank.Length; i++)
            {
                int _num = Array.IndexOf(rank, i); // 학생의 번호를 담기 위한 변수

                // 참석 가능한 학생의 번호를 등수대로 맞는 계산 방식을 적용하여 답안을 구한다.
                if (attendance[_num])
                {
                    answer += _num * (int)Math.Pow(100, 2 - _cnt);
                    _cnt++;

                    if (_cnt == 3)
                        break;
                }
            }
            return answer;
        }
    }
    class 전국_대회_선발_고사
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            // 테스트 케이스
            int[] rank1 = { 3, 7, 2, 5, 4, 6, 1 };
            bool[] attendance1 = { false, true, true, true, true, false, false };
            int result1 = _solution.solution(rank1, attendance1);
            Console.WriteLine(result1); // 출력 결과: 20403

            int[] rank2 = { 1, 2, 3 };
            bool[] attendance2 = { true, true, true };
            int result2 = _solution.solution(rank2, attendance2);
            Console.WriteLine(result2); // 출력 결과: 102

            int[] rank3 = { 6, 1, 5, 2, 3, 4 };
            bool[] attendance3 = { true, false, true, false, false, true };
            int result3 = _solution.solution(rank3, attendance3);
            Console.WriteLine(result3); // 출력 결과: 50200
        }
    }
    */
}
