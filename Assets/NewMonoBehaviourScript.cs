using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int x = 100;
int y = 100;

int sum;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     sum = x + y; 
     
     print(sum);  //->정답은 200입니다.

    print(-sum); //->정답은 -200입니다.

  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
