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

    public enum ElementType
    {
        Fire,
        Ice,
        Rock,
    }

    // int x int y (좌표) => Pos {int, int}
    
    public class Stat
    {
        public int hp;
        public int attackPower;
        public int def;
        public int evade;
        public int crit_dmg;
        public int crit_percent;
        public ElementType elementType;
    }

    public class DamageProcessor // Helper class
    {
        public Stat attackerStat;
        public Stat damagerStat;
        public DamageProcessor(Stat attackerStat, Stat damagerStat)
        {
            this.attackerStat = attackerStat;
            this.damagerStat = damagerStat;
        }

        public static void Process(Stat attackerStat, Stat damagerStat) // 선택
        {
            bool isEvade;
            bool isCrit;

            // 1. 회피 판정을 먼저 체크한다.
            isEvade = false;
            // 2. 크리티컬 판정
            if(isEvade)
            {
                return;
            }
            isCrit = true;
            // 3. 데미지를 적용해라.
            int finalDmg = 10;
            finalDmg = isCrit ? finalDmg * attackerStat.crit_dmg : finalDmg;

            Console.WriteLine($"최종 데미지 : {finalDmg}");
            //Damage(finalDmg);

        }
    }

    public class Player
    {
        // 방어력, 회피
        // 치명타 데미지, 치명타 확률 
        // 속성 - 
        // 플레이어가 복수의 스탯을 가질 수 있나?
        // 실수의 단점. 위험한 점. 
        // 정수로 실수를 표현하는 방식.
        // 다른 타입이면 자료구조 묶을 수 없나요? - (1) 포기한다 (2) 방법을 찾는다.
        protected Stat stat;
        protected PlayerType type;

        protected Player(PlayerType type) // 생성자를 protected 선언한다 ? 무슨 뜻일까? : 자식으로만 생성하고 싶다.
        {
            this.type = type;
        }

        protected void SetInitData(Stat stat)
        {
            this.stat = stat;
        }

        #region 프로퍼티

        public int Hp { get { return stat.hp; } }
        public int AttackPower
        {
            get { return stat.attackPower; }
        }



        #endregion

        public virtual void Test()
        {
            Console.WriteLine("이것은 테스트 함수입니다.");
            Console.WriteLine($"내가 선택한 직업 : {type.ToString()}");

            Console.WriteLine($"체력 : {Hp}, 공격력 : {AttackPower}");
        }

        public virtual void Attack(Player target)
        {        
            DamageProcessor.Process(stat, target.stat);
        }

    }

    public class Warrior : Player 
    {
        int warriorStat = 10;

        public Warrior() : base(PlayerType.Warrior)
        {
            Stat stat = new Stat();
            stat.attackPower = 10;
            stat.hp = 100;
            stat.crit_dmg = 2;
            SetInitData(stat);
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
            Stat stat = new Stat();
            stat.attackPower = 8;
            stat.hp = 90;

            SetInitData(stat);
        }
    }
    public class Rich : Player 
    {
        // ?? 속성

        public Rich() : base(PlayerType.Rich)
        {
            Stat stat = new Stat();
            stat.attackPower = 5;
            stat.hp = 50;

            SetInitData(stat);
        }
    }
    public class Marin : Player
    {
        public Marin() : base(PlayerType.Marin)
        {
            Stat stat = new Stat();
            stat.attackPower = 15;
            stat.hp = 80;

            SetInitData(stat);
        }
    }
}
