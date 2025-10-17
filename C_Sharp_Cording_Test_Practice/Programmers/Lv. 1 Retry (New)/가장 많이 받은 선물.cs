using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 선물을 직접 전하기 힘들 때 카카오톡 선물하기 기능을 이용해 축하 선물을 보낼 수 있습니다. 
 * 당신의 친구들이 이번 달까지 선물을 주고받은 기록을 바탕으로 다음 달에 누가 선물을 많이 받을지 예측하려고 합니다.
 * 
 * 두 사람이 선물을 주고받은 기록이 있다면, 이번 달까지 두 사람 사이에 더 많은 선물을 준 사람이 다음 달에 선물을 하나 받습니다.
 * 예를 들어 A가 B에게 선물을 5번 줬고, B가 A에게 선물을 3번 줬다면 다음 달엔 A가 B에게 선물을 하나 받습니다.
 * 두 사람이 선물을 주고받은 기록이 하나도 없거나 주고받은 수가 같다면, 선물 지수가 더 큰 사람이 선물 지수가 더 작은 사람에게 선물을 하나 받습니다.
 * 선물 지수는 이번 달까지 자신이 친구들에게 준 선물의 수에서 받은 선물의 수를 뺀 값입니다.
 * 예를 들어 A가 친구들에게 준 선물이 3개고 받은 선물이 10개라면 A의 선물 지수는 -7입니다. B가 친구들에게 준 선물이 3개고 받은 선물이 2개라면 B의 선물 지수는 1입니다. 
 * 만약 A와 B가 선물을 주고받은 적이 없거나 정확히 같은 수로 선물을 주고받았다면, 다음 달엔 B가 A에게 선물을 하나 받습니다.
 * 만약 두 사람의 선물 지수도 같다면 다음 달에 선물을 주고받지 않습니다.
 * 위에서 설명한 규칙대로 다음 달에 선물을 주고받을 때, 당신은 선물을 가장 많이 받을 친구가 받을 선물의 수를 알고 싶습니다.
 * 
 * 친구들의 이름을 담은 1차원 문자열 배열 friends 이번 달까지 친구들이 주고받은 선물 기록을 담은 1차원 문자열 배열 gifts가 매개변수로 주어집니다. 
 * 이때, 다음달에 가장 많은 선물을 받는 친구가 받을 선물의 수를 return 하도록 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] friends, string[] gifts)
        {
            int answer = 0;
            Dictionary<string, int> _giftPoint = new Dictionary<string, int>();                                 // 친구별 선물 지수 (준 선물 개수 - 받은 선물 개수)
            Dictionary<(string, string), int> _giftHistory = new Dictionary<(string, string), int>();           // 친구 간 선물 기록 (A가 B에게 준 선물 횟수)
            Dictionary<string, int> _nextMonthGift = new Dictionary<string, int>();                             // 최종적으로 각 친구가 다음 달에 받을 선물 개수

            foreach (string friend in friends)
            {
                _nextMonthGift.Add(friend, answer);
            }
            // 0️. 각 친구별 선물 지수 계산 (준 선물 개수 - 받은 선물 개수)
            foreach (var _gift in gifts)
            {
                var _parts = _gift.Split(' ');
                string _giver = _parts[0];
                string _receiver = _parts[1];

                // 준 사람 +1
                if (_giftPoint.ContainsKey(_giver)) _giftPoint[_giver]++; else _giftPoint[_giver] = 1;
                // 받은 사람 -1
                if (_giftPoint.ContainsKey(_receiver)) _giftPoint[_receiver]--; else _giftPoint[_receiver] = -1;
                // gift history 갱신 (A -> B)
                var _pair = (_giver, _receiver);
                if (_giftHistory.ContainsKey(_pair)) _giftHistory[_pair]++; else _giftHistory[_pair] = 1;
            }

            //  비교
            // 1️. 모든 친구 쌍 (A, B)에 대해 반복 (A != B)
            for (int i = 0; i < friends.Length; i++)
            {
                for (int j = i + 1; j < friends.Length; j++)
                {
                    string _friendA = friends[i];
                    string _friendB = friends[j];

                    // 2️. A→B, B→A 각각 준 선물 횟수 조회 (없으면 0)
                    int _aToB = _giftHistory.ContainsKey((_friendA, _friendB)) ? _giftHistory[(_friendA, _friendB)] : 0;
                    int _bToA = _giftHistory.ContainsKey((_friendB, _friendA)) ? _giftHistory[(_friendB, _friendA)] : 0;

                    // 3️. A와 B가 서로 선물 주고받은 수 비교
                    if (_aToB > _bToA)
                    {
                        // A가 B에게 더 많이 줬다면 다음 달에 A가 선물 하나 받음
                        _nextMonthGift[_friendA]++;
                    }
                    else if (_bToA > _aToB)
                    {
                        // 반대의 경우 B가 하나 받음
                        _nextMonthGift[_friendB]++;
                    }
                    else
                    {
                        // 4️. 선물 주고받은 횟수가 같다면 선물 지수 비교
                        int _aGiftPoint = (_giftPoint.ContainsKey(_friendA) ? _giftPoint[_friendA] : 0);
                        int _bGiftPoint = (_giftPoint.ContainsKey(_friendB) ? _giftPoint[_friendB] : 0);

                        if (_aGiftPoint > _bGiftPoint)
                            _nextMonthGift[_friendA]++;
                        else if (_bGiftPoint > _aGiftPoint)
                            _nextMonthGift[_friendB]++;
                        // 같다면 아무도 받지 않음
                    }
                }
            }
            // 5️. 가장 많이 선물 받은 사람의 수 구하기
            answer = _nextMonthGift.Values.Max();

            return answer;
        }
    }
    internal class 가장_많이_받은_선물
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _friends01 = { "muzi", "ryan", "frodo", "neo" };
            string[] _friends02 = { "joy", "brad", "alessandro", "conan", "david" };
            string[] _friends03 = { "a", "b", "c" };

            string[] _gifts01 = { "muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi" };
            string[] _gifts02 = { "alessandro brad", "alessandro joy", "alessandro conan", "david alessandro", "alessandro david" };
            string[] _gifts03 = { "a b", "b a", "c a", "a c", "a c", "c a" };

            Console.WriteLine(_solution.solution(_friends01, _gifts01));     //2
            Console.WriteLine(_solution.solution(_friends02, _gifts02));     //4
            Console.WriteLine(_solution.solution(_friends03, _gifts03));     //0
        }
    }
    */
}
