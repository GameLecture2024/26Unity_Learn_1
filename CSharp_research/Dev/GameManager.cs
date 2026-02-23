using Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    // 관리자 클래스. 1개만 있으면 좋을 것 같다. 싱글톤 패턴.
    // static void 함수이름();
    public class GameManager
    {
        // 전투 전 세팅

        public static GameManager Instance = new GameManager();

        private GameManager() { }

        // SelectPlayerType 어떤 결과? 해당 타입에 맞는 플레이어가 생성이되어야 한다.
        public Contents.Player SelectPlayerType()
        {
            // playerType 열거헝.  숫자.  숫자->enum 변환 그 클래스 생성.
            Console.WriteLine("플레이어를 선택하세요 (1)W (2)M (3)R (4)Marin");
            string num = Console.ReadLine(); // Console무엇이고 ReadLine()은 무엇인가요?

            int selectedNum = int.Parse(num);

           
            
            PlayerType selectType = (PlayerType)selectedNum;

            // if type monk, warrior.. 자신들의 객체를 만들어라.

            if(selectType == PlayerType.Warrior)
            {
                return new Warrior();
            }
            else if(selectType == PlayerType.Monk)
            {
                return new Monk();
            }
            else if(selectType == PlayerType.Rich)
            {
                return new Rich();
            }
            else if(selectType == PlayerType.Marin)
            {
                return new Marin();
            }

            return null;
        }


        // 전투
        public void Test(Contents.Player player)
        {
            // Player클래스 함수 내부에서 값을 정하는게 아니라.
            // Manager가 플레이어의 타입에 따라 코드를 작성하고 싶다면 어떻게 해야할까?
            // Type. 타입으로 뭘 할 수 있을까요?

            // is : A is B     B의 타입을 A로 변환할 수 있으면? true : false
            // as : A as B     A의 타입으로 B로 변환해라. 변환이 불가능하면 null

            if(player is Warrior)
            {
                // 너는 매니저가 특별히 전사에게만 특별한 코드를 선물해줄게.
                Console.WriteLine("매니저가 전사에게 선물합니다.");
            }

            Monk mMonk = player as Monk;
            if(mMonk != null)
            {
                Console.WriteLine("매니저가 몽크에게 선물합니다.");
            }

            player?.Test();
        }

        // enum - 근접 공격, 원거리 공격
        // 너의 공격이 근접 공격이? 근접 공격으로 코드를 실행하라
        // 원거리 공격? 원거리 공격으로 코드를 실행하라
        // 사거리 어떻게 표현?

    }
}
