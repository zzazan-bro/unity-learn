using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Student : Human // 스튜던트라는 이름의 c#스크립트 만든 상황 ->뒤에 스크립트모노 스크립트cs가아니라 Human으로해서 상속받음
{
    
string schoolName;

void Start()
    {
        schoolName = "케이디 초등학교";
        humanName = "케이디";
        humanAge = 8;

    info(); // 나는 인간입니다라고 휴먼클래스에서 입력되어있지만 내용을 바꾸고싶음! 그런데 부모클래스안가고 굳이 자식클래스에서 바꾸고싶을때 쓰는게 virtual임
    }


protected override void info()
    {
        base.info();  // base가 가르키는건 부모클래스를 말하는 것 -> 나는 인간입니다. 출력
        print("나는 학생입니다."); // 나는 학생입니다는 자식클래스에서는 한 번더 출력 -> Virtual -가상함수 , Override - 재정의
    }
protected override void Name() // 안만들면 모클래스에서 abstract 만들어준 것 덕에 오류가 나옴 이때 override name 까지만 치면 자동완성됨
    {
        print(humanName);
    }


}






abstract public class Human : MonoBehaviour // 휴먼이라는 이름의 c#스크립트 만든 상황 -> 아래 스트링, 인트 변수 두개만들고 save
{
   protected string humanName; // 처음에 스트링앞에 아무것안쓰면 타클래스에서 상속해도 사용불가능(private가 기본값이므로) 
    // 이때 앞에 protected 를 적으면 해결됨 -> 퍼블릭은전체, 프로텍티드는 상속받은 클래스내에서만 공유가능  
   protected int humanAge;

   protected virtual void  info() // 나는 인간입니다라고 휴먼클래스에서 입력되어있지만 내용을 바꾸고싶음! 
   // 그런데 부모클래스안가고 굳이 자식클래스에서 바꾸고싶을때 쓰는게 virtual임 -> 가상함수로 만들겠다는 뜻 이상태에서 자식클래스가서 override(재정의)하면됨
    {
        
        print("나는 인간입니다.");
    }
abstract protected void Name(); // 자식 클래스를 만들다보면 너무많은 변수가있을 시 당연히 들어가야할 이름같은 정보를 입력안할수도있음 
//그래서 추상함수(abstract : 사전적뜻 추상의)로 자식클래스에서 네임이라는 함수를 꼭만들어야한다고 명시해주는 기능임 -> 근데이걸 사용하면 클래스이름 자체에도
//abstract를 붙여줘야함


}

public class NewMonoBehaviourScript : MonoBehaviour
{
    




}

    

