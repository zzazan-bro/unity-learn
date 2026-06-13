using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int a;
string b="100";

    




        void Start()
    {
    a=b; // 당연히 숫자에다가 문자형식을 넣었으니 오류가남 이것도 강제로바꾸는방법이있음
    a=int.Parse(b); //이렇게하면 b의 문자형식이 숫자형식으로 바뀌어서 a에 들어감
    print(a);






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
