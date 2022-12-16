static class Program
{
    static void Main(string[] args)
    {
        // 16 진수 변환
        Console.WriteLine(String.Format("{0:X}", 10));

        // 소수점 2자리까지 표시(소수점 이하 2자리까지 값이 없으면 0으로 표시)
        Console.WriteLine(String.Format("{0:0.00}", 10.1d));
        Console.WriteLine(String.Format("{0:0.00}", 10.111111111111d));

        // 소수점 2자리까지 표시
        Console.WriteLine(String.Format("{0:0.##}", 10.1d));
        Console.WriteLine(String.Format("{0:0.##}", 10.1111111111111111111d));

        // 콤마를 이용해서 자릿 수 표시. 총 10자리수를 기준으로 앞에 공백를 나둔다.
        Console.WriteLine(String.Format("{0,10:#,##0}", 11));
        Console.WriteLine(String.Format("{0,10:#,##0}", 1122));

        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }
}