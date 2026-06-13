using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int a;
string b="ㅁㄴㅇㄹㅁㄴㅇㄹ";

    // short (-3만~+3만) , ushort(0~6만)) 
//uint uint ulong모두 가능 음수없애고 양수쪽으로 범위늘림(용량은 같음)

bool aaaa = true;
bool bbbb = false;
//이런식으로 true false로만 표현되는 자료형도 있음



        void Start()
    {
    a=b; // 당연히 숫자에다가 문자형식을 넣었으니 오류가남 이것도 강제로바꾸는방법이있음
    a=int.Parse(b); //이렇게하면 b의 문자형식이 숫자형식으로 바뀌어서 a에 들어감
    print(a);
//하지만 b에 "100"이런식으로 숫자형식의 문자만 들어가야함 만약 "100a" 이런식으로 들어가면 오류가남
//포멧자체가 숫자형식이여야 정수로바꿔줄수있음 (ㅁㄴㅇㄹ를 정수로못바꿈)





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
