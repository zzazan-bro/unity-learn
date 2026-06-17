using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


//변수의 또다른 활용 프로퍼티

public class NewMonoBehaviourScript : MonoBehaviour
{



    private int salary; // 중요한 샐러리(봉급,돈)같은 변수는 본스크립트에서만 수정가능하게 프라이베이트로 만듦
    //프로퍼티 코드 참고

    public int SalaryP{get {return salary;} private set{ salary = value;}}
    //->이렇게 겟은 퍼블릭, 셋은 프라이베이트로 지정하면 아래에 코드 두줄은 삭제해도됨
    private void SetSalary (int value)
    {
        salary = value;

    }

    public int GetSalary() // 타클래스에서 수정은 못하지만 읽어들일 수 있게 퍼블릭으로 만듦
    {
        
        return salary;
    }

    //** 은닉변수 효율화 외 또 다른 프로퍼티 사용법 예시 2줄 -> 실수줄이기 그리고 자동완성
    public int SalaryP{get {return salary;} set{if(vlaue <0) salary 10; else salary =value;}}

    //샐러리 값에 실수로 음수를 넣는다면 10을 입력하라 , 그외의 경우엔 value값대로 입력하라

    public int Bonus {get; set;}
    //간단하게 get; set;으로만적어도 retun , value값 할당안해줘도 첫번째줄처럼 자동완성됨 get { return bonus; } set { bonus = value; }
    
    

//또다른 파일 프로그램이라는 c#스크립트(클래스)를 만듦  이름 프로그램

public class Program : MonoBehaviour
    {
        Salary mySalary = new Salary(); // 타클래스 이름  , 변수이름 = 실체만들기 클래스이름



    }

    
void Start()
{
    
print(mySalary.GetSalary()); // 읽는건 가능

mySalary.SetSalary(55); // 프라이베이트 로 만들어진 변수라 입력은 불가능하다고 오류뜸

}

//이런 이유로 은닉성유지하는 코드때문에 수정은 프라이베이트로 한줄함수 , 읽기는 퍼블릭으로 한줄함수 총 함수를 두줄써야하는데
//은닉성 변수가 많을 수록 비효율적으로 꼭 데이터가 두줄씩 작성되어야함 이를 해결하기위한 것이 "프로퍼티임" -> 맨위로가서 프로퍼티 코드참고



}