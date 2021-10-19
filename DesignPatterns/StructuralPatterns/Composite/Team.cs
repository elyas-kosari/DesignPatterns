using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Composite
{
    public class Team : IIncidentManagement
    {
        private readonly List<IIncidentManagement> incidentComponents = new List<IIncidentManagement>();

        public void Add(IIncidentManagement incidentComponent)
        {
            incidentComponents.Add(incidentComponent);
        }

        public void Deploy()
        {
            foreach (var incidentComponent in incidentComponents)
            {
                incidentComponent.Deploy();
            }
        }
    }
}
