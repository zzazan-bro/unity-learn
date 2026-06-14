using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


public class test2
{
     private int a = 5;
    public int b = 5;

public void abc()
    {
        
    }
private void abc2()
    {
        
    }

}
public class NewMonoBehaviourScript : MonoBehaviour
{

   test2 aaa;
   
   void abc()
    {
        aaa.b=5;
        aaa.abc();
        aaa.abc2();
    }

        void Start()
    {

            
   


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
