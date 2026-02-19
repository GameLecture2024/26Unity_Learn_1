using Contents;
// #include "contents.h"

namespace Dev
{
    // c - c++ - c#
    // C# type safety 
    // Unit -> Player, Monster를 상속하고 있다.     Npc, Env 뭐를 더 신경을 써야할까?
    // 공통으로 사용하는 기능,속성은 Unit 작성을 하고
    // 개별적으로 사용해야 하는 기능과 속성이 있다면 그 내용을 각자의 클래스 내부에 작성하는 예제를 만들어보세요.
    // 

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100,10);  // A 체력 100 공격력 10          
            Monster slime = new Monster(50,5);  // B 체력 50 공격력 5

            player.Attack(slime);
            player.Attack(slime);


            player.lvUp(); // 
            slime.lvUp();

        }
    }
}