using System;

/* 머쓱이는 직육면체 모양의 상자를 하나 가지고 있는데 
 * 이 상자에 정육면체 모양의 주사위를 최대한 많이 채우고 싶습니다. 
 * 
 * 상자의 가로, 세로, 높이가 저장되어있는 배열 box와 주사위 
 * 모서리의 길이 정수 n이 매개변수로 주어졌을 때, 
 * 상자에 들어갈 수 있는 주사위의 최대 개수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        //  box[가로, 세로, 높이]
        public int solution(int[] box, int n)
        {
            int answer = 0;

            int _width = box[0] / n;
            int _height = box[1] / n;
            int _depth = box[2] / n;

            answer = _width * _height * _depth;

            return answer;
        }
    }
    class 주사위_개수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _box01 = { 1, 1, 1 };
            int[] _box02 = { 10, 8, 6 };

            Console.WriteLine(_solution.solution(_box01, 1));
            Console.WriteLine(_solution.solution(_box02, 3));
        }
    }
    */
}