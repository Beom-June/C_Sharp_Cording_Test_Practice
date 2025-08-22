using System;

/* 당신은 동영상 재생기를 만들고 있습니다. 
 * 당신의 동영상 재생기는 10초 전으로 이동, 10초 후로 이동, 오프닝 건너뛰기 3가지 기능을 지원합니다. 
 * 각 기능이 수행하는 작업은 다음과 같습니다.
 * 
 * 10초 전으로 이동: 사용자가 "prev" 명령을 입력할 경우 동영상의 재생 위치를 현재 위치에서 10초 전으로 이동합니다. 
 * 현재 위치가 10초 미만인 경우 영상의 처음 위치로 이동합니다. 영상의 처음 위치는 0분 0초입니다.
 * 
 * 10초 후로 이동: 사용자가 "next" 명령을 입력할 경우 동영상의 재생 위치를 현재 위치에서 10초 후로 이동합니다. 
 * 동영상의 남은 시간이 10초 미만일 경우 영상의 마지막 위치로 이동합니다. 영상의 마지막 위치는 동영상의 길이와 같습니다.
 * 
 * 오프닝 건너뛰기: 현재 재생 위치가 오프닝 구간(op_start ≤ 현재 재생 위치 ≤ op_end)인 경우 자동으로 오프닝이 끝나는 위치로 이동합니다.
 * 
 * 동영상의 길이를 나타내는 문자열 video_len, 기능이 수행되기 직전의 재생위치를 나타내는 문자열 pos, 
 * 오프닝 시작 시각을 나타내는 문자열 op_start, 오프닝이 끝나는 시각을 나타내는 문자열 op_end, 사용자의 입력을 나타내는 1차원 문자열 배열 commands가 매개변수로 주어집니다. 
 * 
 * 이때 사용자의 입력이 모두 끝난 후 동영상의 위치를 "mm:ss" 형식으로 return 하도록 solution 함수를 완성해 주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            // 문자열을 분리해서 분, 초 단위로 관리
            string[] _videoLenArr = video_len.Split(':');
            string[] _posArr = pos.Split(':');
            string[] _opStartArr = op_start.Split(':');
            string[] _opEndArr = op_end.Split(':');

            //  int로 변환
            int _videoMin = int.Parse(_videoLenArr[0]);
            int _videoSec = int.Parse(_videoLenArr[1]);
            int _posMin = int.Parse(_posArr[0]);
            int _posSec = int.Parse(_posArr[1]);
            int _opStartMin = int.Parse(_opStartArr[0]);
            int _opStartSec = int.Parse(_opStartArr[1]);
            int _opEndMin = int.Parse(_opEndArr[0]);
            int _opEndSec = int.Parse(_opEndArr[1]);

            //  모든 시각을 초 단위로 변환
            int _videoLenSec = _videoMin * 60 + _videoSec;
            int _posSecTotal = _posMin * 60 + _posSec;
            int _opStartSecTotal = _opStartMin * 60 + _opStartSec;
            int _opEndSecTotal = _opEndMin * 60 + _opEndSec;

            // 시작 위치 오프닝 체크
            if (_opStartSecTotal <= _posSecTotal && _posSecTotal <= _opEndSecTotal)
                _posSecTotal = _opEndSecTotal;

            foreach (var _cmd in commands)
            {
                if (_cmd == "prev")
                    _posSecTotal = Math.Max(0, _posSecTotal - 10);

                if (_cmd == "next")
                    _posSecTotal = Math.Min(_videoLenSec, _posSecTotal + 10);

                if (_opStartSecTotal <= _posSecTotal && _posSecTotal <= _opEndSecTotal)
                    _posSecTotal = _opEndSecTotal;
            }

            int _answerMin = _posSecTotal / 60;
            int _answerSec = _posSecTotal % 60;
            return $"{_answerMin:D2}:{_answerSec:D2}";
        }
    }
    internal class 동영상_재생기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _videoLen01 = "34:33";
            string _videoLen02 = "10:55";
            string _videoLen03 = "07:22";

            string _pos01 = "13:00";
            string _pos02 = "00:05";
            string _pos03 = "04:05";

            string _poStart01 = "00:55";
            string _poStart02 = "00:15";
            string _poStart03 = "00:15";

            string _opEnd01 = "02:55";
            string _opEnd02 = "06:55";
            string _opEnd03 = "04:07";

            string[] _commands01 = { "next", "prev" };
            string[] _commands02 = { "prev", "next", "next" };
            string[] _commands03 = { "next" };

            Console.WriteLine(_solution.solution(_videoLen01, _pos01, _poStart01, _opEnd01, _commands01));           //  13:00
            Console.WriteLine(_solution.solution(_videoLen02, _pos02, _poStart02, _opEnd02, _commands02));           //  06:55
            Console.WriteLine(_solution.solution(_videoLen03, _pos03, _poStart03, _opEnd03, _commands03));           //  04:17
        }
    }
    */
}
