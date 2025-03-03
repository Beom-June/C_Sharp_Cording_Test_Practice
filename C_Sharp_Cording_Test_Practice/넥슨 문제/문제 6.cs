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

///* n 개의 초콜릿이 박스에 들어 있고, 각 초콜릿의 무게는 정수 배열 weights[n]으로 주어진다
// * weights[i]는 i번쨰 초콜릿의 무게를 나타낸다. 매일 하나의 초콜릿을 선택해서 절반만 먹고, 나머지 절반을 다시
// * 상자에 넣는다
// * 
// * 하나으 ㅣ초콜릿을 여러 번 먹을 수 있고, 홀수의 무게를 가지고 있을 경우 먹은 부분의 무게는 floor(weights[i]/2)을
// * 이용해서 구할 수 있습니다
// * 
// * d일이 지난 후에 남은 초콜릿의 총 무게의 최소 값을 구하시오
// * 
// * Example
// * 초콜릿 갯수 = 3, 각 초콜릿의 무게 = {30, 20, 25}, d = 4
// * 
// * 날짜       선택한             먹은               남은          결과
// *         초콜릿의 무게     초콜릿의 무게       초콜릿의 무게      
// * 1           20               10                  10          {30, 10, 25}
// * 2           25               12                  13          {30, 10, 13}
// * 3           30               15                  15          {15, 10, 13}
// * 4           15               7                    8          {8, 10, 13}
// * */
//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {

//        public static int findMinWeight(List<int> weights, int d)
//        {

//        }

//    }
//    class 문제_6
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int weightsCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> weights = new List<int>();

//            for (int i = 0; i < weightsCount; i++)
//            {
//                int weightsItem = Convert.ToInt32(Console.ReadLine().Trim());
//                weights.Add(weightsItem);
//            }

//            int d = Convert.ToInt32(Console.ReadLine().Trim());

//            int result = Result.findMinWeight(weights, d);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
