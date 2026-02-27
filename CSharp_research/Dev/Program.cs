using Contents;
using System;
using System.Collections;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // 람다식 : 함수를 { } 생략해서 표현할 수 있는 방법.
        // Delegate
        // Func Action
        // Event

        // 왜 써야하나요? 
        // 함수를 인자로 전달하는 녀석. 이게 가능하면 무엇을 할 수 있을까?
        // 정렬. 어떤 순서? 수. 1 30 5 9 (방식 = 오름차순)
        // Sort (    EQuery. 함수 )

        // delegate 쓰기 너무 어렵다. 쫌 쉽게 사용하는 방법을 지원해줘.


        static void Main(string[] args)
        {          
            Yogiyo yogiyo = new Yogiyo();
            yogiyo.myFoodService("피자");
            yogiyo.ServiceTest("치킨");

        }         
    }
}