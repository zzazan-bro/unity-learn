using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int IntValue;

float FloatValue = 10.5f;
float FloatValue2 = 20.5f;

void FloatToint(float _parameter , float _parameter2)
{

IntValue =(int)(_parameter + _parameter2);
 print(IntValue);
}

        void Start()
    {
    
        FloatToint(FloatValue,FloatValue2);
    
            
   


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
