using Formula1.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories.Contracts
{
    public class PilotRepository : IRepository<IPilot>
    {
        private readonly List<IPilot> models;
        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }
        public IReadOnlyCollection<IPilot> Models => models;

        public void Add(IPilot model)
        {
            this.models.Add(model);
        }

        public IPilot FindByName(string name)
        {
            return models.FirstOrDefault(h => h.FullName == name);
        }

        public bool Remove(IPilot model)
        {
            return this.models.Remove(model);
        }
    }
}
