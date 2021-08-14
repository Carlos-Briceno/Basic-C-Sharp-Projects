using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsteuctorAssignment
{
    class Const
    {
        public string Name { get; set; }
        public string School { get; set; }

        public Const(string name) : this(name, "Carlos") { }
        public Const(string name, string school)
        {
            Name = name;
            School = school;
        }
    }
}
