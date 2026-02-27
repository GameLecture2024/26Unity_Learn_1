using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{

    // 구독. 문법.
    // delegate : 대리자, 함수를 인자로 만드는 것. void*(int,int) 함수포인터.
    // 콜백
    // 함수를 매개변수.
    // 함수는 어떻게 정의를 하나요? 함수의 구성 요소?
    // [반환값 ] [ 이름 ][매개변수]  { 바디  }   


    // 1 매개변수의 이름이 반드시 같아야합니다.
    // 2 달라도 된다.

  

    public class Yogiyo
    {

        public delegate int FoodSendService(string FoodName);
        public FoodSendService myFoodService; // 데이터를 저장.

        // Func   : 반환값이 있는/ + 매개변수.
        // Action : 반환값이 없는/ + 매개변수.
        // 파라미터 0개 ~ 16개

        // 비서. 구독서비스 담당. Callback ? 전달해야한다.나랑 연결되어 있는 구독자의 정보.
        // myFood2 = null; => 이 코드의 의미?

        public event Func<string, int> myFood2;
        public event Action<int, int> myTest;
        public event Func<int, int, int> Sum;

        // 무명 함수 : delegate( x ,y) =>

        public void ServiceTest(string foodname)
        {
            myFood2.Invoke(foodname);

        }

        public Yogiyo()
        {
            myFoodService += SendFood;
            myFood2 += SendFood;

            myTest += (x,y)=>Console.WriteLine($"두 숫자의 합 : {x + y}"); // x이름이 아무렇게 지어도 상관이 없습니다.

            Sum += (x,y) => x + y;
        }

        int SendFood(string foodName)
        {

            Console.WriteLine(foodName);

            return 1;
        }
    }
}
