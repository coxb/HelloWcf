﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldServiceClient();

            Console.WriteLine(client.GetMessage("Mike Liu"));
        }
    }
}
