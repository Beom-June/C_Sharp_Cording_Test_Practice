using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 문자열 s는 한 개 이상의 단어로 구성되어 있습니다. 
 * 각 단어는 하나 이상의 공백문자로 구분되어 있습니다. 
 * 각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수, 
 * solution을 완성하세요.
 * 
 * 제한 사항
 * 문자열 전체의 짝/홀수 인덱스가 아니라, 단어(공백을 기준)별로 짝/홀수 인덱스를 판단해야합니다.
 * 첫 번째 글자는 0번째 인덱스로 보아 짝수번째 알파벳으로 처리해야 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            string[] _temp = s.Split();             //  문자열 저장하는 배열

            //  호출
            for (int i = 0; i < _temp.Length; i++)
            {
                //  하나 씩 꺼냄
                for (int j = 0; j < _temp[i].Length; j++)
                {
                    // 0번째는 짝수 취급이므로 대문자로함
                    if (j == 0)
                    {
                        answer += Char.ToUpper(_temp[i][j]);
                        continue;
                    }
                    // 짝수는 대문자로, 홀수는 소문자로 바꿈
                    if (j % 2 == 0)
                    {
                        answer += Char.ToUpper(_temp[i][j]);
                    }
                    else
                    {
                        answer += Char.ToLower(_temp[i][j]);
                    }
                }
                // 띄어쓰기가 전부 생략되어있으므로 문자열이 하나 끝날때마다 띄어쓰기를 넣어줌.
                // 단, 마지막에는 띄어쓰기를 추가하면 안되므로 temp.Leght-1로 설정해준다.
                if (i != _temp.Length - 1)
                {
                    answer += " ";
                }
            }
            return answer;
        }
    }
    class 이상한_문자_만들기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution("try hello world"));   //  TrY HeLlO WoRlD
        }
    }
    */
}
