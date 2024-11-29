using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fact : MonoBehaviour
{
    // Start is called before the first frame update
    public class MyClass 
    {
        public int i;
        public int j;
    }
    public struct MyStruct
    {
        public string name;
        public int age;
    }


    public class MyList<TItem,T2,T3>
    {
        private TItem[] array = new TItem[4];

        public int count { get;  }

        public void Push(int i)
        { 
        
        }
        public void Insert(int index, int item)
        { 
        
        }
        public void Remove(int item) { }

        public void Clear() { }

        public void InsexOf(int item)
        {
            return;
        }
        public void RemoveAt(int index) { }
    }
    void Start()
    {
        var mc = new MyClass();
        var ms = new MyStruct();
        var ms2 = new MyStruct();
        ms = ms2;

        MyList<MyClass, uint, float> myList = new MyList<MyClass, uint, float>();
    }

}
