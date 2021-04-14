using System;
using System.Threading.Tasks;
using Flurl.Http;

namespace MsgDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = @"http://push.ijingniu.cn/send?key=da19e954e7c54383aedb13d44f09e311&head=Hello&body=Hello.World";

            var xx = await url.GetAsync();

            Console.WriteLine("发送完成");
            Console.WriteLine("Hello World!");
        }
    }
}
