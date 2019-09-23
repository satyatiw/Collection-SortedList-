using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_SortedList_
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
            Console.ReadLine();


            //removes a particular element.
            sortedList.Remove("one");
            //Removes element from a particula index
            sortedList.RemoveAt(0);

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
            Console.ReadLine();

            //Checks if SortedList Contains the following Element.(search by index((we need to inert index in the paranthesis of contains function ))
            Console.WriteLine(sortedList.Contains("two"));
            Console.ReadLine();
        }
    }
}
