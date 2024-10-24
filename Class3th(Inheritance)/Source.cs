using System;

class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}

// Robot 클래스 상속
class CleanRobot : Robot
{
    public void Clean()
    {
        Console.WriteLine("청소를 시작합니다.");
    }
}

class RescueRobot : Robot
{
    // 오버라이딩(매서드 재정의)
    public void Move()
    {
        Console.WriteLine("구조 로봇이 이동합니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cr = new CleanRobot();
        cr.Move();
        cr.Clean();

        RescueRobot rr = new RescueRobot();
        rr.Move();
    }
}