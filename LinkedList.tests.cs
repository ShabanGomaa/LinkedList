using System;
using Xunit;

using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.DataStructures.Tests
{
    public class LinkedListTest
    {
        [Fact]
        public void AddToFirst_Node_Should_Become_Head()
        {
            // Arrange
            var myLinkedList = new LinkedList<int>(new Node<int>(45));

            // Act
            var nodeToAdd = new Node<int>(67);
            myLinkedList.AddToFirst(nodeToAdd);

            // Assert
            var theNode = GetNodeFromList<int>(myLinkedList, nodeToAdd);
            Assert.Equal(nodeToAdd, theNode);
            Assert.Equal(45, theNode.Next.Data);
        }

        [Fact]
        public void AddToLast_Node_Should_Become_Tail()
        {
            // Arrange
            var myLinkedList = new LinkedList<int>(new Node<int>(35));

            // Act
            var nodeToAdd = new Node<int>(14);
            myLinkedList.AddToLast(nodeToAdd);

            // Assert
            var theNode = GetNodeFromList<int>(myLinkedList, nodeToAdd);
            Assert.Equal(nodeToAdd, theNode);
        }

        [Fact]
        public void RemoveFirst_Next_Node_Should_Be_Head()
        {
            // Arrange
            var myLinkedList = new LinkedList<int>(new Node<int>(777));

            var node1 = new Node<int>(1);
            myLinkedList.AddToLast(node1);

            var node2 = new Node<int>(2);
            myLinkedList.AddToLast(node2);

            var node3 = new Node<int>(3);
            myLinkedList.AddToLast(node3);

            // Act
            myLinkedList.RemoveFirst();

            // Assert
            var theNode = GetNodeFromList<int>(myLinkedList, node1);
            Assert.Equal(node1, myLinkedList.Head);
        }

        [Fact]
        public void RemoveLast_Next_Node_Should_Be_Tail()
        {
            // Arrange
            var myLinkedList = new LinkedList<int>(new Node<int>(777));

            var node1 = new Node<int>(1);
            myLinkedList.AddToLast(node1);

            var node2 = new Node<int>(2);
            myLinkedList.AddToLast(node2);

            var node3 = new Node<int>(3);
            myLinkedList.AddToLast(node3);

            // Act
            myLinkedList.RemoveLast();

            // Assert
            var theNode = GetNodeFromList<int>(myLinkedList, node2);
            Assert.Equal(node2, myLinkedList.Tail);
        }

        public static Node<T> GetNodeFromList<T>(LinkedList<T> someLinkedList, Node<T> someNode) where T : struct
        {
            using (var itr = someLinkedList.GetEnumerator())
            {
                while (itr.Current != someNode)
                {
                    itr.MoveNext();
                }
                return itr.Current;
            }
        }
    }
}