using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : IObserver
    {
        private string name;
        private Subject subject;
        public ConcreteObserver(Subject Subject, String Name)
        {
            subject = Subject;
            name = Name;
        }

        public void update()
        {
            Console.WriteLine($"Observer {name} receives the published state:{subject.someState}");
        }
    }
}
