using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/* 삼형제가 엄마와 숫자 카드 놀이를 하고 있다.
 * 엄마가 정해진 숫자(t)와 함께 숫자카드 (d[n])을 제시하면
 * 동생부터 카드를 한 장씩 골라 세장을 더 했을 때 t를 넘겨야 한다
 * 
 * 다만 형은 언제나  동생이 선택한 것 보다 큰 숫자 카드를 골라야 한다
 * 이 떄 삼형제가 만들 수 있는 조합은 몇 가지 인지 구하려고 한다
 * 
 * < 구현 내용 >
 *  함수 tree_numbers 를 만든다
 *  
 *  tree_numbers 는 다음과 같은 인자를 받음
 *  int t : 엄마가 제시한 숫자
 *  int d[n] : 숫자 카드 들
 *  
 *  tree_numbers는 다음과 같은 값을 반환 : long : 조건을 만족하는 조합의 가지 수
 *  
 *  제약 조건
 *  1 <= n <= 10^4
 *  0 <= d[i] <= 10^9
 *  0 < t < 3 x 10^9
 *  
 *  <예제 1>
 *  t = 8
 *  d = {1, 2, 3, 4, 5}
 *  출력 : 4
 *  
 *  <예제 2>
 *  t = 7
 *  d = {3, 1, 2, 4}
 *  출력 : 2
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 넥토리얼_문제5
    {
        // t : 엄마가 제시한 숫자, d[n] : 숫자 카드들
        public static long three_numbers(int t, List<int> d)
        {
            d.Sort();                                   //  카드 정렬
            long _combin = 0;                           //  조합의 가지를 저장

            for (int i = 0; i < d.Count; i++)
            {
                int _left = i - 1;
                int _right = i + 1;

                while (_left < _right)
                {
                    int _total = d[i] + d[_left] + d[_right];
                    if(_total > t)
                    {
                        _right--;
                    }
                    else
                    {
                        _combin += (_right + _left);
                    }
                }

            }

            return _combin;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            int dCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> d = new List<int>();

            for (int i = 0; i < dCount; i++)
            {
                int dItem = Convert.ToInt32(Console.ReadLine().Trim());
                d.Add(dItem);
            }

            long result = 넥토리얼_문제5.three_numbers(t, d);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
    */
}
