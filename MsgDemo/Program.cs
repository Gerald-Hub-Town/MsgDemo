using System;
using System.Threading.Tasks;
using Flurl.Http;

namespace MsgDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {

            try
            {
                var weather = @"http://api.k780.com/?app=weather.today&cityNm=苏州&appkey=10003&sign=b59bc3ef6191eb9f747dd4e83c99f2a4&format=json";
                var wEntity = await weather.GetAsync().ReceiveJson<Rootobject>();

                var url = $@"http://push.ijingniu.cn/send?key=da19e954e7c54383aedb13d44f09e311&head=Hello&body={wEntity?.result?.citynm}+{wEntity?.result?.weather}+{wEntity?.result?.temperature}";

                var xx = await url.GetAsync();
                Console.WriteLine("发送完成");
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


    public class Rootobject
    {
        public string success { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string weaid { get; set; }
        public string days { get; set; }
        public string week { get; set; }
        public string cityno { get; set; }
        public string citynm { get; set; }
        public string cityid { get; set; }
        public string temperature { get; set; }
        public string temperature_curr { get; set; }
        public string humidity { get; set; }
        public string aqi { get; set; }
        public string weather { get; set; }
        public string weather_curr { get; set; }
        public string weather_icon { get; set; }
        public string weather_icon1 { get; set; }
        public string wind { get; set; }
        public string winp { get; set; }
        public string temp_high { get; set; }
        public string temp_low { get; set; }
        public string temp_curr { get; set; }
        public string humi_high { get; set; }
        public string humi_low { get; set; }
        public string weatid { get; set; }
        public string weatid1 { get; set; }
        public string windid { get; set; }
        public string winpid { get; set; }
        public string weather_iconid { get; set; }
    }

}
