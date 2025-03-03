//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

///* 어떤 게임에서 공성전을 진행 하였고, 길드원들의 공성전 기여도 점수를 저장했다.
// * 길드원들의 기여도 점수 배열이 주어지면, 아래의 선택 프로세스를 사용하여 최고점의
// * 기여도 점수들의 합계를 찾고자 한다.
// * 
// * 1. 기여도 점수 배열의 앞 쪽 k 번째 까지의 점수 중에 높은 점수 또는 뒤쪽에서 부터의 k 번째 까지의
// * 길드원 기여도 점수 중 높은 점수를 선택
// * 2. 선택한 점수가 목록에서 제거
// * 3. 이 프로세스는 주어진 반복 횟수 guilder_count 만큼 계속 진행
// * 
// * 제거된 (선택 된) 기여도 점수의 총합을 구하시오.
// * 
// * Note
// * 1. 기여도 점수가 동일한 경우 오니쪾에 가까운 곳에 위치한 점수를 선택해 삭제 (배열의 인덱스가 낮은 쪽)
// * 2. 길드원의 기여도 점수 수가 k명 미만인 경우 전체 목록을 선택할수 있다.
// * 
// * Example
// * score = {8, 21, 8, 15, 5, 30, 21}
// * guilder_count = 2
// * k = 3
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {
//        public static long sumVips(List<int> score, int guilder_count, int k)
//        {
//            long _Sum = 0;                        //  그 리스트 값 더 하는 값

//            for (int i = 0; i < guilder_count; i++)
//            {
//                int _left = Math.Min(k, score.Count);
//                int _right = Math.Min(score.Count - k, 0);

//                int _maxLeft = score.GetRange(0, _left).Max();
//                int _maxRight = score.GetRange(_right, score.Count - _right).Max();

//                if(_maxLeft > _maxRight)
//                {
//                    _Sum += _maxLeft;
//                    score.RemoveAt(score.IndexOf(_maxLeft));
//                }
//                else
//                {
//                    _Sum += _maxRight;
//                    score.RemoveAt(score.IndexOf(_maxRight));
//                }
//            }

//            return _Sum;
//        }

//    }
//    class 문제_3
//    {
//        public static void Main(string[] args)
//        {
//            int scoreCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> score = new List<int>();
//            for (int i = 0; i < scoreCount; i++)
//            {
//                int scoreItem = Convert.ToInt32(Console.ReadLine().Trim());
//                score.Add(scoreItem);
//            }

//            int guilder_count = Convert.ToInt32(Console.ReadLine().Trim());
//            int k = Convert.ToInt32(Console.ReadLine().Trim());

//            long result = Result.sumVips(score, guilder_count, k);
//            Console.WriteLine(result);
//        }
//    }
//}
