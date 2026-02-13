using Contents;
using static System.Net.Mime.MediaTypeNames;

// #include "contents.h"

namespace Dev
{
    // c - c++ - c#
    // C# type safety 

    internal class Program
    {
        static void Main(string[] args)
        {
            // 함수   (Function) cpp
            // 외부에서 독립적으로 사용 - 전역
            // 메서드 (method) c#
            // 클래스 내부에 있는 함수  - 집합
            {
                Study();
            }
        }


        // 이 코드를 함수로 만들어야 하나요?
        private static void Study()
        {
            // 함수 사용
            // Game Play.. 
            // Game Data.. money.
            int money = 1000;
            float modifier = 3.1341345f;
            Test();
            money = Test2(money);
            Console.WriteLine($"함수 오버로딩 테스트 : {Test2(15.15f)}");
            Console.WriteLine($"실행 중인 상태의 돈의 크기 : {money}");
            float f_res = 0;
            money = Test3(money, modifier, out f_res);
            Console.WriteLine($"소수점 결과 값 : {f_res}");
        }

        // 함수 선언
        // override 다른거
        // 오버로딩? overload
        static void Test()
        {
            Console.WriteLine("반환 값이 없는 함수.");
        }

        // int money = money;
        // 포인터. 메모리에 접근해서 값을 바꾸면 되겠다. 이 언어에서는 이 방법을 어떻게 사용하는가? => ref, out
        static int Test2(int money)
        {
            int ret = 0;

            ret = money;
            ret *= 2;

            // 할 것을 한다.
            Console.WriteLine($"출력 : {ret}");

            return ret;
        }

        static float Test2(float money)
        {
            float ret = 0;

            ret = money;
            ret *= 2;

            // 할 것을 한다.
            Console.WriteLine($"출력 : {ret}");

            return ret;
        }

        // 계산 결과 중에 실제로 소수점 (float) 표현된 값도 우리가 알고 싶다.
        // ref vs out : 매개변수로 받은 타입을 반환할 수 있게 하는 문법. 메모리에 접근해서 값을 바꾸는. 
        // out : 너가 함수안에서 어떻게든 바꾼 값을 다시 쓸거라고 생각해서 만든거다. 


        static int Test3(int money, float modifier, out float f_res)
        {
            int ret = 0;

            ret = money;
            float temp = money * modifier;
            f_res = temp;
            ret = (int)temp;

            // 할 것을 한다.
            Console.WriteLine($"초기 값 : {money} 가중치 : {modifier}, 최종 값[내림] : {ret}");

            return ret;
        }


        // 함수를 왜 써야하는가? Why
        // 재사용성. 반복적으로 작성하는 statement 함수로 만들어서 다시 쓸 수 있게 만든다.
        // 어떤걸 함수로 만들어야 할까? What 
        // 
    }
}