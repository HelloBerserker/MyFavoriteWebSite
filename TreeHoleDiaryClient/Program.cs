using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHoleDiaryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string value = Convert.ToString(null);
            try
            {
                Console.WriteLine("Choose An Operation:");
                Console.WriteLine("1.ToYueMei\n2.TreeHole's Diary");
                string key = Console.ReadLine();
                string msg = "";
                if (key == "1")
                {
                    key = "ToYueMei";
                    msg = "ToYueMei";
                }
                else if (key == "2")
                {
                    key = "Today";
                    msg = "TreeHole's Diary";
                }
                else
                    throw new Exception("Invalid Operation");
                Console.WriteLine(msg+"\nInput:");
                string input = Console.ReadLine();
                while (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid Input\nInput:");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Your Input:" + input);
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("lijinfeng.club,password=wsljf.");
                var db = redis.GetDatabase();
                var flag = db.StringSet(key, input);
                if (flag)
                    Console.WriteLine("写入远程服务成功");
                else
                    Console.WriteLine("写入远程服务失败");               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message);
            }
            Console.ReadLine();
        }
    }
}
