using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    public interface IEmployed
    {
        int EmpID { get; set; }
        string Name { get; set; }
    }
}
