using Contents;
using System;  // #include "contents.h"

namespace Dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 한글. -> Encoding -> EUC_KR(949) 사인UTF-8(65001) 
            // 글 -> github 

            GameData gameData = new GameData();
            gameData._hp = 10;
            gameData._level = 1;
            gameData._templateID = 15;

            // 데이터 형식
            // 1. 정수

            {
                int a = 100;    // 4바이트 8비트 = 32
                Int64 ab = 50;
            }

            // 2. 실수 부동소수점.
            // 추정치 표현 값. 최대의 소수점까지만 표현한다. 1/3 = 0.333333|   3333  |무한.
            {
                float a = 3.14f;
                double ab = 3.14;

                if(a == ab)
                {
                    Console.WriteLine("같다");
                }
                else
                {
                    Console.WriteLine("다르다");
                }

                // 실수의 계산과 정수의 계산을 비교하는 행위 실수의 원인이 된다.
                if (2 == 1.9 + 0.1) ;  // 1.90000000000000001 0.10000000000000000001 = 2.00000000001
            }

            // 3. 불리언 (boolean)
            // 게임 사용. 어떤 식으로 사용하면 좋을까?
           
            {
                bool isQuestComplete = false;  // 선언 파트   

                /*
                 *  퀘스트를 클리어 했다. 코드
                 */
                isQuestComplete = true; //  사용 파트

                if (isQuestComplete)
                {
                    Console.WriteLine("퀘스트 클리어");
                }
            }

            // 4. 문자열 string
            // C# -> c++ -> C# 똑같다.
            // 조건을 만족했다. c++ 개발자 자유도 많다. vs c# Fixed, 
            // 암기를 하려는 사람들이 아니다.
            // char x 10 =  10.  -> 20
            // 1바이트.128개 2바이트. 32,767 
            // 포인터 사용 하지마! << 버그. 접근할 수 없어야 하는 코드. 포인터로 접근을 해서 사용. 
            // stack, heap 참조 타입, 값 타입. CPU 너 몰라도 돼. => 두고두고 설명.

            // 문자열 보간. 

            {
                char a = 'a';

                Console.WriteLine(sizeof(char));

                string name = "aabbcc";
                
                Console.WriteLine("이름 출력 : " + name);

                // printf(" %f ", name)
                // 이게 어떻게 가능하지? 실력을 판단. 

                Console.WriteLine(string.Format("이름 {0} 출력 : ", name)); 
                Console.WriteLine($"이름 출력 : {name}");

            }

        }

        // namespace
        // My.이순신  2번.이순신      이순신님 있으신가요?  구별하는 방법?  
    }
}
