using Contents;
using System.Security.Cryptography;
// #include "contents.h"

namespace Dev
{
    internal class Program
    {
        public enum MonsterType
        {
            HUMAN,
            ROBOT
        }

        static MonsterType _monsterType;


        // C# 왜 개발했나? 플랫폼 문제 해결.

        static void Main(string[] args)
        {
            // 필요한 코드를 작성하려면 #include..
            // 기본 내장이 되어있다. 시스템 경로. Windows.kit < >  " "
            // .Net 8 - 프레임 워크
            // 실제 코드 뭉치들. 
            // 엔진( ) - 너가 비용주고 써 vs open source
            // 컨텐츠 개발.

            // object
            {
                // 메모리 사용. reference 타입 - heap 저장.
                
                // Garbage Collector  (GC)
                // heap - 더 이상 사용하지 못하는 정보를 관측해서 지운다.
                // GC가 쓰레기값을 인지하는 방법이 무엇일까? [ stack  ]     [ heap ]
                // stack에서 heap가리키지 않고 있다. 
                // GC 지원하는 언어. managed language (포인터 안씀)
                // 포인터. 참조타입을 마구잡이로 막 써도 되나? 안되겠다. -> [1  ]  [  ]  [  ]  [  ]
            }

            // 배열 - 자료구조
            // 왜 쓰는가? 

            {
                int[] array2 = new int[] { 1, 2 };
                int[] array3 = new int[100];
                int[,] d2array = new int[10, 10];
            }

            // 자료의 흐름. 
            
            {
                // 어떻게 사용해? 
                // 반복문 하지뭐.
                // 배열이 가져야 할 변수. 너가 지금 몇개나 가지고 있니? size();

                int[] array2 = { 1, 2, 3 };

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine($"[{i+1}]번째 배열의 값 : {array2[i]}");
                }

                
            }

            // 조건문 반복문

            // if, else
            // switch
            // 1> switch 값이 딱 떨어질 때 쓰자.
            // num 0,1,2 => enum
            {
                switch (_monsterType)
                {
                    case MonsterType.HUMAN:
                        break;
                    case MonsterType.ROBOT:
                        break;
                }
            }
            // 반복문
            {

                int count = 1;
                
                // 초기화가 필요한 코드.
                do
                {
                    Console.WriteLine("코드 실행");
                    // 그러한 코드를 작성을 하라.
                } while (count > 2);

            }

            // eunm(열거형) 상수형
            {

                // enum을 왜 쓰는가?
                // 전부다 상수로 표현하니간 비슷한대, 이름이 겹치는 문제가 생긴다.

                Console.WriteLine($"나의 몬스터 타입 : {_monsterType.ToString()}"); 
                
                string Name = _monsterType.ToString();

                // 에디터 툴. 타입. 문자열 전달해가지고 알아서 판별하는 코드.

            }

        }
    }
}