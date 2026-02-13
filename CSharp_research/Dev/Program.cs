using Contents;
// #include "contents.h"

namespace Dev
{
    // c - c++ - c#
    // C# type safety 

    internal class Program
    {
        // 함수를 심화.

        // [반환] [Main](Param : string[]  args)
        // Main      :  특별한 이름으로 특별한 기능
        // string[]  :  문자열 배열    {"AAAA", "BBBB", "CCCC"} { }
        // Main 붙어있는 parameter를 어떻게 쓰면 좋을까?

        static void Main(string[] args)
        {
            // args 인자가 몇개가 있을까요?
            // size만큼, 정해지지 않음.
            // 인자 0개. 인자를 전달해서 실행하는 방법이 있지 않을까?

            // main이 종료가 안되게 하는 방법?

            // 파일을 실행하라. -v "메모장.txt" 외부 파일 이름 + 확장자 받아온다.
            // 메모장 안에 있는 내용물을 가져오자. 
            // 사용 설명서
            // 방향키 wasd,  키보드 화살표,  ijkl.
            // 메모장. 

            // .bat 이용해서 받아온 문자열을 확장자까지 받아온 다음에
            // 그 확장자를 string 출력을 해보세요.
            // gameSetting.txt -> 이 텍스트 파일을 열어서 안에 있는 데이터를 가져올 수 있을까?

            Console.WriteLine("프로그램 시작!");

            if(args.Length > 0)
            {
                Console.WriteLine($"메인 함수의 매개 변수를 사용해보자 {args[0]}"); // "텍스트"
                string GameSetting = args[0];

                // 원하는 실제 타입으로 변환. 결과물.

            }



            Console.ReadLine();
            //while (true)
            //{
            //   
            //}

        }
    }
}