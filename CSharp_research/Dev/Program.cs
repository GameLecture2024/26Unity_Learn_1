using Contents;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // namespace 관련된 키워드

        // 과제 1. 메인 로직에서 if, switch 조건문을 사용하여 플레이어의 직업을 선택하는 로직 만든다.
        // 과제 2. 플레이어 만든 실제 hp, ap 데이터를 어떻게 처리하는 것이 더 효율적인지 고민.
        // [ 기획    ] [프로그래밍  ]

        static void Main(string[] args)
        {
            //Player2 p = new Player2();

            Warrior warrior = new Warrior();
            Monk monk = new Monk();
            Rich rich = new Rich();
            Marin marin = new Marin();
            // Marin, Monk, Rich

            Console.WriteLine($"체력: {marin.Hp} 공격력: {marin.AttackPower}"); 

            // GameManager
            // BattleManager
        }    
        
    }
}