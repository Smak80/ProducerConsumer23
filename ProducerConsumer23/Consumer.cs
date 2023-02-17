using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer23
{
    public class Consumer
    {
        public void Start()
        {
            var t = new Thread(() =>
            {
                while (true)
                {
                    var tResults = CommonData.Get();
                    var r = new Random();
                    Thread.Sleep(r.Next(2000, 5000));
                    var res = $"{tResults[0]} + {tResults[1]} + {tResults[2]} = {tResults.Sum()}";
                    Console.WriteLine(res);
                }
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
