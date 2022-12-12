﻿// 키워드 (예약어)
// 미리 예약되어 있는 (정의되어있는) 단어
// 시스템에서 정의 되어 있기 때문에 사용자가 임의로 동일한 이름을 사용할 수 없다.

// using 키워드
// 무언가(namespace)를 사용하겠다고 선언하는 키워드
using System;

// namespace 키워드
// 이름으로 공간을 분리하는 키워드
namespace First_program
{
    // internal - 접근제한자
    // 동일 어셈블리 내에서만 접근 가능한 제한자.

    // class - class 타입 정의 키워드
    // class 의 멤버들을 정의함
    // 멤버: 클래스를 구성하는 구성원
    // 형식 :
    // class 클래스이름
    // {
    //   멤버 정의
    // }


    internal class Program
    {
        // Main 함수
        // 함수 형태
        // 반환형 함수이름(매개변수1타입 매개변수1이름, 매개변수,2타입 매개변수2 이름 ... )
        // {
        //       함수 연산
        //       return 반환값
        // }
        //
        // void : 반환값의 형태가 없다는 뜻
        // argument : (인자) : 매개변수에 대입할 값

        // static : 정적 키워드
        // static <-> dynamic
        // static 의 의미 : 런타임중에 메모리에 할당 할 수 없다. 동적(런타입에서)으로 생성할 수 없다.객체화가 불가능하다. 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            return;
        }
    }
}