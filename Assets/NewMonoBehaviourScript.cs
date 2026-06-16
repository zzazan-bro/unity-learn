using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour
{

    //배열
    int[] exp = new int[5]{1,2,3,4,5};

    //arraylist 자료형(실수,정수,텍스트)를 지정하지않아도 작동하지만, 연산량이 높음

    ArrayList arrayList = new ArrayList();

    //List 자료형을 지정해야하지만, 연산량이 줄어들어서 효율적임

    List<int> list = new List<int>();

    // HashTable 인덱스(0~??까지의 순번)으로 값을 찾는게 아니라 키값으로 찾음(앞에적어준 키값을 프린트해야 뒤에있는 값이 출력됨)

    Hashtable hashtable = new Hashtable();


        void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("가나다라");
        arrayList.Add(4);

        arrayList.Remove("가나다라"); // 가나다라 를 지우겠다
        arrayList.RemoveAt(3); // 4번째 데이터를 지우겠다
        arrayList.RemoveRange(1,3); // 2번째부터(0이 첫번째이므로,,) 3개를 지우겠다 -> 결과 1이랑 4만 출력됨


        for (int i=0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);

        }

        list.Add(3); // 가능
        list.Add("가나다"); // 불가능


        hashtable.Add("만" , 10000);
        hashtable.Add("백만" , 1000000);
        hashtable.Add(50,"1억");

        print(hashtable["백만"]); // 결과 1000000
         print(hashtable["50"]); // 결과 1억

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
