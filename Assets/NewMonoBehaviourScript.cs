using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public struct Youtube //구버전 a값을 직접 지정할수없어 스트럭트로 설계하고 클래스에서 함수식이나 a를직접불러와서 값을 넣어줘야함
{
    public int a;


public void GetA(int value)
    {
        a = value;
    }

}

public class NewMonoBehaviourScript : MonoBehaviour 
{

Youtube keidy; //유튜브 스트럭트 설계도를 불러와서 keidy라는 이름의 변수상자를 만듦(뒤에 =new Youtube(); 이거는 스트럭트에서 가져온거라 알아서실행됨, 만약 class였다면
//적어줘야함!


        void Start()
    { keidy.a=5;
    keidy.GetA(5);

    
       
      



    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
