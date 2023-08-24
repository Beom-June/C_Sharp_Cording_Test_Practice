using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 문자열 myString이 주어집니다. 
 * myString에서 알파벳 "a"가 등장하면 전부 "A"로 변환하고, 
 * "A"가 아닌 모든 대문자 알파벳은 소문자 알파벳으로 변환하여 
 * return 하는 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string myString)
        {
            char[] array = myString.ToCharArray();
            for (int i = 0; i < myString.Length; i++)
            {
                if (array[i].ToString() == "a" || array[i].ToString() == "A")
                {
                    array[i] = array[i].ToString().ToUpper()[0];
                }
                else
                {
                    array[i] = array[i].ToString().ToLower()[0];
                }
            }
            return new string(array);
        }
    }
    class A_강조하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _myString1 = "abstract algebra";
            string _myString2 = "PrOgRaMmErS";

            Console.WriteLine(_solution.solution(_myString1));
            Console.WriteLine(_solution.solution(_myString2));
        }
    }
    */
}
