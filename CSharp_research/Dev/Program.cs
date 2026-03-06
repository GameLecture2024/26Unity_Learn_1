using Contents;
using Newtonsoft.Json;
using System;
using System.Collections;

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        static void Main(string[] args)
        {
            string JsonText = File.ReadAllText("WeaponData.json");
            Console.WriteLine(JsonText);
            string CharacterJson = File.ReadAllText("Character.json");
            Console.WriteLine(CharacterJson);

            // Item.  -> Enum => 무기, 방어구, 소모성 (포션)

            var weaponData = JsonConvert.DeserializeObject<Dictionary<string, BaseAction>>(JsonText);

            List<Character> CharacterDB = JsonConvert.DeserializeObject<List<Character>>(CharacterJson);

            foreach (var item in weaponData)
            {
                string weaponName = item.Key; // 메이스, 대검
                BaseAction info = item.Value; // 내부 상세 데이터

                Console.WriteLine($"무기: {weaponName}, 스킬: {info.ActionName}, 공격력: {info.AttackPower}");
            }

            
            foreach(var character in CharacterDB)
            {
                Console.WriteLine($"직업 : {character.Job} 체력 : {character.hp}");

               // FoundTarget
                // 내가 찾고 싶은 데이터를 찾았으면 이제 이 루프를 종료하세요.
                //if (FoundTarget) break;
                CharacterManager.GetCharacterJob(character);
            }

            // 방어력이 낮은 순의 캐릭터 정렬 집합
            // 조건에 맞춰서 LINQ 작성을 해봐라.
            // 모바일 게임. 수집형 모바일 게임. 필터. 모방. 

            {
                var DefLowerCharacter =
                from x in CharacterDB
                where x.dfe < 50             // 전투력 50이상 캐릭터만    
                orderby x.dfe                // 오름차순  내림차순 ASC  DESC
                select x;

                DefLowerCharacter.ToList();

                foreach(var item in DefLowerCharacter)
                {
                    Console.WriteLine($"{item.Job} : 수치 {item.dfe}");
                }
            }

            // LINQ - 람다식    x => x.def
            // 람다식? { }

            // 행동 속도 턴제. 
            // 속도 다다른 경우 ->가장큰 순서대로 정렬 TurnManager .add [0]

            {
                var tempList = CharacterDB.Where(x => x.dfe < 50)
                           .OrderBy(x => x.dfe)
                           .Select(x => x).ToList();

                foreach (var item in tempList)
                {
                    Console.WriteLine($"{item.Job} : 수치 {item.dfe}");
                }


            }

            // LINQ 왜 쓰나요?
        }         
    }
}