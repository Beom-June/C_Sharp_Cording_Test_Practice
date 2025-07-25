using System;
using System.Collections.Generic;

/* Retry
 * 얀에서는 매년 달리기 경주가 열립니다. 해설진들은 선수들이 자기 바로 앞의 선수를 추월할 때 추월한 선수의 이름을 부릅니다. 
 * 예를 들어 1등부터 3등까지 "mumu", "soe", "poe" 선수들이 순서대로 달리고 있을 때, 
 * 해설진이 "soe"선수를 불렀다면 2등인 "soe" 선수가 1등인 "mumu" 선수를 추월했다는 것입니다. 
 * 즉 "soe" 선수가 1등, "mumu" 선수가 2등으로 바뀝니다.
 * 
 * 선수들의 이름이 1등부터 현재 등수 순서대로 담긴 문자열 배열 players와 해설진이 부른 이름을 담은 문자열 배열 callings가 매개변수로 주어질 때, 
 * 경주가 끝났을 때 선수들의 이름을 1등부터 등수 순서대로 배열에 담아 return 하는 solution 함수를 완성해주세요.
 */
/*
namespace C_Sharp_Cording_Test_Practice.Programmers
{
public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        string[] answer = new string[players.Length];

        // 플레이어 순위
        Dictionary<string, int> _playerRank = new Dictionary<string, int>();

        // players 배열의 선수 이름과 인덱스를 매핑하여 딕셔너리에 저장
        for (int i = 0; i < players.Length; i++)
        {
            _playerRank[players[i]] = i;
        }

        foreach (string calling in callings)
        {
            // 호출된 선수의 현재 순위 인덱스 가져오기
            int _idx = _playerRank[calling];

            // 현재 순위가 0이 아니면, 즉 1등이 아니면
            if (_idx > 0)
            {
                string _frontPlayer = players[_idx - 1];

                // 순서 바꾸기
                players[_idx - 1] = calling;
                players[_idx] = _frontPlayer;

                // 딕셔너리 갱신
                _playerRank[calling] = _idx - 1;
                _playerRank[_frontPlayer] = _idx;
            }
        }
        return players; // 굳이 answer 배열 만들 필요 없음
    }
}
internal class 달리기_경주
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        string[] _players = { "mumu", "soe", "poe", "kai", "mine" };
        string[] _callings = { "kai", "kai", "mine", "mine" };

        string[] result = _solution.solution(_players, _callings);
        Console.WriteLine(string.Join(", ", result)); // Expected: "mumu, kai, mine, soe, poe"
    }
}
}
*/

