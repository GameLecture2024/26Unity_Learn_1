using Contents;
using System;
using System.Collections;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // 람다식
        // 자료구조
        // foreach
        static void Main(string[] args)
        {
            // SomeFunc : 함수 인자가 int가 2개이고 ruturn 타입이 int인 함수를 인자로 받겠다.
            // skill.Add
            // () 3 + 4 <<= add 함수를 만들어야해요?
            // 함수 인자로 받는 타입. 함수가 아닌 상태로 넘길 수 있을까? 람다식
            // 회사 기본으로 원하는 실력.
            Skill.SomeFunc((a, b) => a+b, 5, 10);
        }         
    }
}