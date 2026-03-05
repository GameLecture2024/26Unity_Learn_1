using Contents;
using Newtonsoft.Json;
using System;
using System.Collections;

namespace Dev
{
    using Player2 = Contents.Player;

    internal class Program
    {
        // 자료구조. 
        // 언제 쓰면 좋을까?
        // 어디에 쓰일까

        // 게임에서 이 자료구조 어디서 쓸까요?
        // 만들고 싶은 기능.



        static void Main(string[] args)
        {

            // Naming Convenction
            // 1. 띄어쓰기 하지맙시다.
            // 2. 영어를한글로표현.데미지.대미지.
            // type - int
            // ID :  1000'0000'1111'0001
            // 이 약속을 어디에 해야할까요?
            // 기존의 데이터를 다른 데이터로 표현하는 것 Parsing.
            // JSON PARSING ( )게임 객체: 
            // JSON Parser
            // 누군가 전달해준 포맷을 받아서 우리에 맞게끔 변형해야한다. (클라이언트)

            // IO  
            // system.IO 어떤 기능을 가져오고 싶다.
            // static - 클래스 이름으로 기능을 가져올 수 있다.
            // 시스템적으로 지원하는 기능. - 공통 기능 집합을 지원한다.
            // ( 전투 ) 시스템 - 누구나 접근할 수 있는 기능. => 전투쪽에서만 접근할 수 있는 공통된 기능.

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

            // 150개. 150개데이터
            // 원하는 데이터만 뽑아오는 방법
            foreach(var character in CharacterDB)
            {
                Console.WriteLine($"직업 : {character.Job} 체력 : {character.hp}");

                // FoundTarget
                // 내가 찾고 싶은 데이터를 찾았으면 이제 이 루프를 종료하세요.
                //if (FoundTarget) break;
                CharacterManager.GetCharacterJob(character);
            }

            // LINQ   -  SQL  
            // Excel Data -> JSON 전달 -> 우리 게임의 Class, struct, List<Class> 변경할 수 있다.
            // 화면에 출력을 해보세요.

        }         
    }
}