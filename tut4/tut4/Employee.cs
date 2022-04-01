using System;
using System.Collections.Generic;
using System.Text;

namespace tut4
{
    enum Gender { M, F, X };
    class Employee
    {
        public string name;
        public int id;
        public Gender gender;

        public override string ToString()
        {
            return(this.name+","+this.id+","+this.gender);
        }

    }
}
