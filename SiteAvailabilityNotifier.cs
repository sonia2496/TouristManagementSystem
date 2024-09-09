using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class SiteAvailabilityNotifier : ISubject
    {
        private List<IObserver> observers;
        private HashSet<string> futureAvailableSites;

        public SiteAvailabilityNotifier()
        {
            observers = new List<IObserver>();
            futureAvailableSites = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                foreach (var site in futureAvailableSites)
                {
                    observer.Update(site);
                }
            }
        }

        public void AddFutureAvailableSite(string site)
        {
            string standardizedSite = site.Trim();
            if (futureAvailableSites.Add(standardizedSite)) 
            {
                Notify(); 
            }
        }

        public void ClearFutureAvailableSites()
        {
            futureAvailableSites.Clear();
        }
    }
}
