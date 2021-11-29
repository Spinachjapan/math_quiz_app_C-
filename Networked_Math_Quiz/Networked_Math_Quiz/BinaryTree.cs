/*
 * File name: BinaryTree.cs
 * Purpose: For binary tree structure and each order
 * Author: Kohei Kaburaki
 * Date: 25th October, 2021
 * Version: 1.0
 * Note: This file will continue to be fixed and updated by Kohei or authoratized developers.
         This file refers the third party library "BinaryTree", which is licensed from Hans Telford under GNU
 */


using System;


namespace Networked_Math_Quiz
{
    class BinaryTree
    {

        private Question root;
        public int count = 0;
        private String traversalString;


        //reset traversalString before next ordering
        public void methodsForSorting()
        {
            //root = null;
            //count = 0;
            traversalString = "";

        }

        

        public Question getRoot()
        {
            return root;
        }


        //For creating binary tree structure
        public void addToBinaryTree(Question data)
        {


            if (root == null)
            {
                root = data;
                count++;
            }
            else
            {
                Question current = root;
                Question parent;

                while (true)
                {
                    parent = current;

                    if (data.CompareTo(current) == -1)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = data;
                            count++;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = data;
                            count++;
                            return;
                        }
                    }

                }

            }

        }




        public void preOrder(Question root)
        {
            

            if (root != null)
            {
                
                traversalString += " " + root.ToString();

                preOrder(root.leftChild);
                preOrder(root.rightChild);

                

            }
        }

        public void postOrder(Question root)
        {
           

            if (root != null)
            {
                postOrder(root.leftChild);
                postOrder(root.rightChild);
                traversalString += " " + root.ToString();

            }
        }

        public void inOrder(Question root)
        {
       

            if (root != null)
            {
                inOrder(root.leftChild);
                traversalString += " " + root.ToString();
                inOrder(root.rightChild);
            }
        }

        //displayed in BinaryTreeTextarea
        public String getTraversalString()
        {
            return traversalString;
        }













    }
}
