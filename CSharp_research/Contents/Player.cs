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

        public int Hp { get { return hp; } }
        public int AttackPower
        {
            get { return attackPower; }
        }

    }

    public class Warrior : Player 
    {
        public Warrior() : base(PlayerType.Warrior)
        {
            SetInitData(100, 10);
        }
    }
}
