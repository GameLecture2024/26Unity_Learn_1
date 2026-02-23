namespace Contents
{
    // 클래스 만드는 연습. 30분 ~ 1시간.

    // 플레이어 만들어 보겠습니다. 플레이어. 직업을 선택을 할 수 있다.
    // Warrior, Monk, Rich, Marin

    public enum PlayerType
    {
        None,
        Warrior = 1,
        Monk = 2,
        Rich = 3,
        Marin = 4,
    }

    public class Player
    {
        protected PlayerType type;
        protected int hp;
        protected int attackPower;

        protected Player(PlayerType type) // 생성자를 protected 선언한다 ? 무슨 뜻일까? : 자식으로만 생성하고 싶다.
        {
            this.type = type;
        }

        protected void SetInitData(int hp, int attackPower)
        {
            this.hp = hp;
            this.attackPower = attackPower;
        }

        #region 프로퍼티

        public int Hp { get { return hp; } }
        public int AttackPower
        {
            get { return attackPower; }
        }



        #endregion

        public virtual void Test()
        {
            Console.WriteLine("이것은 테스트 함수입니다.");
            Console.WriteLine($"내가 선택한 직업 : {type.ToString()}");
        }

        public virtual void Attack(Player player)
        {

        }

    }

    public class Warrior : Player 
    {
        int warriorStat = 10;

        public Warrior() : base(PlayerType.Warrior)
        {
            SetInitData(100, 10);
        }

        public override void Test()
        {
            base.Test();
           

            Console.WriteLine($"워리어 전용 스탯 : {warriorStat}");
        }
    }

    public class Monk : Player 
    {
        public Monk() : base(PlayerType.Monk)
        {
            SetInitData(90, 8);
        }
    }
    public class Rich : Player 
    {
        // ?? 속성

        public Rich() : base(PlayerType.Rich)
        {
            SetInitData(50, 5);
        }
    }
    public class Marin : Player
    {
        public Marin() : base(PlayerType.Marin)
        {
            SetInitData(80, 15);
        }
    }
}
