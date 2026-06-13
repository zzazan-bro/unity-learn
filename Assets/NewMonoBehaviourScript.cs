using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int a = 100;
    string b;
    




        void Start()
    {
        b= a; //원래는 이렇게하면 오류가남
        b = a.ToString(); //이렇게 하면 강제로 a를 문자열로 바꿔서 b에 넣어줌
        // int a = "100"; 이런느낌임



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
