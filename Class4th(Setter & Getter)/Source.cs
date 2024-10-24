using System;

class Cat
{
    private string name; // this.name과 동일

    public Cat(string name)
    {
        this.name = name;
        Console.WriteLine("고양이의 이름은 " + name + "입니다.");
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Cat c = new Cat("초코");
        c.SetName("몰리");
        Console.WriteLine("고양이의 이름은 " + c.GetName() + "입니다.");
    }
}