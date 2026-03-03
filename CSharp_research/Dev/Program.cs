using Contents;
using System;
using System.Collections;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // 자료구조. 
        // 언제 쓰면 좋을까?
        // 어디에 쓰일까

        // 게임에서 이 자료구조 어디서 쓸까요?
        // 만들고 싶은 기능.



        static void Main(string[] args)
        {
            var SomeDB = WeaponManager.Instance.WeaponDB;

            // STL - Iterator 
            // const auto& it 반복자
            // interface IAttackable

            // for( const ref : 클래스이름)
            // { }

            List<BaseAction> CachedActions = SomeDB["메이스"];

            foreach(var action in CachedActions)
            {
                Console.WriteLine(action.ActionName);
            }

            // 다양한 스킬, 다양한 패턴, 다양한 무기, 다양한 아이템, .. 자료구조.
            // 1개 스킬 1개 패턴 1무기 1아이템.

            // 그 다음에 해야할 것?

            // 필요한 데이터를 어떻게 꺼내올 것인가.
        }         
    }
}