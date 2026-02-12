using Contents;
using System;  // #include "contents.h"

namespace Dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string format
            int day = 0;
            // $ 문자열 보간.
            Console.WriteLine($"Day-{day}");

            // 논리 연산
            // and or

            bool IsCoolTimeFinished = true;
            bool IsResourceEnough = true;
            bool IsRanged = true;
            bool IsAlive = true;

            // bool 조건을 실제로 판별하는 코드

            bool IsSkillAvailabe = IsCoolTimeFinished && IsResourceEnough && IsRanged && IsAlive;

            if (IsSkillAvailabe)
            {

            }

            // 비교 연산

            int monsterDistance = 3;
            int weaponRanged = 5;
            IsRanged = (monsterDistance < weaponRanged);

            // 삼항 연산자

            // 타입 변수 = [ 조건 bool타입] = true false ?   [ 들어갈 타입 ] : [들어갈 타입];

            int count = day > 1 ? 8 : 0;
            Console.WriteLine($"현재 학생 수 : {count}");

            // 산술 연산 
            // + - x * %

            {
                int num = 2 + 3 * 5;
                int dividedCount = num / 3;  // 몫
                int remain = num % 3;

                Console.WriteLine($"몫 : {dividedCount} 나머지 :{remain}");

                // 3 2배곱한 값을 얻을려면 어떻게 하면좋을까?
            }

            // 캐스팅 cast - 형변환
            {
                int hp = 10;
                int maxHp = 20;
                double hpbar = (double)hp / maxHp;

                Console.WriteLine($"현재 체력 바 : {hpbar * 100}%");
                // static_cast
                // 다른 타입의 변환은 어떻게 해야 할까?
                // dynamic_cast -> 클래스. 상속. virtual. => is, as

                // 숫자 -> 문자 바꾸는 방법.
            }

            // 3.  "3" 뭐가 다를까? 주소로 저장된 녀석.
            // 주력 언어. 용어 잘 정리해야한다.
            // 포인터. C# 포인터가 없다. C# 주소를 어떻게 처리할까?
            // object 전부다 시작한다. -> value타입?  reference 타입?
            // int 어떤 타입?     v
            // struct 어떤 타입?  v
            // class 어떤 타입?   r
            {
                Console.WriteLine(3  + 3.ToString());
                Console.WriteLine(3+3);

                Int32 abc = 10;

                // C# object 기본 타입. 뭐든지 될 수 있다.
                // c, C++ => C# 쉽다.
                // struct -> 참조. value선언을 하지도 않았는데 왜 ??

                // C# [박싱 언박싱]   =>  value => 메모리 힙에다가 저장.
                // Generic 박싱 언박싱 비용이 정말 많이 듭니다.
                // stack - 로컬 변수      : { } 소멸
                // heap  - 포인터 쓴 변수 : 남는다. 포인터.
                object o = (object)abc;
                int myInt = (int)o;

            }

        }
    }
}
