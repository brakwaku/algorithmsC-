using System;

namespace algorithmsC9
{
    public class CustomTree
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }

            public int Data { get; set; }
        }

        public class BinaryTree
        {
            // PreOrder
            public static void preOrderTraversal(Node root)
            {
                if (root == null) { return; }

                Console.Write(root.Data + " ");
                preOrderTraversal(root.Left);
                preOrderTraversal(root.Right);
            }

            // InOrder
            public static void inOrderTraversal(Node root)
            {
                if (root == null) { return; }

                inOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                inOrderTraversal(root.Right);
            }

            // PostOrder
            public static void postOrderTraversal(Node root)
            {
                if (root == null) { return; }

                postOrderTraversal(root.Left);
                postOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        public class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                }
                else if (value < root.Data)
                {
                    // Insert on left
                    root.Left = Insert(root.Left, value);
                }
                else if (value > root.Data)
                {
                    // Insert on right
                    root.Right = Insert(root.Right, value);
                }

                return root;
            }
        }

        public static Boolean TreeContains(Node input, int value)
        {
            if (input == null)
            {
                return false; 
            }
            else if (value < input.Data)
            {
                return TreeContains(input.Left, value);
            }
            else if (value > input.Data)
            {
                return TreeContains(input.Right, value);
            }
            else
            {
                return true;
            }
        }

        public static void supposedFx3()
        {
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);
        }
    }
}