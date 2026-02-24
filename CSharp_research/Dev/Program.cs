using Contents;
using System;
using System.Collections;
// #include "contents.h"

namespace Dev
{
    using Player2 = Contents.Player;



    internal class Program
    {
        static void Main(string[] args)
        {
            // C# 자료구조 
            // 벡터 : 크기와 방향
            // 타입(클래스) 변수이름; 의미하는 바가 무엇일까요? 
            // 왼쪽 무엇' = ' 오른쪽 무엇   메모리.

            // 문제점? 주소. 주소가 진짜 가리키는 것이 없다. nul
            List<int> numList = new List<int>();

            numList.Add(1);

            numList.Add(2);
            numList.Add(3);

            for(int i =0; i < numList.Count; i++)
            {
                Console.Write($"{numList[i]} ,"); 
            }

            // ArrayList 정수, 실수, 문자열 전부 저장할 수 있는 타입. 가능한가요?

            ArrayList arrayList = new ArrayList();


            // 모든 타입으로 변할 수 있는 메타몽. object
            // object로 이루어진 모든 데이터 더미.

            arrayList.Add(1);     // int32 value type   -> ref type 
            arrayList.Add(0.1f);  // float value type   -> ref type
            arrayList.Add("Hello World"); // ref type

            // object.
            // ArrayList  List<T>
            // 알고리즘 (1) 선택 (2) 이유
            // List<T> 더 빠르기 때문이다.
            // object 느리다.
            // object 왜 느릴까요?
            // 힙 메모리 X  [ 주소 변환]         ->  [  힙 ]  Boxing
            //               본연의 데이터 변환  <-   object      UnBoxing

            // 박싱과 언박싱

            // int 타입을 object 타입으로 변환 (박싱)
            // object 타입 int 타입 변환 (언박싱)

            int testint = 10;
            object someObj = (object)testint;  // 박싱

            Console.WriteLine($"testint : {(int)someObj}"); 

            // 

            Console.WriteLine();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write($"{arrayList[i]} ,");
            }


            List<float> floatList = new List<float>();

            floatList.Add(0.1f);
            floatList.Add(0.2f);
            floatList.Add(0.3f);
            Console.WriteLine();
            for (int i = 0; i < floatList.Count; i++)
            {
                Console.Write($"{floatList[i]} ,");
            }


           Player2 myPlayer = GameManager.Instance.SelectPlayerType();
           Player2 myPlayer2 = GameManager.Instance.SelectPlayerType();
           GameManager.Instance.Test(myPlayer);

            myPlayer.Attack(myPlayer2);

        }    
        
    }
}