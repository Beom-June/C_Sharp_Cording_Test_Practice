using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 고객의 약관 동의를 얻어서 수집된 1~n번으로 분류되는 개인정보 n개가 있습니다. 
 * 약관 종류는 여러 가지 있으며 각 약관마다 개인정보 보관 유효기간이 정해져 있습니다. 
 * 당신은 각 개인정보가 어떤 약관으로 수집됐는지 알고 있습니다. 수집된 개인정보는 유효기간 전까지만 보관 가능하며, 
 * 유효기간이 지났다면 반드시 파기해야 합니다.
 * 
 * 예를 들어, A라는 약관의 유효기간이 12 달이고, 2021년 1월 5일에 수집된 개인정보가 A약관으로 수집되었다면 
 * 해당 개인정보는 2022년 1월 4일까지 보관 가능하며 2022년 1월 5일부터 파기해야 할 개인정보입니다.
 * 당신은 오늘 날짜로 파기해야 할 개인정보 번호들을 구하려 합니다.
 * 
 * 모든 달은 28일까지 있다고 가정합니다.
 * 
 * 다음은 오늘 날짜가 2022.05.19일 때의 예시입니다.
 * 
 * 약관 종류	유효기간
 *    A	         6 달
 *    B	        12 달
 *    C	         3 달
 *    번호	개인정보 수집 일자	약관 종류
 *     1	    2021.05.02	        A
 *     2	    2021.07.01	        B
 *     3	    2022.02.19	        C
 *     4	    2022.02.20	        C
 * 첫 번째 개인정보는 A약관에 의해 2021년 11월 1일까지 보관 가능하며, 유효기간이 지났으므로 파기해야 할 개인정보입니다.
 * 두 번째 개인정보는 B약관에 의해 2022년 6월 28일까지 보관 가능하며, 유효기간이 지나지 않았으므로 아직 보관 가능합니다.
 * 세 번째 개인정보는 C약관에 의해 2022년 5월 18일까지 보관 가능하며, 유효기간이 지났으므로 파기해야 할 개인정보입니다.
 * 네 번째 개인정보는 C약관에 의해 2022년 5월 19일까지 보관 가능하며, 유효기간이 지나지 않았으므로 아직 보관 가능합니다.
 * 따라서 파기해야 할 개인정보 번호는 [1, 3]입니다.
 * 
 * 오늘 날짜를 의미하는 문자열 today, 약관의 유효기간을 담은 1차원 문자열 배열 terms와 
 * 수집된 개인정보의 정보를 담은 1차원 문자열 배열 privacies가 매개변수로 주어집니다. 
 * 이때 파기해야 할 개인정보의 번호를 오름차순으로 1차원 정수 배열에 담아 return 하도록 solution 함수를 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    internal class 개인정보_수집_유효기간
    {
        public class Solution
        {
            //  today : 오늘 날짜를 의미
            //  terms : 약관의 유효기간을 담은 1차원 문자열 배열
            //  privacies : 수집된 개인정보의 정보를 담은 1차원 문자열 배열
            public int[] solution(string today, string[] terms, string[] privacies)
            {
                int[] answer = new int[] { today.Length };

                //  오늘 날짜를 DateTime으로 변환
                DateTime _today = DateTime.ParseExact(today, "yyyy.MM.dd", null);

                //  약관 종류와 유효기간을 매핑하는 딕셔너리 생성
                Dictionary<string, int> _termsDict = new Dictionary<string, int>();

                foreach (string term in terms)
                {
                    string[] _termParts = term.Split(' ');
                    string _type = _termParts[0];
                    int _months = int.Parse(_termParts[1]);
                    _termsDict[_type] = _months;
                }
                //  파기해야 할 개인정보 번호를 저장할 리스트
                List<int> _toBeDeleted = new List<int>();
                //  개인정보 정보 처리
                for (int i = 0; i < privacies.Length; i++)
                {
                    string[] _privacyParts = privacies[i].Split(' ');
                    DateTime _collectionDate = DateTime.ParseExact(_privacyParts[0], "yyyy.MM.dd", null);
                    string _termType = _privacyParts[1];
                    //  해당 약관의 유효기간을 가져옴
                    if (_termsDict.TryGetValue(_termType, out int _months))
                    {
                        //  유효기간이 지난 날짜 계산
                        DateTime _expiryDate = _collectionDate.AddMonths(_months);
                        //  오늘 날짜와 비교하여 파기해야 할 개인정보인지 확인
                        if (_expiryDate < _today)
                        {
                            _toBeDeleted.Add(i + 1); //  번호는 1부터 시작하므로 i + 1
                        }
                    }
                }
                //  결과를 오름차순으로 정렬
                _toBeDeleted.Sort();
                //  리스트를 배열로 변환
                answer = _toBeDeleted.ToArray();
                //  결과 반환
                if (answer.Length == 0)
                    return new int[] { }; // 파기할 개인정보가 없을 경우 빈 배열 반환
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _today01 = "2022.05.19";
            string _today02 = "2020.01.01";

            string[] _terms01 = { "A 6", "B 12", "C 3" };
            string[] _terms02 = { "Z 3", "D 5" };

            string[] _privacies01 = { "2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C" };
            string[] _privacies02 = { "2019.01.01 D", "2019.11.15 Z", "2019.08.02 D", "2019.07.01 D", "2018.12.28 Z" };

            Console.WriteLine(String.Join("," + _solution.solution(_today01, _terms01, _privacies01)));
            Console.WriteLine(String.Join("," + _solution.solution(_today02, _terms02, _privacies02)));
        }
    }
}
