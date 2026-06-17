using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour 
{

    int input = 11;
    int num = 10;
    bool result;

  //switch 조건문 -> switch선언 (변수) 아래줄 케이스 : -> 세미콜론 아니고, 콜론붙이고 아랫줄에 프린트값적고 아랫줄에 break로 탈출하기
  //if문의 else 대신에 defalut:를 사용함
  //if 조건문 -> if선언 (변수 조건연산자 [==, > , < !=등]) 아랫줄에 프린트() 효율적으로 하기위해 if를 난사하지말고 else if로 다음조건을 적으면 조건에 맞을때까지만 연산함
  //모두 if로한다면 맞아도 끝까지 if에 해당하는게있는지 연산하므로 비효율적임
  
  //3항 연산자 temp = 변수 조건연산자 변수 ? 트루출력값 : 폴스출력값 ; 
  // 변수와 변수 비교했을때 ?뒤 트루일경우 첫번째값  : 폴스일경우 두번째 값 출력
        void Start()
    {

        int temp = input == num ? 50: 100;

    switch (input)
{
    case 10:
        print("intput의 값이 10입니다");
        break;
    case 11:
        print("intput의 값이 11입니다");
        break;
    case 12:
        print("input의 값이 12입니다");
        break;
    default:
        print("그 외의 경우");
        break;
}

        if(input == 10)
            print("intput의 값이 10입니다");
             else if(input == 11)
            print("intput의 값이 11입니다");
             else if(input == 12)
            print("intput의 값이 12입니다");
             else if(input == 13)
            print("intput의 값이 13입니다");

            else
            print("그 외의 경우");
            

      


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
