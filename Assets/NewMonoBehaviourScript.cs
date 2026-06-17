using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum Item // 넣고싶은 값만 고를 수 있게 만드는 타입 (선택지로 이해)
{
    weapon,
    shield,
    potion,


}

public struct Youtube //구버전 a값을 직접 지정할수없어 스트럭트로 설계하고 클래스에서 함수식이나 a를직접불러와서 값을 넣어줘야함
{
    public int a;
    public int b;
    public int c;
    public int d;
    
    public Youtube(int _a, int _b ,int _c, int _d ) // 생성자 형식
    {
        a = _a; b= _b; c= _c; d= _d;
    }

public void GetA(int value)
    {
        a = value;
    }

}

public class NewMonoBehaviourScript : MonoBehaviour 
{
   Item item;
Youtube keidy; //유튜브 스트럭트 설계도를 불러와서 keidy라는 이름의 변수상자를 만듦(뒤에 =new Youtube(); 이거는 스트럭트에서 가져온거라 알아서실행됨, 만약 class였다면
//적어줘야함!

Youtube keid = new Youtube(1,2,3,4); // 생성자 만든 스트럭트 변수들에 값 지정해주는 방법
Youtube keid2 = new Youtube(5,6,7,8);
        void Start()
    { keidy.a=5;
    keidy.GetA(5);

    
    item = Item.weapon;
    item = Item.shield;

      print(item); // 마지막에 적은 shield가 프린트됨 but // ex)) item=Item.acs; ->로 적게되면 Item 에 선택지로 acs가없으므로 오류발생


    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
