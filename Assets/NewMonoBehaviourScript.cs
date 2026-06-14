using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

int IntValue;

float FloatValue = 10.5f;
float FloatValue2 = 20.5f;

int FloatToint(float _parameter , float _parameter2)
{
 return Multiply((int)(_parameter + _parameter2));
}

int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }
        void Start()
    {
    
       print(FloatToint(FloatValue,FloatValue2));
    
            
   


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
