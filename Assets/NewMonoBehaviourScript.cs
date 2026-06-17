using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour 
{
// for문 반복횟수가 명확할때 vs while 반복횟수가 명확하지않을때

// do while -> while은 와일 괄호()안에 조건을 먼저 생각하고 실행함 but, do while은 do먼저 실행하고 그담에 와일()괄호 안의 조건을 생각함 
// 만약 조건이맞지않는다면 1회차만 Do를 실행하고 그다음부터는 실행하지않음

// foreach는 긴 텍스트 값을 텍스트안의 글자여러개를 글자하나로 쪼개겠다는 뜻임
    int num = 0;

    string text=("가나다라마바사"); 



        void Start()
    {
       
           while(num < 10)
        {
            num++;

            print(num);

        }

        do
        {
            
            num++;
            print(num);
            
        }
        while(num<10);

   foreach(char a in text) // text라는 긴변수를 쪼개서 a라는 변수에 하나씩 char타입으로 담겠다는 뜻
   {
print(a);
    
   }

    }
   


    // Update is called once per frame
    void Update()
    {
        
    }
}
