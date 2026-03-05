using System;

class Program
{
    static void Main()
    {
        var random = new Random();   // ★ここで1回だけ作る

        while (true)
        {
            Console.WriteLine($"今日の日付: {DateTime.Now:yyyy/MM/dd}");
            
            Console.WriteLine("Enterキーでおみくじ（終了は q ）");
            var input = Console.ReadLine();
            if (input == "q") break;

            int result = random.Next(1, 5); // 1～4
            string fortune = result switch
            {
                1 => "大吉",
                2 => "中吉",
                3 => "小吉",
                _ => "凶"
            };

            Console.WriteLine($"運勢: {fortune}");
        }
    }
}