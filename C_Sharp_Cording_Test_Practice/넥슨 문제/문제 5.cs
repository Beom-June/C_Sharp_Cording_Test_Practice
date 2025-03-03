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

///* 프로그래머 문자열이란 "programmer"라는 단어를 구성 할 수 있는 문자들을 포함하고 있으며
// * 더 긴 문자열의 부분이 될 수도 있다.
// * 
// * 이 정의에 따라서 위치만 바꾼 문자열 "grammproer"은 "programmer"의 위치가 바뀐 구조의 프로그래머 문자열이고
// * 문자열 "prozmerqgram"은 "programmer"라는 문자열을 섞고나서 일부 문자열을 내부에 추가로 
// * 포함한 프로그래머 문자열 이다.
// * 또한 프로그래머 문자열은 문자열 "rpgrammer"를 구성 가능한 최소한의 길이로 계산해야 한다.
// * 
// * 주어진 문자열에서 가장 오른쪽에 있는 프로그래머 문자열과 가정 왼쪽에 있는 문자열 사이에 있는 인덱스 수를 구해라
// * 
// * Example1
// * s = 'programmerxxprozmergqgram'
// * index = 3
// * 
// * Example2
// * s = 'progxrammerrxproxgrammer'
// * index = 2
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {

//        public static int programmerStrings(string s)
//        {
//            string _programmer = "programmer";
//            int[] _cnt = new int[s.Length];
//            int _left = 0;
//            int _right = s.Length - 1;

//            for (int i = 0; i < s.Length; i++)
//            {

//            }

//            return Math.Max(0, _right - _left + 1);
//        }

//    }
//    class 문제_5
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            string s = Console.ReadLine();

//            int result = Result.programmerStrings(s);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
