using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.model {
    public class Person {

        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public override string ToString() {

            ReturnMessage FirstName + " " + LastName;
        }
        
    }
}
