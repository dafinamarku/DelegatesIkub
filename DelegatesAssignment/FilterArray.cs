using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
  class FilterArray
  {
    public delegate void Filter(ref string[] arr);

    public void Extract(ref string[] a,Filter filter)
    {
      filter(ref a);
    }
  }
}
