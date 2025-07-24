using System;
using System.Collections.Generic;

/* Retry
 * 0번부터 n - 1번까지 n명의 학생 중 3명을 선발하는 전국 대회 선발 고사를 보았습니다. 
 * 등수가 높은 3명을 선발해야 하지만, 개인 사정으로 전국 대회에 참여하지 못하는 학생들이 있어 
 * 참여가 가능한 학생 중 등수가 높은 3명을 선발하기로 했습니다.
 * 
 * 각 학생들의 선발 고사 등수를 담은 정수 배열 rank와 전국 대회 참여 가능 여부가 
 * 담긴 boolean 배열 attendance가 매개변수로 주어집니다. 
 * 전국 대회에 선발된 학생 번호들을 등수가 높은 순서대로 각각 a, b, c번이라고 할 때 
 * 10000 × a + 100 × b + c를 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] rank, bool[] attendance)
        {
            List<(int rank, int index)> _validStudents = new List<(int, int)>();

            // 참여 가능한 학생들만 리스트에 넣음 (등수, 학생 번호)
            for (int i = 0; i < rank.Length; i++)
            {
                if (attendance[i])
                {
                    _validStudents.Add((rank[i], i));
                }
            }

            // 등수를 기준으로 오름차순 정렬
            _validStudents.Sort((a, b) => a.rank.CompareTo(b.rank));

            // 상위 3명의 학생 번호 추출
            int _a = _validStudents[0].index;
            int _b = _validStudents[1].index;
            int _c = _validStudents[2].index;

            // 공식에 따라 결과 계산
            return 10000 * _a + 100 * _b + _c;
        }
    }
    class 전국_대회_선발_고사
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _rank01 = { 3, 7, 2, 5, 4, 6, 1 };
            int[] _rank02 = { 1, 2, 3 };
            int[] _rank03 = { 6, 1, 5, 2, 3, 4 };

            bool[] _attendance01 = { false, true, true, true, true, false, false };
            bool[] _attendance02 = { true, true, true };
            bool[] _attendance03 = { true, false, true, false, false, true };

            Console.WriteLine(_solution.solution(_rank01, _attendance01));      //  20403
            Console.WriteLine(_solution.solution(_rank02, _attendance02));      //  102
            Console.WriteLine(_solution.solution(_rank03, _attendance03));      //  50200
        }
    }
    */
}
