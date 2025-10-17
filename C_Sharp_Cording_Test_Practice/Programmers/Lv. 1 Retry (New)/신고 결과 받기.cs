using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 신입사원 무지는 게시판 불량 이용자를 신고하고 처리 결과를 메일로 발송하는 시스템을 개발하려 합니다. 무지가 개발하려는 시스템은 다음과 같습니다.
 * 
 * 각 유저는 한 번에 한 명의 유저를 신고할 수 있습니다.
 * 신고 횟수에 제한은 없습니다. 서로 다른 유저를 계속해서 신고할 수 있습니다.
 * 한 유저를 여러 번 신고할 수도 있지만, 동일한 유저에 대한 신고 횟수는 1회로 처리됩니다.
 * k번 이상 신고된 유저는 게시판 이용이 정지되며, 해당 유저를 신고한 모든 유저에게 정지 사실을 메일로 발송합니다.
 * 유저가 신고한 모든 내용을 취합하여 마지막에 한꺼번에 게시판 이용 정지를 시키면서 정지 메일을 발송합니다.
 * 다음은 전체 유저 목록이 ["muzi", "frodo", "apeach", "neo"]이고, k = 2(즉, 2번 이상 신고당하면 이용 정지)인 경우의 예시입니다.
 * 
 * 유저 ID	유저가 신고한 ID	설명
 * "muzi"	    "frodo"	        "muzi"가 "frodo"를 신고했습니다.
 * "apeach"	    "frodo"	        "apeach"가 "frodo"를 신고했습니다.
 * "frodo"	    "neo"	        "frodo"가 "neo"를 신고했습니다.
 * "muzi"	    "neo"	        "muzi"가 "neo"를 신고했습니다.
 * "apeach"	    "muzi"	        "apeach"가 "muzi"를 신고했습니다.
 * 
 * 각 유저별로 신고당한 횟수는 다음과 같습니다.
 * 유저 ID	신고당한 횟수
 * "muzi"	    1
 * "frodo"	    2
 * "apeach"	    0
 * "neo"	    2
 * 
 * 위 예시에서는 2번 이상 신고당한 "frodo"와 "neo"의 게시판 이용이 정지됩니다. 이때, 각 유저별로 신고한 아이디와 정지된 아이디를 정리하면 다음과 같습니다.
 * 유저 ID	유저가 신고한 ID	정지된 ID
 * "muzi"	["frodo", "neo"]	["frodo", "neo"]
 * "frodo"	["neo"]	            ["neo"]
 * "apeach"	["muzi", "frodo"]	["frodo"]
 * "neo"	    없음	           없음
 * 따라서 "muzi"는 처리 결과 메일을 2회, "frodo"와 "apeach"는 각각 처리 결과 메일을 1회 받게 됩니다.
 * 
 * 이용자의 ID가 담긴 문자열 배열 id_list, 각 이용자가 신고한 이용자의 ID 정보가 담긴 문자열 배열 report, 
 * 정지 기준이 되는 신고 횟수 k가 매개변수로 주어질 때, 각 유저별로 처리 결과 메일을 받은 횟수를 배열에 담아 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    internal class 신고_결과_받기
    {
        public class Solution
        {
            public int[] solution(string[] id_list, string[] report, int k)
            {
                int[] answer = new int[id_list.Length];

                // 신고 관계/카운트 자료구조
                Dictionary<string, HashSet<string>> _reportDic = new Dictionary<string, HashSet<string>>();
                Dictionary<string, int> _reportCnt = new Dictionary<string, int>();

                foreach (var id in id_list)
                {
                    _reportDic[id] = new HashSet<string>();
                    _reportCnt[id] = 0;
                }

                // 1) 중복 제거된 신고만 반영: 관계 기록 + 신고당한 횟수 누적
                foreach (var v in report.Distinct())
                {
                    string[] _reportInfo = v.Split(' ');
                    string reporter = _reportInfo[0];
                    string reported = _reportInfo[1];

                    // HashSet이므로 같은 (reporter→reported) 추가 시 자동 중복 방지
                    if (_reportDic[reporter].Add(reported))
                    {
                        _reportCnt[reported]++;
                    }
                }

                // 2) 정지 대상 확정 (신고 k회 이상)
                var _banned = new HashSet<string>(
                    _reportCnt.Where(x => x.Value >= k).Select(x => x.Key)
                );

                // 3) 결과 메일 카운트 (id_list 순서대로)
                for (int i = 0; i < id_list.Length; i++)
                {
                    string _id = id_list[i];
                    int _cnt = 0;
                    foreach (var target in _reportDic[_id])
                    {
                        if (_banned.Contains(target))
                            _cnt++;
                        Console.WriteLine(target);
                    }
                    answer[i] = _cnt;
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();
            string[] _idList01 = { "muzi", "frodo", "apeach", "neo" };
            string[] _idList02 = { "con", "ryan" };

            string[] report01 = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            string[] report02 = { "ryan con", "ryan con", "ryan con", "ryan con" };

            int[] _result01 = _solution.solution(_idList01, report01, 2);
            int[] _result02 = _solution.solution(_idList02, report02, 3);

            Console.WriteLine(string.Join(", ", _result01)); // 결과 출력 [2, 1, 1, 0]
            Console.WriteLine(string.Join(", ", _result02)); // 결과 출력 [0, 0]
        }
    }
    */
}