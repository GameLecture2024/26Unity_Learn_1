using Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Dev
{
    // 스킬을 하드코딩으로 만든다.

    // 다리우스. Q W E R 
    // 타입, 계수, 물리, 마법, 사용하는 캐릭터. 

    // 스킬의 판정을 어떻게 해야하는가?
    // 스킬의 펙트는 어떻게 해야하는가?
    // 스킬을 사용하는 사운드는?

    // 가렌의 스킬은 사운드와 이펙트.

    // 모든 캐릭터는 스킬 [에 사운드와 이펙트를 가진다.] 붕어빵틀
    // 가렌은 고유한 스킬을 가진다.
    // class 붕어빵틀 Instance

    // q스킬 : 반원. 작은원 () ( ) 테두리원( )
    // 롤에서 챔피언 스킬을 왜 쓰나? 데미지를 주기 위해서. 

    // 기획 숫자 데이터를 만들었다 -> 

    // (1) 자기가 직접 코딩한다 - 기획자 AI 니가해
    // (2) 개발자님 만들어줘.

    // 밸런싱. 엑셀 -> export. xlsx// 엑셀->JSON 
    // 기획. .xlsx 데이터로 테스트해주세요.
    // (1) json으로 만들어주세요 요청한다
    // (2) 내가 json으로 만들어서 한다.(

    // 스킬
    // - data가 존재한다. /*데이터 영역*/을 분리한다.
    // - 붕어빵 틀. 스킬을 실제로 게임에 표현할 수 있는 공통적인 내용. 
    // 패시브1개 스킬 3개 궁극기 1개
    // [child skill sub skill]스킬 이펙트, 스킬 사운드
    // - 가렌 스킬 QWER 패시브. ( instance)

    public class Skill
    {
        int coolTime;
        int AttackPower;
        int Range;

        // 문 Statement
        // 람다식. 프로퍼티에서만 사용하나요?

        int CoolTime 
        {
            get => coolTime;           
            set => coolTime = value;
        }

        public static void SomeFunc(Func<int,int,int> Test, int a, int b)
        {
            string print = $"함수에서 두 수를 더해서 출력 : {Test.Invoke(a, b)}";

            Console.WriteLine(print); 
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 람다식 : 함수를 중괄호 없이 표현한다.
        // 특별한 계산이 다끝나고가서 A B 타입. A+B;
        // 함수 포인터. 

    }

    public class DariusSkill : Skill 
    {

    }

    
}
