using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour
{

    int intvalue;
    float floatvalue =10.5f;
    float floatvalue2 =20.5f;

    void FloatToint(float _parameter, float _parameter2 , string _stringparm = "디폴트값" ) // 1.void는 함수만들기전에 들어가는 선언문(리턴값이 없음) , _parameter는 매개변수라는 뜻 ->
    //FLoatToint() 만 해도 함수가 완성되긴하지만, 매개변수(parameter)를 설정해주면 , (퍼블릭클래스에서 선언한)변수가 두개이상일때 보이드스타트 아래에 함수이름(변수이름) 만 설정해도
    //프린트됨 , 물론 실수형말고 string_stringParm처럼 변수의 자료형을 텍스트형태로도 인풋할 수 있음
    //디폴트값은 첫변수에는 못하고 무조건 뒤에와야함 -> 그래야 오류없이 적용됨
    {
        intvalue =(int)(_parameter + _parameter2);
        print(intvalue);
        print(_stringparm);
    }

     int FloatToint(float _ parameter , float _parameter2)
    {
        return (int)(_parameter + _parameter2);
    }
     //void가 아니라 int해놓고 함수만들면 무조건 return을 끝에 적어서 반환값설정해줘야함
        void Start()
    {
      FloatToint(floatvalue , floatvalue2 , "12312");
    
      




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
