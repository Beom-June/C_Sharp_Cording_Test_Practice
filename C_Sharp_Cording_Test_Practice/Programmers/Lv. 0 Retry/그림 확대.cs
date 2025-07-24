using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 직사각형 형태의 그림 파일이 있고, 이 그림 파일은 1 × 1 크기의 
 * 정사각형 크기의 픽셀로 이루어져 있습니다. 
 * 
 * 이 그림 파일을 나타낸 문자열 배열 picture과 정수 k가 매개변수로 주어질 때, 
 * 이 그림 파일을 가로 세로로 k배 늘린 그림 파일을 나타내도록 문자열 배열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string[] solution(string[] picture, int k)
        {
            int _height = picture.Length;
            int _width = picture[0].Length;

            List<string> _answer = new List<string>();

            for (int i = 0; i < _height; i++)
            {
                for (int row = 0; row < k; row++)
                {
                    string newRow = "";
                    for (int j = 0; j < _width; j++)
                    {
                        for (int col = 0; col < k; col++)
                        {
                            newRow += picture[i][j];
                        }
                    }
                    _answer.Add(newRow);
                }
            }

            return _answer.ToArray();
        }
    }
    class 그림_확대
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _picture1 = { ".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...." };
            string[] _picture2 = { "x.x", ".x.", "x.x" };

            int _k1 = 2, _k2 = 3;

            foreach (var _result in _solution.solution(_picture1, _k1))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();

            foreach (var _result in _solution.solution(_picture2, _k2))
            {
                Console.Write(_result + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
