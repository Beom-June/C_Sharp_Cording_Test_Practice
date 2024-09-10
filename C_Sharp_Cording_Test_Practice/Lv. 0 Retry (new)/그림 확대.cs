using System;
using System.Collections.Generic;

/* Retry
 * 직사각형 형태의 그림 파일이 있고, 이 그림 파일은 1 × 1 크기의 정사각형 크기의 픽셀로 이루어져 있습니다. 
 * 
 * 이 그림 파일을 나타낸 문자열 배열 picture과 정수 k가 매개변수로 주어질 때, 
 * 이 그림 파일을 가로 세로로 k배 늘린 그림 파일을 나타내도록 문자열 배열을 return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] picture, int k)
        {
            List<string> answer = new List<string>();

            // picture 배열을 순회
            foreach (string row in picture)
            {
                string charRow = "";

                // 각 문자를 k번 반복하여 새로운 문자열 생성
                foreach (char _c in row)
                {
                    charRow += new string(_c, k);
                }

                // 새로 생성된 문자열을 k번 반복하여 리스트에 추가
                for (int count = 0; count < k; count++)
                {
                    answer.Add(charRow);
                }
            }

            return answer.ToArray();
        }
    }
    class 그림_확대
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _picture01 = { ".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...." };
            string[] _picture02 = { "x.x", ".x.", "x.x" };

            foreach (var i in _solution.solution(_picture01, 2))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (var i in _solution.solution(_picture01, 3))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
