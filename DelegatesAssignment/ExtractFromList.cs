using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
  class ExtractFromList
  {
    //a) You should create a method LessthanFivethat will extract  all names  from this
    //  list that have less than 5 characters.
    //  b) Create a methodMoreThanFivethat will extract all names from the list
    //  that contain more than 5 characters.
    //  c) Create a method ExactlyFivethat will extract all 
    //  names with exactly  5 characters.
    //  d) Find a way to provide similar methods,  using delegates


    //bllok kodi qe perseritet ne 3 funx pasardhese
    private void swapTillTheEnd(ref string[] a, ref int startingIndex)
    {
      string temp;
      for (int j = startingIndex; j < a.Length - 1; j++)
      {
        for (int k = j + 1; k < a.Length; k++)
        {
          temp = a[j];
          a[j] = a[k];
          a[k] = temp;
        }
      }
      Array.Resize(ref a, a.Length - 1);
      startingIndex--;
    }


    public void LessThanFive(ref string[] a)
    {
      for(int i= 0;i < a.Length;i++)
      {
        if (a[i].Length < 5)
        {
          swapTillTheEnd(ref a, ref i);
        }
      }
    }

    public void MoreThanFive(ref string[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i].Length > 5)
        {
          swapTillTheEnd(ref a, ref i);
        }
      }
    }

    public void ExactlyFive(ref string[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i].Length == 5)
        {
          swapTillTheEnd(ref a, ref i);
        }
      }
    }


   
  }
}
