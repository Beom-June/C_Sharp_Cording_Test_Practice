using System;
using System.Collections.Generic;

/* 오늘 해야 할 일이 담긴 문자열 배열 todo_list와 각각의 일을 지금 마쳤는지를 
 * 나타내는 boolean 배열 finished가 매개변수로 주어질 때, 
 * 
 * todo_list에서 아직 마치지 못한 일들을 순서대로 담은 문자열 배열을 
 * return 하는 solution 함수를 작성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
        public class Solution
        {
            public string[] solution(string[] todo_list, bool[] finished)
            {
                List<string> answer = new List<string>();
                for (int i = 0; i < todo_list.Length; i++)
                {
                    if (!finished[i])
                        answer.Add(todo_list[i]);
                }
                return answer.ToArray();
            }
        }
        class 할_일_목록
        {
            static void Main(string[] args)
            {
                Solution _solution = new Solution();

                string[] _todoList = { "problemsolving", "practiceguitar", "swim", "studygraph" };
                bool[] _finished = { true, false, true, false };

                foreach (var item in _solution.solution(_todoList, _finished))
                {
                    Console.Write(item + " ");
                }
            }
        }
        */
}
