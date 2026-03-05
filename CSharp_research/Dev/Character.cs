using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    // Excel to Json
    // Json to class

    // Data전용 클래스 (★★★) 
    // 여기 클래스를 함부로 변경하면 구조가 망가진다. 파이프라인.
    // 이 클래스 절대 바꾸면 안된다? -> 회의.

    public class Character
    {
        [JsonProperty("Job")]
        public string Job { get; set; }

        [JsonProperty("hp")]
        public int hp { get; set; }

        [JsonProperty("attackPower")]
        public int attackPower { get; set; }

        [JsonProperty("dfe")]
        public int dfe { get; set; }

        [JsonProperty("evade")]
        public int evade { get; set; }

        [JsonProperty("crit_dmg")]
        public int crit_dmg { get; set; }

        [JsonProperty("crit_percent")]
        public int crit_percent { get; set; }
    }

    public class Knight : Character { } // W
    public class Archer : Character { }
    public class Magician : Character { }

    public enum CharacterJobType
    {
        W,
        A,
        M
    }

    public class CharacterManager
    {

        public static void GetCharacterJob(Character selectCharacter)
        {
            string typeChecker = selectCharacter.Job; // "W"

            if(Enum.TryParse(typeChecker,true, out CharacterJobType result)) //   Try + Parse :  Try 데이터를 다른 데이터로 바꾸기
            {
                switch (result)
                {
                    case CharacterJobType.W:
                        Console.WriteLine("W");
                        break;
                    case CharacterJobType.A:
                        Console.WriteLine("A");
                        break;
                    case CharacterJobType.M:
                        Console.WriteLine("M");
                        break;
                }
            }
        }

    }
}