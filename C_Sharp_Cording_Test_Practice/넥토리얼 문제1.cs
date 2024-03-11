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

/* 천공 카드는 0과 1을 구멍을 뚫었는지 여부를 통해 저장하는 매체
 * 넥돌이는 바이너리 문자열을 입력하면 천공 카드에 기록해 주는 입력장치 시스템을 개발중
 * 바이너리 문자열은 입력할 떄 실수하기 쉽기 떄문에 ㅇ비력 편의를 위해 입력 도우미 기능을 추가하려함
 * 
 * 도우미 기능은 다음과 같이 동작한다
 * 문자를 하나 입력할 때마다 기존 입력 기록을 기반으로 자동 완성 시켜줄 수 있는 문자열을 보여줌
 * 만약 자동 완성해 줄 수 있는 기록이 여럿이라면 가장 최근의 것으로 보여줌
 * 
 * 자동 완성해 줄수 있는 기록이 없다면 바로 직전의 문자열을 보여줌
 * 
 * 이전 기록이 하나도 없다면 빈 문자열을 보여줌
 * 
 * <구현 내용>
 * 도우미 기능을 테스트할 함수 autocompletes를 구현한다
 * 
 * autocompletes 는 다음과 같은 인자를 입력 받는다
 * > string inputs[n] : 입력할 문자열의 목록. i 번째 문자열은 i - 1 번째 까지의 문자열을 이전 입력 기록으로 간주
 * 
 * autocompletes 는 다음과 같은 값을 반환한다
 *  int[n] : 각 문자열을 입력할 때 도우미 기능이 마지막으로 보여준 문자열의 입력 번호
 *   * 입력 번호는 1부터 시작하기 떄문에 inputs 의 index + 1 이다
 *   ** 이전 기록이 하나도 없어 빈 문자열을 보여주는 경우 0으로 기록
 *   
 *   제약 조건
 *   2 <= n <= 10^5
 *   1 <= input 1개의 길이 <= 30
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 넥토리얼_문제1
    {
        public static List<int> autocompletes(List<string> inputs)
        {
            List<int> _answer = new List<int>();
            Dictionary<string, int> _auto = new Dictionary<string, int>();

            foreach (var _result in inputs)
            {
                int _inputNum = 0;

                // 만약 키입력 값이면
                if (_auto.ContainsKey(_result))
                {
                    _inputNum = _auto[_result];
                }
                else if(_auto.Count > 0)
                {
                    // 이전 기록이 없을 때, 가장 최근 기록을 찾음
                    foreach (var _output in _auto)
                    {
                        _inputNum = _output.Value;
                        break;
                    }
                }
                _answer.Add(_inputNum);
                _auto[_result] = inputs.Count;
            }
            return _answer;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int inputsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> inputs = new List<string>();

            for (int i = 0; i < inputsCount; i++)
            {
                string inputsItem = Console.ReadLine();
                inputs.Add(inputsItem);
            }

            List<int> result = 넥토리얼_문제1.autocompletes(inputs);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

    }
    */
}
