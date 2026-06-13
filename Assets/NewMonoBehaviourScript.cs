using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int intValue;

    float FloatValue = 10.5f;

    void FloatToint()
    {
        intValue=(int)FloatValue;


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
