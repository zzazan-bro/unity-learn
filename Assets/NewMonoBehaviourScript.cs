using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMonoBehaviourScript : MonoBehaviour
{

    //배열
    int[] exp = new int[5]{1,2,3,4,5};

    //Arraylist 자료형(실수,정수,텍스트)를 지정하지않아도 작동하지만, 연산량이 높음

    ArrayList arrayList = new ArrayList();

    //List 자료형을 지정해야하지만, 작동함 연산량이 줄어들어서 효율적임

    List<int> list = new List<int>();

    // HashTable 인덱스(0~??까지의 순번)으로 값을 찾는게 아니라 키값으로 찾음(앞에적어준 키값을 프린트해야 뒤에있는 값이 출력됨)

    Hashtable hashtable = new Hashtable();

    // Dictionary 자료형을 지정해야지만, 작동함 연산량이 줄어서 효율적임 (Arraylist 와 List의 관계와같음)


    Dictionary<string , int>dictionary = new Dictionary<string, int>();

    //Queue 선입선출 FIFO -> 게임에서 은행대기줄 또는 포션제작 대기열
    Queue<int> queue = new Queue<int>();

    //Stack , 후입선출 ,LIFO -> 게임에서 요리게임 설거지 마지막에들어온거 제일먼저닦아서 나감
    
    Stack<int>stack = new Stack<int>();
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

        dictionary.Add("가" , 100); // 가능
        dictionary.Add(100 , 100); // 불가능

        queue.Enqueue(5);
        queue.Enqueue(10);

        if(queue.Count !=0) // 큐의 갯수가 0과다르다면 출력, 0과같다면 미출력
        print(queue.Dequeue()); // 결과 5
if(queue.Count !=0)
         print(queue.Dequeue()); // 결과 10
if(queue.Count !=0) // 본래오류였으나 0이면 미출력하라했으므로 그냥 아무것도 출력되지않음
          print(queue.Dequeue()); // 결과 오류

          stack.Push(1);
          stack.Push(2);
          stack.Push(3);

    print(stack.Pop()); //결과 3
    print(stack.Pop()); //결과 2
    print(stack.Pop()); //결과 1
    if(stack.Count!=0) // 오류였으나 스택이 0과다를때만 출력하라고 조건문붙였으므로 그냥 출력되지않는것으로 끝
    print(stack.Pop()); // 결과오류


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
