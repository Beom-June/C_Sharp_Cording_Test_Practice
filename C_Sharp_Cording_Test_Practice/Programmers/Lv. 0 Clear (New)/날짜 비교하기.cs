using System;

/* 정수 배열 date1과 date2가 주어집니다. 
 * 두 배열은 각각 날짜를 나타내며 [year, month, day] 꼴로 주어집니다. 
 * 각 배열에서 year는 연도를, month는 월을, day는 날짜를 나타냅니다.
 * 
 * 만약 date1이 date2보다 앞서는 날짜라면 1을, 아니면 0을 return 하는 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] date1, int[] date2)
        {
            // 연도 비교
            if (date1[0] < date2[0])
                return 1;
            else if (date1[0] > date2[0])
                return 0;

            // 월 비교
            if (date1[1] < date2[1])
                return 1;
            else if (date1[1] > date2[1])
                return 0;

            // 날짜 비교
            if (date1[2] < date2[2])
                return 1;
            else if (date1[2] > date2[2])
                return 0;

            // 모든 값이 동일할 경우
            return 0;
        }
    }
    class 날짜_비교하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _date11 = { 2021, 12, 28 };
            int[] _date12 = { 1024, 10, 24 };

            int[] _date21 = { 2021, 12, 29 };
            int[] _date22 = { 1024, 10, 24 };

            Console.WriteLine(_solution.solution(_date11,_date21));     //  1
            Console.WriteLine(_solution.solution(_date12,_date22));     //  0
        }
    }
    */
}
