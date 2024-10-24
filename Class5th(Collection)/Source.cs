using System;
using System.Collections; // 컬렉션을 사용할 때 추가

class MainClass
{
    public static void Main(string[] args)
    {
        #region Collection
        // 다양한 자료형을 넣을 수 있음
        #region ArrayList
        ArrayList al = new ArrayList();

        // Add 메소드를 통해 아이템 추가
        al.Add(1);
        al.Add("Hello");
        al.Add(3.3);
        al.Add(true);

        // var : 자료형이 가변적일 때 사용
        foreach (var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Remove 메소드를 통해 아이템 삭제
        al.Remove("Hello");
        foreach (var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        #endregion

        #region Queue
        Queue qu = new Queue();

        // Enqueue 메소드를 통해 아이템 추가
        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        // Dequeue 메소드를 통해 아이템 제거
        while (qu.Count > 0)
        {
            Console.WriteLine(qu.Dequeue());
        }
        Console.WriteLine();
        #endregion

        #region Stack
        Stack st = new Stack();

        // Push 메소드를 통해 아이템 추가
        st.Push(1);
        st.Push(2);
        st.Push(3);

        // Pop 메소드를 통해 아이템 제거
        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }
        Console.WriteLine();
        #endregion

        #region Hashtable
        Hashtable ht = new Hashtable();

        // 키와 값 형태로 Hashtable에 아이템 추가
        ht["apple"] = "사과";
        ht["banana"] = "바나나";
        ht["orange"] = "오렌지";

        // Hashtable에 저장된 키에 해당하는 값 출력
        Console.WriteLine(ht["apple"]);
        Console.WriteLine(ht["banana"]);
        Console.WriteLine(ht["orange"]);

        #endregion
        #endregion
    }
}