using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test2 : MonoBehaviour // 이건 원래 c# 스크립트 하나더만든건데 귀찮아서 여기에 클레스 파일명tes2더만듦 다파일에서 만든 함수도 event 로만든 chain에
//넣을 수 있다는 걸 보여주기위함
{
    void Start()
    {
        Test.Onstart +=Abc; // Test에있는 Onstart라는 변수에 Abc함수 추가하겠다는 뜻 -> 스테틱 이벤트로만든 변수에서는 타 클래스에서 만든 함수를 첨부가능
    }
public void Abc(int value)
{
    
    print(value + "값이 증가했습니다");

}
}
public class NewMonoBehaviourScript : MonoBehaviour 
{
    public static event ChainFucntion Onstart; // 이거는 타클래스 (다른 test2라는 c#스크립트를 만들고 거기에있는 함수도불러올수있음)
    public delegate void ChainFunction(int value); // 델리게이트 는 클래스랑비슷한 기능, 체인펑션이라는 이름의 클래스생성 
    // -> 함수여러개 넣어주는 공간임(hp,민첩등 다른변수도 chain한번에관리가능)
    ChainFunction chain; // 체인펑션에 체인이라는 이름의 변수 할당

    

    int power;
   int defence;

   public void SetPower(int value)
    {
        power += value;
        print("power의 값이" +value+ "만큼 증가했습니다 . 총 power의 값 =" + power);
    }
   public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" +value+ "만큼 증가했습니다 . 총 defence의 값 =" + defence);
    }

    void Start()
    {
      

chain += SetPower; //- 체인이라는 이름변수에 셋파워 함수추가
chain += SetDefence; //- 체인이라는 이름변수에 셋디펜스 함수 추가

chain-= SetDefence; // - 체인이라는 이름변수에 셋디펜스 함수 제거 -> 이러면 파워값만 프린트됨
    if(chain != null) // - 체인에 어떠한 함수도 없지않을경우(값이있을경우에만) 실행 -> 오류방지 조건문임
chain(5); // - 함수에 5넣어서 실행



//여기부터는 onstart변수 예시 //

void Start()
        {
            Onstart +=SetPower;
            Onstart +=SetDefence;
            
        }

    }

   
    private void OnDisabel() // 게임이 꺼지면 온스타트에 5넣기
    {
        OnStart(5);
    }

    void Update()
    {
        
    }
}
