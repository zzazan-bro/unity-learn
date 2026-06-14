using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int IntValue;

float FloatValue = 10.5f;
float FloatValue2 = 20.5f;

void FloatToint(float _parameter)
{

IntValue =(int)_parameter;
 print(IntValue);
}

        void Start()
    {
    
        FloatToint(FloatValue);
        FloatToint(FloatValue2);
            
   


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
