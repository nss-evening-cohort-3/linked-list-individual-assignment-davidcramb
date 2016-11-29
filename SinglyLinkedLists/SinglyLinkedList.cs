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
            get { return List[i]; }
            set { List[i] = value; }
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
            return List.FirstOrDefault();
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
            
            return List.IndexOf(value);
        }

        public bool IsSorted()
        {
            if (!List.Any() || List.Count == 1)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < List.Count() - 1; i++)
                {
                    if (List[i].CompareTo(List[i + 1]) < 0 || List[i].CompareTo(List[i +1]) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            
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
            return List.LastOrDefault();
        }

        public void Remove(string value)
        {
            try
            {
                List.RemoveAt(List.IndexOf(value));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Node doesn't exist. Your list remains the same.");
            }

        }

        public void Sort()
        {
            List<string> sortedList = new List<string>();

            if (!List.Any() || List.Count() == 1)
            {
                List.ToArray();
            }
            else
            {
                while (!this.IsSorted())
                {
                   var this_node = Node;
                    var next_node = this_node.Next;
                    for (int i = 0; i < this.Count() -1; i++)
                    {
                        if (this_node.Value.CompareTo(next_node.Value) > 0)
                        {
                            var node_arranger = this_node.Next.Value;
                            next_node.Value = this_node.Value;
                            this_node.Value = node_arranger;
                        }
                        this_node = this_node.Next;
                        next_node = next_node.Next;
                    }

                }
            }
            
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
        }
    }
}
