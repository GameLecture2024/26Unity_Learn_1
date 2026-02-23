using Contents;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // static 키워드
        // 다형성
        // is as 형변환

        // 클래스에 귀속이 되어 있는 함수.
        // 멤버 (member) 함수

        // 클래스 왜 사용하는가?
        // 붕어빵 틀 : 클래스
        // 붕어빵 : 인스턴스
        // 붕어빵 10개가 나왔다. [  5  ]  [  5 ] 소스를 뿌르는 행위

        // 플레이어. 몬스터.
        // 플레이어 클래스 만들면 어떻게 사용할 수 있을까?
        // 유닛.

        // 어떻게 이 문제를 해결할 수 있을까? - 관리자를 하나만 사용하기 위한 방법이 있을까?
         
        // 데이터를 설명하는 클래스. -> player 상속받는 클래스.
        // 데이터 처리하는 클래스 -> GameManager, Handler  


         static void Main(string[] args)
         {
            Warrior warrior = new Warrior();
            Warrior warrior2 = new Warrior();

            // 특별히 다뤄야 할 주제
            // 왜 관리를 한명이 해야할까요?

            // 관리자 2명. 1게임 관리자 2명이 거입니다.
            //     GM
            // A   vs    B
            // 함수 static 선언했더니. 클래스 이름 만으로 호출이 가능해졌다.
            Player2 myPlayer = GameManager.Instance.SelectPlayerType();

            // 다형성 성질을 갖도록 코드를 작성을 해라.
            // 형태는 같은데 결과가 다르다. 실행이 되도록.

            GameManager.Instance.Test(myPlayer);  // if(myPlayer !=null) 실행하라.



        }    
        
    }
}