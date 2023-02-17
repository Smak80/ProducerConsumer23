// See https://aka.ms/new-console-template for more information

using ProducerConsumer23;

Consumer consumer = new Consumer();

Producer p1 = new Producer(0);
Producer p2 = new Producer(1);
Producer p3 = new Producer(2);

consumer.Start();

p1.Start();
p2.Start();
p3.Start();

Console.ReadLine();