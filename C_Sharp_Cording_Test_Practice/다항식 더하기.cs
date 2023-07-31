using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 복습
 * 한 개 이상의 항의 합으로 이루어진 식을 다항식이라고 합니다. 
 * 다항식을 계산할 때는 동류항끼리 계산해 정리합니다. 
 * 덧셈으로 이루어진 다항식 polynomial이 매개변수로 주어질 때, 
 * 동류항끼리 더한 결괏값을 문자열로 return 하도록 solution 함수를 완성해보세요. 
 * 같은 식이라면 가장 짧은 수식을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
public class Solution
{
    public string solution(string polynomial)
    {
        string answer = "";
        string _temp = "";
        string[] _str = polynomial.Split(" ");
        int _xNum = 0;
        int _num = 0;

        for (int i = 0; i < _str.Length; i += 2)
        {
            // Contains()을 활용해 str[i]에 x가 있는지 확인
            if (_str[i].Contains("x"))
            {
                // temp에 str[i].Replace를 활용해 x를 string.Empty로 초기화
                _temp = _str[i].Replace("x", string.Empty);
                // temp에 값이 없으면 xNum에 1을 더함
                if (_temp == "")
                {
                    _xNum += 1;
                }
                // temp에 값이 있으면 xNum에 int형으로 변환후 더함
                else
                {
                    _xNum += int.Parse(_temp);
                }
            }
            else
            {
                _num += int.Parse(_str[i]);
            }
        }
        if (_num == 0)
        {
            if (_xNum == 1)
            {
                answer = "x";
            }
            else
            {
                answer = _xNum.ToString() + "x";
            }
        }
        else
        {
            if (_xNum == 0)
            {
                answer = _num.ToString();
            }
            else if (_xNum == 1)
            {
                answer = "x " + "+ " + _num.ToString();
            }
            else
            {
                answer = _xNum.ToString() + "x " + "+ " + _num.ToString();
            }
        }
        return answer;
    }
}
class 다항식_더하기
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        string _polynomial1 = "3x + 7 + x";
        string _polynomial2 = "x + x + x";

        Console.WriteLine(_solution.solution(_polynomial1));
        Console.WriteLine(_solution.solution(_polynomial2));
    }
}
    */
}
