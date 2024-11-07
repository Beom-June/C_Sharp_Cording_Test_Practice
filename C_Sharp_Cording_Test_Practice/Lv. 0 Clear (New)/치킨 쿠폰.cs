using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 프로그래머스 치킨은 치킨을 시켜먹으면 한 마리당 쿠폰을 한 장 발급합니다. 
 * 쿠폰을 열 장 모으면 치킨을 한 마리 서비스로 받을 수 있고, 서비스 치킨에도 쿠폰이 발급됩니다. 
 * 시켜먹은 치킨의 수 chicken이 매개변수로 주어질 때 받을 수 있는 
 * 최대 서비스 치킨의 수를 return하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int chicken)
        {
            int _service = 0;
            int _coupons = chicken;

            while (_coupons >= 10)
            {
                int _newService = _coupons / 10;  // 서비스로 받을 치킨 수
                _service += _newService;   // 서비스 치킨 추가
                _coupons = _coupons % 10 + _newService;  // 남은 쿠폰 + 새로 받은 서비스 치킨으로 쿠폰 추가
            }

            return _service;
        }
    }
    class 치킨_쿠폰
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(100));     //  11
            Console.WriteLine(_solution.solution(1081));     //  120
        }
    }
    */
}