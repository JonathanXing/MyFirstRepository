using System;

using ClearScada.Client;
using ClearScada.Client.Simple;

class Program
{
    static void Main(string[] args)
    {
        using (Connection conn = new Connection("TMC"))
        {
            // Connect to local server
            conn.Connect("192.168.1.104");

            // Create a new point
            DBObject point = conn.CreateObject("CPointAlgManual", ObjectId.Root, "My Point");

            // Set a property
            point["FullScale"] = 200;

            // Get a property
            Console.WriteLine("FullScale = {0}", point["FullScale"]);

            while (true)
            {

            }
        }
    }
}
