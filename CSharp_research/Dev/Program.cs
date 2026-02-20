using Contents;
// #include "contents.h"

namespace Dev
{
    // c - c++ - c#
    // C# type safety 
    // Unit -> Player, Monster를 상속하고 있다.     Npc, Env 뭐를 더 신경을 써야할까?
    // 공통으로 사용하는 기능,속성은 Unit 작성을 하고
    // 개별적으로 사용해야 하는 기능과 속성이 있다면 그 내용을 각자의 클래스 내부에 작성하는 예제를 만들어보세요.
    // 

    internal class Program
    {
        // 복사(copy) 참조(reference)
        // 복사? copy ctrl c + ctrl v 어떤 결과? 모든 내용물이 x2
        // 참조? 주소, 참조자 어떤 차이? 포인터 주소. 포인터의 크기? 8바이트. 어떤 장점? 

        struct SampleItem // 주소 - 8바이트. 객체의 크기가 얼마나 크든 상관없이 8바이트로 저장할 수 있다.
        {
            public int id;              // 4
            public int templateId;      // 4
            public string name;         // string 어떤 타입? char* 주소 - 8 
        }

        class ItemClass : ICloneable 
        {
            public int id;              
            public int templateId;      
            public string name;

            public object Clone()
            {
                return new ItemClass();
            }
        }


        // (Sampleitem id10 ) ctrl c + ctrl v .AddId stack만 존재하는 데이터.
        static void AddId(SampleItem item)
        {
            item.id++;
        }

        // 힙(heap) 저장. 주소 가리키고.
        
        static void AddId(ItemClass item)
        {
            item.id++;
        }

        // class타입, struct타입. 둘 타입을 선택을 해서 함수의 매개변수로 넣어줘야 한다.
        // 기본 타입을 합쳐서 하나의 객체로 표현.
        // 언제 class쓰고 언제 struct쓰면 될까요?
        // - 데이터 변경된 내용을 기억.
        // - struct 결과값 - 크기가 작은 객체를 표현할 때 적합하다. C# value Type. (ctrl c + ctrl v)
        // 토론 disc

        struct GameResult
        {
            int score;
            int maxScore;
            int dateTime;
            string name;
        }

        // struct class Item(x)

        static void Main(string[] args)
        {
            SampleItem item1 = new SampleItem();
            item1.id = 10;
            ItemClass item2 = new ItemClass();
            item2.id = 20;
            Console.WriteLine();

            {
                AddId(item1);
                AddId(item2);

                Console.WriteLine($"아이템1의 아이디 : {item1.id}");
                Console.WriteLine($"아이템2의 아이디 : {item2.id}");

                // 결과    : item1(struct)로 실행한 메서드는 결과가 안변함. item2(class) 결과가 변함.
                // 그 이유 : -
                // 해설    : struct 복사가 발생했다, class는 참조가 발생했다.
                // C# 모든 데이터 타입이 이미 결정되어 있다.
                // struct 태생적으로 value타입, class 태생적으로 class 타입
                // c,c++ class, struct큰 차이 없었다. C# 매우 큰 차이. (★★★★★)

                Type type = typeof(SampleItem); // Isvalue 값타입, 참조 타입
                Type type2 = typeof(ItemClass);
            }

            // 어떤 타입을 힙에 저장해야 하나요?
            // c# 참조 타입은 힙에 메모리가 저장이 된다. 

            // 스택 영역. 
            // c++ new (malloc) 같은가? (x) 객체의 초기화를 진행하라. struct 타입의 초기화를 진행하라. => 생성자.
            SampleItem item3 = new SampleItem(); // 스택. ctrl c ctrl v
            ItemClass item4 = new ItemClass();   // 힙.  item4 스택--> 메모리
                                                 // GC 

            // Garbage Collector (GC)
            // 쓰레기 수집
            // 어떤 방식으로 쓰레기인지 인식? 


            // Shallow copy vs Deep copy
            // 얕은 복사 : 주소를 복사해온다. =>
            // 깊은 복사 : ctrl c + ctr v

            // C# 클래스의 복사가 일어낫을 때 어떤 일이 일어날까요? (S -copy , D - copy)
            // s - 2 , d - 3 => 진짜 그럴까? Debug
            // 클래스 = 클래스; 일어나는 결과 shallow copy

            // 형변환  object. 아무 타입이나 형변환 할 수 있나?

            ItemClass item5 = (ItemClass)(item4.Clone()); // 두 클래스는 사실 같은 힙을 가리킨다. -
                                     // item5의 값을 바꾸면 item4의 정보도 바뀐다.
                                     // item5 신나게 증가시킵니다. item4같이 증가하는거에요?
            item4.id++;
            Console.WriteLine($"item4의 {item4.id}");
            Console.WriteLine($"item5의 {item5.id}");

            // deep copy 어떻게 해야 하나요? (스스로 공부하실 능력)

        }
    }
}