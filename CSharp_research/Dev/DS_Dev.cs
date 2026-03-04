using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    // 자료구조 Data Structure
    // 게임의 모든 요소에 전부 들어갈 수 있다.

    // ~Begin Soul
    class BaseAction
    {
        // 이 액션을 트리거 됐다. 총 방아쇠
        // Binding - Key
        [JsonProperty("ActionName")]
        public string ActionName { get; set; }
        [JsonProperty("AttackPower")]
        public int AttackPower { get; set; }
        public void OnActivate()
        {

        }

        public BaseAction(string actionName)
        {
            ActionName = actionName;
        }
    }


    // Excel - JSON 추출.
    // 데이터 -> 메모리 저장.
    // 무기만 action을 가지고 있어야 한다. has-A
    class WeaponManager
    {
        public static WeaponManager Instance = new WeaponManager();

        Dictionary<string, List<BaseAction>> Weapons = new Dictionary<string, List<BaseAction>>();

        public Dictionary<string, List<BaseAction>> WeaponDB => Weapons;

        public WeaponManager()
        {
            // Key
            string tempName = "메이스";
            // Value

            List<BaseAction> tempActions = new List<BaseAction>();

            BaseAction tempAction = new BaseAction("데미지경감액션");
            BaseAction tempAction2 = new BaseAction("강력한휘두르기액션");

            tempActions.Add(tempAction);
            tempActions.Add(tempAction2);

            Weapons.Add(tempName, tempActions);

            // 메이스 무기. 데미지 경감 액션 1개밖에 스킬을 가지고 있지 않다. 
        }
    }

    class WeaponBase
    {
        List<BaseAction> WeaponSkills = new List<BaseAction>();   // 무기가 가지고 있는 스킬s
        public string name;
        // 무기 마다 데이터가 다르다. 기획자 데이터 시트를 만들어서 전달. 엑셀. JSON. XML.

        public WeaponBase(string name)
        {
            this.name = name;
        }

    }

    // ~End Soul

    public class DS_Dev
    {
        // 소울, 버프 디버프 , 턴제

        // 전투. - 플레이어가 할 수 있는 행동 (action)
        // WASD 이동
        // space 구르기

        // 강공격 
        // 약공격
        // 무기에 들어있는 스킬 

        List<BaseAction> MustHaveActions = new List<BaseAction>();
        List<BaseAction> ActionsAsCondition = new List<BaseAction>();

        /*
         *  가변배열 List. Dictionary
         *  vector. push_back            [ ] [ ] [ ] [ ][ ] [ ] [ ]
         */

        // 배열. 
        // 고정 배열 잘안쓰는 편. 

        // 조건에 따라 바뀌는 액션 배열은 고정 배열로 하면 안된다.

        // 현재 장착한 무기   - 무기 전용 스킬


        // 현재 선택된 캐릭터 - 캐릭터 전용 스킬


        public DS_Dev()
        {
            MustHaveActions.Add(new BaseAction("이동"));
            MustHaveActions.Add(new BaseAction("구르기"));

            ActionsAsCondition.Add(new BaseAction("강공격"));
            ActionsAsCondition.Add(new BaseAction("약공격"));
            ActionsAsCondition.Add(new BaseAction("무기에 따른 스킬"));
        }
    }
}
