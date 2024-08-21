using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* n명의 학생이 기숙사에 입사하게 되었다.
 * 기숙사는 총 n/4 (올림) 개의 방이 존재. 한 방에는 2개의 2층 침대가 있다.
 * 
 * 학생 4명당 방 하나가 배정되며 4명씩 모두 배정되고 남은 인원이 있다면 남은 인원끼리 마지막 방을 사용한다
 * ex : 5명이 기숙사에 입사하게 된다면 4명이 한 방을 쓰고 나머지 1명이 한 방을 쓰게 됨
 * 
 * 기본적으로, 같은 방을 배정받은 학생들의 학번이 적은 순으로 침대 위치가 지정
 * 방의 인원수가 3명 혹은 4명일 경우, ㅎ가번이 적은 2명은 1층 침대로 지정, 나머지 학생은 2층 침대로 지정
 * 방의 인원수가 1명 혹은 2명일 경우 모든 학생이 1층 침대로 지정
 * 
 * 모든 학생은 기숙사에 입사하기 전 2층 침대의 1층에서 자고 싶은지에 대한 희망 여부를 기숙사에 제출
 * 당신은 학생들에게 방을 배정할 때, 1층을 원하는 학생들이 1층 침대로 최대한 많이 지정되도록 해야함
 * 
 * n 명의 학생들의 학번을 담은 1차원 정수바열 sid, 2층 침대의 1층 이용을 원하는 학생들의 학번을 담은 1차원 정수 배열 sfirst 가 매개 변수로 주어짐
 * 학새들에게 방을 적절히 배정하여 2층 침대의 1층을 이용하는 1층 침대에 지정될 수 있는 학생 수의 최댓값을 return 하도록 solution 함수를 완성
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 문제3
    {
        public class Solution
        {
            public int solution(int[] sid, int[] sfirst)
            {
                int answer = -1;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _sid01 = { 201820793, 201969011, 202020202, 202299999, 202200000, 202232134, 202310039 };
            int[] _sid02 = { 900000000, 900000001, 900000002, 900000003, 999999999 };

            int[] _sfirst01 = { 201820793, 202020202, 202200000, 202232134, 202310039 };
            int[] _sfirst02 = { 999999999 };

            Console.WriteLine(_solution.solution(_sid01, _sfirst01));        //  3
            Console.WriteLine(_solution.solution(_sid02, _sfirst02));        //  1
        }
    }
    */
}
