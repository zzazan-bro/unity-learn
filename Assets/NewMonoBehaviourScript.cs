using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int a = 100;
    long b = 100;
    
    long sum;

   //인트 선언 가정 int sum;
   
        void Start()
    {sum = a + b ; // -> 오류안뜨고 200뜸

//but 위에 가 int sum; 이렇게 long이 아니라 int로 선언하면 오류뜸 
//왜냐하면, a는 int형이고 b는 long형이기 때문입니다, (long>int)기때문에 인트 변수로 롱의 값을 담을 수 없음
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
