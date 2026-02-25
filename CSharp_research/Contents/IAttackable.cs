using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contents
{
    // 인터페이스
    // cpp : virtual void Attack() = 0; 순수 가상 함수 - 자식들이 반드시 이 기능을 포함해라

    // 상속  
    //  - why? 꼭 virtual 표현해야하는가? 
    //  - attack기능이 이 클래스에 반드시 들어가야하는가?
    //  -> virtual vs interface (1순위) 클래스 구조.
    //  - virtual : 다형성. (2순위)

    // 

    public interface IAttackable
    {
        public Stat Stat { get; set; }

        public void Attack(IDamagable damagable);
    }

    public interface IDamagable
    {
        public Stat Stat { get; set; }

        public void Damage(IAttackable attackable);
    }
}
