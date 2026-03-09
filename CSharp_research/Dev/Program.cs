using Contents;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Reflection;

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // Reflection
        // - 프로그래밍 언어에서 무엇이 반사되어 보일까?
        // 어디에 이 기능을 써 먹을 수 있을까?
        // 설계도를 반사 반영시켜서 안에 있는 정보를 훝어 본다.
        // 이름만 알고 있을 때, 
        // 게임 꼭 필요한 기능. 몬스터 - [전투, 보상, 외형, 사운드, 애니메이션....]
        // 카밀 - 이동기 - 전용 클래스 호출. 어떻게 호출할 수 잇나요?

        // Attribute

        // 에디터 클래스.  Babarian. object.
        // 이름만 알고 있을 때 특정클래스에 접근할 수 있나?

        static void Main(string[] args)
        {
            Item myItem = new Item();
            Type m_type = typeof(Item);
            PropertyInfo property = m_type.GetProperty("ID");

            object nameValue = property.GetValue(myItem);

            Console.WriteLine($"속성 이름 : {property.Name}");

            var myDev = m_type.GetCustomAttribute<DeveloperAttribute>();

            Console.WriteLine($"개발자 : {myDev.Name}, 버전 : {myDev.Version}");

            myItem.PrintName();
        }
    }
}