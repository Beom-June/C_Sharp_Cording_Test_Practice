using System;
using System.Collections.Generic;

/* Retry
 * 휴대폰의 자판은 컴퓨터 키보드 자판과는 다르게 하나의 키에 여러 개의 문자가 할당될 수 있습니다. 
 * 키 하나에 여러 문자가 할당된 경우, 동일한 키를 연속해서 빠르게 누르면 할당된 순서대로 문자가 바뀝니다.
 * 
 * 예를 들어, 1번 키에 "A", "B", "C" 순서대로 문자가 할당되어 있다면 1번 키를 한 번 누르면 "A", 
 * 두 번 누르면 "B", 세 번 누르면 "C"가 되는 식입니다.
 * 
 * 같은 규칙을 적용해 아무렇게나 만든 휴대폰 자판이 있습니다. 이 휴대폰 자판은 키의 개수가 1개부터 
 * 최대 100개까지 있을 수 있으며, 특정 키를 눌렀을 때 입력되는 문자들도 무작위로 배열되어 있습니다. 
 * 또, 같은 문자가 자판 전체에 여러 번 할당된 경우도 있고, 키 하나에 같은 문자가 여러 번 할당된 경우도 있습니다. 
 * 심지어 아예 할당되지 않은 경우도 있습니다. 따라서 몇몇 문자열은 작성할 수 없을 수도 있습니다.
 * 
 * 이 휴대폰 자판을 이용해 특정 문자열을 작성할 때, 키를 최소 몇 번 눌러야 
 * 그 문자열을 작성할 수 있는지 알아보고자 합니다.
 * 
 * 1번 키부터 차례대로 할당된 문자들이 순서대로 담긴 문자열배열 keymap과 
 * 입력하려는 문자열들이 담긴 문자열 배열 targets가 주어질 때, 
 * 각 문자열을 작성하기 위해 키를 최소 몇 번씩 눌러야 하는지 순서대로 배열에 담아 
 * return 하는 solution 함수를 완성해 주세요.
 * 
 * 단, 목표 문자열을 작성할 수 없을 때는 -1을 저장합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        List<int> answer = new List<int>();
        Dictionary<char, int> _minDic = new Dictionary<char, int>();    //  최소 입력 딕셔너리

        //  keymap의 각 문자를 최소 입력 횟수로 초기화
        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                if (!_minDic.ContainsKey(keymap[i][j]) || _minDic[keymap[i][j]] > j + 1)
                {
                    _minDic[keymap[i][j]] = j + 1;
                }
            }
        }

        // targets 배열의 각 문자열에 대해 최소 입력 횟수를 계산
        for (int i = 0; i < targets.Length; i++)
        {
            int _num = 0; // 현재 문자열의 총 입력 횟수
            bool _checking = true;

            for (int j = 0; j < targets[i].Length; j++)
            {
                char ch = targets[i][j];
                if (_minDic.ContainsKey(ch))
                {
                    _num += _minDic[ch];
                }
                else
                {
                    _checking = false;
                    break;
                }
            }

            answer.Add(_checking ? _num : -1);
        }

        return answer.ToArray();
    }
}
class 대충_만든_자판
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        string[] _keymap01 = { "ABACD", "BCEFD" };
        string[] _keymap02 = { "AA" };
        string[] _keymap03 = { "AGZ", "BSSS" };

        string[] _targets01 = { "ABCD", "AABB" };
        string[] _targets02 = { "B" };
        string[] _targets03 = { "ASA", "BGZ" };

        // 결과 출력
        Console.WriteLine(string.Join(", ", _solution.solution(_keymap01, _targets01))); // 9, 4
        Console.WriteLine(string.Join(", ", _solution.solution(_keymap02, _targets02))); // -1
        Console.WriteLine(string.Join(", ", _solution.solution(_keymap03, _targets03))); // 4, 6
    }
}
    */
}
