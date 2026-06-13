using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    long a = 40000000;

    // sbyte 음수 정수 자료형 (-128~127) -1바이트
    // byte 정수 자료형 (0~255) -1바이트
    // short 정수 자료형 (-3만~+3만) -2바이트
    // integer 정수 자료형 (-20억~+20억) -4바이트)
    // long 정수 자료형 (그냥무한) -8바이트)

    float f = 4.000001f;
    double d = 4.000001;
    decimal m = 4.000001m;

    // float 실수 자료형 (7자리까지 표현) -4바이트
    // double 실수 자료형 (15자리까지 표현) -8바이트
    // decimal 실수 자료형 (28~29자리까지 표현) -16바이트

    string s = "asdfasdf";
    char c = 'A'; //-> 글자를 유니코드로인식 사실 0093 같은 값이들어감
    
    //문자 자료형

        void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
