using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{

   //1차원 배열
int[]exp = { 50, 100, 150, 200, 250};

int[] array = new int[10];

// 2차원 배열 -> 1차원배열이 2개있는것
int[ , ] array2 = {{1,2,3,4,5},{10,20,30,40,50}};

// 3차원 배열

int[ , , ] array3 ={ {{1,2,3,4,5,} , {10,20,30,40,50}} , {{1,2,3,4,5,} , {10,20,30,40,50}} };



        void Start()
    {
print(array2[1,3]); // 결과  40
   
print(array2[0,1]); // 결과  2


    print(array3[1,1,2]); // 결과 30
    print(array3[0,0,3]); // 결과 4
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
