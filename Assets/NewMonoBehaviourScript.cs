using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // 1+1=2
    // 숫자 1 - 상수

    // 1+x=랜덤
    // 숫자 1 - 상수
    // x - 변수
    int x = 100; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     print(x);

    x= -500;
     print(x);

    x = x-500;
     print(x);

        x = x+1000;
        print(x);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
