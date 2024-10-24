using System;

class MainClass
{
    public static void Main(string[] args)
    {
        #region try-catch
        // 예외 처리가 필요할 때 사용하는 구문

        Console.Write("나눌 숫자를 입력하세요 : ");

        // Parse : 형변환 메소드
        int divider = int.Parse(Console.ReadLine());

        // try : 예외가 생기지 않았을 경우
        try
        {
            Console.WriteLine(10 / divider);
        }
        // catch : 예외가 생겼을 경우 catch문으로 이동
        // Exception : 다양한 예외 사항의 원인을 찾을 때 사용
        catch (Exception e)
        {
            // Message 메소드를 통해 원인 확인 가능
            Console.WriteLine("예외 : " + e.Message);
        }
        #endregion
    }
}