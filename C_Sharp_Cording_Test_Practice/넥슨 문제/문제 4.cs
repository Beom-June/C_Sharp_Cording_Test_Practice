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

///* 끝나기 직전의 배열이란 해당 배열에서 최대 하나의 원소만 삭제하면 정렬이 완성되는 정렬
// * 
// * Ex. 배열 {2, 1, 7}, {13}, {9, 2}, {1, 5, 6}을 살펴보면 각각 0개 또는 1개의 원소만 배열에서 없애면
// * 정렬된 상태가 되니까 정렬이 끝나기 직전의 배열이라고 할 수 있다.
// * 배열 {4, 2, 1}, {1, 2, 6, 4, 3}은 2개 이상의 원소를 제거해야만 완벽하게 정렬 된 상태가 되니깐
// * 정렬이 끝나기 직전의 배열이라고 볼 수 없다.
// * 
// * n개의 고유한 값의 배열 중에서 최소한 몇 개의 원소를 제거 해야 정렬이 끝나기 직전의 배열의 상태가 되는지 구하시오
// * 
// * Example
// * arr = {3, 4, 2, 5, 1}
// * 
// * 2를 삭제하면 {3, 4, 5, 1} 이 되어 정렬이 끝나기 직전의 배열이 된다 (1을 제거하면 정렬 상태)
// * 1를 삭제하면 {3, 4, 5} 이 되어 정렬이 끝나기 직전의 배열이 된다 (2을 제거하면 정렬 상태)
// * 
// * 둘 다 정렬이 끝나기 직전의 배열을 만들기 위해서는 최소한 1개의 원소를 삭제 해야 했으므로, 답은 1
// * 
// * Function Description : 함수 minDeletions을 완성해라
// * 
// * minDeletions의 파라미터 : int arr[n] : 정렬 안된 integer 배열
// * 
// * Returns : int 형의 값을 반호나하고, 정렬이 끝나기 직전의 배열이 되기 까지 삭제 해야하는 최소한의 원소의 수
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {

//        public static int minDeletions(List<int> arr)
//        {
//            int[] _lis = new int[arr.Count];
//            Array.Fill(_lis, 1);
//            for (int i = 1; i < arr.Count; i++)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    if (arr[i] > arr[j] && _lis[i] < _lis[j] + 1)
//                    {
//                        _lis[i] = _lis[j] + 1;
//                    }
//                }
//            }
//            int maxLisLength = _lis.Max(); 
//            return arr.Count - maxLisLength; 
//        }

//    }
//    class 문제_4
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = new List<int>();

//            for (int i = 0; i < arrCount; i++)
//            {
//                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//                arr.Add(arrItem);
//            }

//            int result = Result.minDeletions(arr);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
