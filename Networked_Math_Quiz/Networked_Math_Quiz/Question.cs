/*
 * File name: Question.cs
 * Purpose: For each of Question objects
 * Author: Kohei Kaburaki
 * Date: 25th October, 2021
 * Version: 1.0
 * Note: This file will continue to be fixed and updated by Kohei or authoratized developers.
 */



using System;


namespace Networked_Math_Quiz
{
    class Question : IComparable<Question>
    {
        public string First { get; set; }
        public string Operator { get; set; }
        public string Second { get; set; }
        public string Answer { get; set; }

        public Question leftChild { get; set;}
        public Question rightChild { get; set; }






        public Question(string first, string operator_, string second, string answer)
        {
            this.First = first;
            this.Operator = operator_;
            this.Second = second;
            this.Answer = answer;

            
            
            

        }
        //Comparing answers for sorting and ordering
        public int CompareTo(Question other)
        {
            if (int.Parse(this.Answer) == int.Parse(other.Answer))
            {
                return 0;
            }
            else if (int.Parse(this.Answer) < int.Parse(other.Answer))
            {
                return -1;
            }
            else
            {
                return 1;
            }



        }




        public override string ToString()
        {

            return this.Answer + "(" + this.First + this.Operator + this.Second + ")";
        }



    }
}
