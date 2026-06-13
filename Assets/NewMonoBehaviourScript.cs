using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int a = 100;
    float b = 100.15f;
    
    float sum;

   //인트 선언 가정 int sum;

        void Start()
    {sum = a + b ; 
//float 선언시에는 오류 발생안하고 220.15로 출력됨. int 선언시에는 오류 발생함.
//왜냐하면 int(정수)는 소수점을 표현할 수 없기 때문에 float(소수점까지 나타내는 실수)로 선언된b를 표현불가
// 강제로 int로변환하는법 있음 묶고나서 인트로선언 캐스트라고함

sum= (int)(a+b);
//이렇게하면 소수점이 버려지고 220으로 출력됨.


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
