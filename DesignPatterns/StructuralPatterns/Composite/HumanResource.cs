using System;

namespace DesignPatterns.CreationalPatterns.Composite
{
    public class HumanResource : IIncidentManagement
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying a human resource");
        }
    }
}
