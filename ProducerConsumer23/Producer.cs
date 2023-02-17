using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer23
{
    public class Producer
    {
        private const int maxCount = 5;

        private int num;
        public int Num => num;

        public Producer(int num)
        {
            this.num = num;
        }

        public void Start()
        {
            var t = new Thread(() =>
            {
                var iter = 0;
                while (iter++ < maxCount)
                {
                    var r = new Random();
                    Thread.Sleep(r.Next(2000, 5000));
                    var result = r.Next(1000);

                    Console.WriteLine($"Producer №{num}: {result}");

                    CommonData.Put(num, result);
                }
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
