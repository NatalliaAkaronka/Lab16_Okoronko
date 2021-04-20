using System;

namespace Lab16_Okoronko
{
    public delegate  void MyDelegate();
    public class Ping
    {
        public event MyDelegate MyEvent;

        public  void Hit()
        {
            Console.WriteLine("Ping recieved Pong");
            MyEvent();

        }

    }
    public class Pong
    {
        public event MyDelegate MyEvent;
        public void Hit()
        {
            Console.WriteLine("Pong recieved Ping");
            MyEvent();
        }
    }
        class Program
    {
        static void Main()
        {

                Ping ping = new Ping();
                Pong pong = new Pong();

                ping.MyEvent += pong.Hit;
                pong.MyEvent += ping.Hit;
                ping.Hit();


            Console.ReadLine();
        }
    }
}
