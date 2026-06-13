using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int intValue;
    float FloatValue = 10.5f;
그런데 지금 수정한거랑 이전꺼도 같이 올라가있어야하는거아냐? 이전꺼는 안올라가있는데
    void FloatToint()
    {
        intValue=(int)FloatValue;
ㅇㅇ

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FloatToint();

        print(intValue);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
