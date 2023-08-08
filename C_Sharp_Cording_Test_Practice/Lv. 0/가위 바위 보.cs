using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 가위는 2 바위는 0 보는 5로 표현합니다. 
 * 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, 
 * rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 
 * 문자열을 return하도록 solution 함수를 완성해보세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string rsp)
        {
            // 가위 : 2, 바위 : 0, 보 5
            string answer = "";
            for (int i = 0; i < rsp.Length; i++)
            {
                char _ch = rsp[i];
                switch (_ch)
                {
                    case '2': 
                        answer += "0";
                        break;
                    case '0': 
                        answer += "5";
                        break;
                    case '5':
                        answer += "2";
                        break;
                    default:
                        break;
                }
            }
            return answer;
        }
    }
    class 가위_바위_보
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            // 입력부
            string _rsp1 = "2";
            string _rsp2 = "205";

            // 출력부
            Console.WriteLine(_rsp1 + " " + _solution.solution(_rsp1));
            Console.WriteLine(_rsp2 + " " + _solution.solution(_rsp2));
        }
    }
    */
}
