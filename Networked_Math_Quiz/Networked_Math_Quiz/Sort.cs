/*
 * File name: Sort.cs
 * Purpose: For sorting methods (Bubble,  Selection, Insertion)
 * Author: Kohei Kaburaki
 * Date: 25th October, 2021
 * Version: 1.0
 * Note: This file will continue to be fixed and updated by Kohei or authoratized developers.
 */


using System.Collections.Generic;


namespace Networked_Math_Quiz
{
    class Sort
    {
        //each sorting function returns sorted linked list

        private List<Question> question_list { get; set; }

        private Question memo;

      public  Sort(List<Question> q_list)
        {
            this.question_list = q_list;

        }

        public List<Question> bubble_sort()
        {

            bool bubble_flag = false;

            while (!bubble_flag)
            {
                bubble_flag = true;
                for (int i = 0; i < question_list.Count - 1; i++)
                {

                    if (question_list[i].CompareTo(question_list[i + 1]) == 1)
                    {

                        memo = question_list[i];
                        question_list[i] = question_list[i + 1];

                        question_list[i + 1] = memo;
                        bubble_flag = false;
                    }

                }

            }


            return question_list;


        }


        public List<Question> selection_sort()
        {
            for (int i = 0; i < question_list.Count; i++)
            {

                int maximum = i;

                for (int j = i + 1; j < question_list.Count; j++)
                {
                    if (question_list[j].CompareTo(question_list[i]) == 1)
                    {
                        maximum = j;
                    }
                }

                memo = question_list[i];
                question_list[i] = question_list[maximum];
                question_list[maximum] =  memo;

            }

            return question_list;
        }



        public List<Question> insertion_sort()
        {

            for (int i = 1; i < question_list.Count; i++)
            {
                
                for (int j = 0; j < i; j++)
                {

                    if (question_list[j].CompareTo(question_list[i]) == 1)
                    {

                        memo = question_list[j];
                        question_list[j] = question_list[i];
                        question_list[i] = memo;

                    }

                }






            }


            return question_list;
        }























        }
}
