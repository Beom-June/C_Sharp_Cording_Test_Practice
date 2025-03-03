using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 점심시간에 도둑이 들어, 일부 학생이 체육복을 도난당했습니다. 
 * 다행히 여벌 체육복이 있는 학생이 이들에게 체육복을 빌려주려 합니다. 
 * 학생들의 번호는 체격 순으로 매겨져 있어, 
 * 바로 앞번호의 학생이나 바로 뒷번호의 학생에게만 체육복을 빌려줄 수 있습니다. 
 * 
 * 예를 들어, 4번 학생은 3번 학생이나 5번 학생에게만 체육복을 빌려줄 수 있습니다. 
 * 체육복이 없으면 수업을 들을 수 없기 때문에 체육복을 적절히 빌려 최대한 많은 학생이 체육수업을 들어야 합니다.
 * 
 * 전체 학생의 수 n, 체육복을 도난당한 학생들의 번호가 담긴 배열 lost, 
 * 여벌의 체육복을 가져온 학생들의 번호가 담긴 배열 reserve가 매개변수로 주어질 때, 
 * 체육수업을 들을 수 있는 학생의 최댓값을 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            // HashSet을 사용하여 빠른 탐색 (O(1) 복잡도)
            HashSet<int> _lostSet = new HashSet<int>(lost);
            HashSet<int> _reserveSet = new HashSet<int>(reserve);

            // 중복 제거: 도난당한 학생이 여벌 체육복을 가진 경우 우선 제거
            foreach (int student in lost.ToArray())  // 배열 복사로 GC 최소화
            {
                if (_reserveSet.Contains(student))
                {
                    _lostSet.Remove(student);
                    _reserveSet.Remove(student);
                }
            }

            int answer = n - _lostSet.Count; // 체육복을 가진 학생 수

            // 체육복 빌려주기
            foreach (int student in _lostSet)
            {
                if (_reserveSet.Contains(student - 1)) // 앞번호 학생이 빌려줄 수 있는 경우
                {
                    _reserveSet.Remove(student - 1);
                    answer++;
                }
                else if (_reserveSet.Contains(student + 1)) // 뒷번호 학생이 빌려줄 수 있는 경우
                {
                    _reserveSet.Remove(student + 1);
                    answer++;
                }
            }

            return answer;
        }
    }
    class 체육복
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _lost01 = { 2, 4 };
            int[] _lost02 = { 3 };

            int[] _reserve01 = { 1, 3, 5 };
            int[] _reserve02 = { 3 };
            int[] _reserve03 = { 1 };

            Console.WriteLine(_solution.solution(5, _lost01, _reserve01));        //  5
            Console.WriteLine(_solution.solution(5, _lost01, _reserve02));        //  4
            Console.WriteLine(_solution.solution(3, _lost02, _reserve03));        //  2
        }
    }
    */
}
