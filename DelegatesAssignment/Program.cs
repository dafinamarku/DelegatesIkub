using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };
      ExtractFromList extract = new ExtractFromList();
      FilterArray filter = new FilterArray();
      FilterArray.Filter filterHandler = extract.ExactlyFive;
      filterHandler += extract.MoreThanFive;

      filter.Extract(ref names, filterHandler);
      foreach(var i in names)
        Console.WriteLine(i);
      
     
    }
  }
}
