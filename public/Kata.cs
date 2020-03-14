using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
  public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
  {

    foreach (var item in listOfItems)
    {
      var isNum = int.Parse(item);

      if (isNum)
      {
        return item;
      }
    }
    return item;
  }
}