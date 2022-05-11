using System;

namespace CrackingCodingInterview
{
    public class LinkedListImplementation
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int _data)
            {
                data = _data;
            }
        }

        private static LinkedListImplementation list = new LinkedListImplementation();
        Node nodeB = new Node(2);
        Node nodeC = new Node(3);
        Node nodeD = new Node(5);

        public void SetNodes()
        {
            list.head = new Node(23);
            list.head.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;
        }
        public static int count = 0;

        public void CountNodes() => Console.WriteLine("Count is =>" + count);

        public void DisplayNodes(Node head)
        {
            if (head == null)
                SetNodes();
            Node tc = head;
            while (tc != null)
            {
                count += tc.data;
                Console.Write(tc.data + "->");
                tc = tc.next;
            }
            Console.WriteLine("END");
        }

        public void ReverseNodes(Node head)
        {
            // a -> b -> c -> d -> null
            /* null <- a    b                -> c -> d
             * prev   curr  next = curr.next
             * null <- a      b                -> c -> d
             *         prev   curr              next = curr.next
            */
            // d -> c -> b -> a -> null [Output]
            Node prev = null;
            Node current = head;
            while (current != null)
            {
                Node next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            DisplayNodes(head);
        }

        public void InsertAtFirst(Node head)
        {
            Node current = head;
            head = new Node(123);
            head.next = current;

            DisplayNodes(head);
        }

        public void InsertAtLast(Node head)
        {
            Node current = head;
            Node trackNodes = current;
            while (current != null)
            {
                trackNodes = current;
                current = current.next;
            }

            trackNodes.next = new Node(39);
            DisplayNodes(trackNodes);
        }

        public void InsertAtKthPosition(int position, Node head)
        {
            if (position == 0 || head == null)
            {
                DisplayNodes(head);
                return;
            }

            Node current = head;
            Node trackNode = current;
            for (int i = 0; i < position; i++)
            {
                if (current == null)
                {
                    DisplayNodes(current);
                    return;
                }
                trackNode = current;
                current = current.next;
            }
            trackNode.next = new Node(234);
            trackNode.next.next = current;
            DisplayNodes(trackNode);
        }
        public Node RemoveDuplicatesFromLinkedList(Node head)
        {
            //1-1-1-3-4-5-5-6-7
            //1-3-4-5-5-6-7
            Node current = head;
            Node tracker;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    tracker = current.next.next;
                    current.next = null;
                    current.next = tracker;
                }
                else
                {
                    current = current.next;
                }
                
            }
            return current;
        }
        public Node deleteKthNode(LinkedListImplementation node, int k)
        {
            //Check base case
            if (node == null || k == 0)
            {
                return node.head;
            }
            //Given [1, 2, 3, 5] Delete c
            //Output should be [1, 2, 5]
            Node firstNode = node.head;
            Node secondNode = node.head;

            for (int i = 0; i < k; i++)
            {
                secondNode = secondNode.next;
                if (i == k - 1)
                {
                    secondNode.next = secondNode.next.next;
                }
            }

            while (secondNode != null)
            {
                firstNode.next = secondNode.next;
            }

            return firstNode;
        }

    }
}