using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return next; }
            set {
                if(this == value)
                {
                    throw new ArgumentException();
                } else
                {
                    this.next = value;
                }

            } //same as public string set_Next(string value) { this.next = value;}
        }
        
        private string value;
        public string Value 
        {
            get { return this.value; }
            set
            {
                this.value = value;
            }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;
            
            // Used by the visualizer:

            allNodes.Add(this);
        }

        public override bool Equals(Object obj)
        {
            // If parameter is null return false.
            if (obj == null || ! (obj is SinglyLinkedListNode))
            {
                return false;
            }
            // If parameter cannot be cast to Point return false.
            SinglyLinkedListNode p = obj as SinglyLinkedListNode;
            if ((Object)p == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (value == p.value);
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            if (obj == null)
                return 1;
            SinglyLinkedListNode nextNode = obj as SinglyLinkedListNode;
            if (nextNode != null)
            {
                return this.Value.CompareTo(nextNode.Value);
            } else
            {
                throw new ArgumentException("Not a linked node");
            }
            {
                return 1;
            }
            SinglyLinkedListNode nextObject = obj as SinglyLinkedListNode;
            if (nextObject != null)
            {
                //return this.value.CompareTo(nextObject.value);
                return this.value.CompareTo(nextObject.value);
            }
            else throw new Exception("WHYYYYY?!");
        }

        public bool IsLast()
        {
            var last = allNodes.LastOrDefault();
            if (this == last)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
