using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 문자열 my_string이 매개변수로 주어질 때, 
 * my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 
 * return 하도록 solution 함수를 작성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(string my_string)
        {
            List<int> _list = new List<int>();

            for (int i = 0; i < my_string.Length; i++)
            {
                // IsDigit()는 문자열에 10진수가 있으면 true를 반환
                if (char.IsDigit(my_string[i]) == true)
                {
                    _list.Add((int)my_string[i] - 48);
                }
            }
            int[] answer = _list.ToArray();
            Array.Sort(answer);
            return answer;
        }
    }
    class 문자열_정렬하기__1_
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _my_string1 = "hi12392";
            string _my_string2 = "p2o4i8gj2";
            string _my_string3 = "abcde0";

            Console.WriteLine(string.Join(", " ,_solution.solution(_my_string1)));
            Console.WriteLine(string.Join(", " ,_solution.solution(_my_string2)));
            Console.WriteLine(string.Join(", " ,_solution.solution(_my_string3)));
        }
    }
    */
}
