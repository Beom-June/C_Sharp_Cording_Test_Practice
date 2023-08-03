using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 머쓱이는 프로그래머스에 로그인하려고 합니다. 
 * 머쓱이가 입력한 아이디와 패스워드가 담긴 배열 id_pw와 회원들의 
 * 정보가 담긴 2차원 배열 db가 주어질 때, 다음과 같이 로그인 성공, 
 * 실패에 따른 메시지를 return하도록 solution 함수를 완성해주세요.
 * 아이디와 비밀번호가 모두 일치하는 회원정보가 있으면 "login"을 return합니다.
 * 로그인이 실패했을 때 아이디가 일치하는 회원이 없다면 “fail”를, 
 * 아이디는 일치하지만 비밀번호가 일치하는 회원이 없다면 “wrong pw”를 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string[] id_pw, string[,] db)
        {
            string answer = "";

            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (id_pw[0] == db[i, 0])
                {
                    if (id_pw[1] == db[i, 1])
                    {
                        answer = "login";
                    }
                    else
                    {
                        answer = "wrong pw";
                    }
                    break;
                }
                else
                {
                    answer = "fail";
                }
            }
            return answer;
        }
    }
    class 로그인_성공
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _id_pw1 = { "meosseugi", "1234" };
            string[] _id_pw2 = { "programmer01", "15789" };
            string[] _id_pw3 = { "rabbit04", "98761" };

            string[,] _db1 = { { "rardss", "123" }, { "yyoom", "1234" }, { "meosseugi", "1234" } };
            string[,] _db2 = { { "programmer02", "111111" }, { "programmer00", "134" }, { "programmer01", "1145" } };
            string[,] _db3 = { { "jaja11", "98761" }, { "krong0313", "29440" }, { "rabbit00", "111333" } };

            Console.WriteLine(_solution.solution(_id_pw1, _db1));        //  login
            Console.WriteLine(_solution.solution(_id_pw2, _db2));        //  wrong pw
            Console.WriteLine(_solution.solution(_id_pw3, _db3));        //  fail
        }
    }
    */
}
