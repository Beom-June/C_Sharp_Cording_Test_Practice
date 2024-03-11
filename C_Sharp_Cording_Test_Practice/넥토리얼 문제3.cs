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

/* 지웅이는 수학 시간에 선생님이 주신 좌표대로 선분을 그리거나 점을 찍어야 한다.
 * 그런데 선생님이 주신 좌표 리스트를 보니 불필요한 선들이 보인다. 
 * 불필요한 선들을 정리하고 작은 숫자부터, 큰 숫자로 정리해서 최소한의 노력으로 선을 긋게 지웅이를 도와주자
 * 
 * <예제>
 * 선분에 대한 정보는 [A, B] 형태로 주어지면 여러개의 선분의 리스트가 주어진다.
 * lineSegmets = {{15, 15}, {7, 7}, {2, 3}, {6, 11}, {1, 2}}
 * 
 * 선분 {1, 2}와 {2, 3}의 경우 합쳐서 {1, 3}으로 그리기가 가능하다 선분 {7, 7}의 경우 선분 {6, 11}에 포함
 * {15, 15}는 독립되어 점으로 찍어야 하므로 더 이상 겹치지는 부분이 없는 최소 선분 묶음은 {{1, 3}, {6, 11}, {15, 15}
 * 
 * <함수 설명>
 * 함수 getMergedLineSegments를 구현하라
 * 
 * getMergedLineSegments는 다음의 파라미터를 가진다
 *  int lineSegment[[n][2]] : 두점으로 이루어진 n개의 선분
 *  
 *  <반환 값>
 *  int[][2] : 순서대로 정리된 최소 묶음의 선분들
 *  
 *  <제약 조건>
 *  1 <= n <= 10^5
 *  1 <= lineSegments[i][2] <= 10^9
 *  모든 i에 대해서 lineSegments[i][0] <= lineSegments[i][1]
 *  
 *  <예제 1>
 *  입력 값 : {{6, 9}, {2, 3}, {9, 11}, {1, 5}, {14, 18}}
 *  출력 값 : {{1, 5}, {6, 11}, {14, 18}}
 *  
 *  <예제 2>
 *  입력 값 : {{4, 8}, {2, 6}, {5, 7}}
 *  출력 값 : {{}}
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class 넥토리얼_문제3
    {

        public static List<List<int>> getMergedLineSegments(List<List<int>> lineSegments)
        {
            lineSegments.Sort((a, b) => a[0].CompareTo(b[0]));          // 선분 정렬
            List<List<int>> _answer = new List<List<int>>();

            for (int i = 1; i < lineSegments.Count; i++)
            {

            }

            return _answer;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int lineSegmentsRows = Convert.ToInt32(Console.ReadLine().Trim());
            int lineSegmentsColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> lineSegments = new List<List<int>>();

            for (int i = 0; i < lineSegmentsRows; i++)
            {
                lineSegments.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(lineSegmentsTemp => Convert.ToInt32(lineSegmentsTemp)).ToList());
            }

            List<List<int>> result = 넥토리얼_문제3.getMergedLineSegments(lineSegments);

            textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

            textWriter.Flush();
            textWriter.Close();
        }
    }
    */
}
