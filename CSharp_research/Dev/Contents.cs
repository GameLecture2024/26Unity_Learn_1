using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    // 우리가 하고 있는 작업. 프로그래밍이 시작할 때 중요하다.

    // 오늘 뭐할까? -> "공격 기능을 만들어 봅시다" -> 작업 지시서 

    // ?? 게임에서 작동하는 기능을 만들겠다. ??
    // (1) 이름 짓기
    // (2) <attribute> 속성 <method>기능
    // (3) 속성 - 프로퍼티 설정을 해주기.

    // Attack(공격하는 대상이 누구인지, 누구를 공격하는지);
    // Class->Attack( (this), 누구를 공격하는지)

    // Player, Enemy, NPC

    // 문법적. ctrl + c / ctrl + v 똑같은 기능을 가진 player 만들어지는.
    // 상속.  

    public class Unit // 객체. 게임에 필요한 데이터 프로그래머가 설계.
    {
        private int _hp; // Unit 객체 정수형 타입의 이름이 hp인 데이터를 갖는다.
        private int _attackPower;
        private int _level;

        // 공격을 하려면 어떤 정보가 필요해요?
        // 공격력 attack 어떤?
        // 나의 정보  : struct Attacker    ->M  ->N ->env  N->P n-<>  100갯수
        // 상대의 정보 : struct Damaged

        // 생성자. 왜 쓰면 좋은가?

        // 빠른 생성자 구현 단축키 ctor 텝.
        // 생성자에서 기본 값을 초기화하고 싶은 속성을 드래그해서 빠른 작업 및 리팩토링 실행시킨다.

        public Unit(int hp, int attackPower)
        {
            _hp = hp;
            _attackPower = attackPower;
        }


        #region 프로퍼티
        // private 선언한 속성값을 외부에서 사용할 수 있게 노출시키기.
        // 프로퍼티. C#에 있는 문법, public [타입] 이름<대문자 이름>{get }

        public int Hp 
        {
            get { return _hp; }
            set { _hp = value; } 
        }
        public int AttackPower 
        {
            get { return _attackPower; }
            set { _attackPower = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
    

        #endregion

        // 체력, 공격력 모든 걸 표현할 수 있나요?
        // 또 어떠한 속성을 추가해야 여러분이 원하는 전투를 구현할 수 가 있을것 같습니까? <1> 직접 데이터를 선언할 수 있는가?
        // 새로운 속성을 추가했다면 무엇이 또 반복이 되는가?

        public void Attack(Unit damagedUnit)
        {          
            damagedUnit.Hp -= AttackPower;

            Console.WriteLine($"현재 적 유닛 체력 : {damagedUnit.Hp}");

            //damagedUnit._hp = 0; // (1) 이 코드를 작성한 사람 나와. (2) 컴파일러가 이 수정을 못하게 막는다.
        }

        // 경험치 로직 exp 데이터


        public void lvUp()
        {
            LevelUp();
        }

        protected virtual void LevelUp()
        {
            Level++;

            // 이펙트.
            // 사운드
            // 
        }
    }

    class Player : Unit
    {
        bool _equippedItem; // Item -> Stat -> 영향

        int levelModifier = 3;

        public Player(int hp, int attackPower) : base(hp, attackPower)
        {
        }

        protected override void LevelUp() // override 키워드 사용하는 이유?
        {
            base.LevelUp(); // 공통적으로 레벨업에서 해야할 코드.

            //
            AttackPower *= levelModifier;
            Hp *= levelModifier;
        }
    }

    class Monster : Unit
    {
        string droppedItemName;

        public Monster(int hp, int attackPower) : base(hp, attackPower)
        {
        }

        protected override void LevelUp()
        {
            base.LevelUp();
        }
    }
}
