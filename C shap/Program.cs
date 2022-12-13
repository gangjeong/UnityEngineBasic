using System;
using System.Runtime.InteropServices;

// Function : 연산을 수행할 수 있는 기능
// Method : 객체/클래스 단위로 호출되는 Function (⊃ 멤버 함수)
// Method ⊂ Function
//
// 함수 형태 3가지
// 함수 선언, 정의, 호출
// 함수 선언 : 아래 형태와같은 함수를 사용하겠다 라고만 선언하는 것이고, 실제 함수가 어떤 연샨을 하는지 구현부분이 없음.
// 변환형 함수이름 (피라미티);
//
// 함수 정의 :
// 변환형 함수이름 (피라미티)
// {
//      연산
//      return;
// }
// 함수 호출 :
// 함수 이름 (인자);
namespace Method
{
    class Program
    {
        static bool __helloworldPrinted;

        // 여기서 Main 함수는 함수 정의
        static void Main (string[] args)
        {
            PrintHelloWorld();
            string name = "dfdf";
            PrintSomthing(name);
        }

        static void PrintHelloWorld()
        {
            // 여기 Console,writeLine 은 함수 호출
            Console.WriteLine("Hello World!");
            __helloworldPrinted = true;
        }
        static void PrintSomthing (string something)
        {
            Console.WriteLine(something);
        }

    }
}
