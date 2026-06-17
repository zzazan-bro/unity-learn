using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour 
{

    int num = 0; // -> 1항 규칙 대채식 표기값 이미 할당했음 넘은 0으로
        void Start()
    {
        for(int i = 0; i <10; i++)
        {
             num =i;
            print(num);
           
        }

      //  print(num++); -> for(타입선언 변수이름 = 0-> 0부터 ; i<10 -> i가 10보다 작을때까지반복함 i++->자신에게 계속 1을 더함 * 1항과 2항 3항은 필수아님)
        //print(num++); 이렇게 10번 반복할거를 그냥 for반복문 한줄로 끝낼수있음
       // print(num++); 필수아닐때 작성법
       // for( ; ; )
       //{ if(num>=10)
       //   break;-> 위 두줄은 2항 규칙 대채식 넘이 10보다같거나 크면 반복문or조건문 빠져나가기
       //print(num;)
       //   num +=2; -> 3항 규칙대체식}
       // print(num++);

    }
    void Strat()
    {
        
        for( ; ; )

        num++

        if(num % 2 ==0)
        continue; // 해당 회차를 끝냄.

        pirnt(num);

        if (num >10)
        break; // 첫번째 반복문 또는 조건문 탈출

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
