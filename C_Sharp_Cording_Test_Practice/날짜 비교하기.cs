using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 정수 배열 date1과 date2가 주어집니다. 
 * 두 배열은 각각 날짜를 나타내며 [year, month, day] 꼴로 주어집니다. 
 * 각 배열에서 year는 연도를, month는 월을, day는 날짜를 나타냅니다.
 * 
 * 만약 date1이 date2보다 앞서는 날짜라면 1을, 
 * 아니면 0을 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] date1, int[] date2)
        {
            // 연도(year) 비교
            if (date1[0] < date2[0])
            {
                return 1; // date1이 date2보다 앞섬
            }
            else if (date1[0] > date2[0])
            {
                return 0; // date2가 date1보다 앞섬
            }

            // 연도가 동일한 경우, 월(month) 비교
            if (date1[1] < date2[1])
            {
                return 1; // date1이 date2보다 앞섬
            }
            else if (date1[1] > date2[1])
            {
                return 0; // date2가 date1보다 앞섬
            }

            // 연도와 월이 동일한 경우, 날짜(day) 비교
            if (date1[2] < date2[2])
            {
                return 1; // date1이 date2보다 앞섬
            }
            else
            {
                return 0; // date2가 date1보다 앞섬 또는 두 날짜가 같음
            }
        }
    }
    class 날짜_비교하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _data1_1 = { 2021, 12, 28 };
            int[] _data1_2 = { 1024, 10, 24 };

            int[] _data2_1 = { 2021, 12, 29 };
            int[] _data2_2 = { 1024, 10, 24 };

            Console.WriteLine(_solution.solution(_data1_1, _data2_1));
            Console.WriteLine(_solution.solution(_data1_2, _data2_2));
        }
    }
    */
}
