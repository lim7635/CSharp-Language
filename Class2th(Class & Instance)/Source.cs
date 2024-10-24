using System;

#region 속성, 프로퍼티, 매서드
//class Person
//{
//    // 속성(Property)
//    public string Name;
//    public string Birthday;

//    // 메소드(Method)
//    public void Eat()
//    {
//        Console.WriteLine(Name + "이 아침을 먹습니다.");
//    }

//    public void Walk()
//    {
//        Console.WriteLine(Name + "이 걷습니다.");
//    }

//    public void Run()
//    {
//        Console.WriteLine(Name + "이 뜁니다.");
//    }

//    public void Birth()
//    {
//        Console.WriteLine(Name + "의 생일은 " + Birthday + "입니다.");
//    }
//}
#endregion

#region 생성자, 오버로딩, 소멸자
//class Cat
//{
//    public string Name;
//    public int Weight;

//    // 클래스와 메서드의 이름이 같으면 생성자가 호출
//    public Cat()
//    {
//        Console.WriteLine("고양이 생성자가 호출되었습니다.");
//    }

//    public Cat(string name)
//    {
//        //Console.WriteLine("고양이 생성자가 호출되었습니다.");

//        Name = name;
//        Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
//    }

//    // 메서드 오버로딩(매개 변수를 다르게 설정하면 동일한 이름의 매서드 사용 가능)
//    public Cat(string name, int weight)
//    {
//        Name = name;
//        Weight = weight;
//        Console.WriteLine("고양이의 이름은 " + Name + "이며, 몸무게는 " + weight + "kg입니다.");
//    }

//    // 소멸자(물결 표시)
//    ~Cat()
//    {
//        Console.WriteLine(Name + "가 사라집니다.");
//    }
//}
#endregion

class MainClass
{
    public static void Main(string[] args)
    {
        // Cat c = new Cat();
        // Cat choco = new Cat("초코");
        // Cat moly = new Cat("몰리", 3);
    }
}