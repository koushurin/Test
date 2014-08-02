using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SerialTest
{
    class Program
    {
        static bool running = true;
        static void Main(string[] args)
        {
            SerialPort mySerialPort = new SerialPort("COM3");
            mySerialPort.BaudRate = 9600;
            mySerialPort.Open();
            while (running)
            {
                //string myData = mySerialPort.ReadLine();
                //Console.WriteLine(myData);
                mySerialPort.Write("o");
                System.Threading.Thread.Sleep(1000);
                mySerialPort.Write("n");
                System.Threading.Thread.Sleep(1000);
            }
        } 
    }
}
