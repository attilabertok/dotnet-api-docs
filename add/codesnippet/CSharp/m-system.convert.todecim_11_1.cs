      bool[] flags = { true, false };
      decimal result;
      
      foreach (bool flag in flags)
      {
         result = Convert.ToDecimal(flag);
         Console.WriteLine("Converted {0} to {1}.", flag, result);
      }
      // The example displays the following output:
      //       Converted True to 1.
      //       Converted False to 0.      