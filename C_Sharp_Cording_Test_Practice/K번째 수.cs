using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.
 * 
 * 예를 들어 array가 [1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면
 * array의 2번째부터 5번째까지 자르면 [5, 2, 6, 3]입니다.
 * 1에서 나온 배열을 정렬하면 [2, 3, 5, 6]입니다.
 * 2에서 나온 배열의 3번째 숫자는 5입니다.
 * 
 * 배열 array, [i, j, k]를 원소로 가진 2차원 배열 commands가 매개변수로 주어질 때, 
 * commands의 모든 원소에 대해 앞서 설명한 연산을 적용했을 때 나온 결과를 배열에 담아 
 * return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLongLength(0)];

            //  i, j 까지 배열 추출
            for (int n = 0; n < commands.GetLongLength(0); n++)
            {
                //  각 i, j, k의 원소를 매 횟수 마다 초기화
                int i = commands[n, 0];
                int j = commands[n, 1];
                int k = commands[n, 2];

                //  i ~ j 까지 자른 배열 선언
                int[] _temp = new int[j - i + 1];
                for (int m = 0; m < _temp.Length; m++)
                {
                    _temp[m] = array[m + i - 1];
                }
                //  배열 정렬
                Array.Sort(_temp);
                //  k 번째 숫자 추출
                answer[n] = _temp[k - 1];
            }
            return answer;
        }
    }
    class K번째_수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] _commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            Console.WriteLine(string.Join(", ", _solution.solution(_array, _commands)));       //  5, 6, 3
        }
    }
}
