using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1;

namespace WpfApplication1
{
    class PersonNameViewModel
    {
        private Person person;

        public Person personobj
        {
            get
            {
                return person;
            }
            set
            {
                person = value ?? value;
            }
        }
        public PersonNameViewModel()
        {
            this.personobj = new Person { FirstName = "Anil", LastName = "G" };
        }
    }
}
