using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    // Weapon, Armor
    // Potion IStackable

    enum ItemType
    {
        Weapon,
        Armor,
        Consumable
    }

 

    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string Version { get; set; }

        public DeveloperAttribute(string name)
        {
            Name = name;
            Version = "1.0";
        }
    }

    // extension
    // 무슨 기능 같습니까? 
    // 어떤 방법으로? '기존 클래스 유지한채로 코드를 추가하는 방법'
    // 언제 사용할 수 있을까?

    public static class ItemExtensions // public static class 확장클래스이름extensions
    {
        public static void PrintName(this Item item)
        {
            Console.WriteLine($"커스텀 이름 호출{item.Name}");
        }
    }

    [Developer("개발자", Version = "1.0")] // attribute 클래스. 특별한 기능을 하는 클래스.
    public class Item
    {
        ItemType itemType;
        int id;
        string name;
        string descript;

        public string Name => name;

        public int ID => id;
    }

    public class WeaponItem : Item
    {
        public WeaponItem()
        {
            // 생성자에서 반드시 미리 해줘야할 것. JSON 데이터 분할.

        }
    }


    // Item  무기 가질 속성, 방어구 속성, 소비아이템 속성
    // WeaponItem, ArmorItem, ConsumableItem
    // 클래스 분할, 분할한 클래스가 고유의 기능을 갖는가?
}
