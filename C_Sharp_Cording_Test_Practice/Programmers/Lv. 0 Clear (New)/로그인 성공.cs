using System;

/* 머쓱이는 프로그래머스에 로그인하려고 합니다. 
 * 머쓱이가 입력한 아이디와 패스워드가 담긴 배열 id_pw와 회원들의 정보가 담긴 2차원 배열 db가 주어질 때, 
 * 다음과 같이 로그인 성공, 실패에 따른 메시지를 return하도록 solution 함수를 완성해주세요.
 * 
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
            string answer = "fail"; // 기본값으로 "fail" 설정
            string _id = id_pw[0];
            string _pw = id_pw[1];

            for (int i = 0; i < db.GetLength(0); i++)
            {
                // 아이디가 일치하는 경우
                if (db[i, 0] == _id)
                {
                    // 비밀번호까지 일치하면
                    if (db[i, 1] == _pw)
                    {
                        return "login"; // 로그인 성공
                    }
                    // 아이디는 일치하지만 비밀번호가 다름
                    else
                    {
                        return "wrong pw";
                    }
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

            string[] _idpw01 = { "meosseugi", "1234" };
            string[] _idpw02 = { "programmer01", "15789" };
            string[] _idpw03 = { "rabbit04", "98761" };

            string[,] _db01 = { { "rardss", "123" }, { "yyoom", "1234" }, { "meosseugi", "1234" } };
            string[,] _db02 = { { "programmer02", "111111" }, { "programmer00", "134" }, { "programmer01", "1145" } };
            string[,] _db03 = { { "jaja11", "98761" }, { "krong0313", "29440" }, { "rabbit00", "111333" } };

            Console.WriteLine(_solution.solution(_idpw01, _db01));       //  login
            Console.WriteLine(_solution.solution(_idpw02, _db02));       //  wrong pw
            Console.WriteLine(_solution.solution(_idpw03, _db03));       //  fail
        }
    }
    */
}