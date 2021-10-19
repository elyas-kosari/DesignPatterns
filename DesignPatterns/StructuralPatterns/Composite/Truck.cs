using System;

namespace DesignPatterns.CreationalPatterns.Composite
{
    public class Truck : IIncidentManagement
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a truck");
        }
    }
}
