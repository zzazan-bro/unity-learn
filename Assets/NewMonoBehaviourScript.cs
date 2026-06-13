using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int IntValue;

float FloatValue = 10.5f;

void FloatToint()
{

IntValue =(int)FloatValue;

}

        void Start()
    {
    
        FloatToint();
    print(IntValue);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
