using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode Node;
        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }
        List<string> List = new List<string>();

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            foreach(string value in values)
            {
                List.Add(value);
            }

        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            int ValueIndex = List.FindIndex(x => x.Contains(existingValue));
            if (ValueIndex == -1)
            {
                throw new ArgumentException(existingValue + " does not exist in the currently defined list.");
            }
            else
            {
                List.Insert(ValueIndex + 1, value);
            }
        }

        public void AddFirst(string value)
        {
            List.Insert(0, value);
        }

        public void AddLast(string value)
        {
           List.Add(value);
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            return List.Count();
        }

        public string ElementAt(int index)
        {
            if (!List.Any())
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                try
                {
                    return List.ElementAt(index);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    return null;
                }
            }


        }

        public string First()
        {
            try
            {
                return List.First();
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            return List.LastOrDefault();
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            List<string> nodeListToArray = new List<string>();
            //string[] nodeArray = new string[this.Count()];
            foreach (var item in List)
            {
                //nodeArray[this.Count()-1] = item;
                nodeListToArray.Add(item);
            }
            //return nodeArray;
            return nodeListToArray.ToArray();
        }

        public override string ToString()
        {
            string str = "{ ";
            if (!List.Any())
            {
                return "{ }";
            }
            else
            {
                foreach (var item in List)
                {
                    str += "\"" +item + "\", ";
                }
                str = str.Remove(str.LastIndexOf(','));
                return str +  " }";
            }
            //else return "{ \"" + List[0].ToString() + "\" }";
        }
    }
}
