using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }
        List<string> List = new List<string>();

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(string value)
        {
            List.Add(value);

        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            if (index >= 0)
            {
                return List[index];
            }
            else if (index <= 0)
            {
                index = index - index;
                return List[index];
            }
            else throw new IndexOutOfRangeException();
        }

        public string First()
        {
            return List.FirstOrDefault();
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
            if (List.Count == 0)
            {
                return null;
            }
            else
            {
                return List.ElementAt(List.Count() - 1);
            }
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
            if (List.Count() == 0)
            {
                return new string[] { };
            }
            else if (List.Count() == 1)
            {
                string[] singleItemArray = new string[] { List[0] };
                return singleItemArray;
            }
            else
            {
                return List.ToArray();
            }

        }
        public override string ToString()
        {
            string returned_string = "";
            if (List.Count() == 0)
            {
                return "{ }";
            }
            else if (List.Count() == 1)
            {
                return "{ \"" +List[0].ToString() +"\" }";
            }
            else
            {
                for (int i = 0; i <= List.Count() - 1; i++)
                {
                    if (i != List.Count()-1)
                    {
                        returned_string += "\"" + List[i].ToString() + "\", ";
                    }
                    if (i == List.Count() - 1)
                    {
                        returned_string += "\"" + List[i].ToString() + "\"";
                    }
                }
                return "{ " + returned_string + " }";
            }
        }
    }
}
