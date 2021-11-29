/*
 * File name: Teacher_form.cs
 * Purpose: For the gui of Instructor project
 * Author: Kohei Kaburaki
 * Date: 25th October, 2021
 * Version: 1.0
 * Note: This file will continue to be fixed and updated by Kohei or authoratized developers.
 */



using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Networked_Math_Quiz
{
    public partial class Teacher_form : Form
    {

        public bool exitStatus = false; 
        public const int BYTE_SIZE = 1024;
        public const int PORT_NUMBER = 8888;
        private TcpListener serverListener;
        private TcpClient serverSocket;
        private NetworkStream netStream;
        private Thread serverThread = null;
      
        delegate void SetTextCallback (string text);

        private String first_number = null;
        private String second_number = null;
        private String operator_ = null;
        private string q_sentence = null;
        private string a_sentence = null;

        private List<Question> question_list = new List<Question>();
        private LinkedList<Question> incorrect_answers = new LinkedList<Question>();
        private Sort sort_instance;

        private string order_flag = null;

        private BinaryTree instance_binary_tree = new BinaryTree();



        public Teacher_form()
        {
            InitializeComponent();
            startServer();



        }

        private void startServer()
        {

            try
            {
                serverListener = new TcpListener(IPAddress.Loopback, PORT_NUMBER);
                serverListener.Start();
                serverSocket = serverListener.AcceptTcpClient();
                netStream = serverSocket.GetStream();
                serverThread = new Thread(ReceiveStream);

                serverThread.Start();

            }
            catch (Exception e)
            {
                // display exception message


            }

        }


        
        public void ReceiveStream()
        {
            byte[] bytesReceived = new byte[BYTE_SIZE];
       
            while (! exitStatus)
            {
                try
                {
                    int bytesRead = netStream.Read(bytesReceived, 0, bytesReceived.Length);

                    if (Encoding.ASCII.GetString(bytesReceived, 0, bytesRead) == "y")
                    {
                        //The case in which the student answer correctly.
                        MessageBox.Show("Correct!", "Correct Answer", MessageBoxButtons.OK);

                    }
                    else if (Encoding.ASCII.GetString(bytesReceived, 0, bytesRead) == "n")
                    {   
                        //The case in which the student answer incorrectly.
                        MessageBox.Show("InCorrect!", "Incorrect Answer", MessageBoxButtons.OK);

                       
                        incorrect_answers.AddLast(new Question(first_number, operator_, second_number, a_sentence));


                    }

  
                    question_list.Add(new Question(first_number, operator_, second_number, a_sentence));

                    instance_binary_tree.addToBinaryTree(new Question(first_number, operator_, second_number, a_sentence));

                    
                    Insert_to_cell();

                }
                catch (System.IO.IOException)                
                
                {
                    Console.WriteLine("Client has exited.");
                    exitStatus = true;
                
                }  
            }
        }


        //The function for inserting data to grid view.
        private void Insert_to_cell()
        {
            //For handling gui from client side
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Insert_to_cell));
                return;
            }
         
            firstNumber_textBox.Text = "";
            firstNumber_textBox.Enabled = true;
            operator_comboBox.SelectedIndex = 0;
            operator_comboBox.Enabled = true;
            secondNumber_textBox.Text = "";
            secondNumber_textBox.Enabled = true;
            answer_textBox.Text = "";
            answer_textBox.Enabled = true;
            send_button.Enabled = true;

          


            mathQuiz_dataGridView.Rows.Clear();

            foreach (Question each_question in question_list)
                {
                    mathQuiz_dataGridView.Rows.Add(each_question.First, each_question.Operator, each_question.Second, "=", each_question.Answer);

                }


        }







        
        private void send_button_Click(object sender, EventArgs e)
        {
            //sending question to client side
           


            first_number = firstNumber_textBox.Text;
            second_number = secondNumber_textBox.Text;
            operator_ = operator_comboBox.SelectedItem.ToString();


            List<string> error_list = new List<string>();


            //error check of question
            if (first_number == "")
            {
                error_list.Add("First number is missing.");
            }
    
            else
            {
                try
                {
                    int.Parse(first_number);
                }

                catch(System.FormatException)
                {
                    error_list.Add("First number is not numeric.");

                }
                

            }



            if (second_number == "")
            {
                error_list.Add("Second number is missing.");
            }

            else
            {
                try
                {
                    int.Parse(second_number);
                }

                catch (System.FormatException)
                {
                    error_list.Add("Second number is not numeric.");

                }


            }

            if (error_list.Count != 0)
            {
                string error_sentence = "";

                for (int i = 0; i<error_list.Count; i++)
                {
                    error_sentence += error_list[i] + "\n";

                }



                MessageBox.Show(error_sentence, error_list.Count.ToString() + " error(s) detected!",  MessageBoxButtons.OK);
                return;

            }

          



            if (operator_ == "+")
            {

                q_sentence = first_number + " + " + second_number;
                a_sentence = (int.Parse(first_number) + int.Parse(second_number)).ToString();
                
                
                

            }
            else if (operator_ == "-")
            {
                q_sentence = first_number + " - " + second_number;
                a_sentence = (int.Parse(first_number) - int.Parse(second_number)).ToString();

              
            }
            else if (operator_ == "*")
            {
                q_sentence = first_number + " * " + second_number;
                a_sentence = (int.Parse(first_number) * int.Parse(second_number)).ToString();

             
            }
            else if (operator_ == "/")
            {
                q_sentence = first_number + " / " + second_number;
                a_sentence = (int.Parse(first_number) / int.Parse(second_number)).ToString();

            
            }

            answer_textBox.Text = a_sentence;


            byte[] sentQuestion = Encoding.ASCII.GetBytes(q_sentence);
                byte[] sentAnswer = Encoding.ASCII.GetBytes(a_sentence);

            netStream.Write(sentQuestion, 0, sentQuestion.Length);
            netStream.Write(sentAnswer, 0, sentAnswer.Length);

            firstNumber_textBox.Enabled = false;
            operator_comboBox.Enabled = false;
            secondNumber_textBox.Enabled = false;
            send_button.Enabled = false;

            





        }


        private void teacher_FormClosed(object sender, FormClosedEventArgs e)
        {

             if (serverThread.IsAlive) { 
                
                Console.WriteLine("Server thread is alive"); 
                serverThread.Interrupt(); if (serverThread.IsAlive) 
                { 
                    Console.WriteLine("Server thread is now terminated"); 
                } 
            } else { 
                Console.WriteLine("Server thread is terminated"); 
            
            }
            Environment.Exit(0);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Setting the default operator(+)
            operator_comboBox.SelectedIndex = 0;
        }

        private void bubble_button_Click(object sender, EventArgs e)
        {
            sort_instance = new Sort(question_list);
            question_list = sort_instance.bubble_sort();
            Insert_to_cell();

                   

        }

        private void selection_button_Click(object sender, EventArgs e)
        {
            sort_instance = new Sort(question_list);
            question_list = sort_instance.selection_sort();
            Insert_to_cell();

        }

        private void insertion_button_Click(object sender, EventArgs e)
        {
            sort_instance = new Sort(question_list);
            question_list = sort_instance.insertion_sort();
            Insert_to_cell();

        }

        private void linkedList_button_Click(object sender, EventArgs e)
        {
            string incorrect_answer_show;
            if (incorrect_answers.Count == 0)
            {
                incorrect_answer_show = "No incorrectly answered question.";

            }
            else
            {
                incorrect_answer_show = "HEAD<->";

                foreach (Question each in incorrect_answers)
                {

                    incorrect_answer_show += each.Answer + "(" + each.First + each.Operator + each.Second + ")<->";


                }

                incorrect_answer_show += "TAIL";



            }

            wrongAnswer_TextBox.Text = incorrect_answer_show;

        }


        private void order(string type)
        {

          


            instance_binary_tree.methodsForSorting();
     
            
            //pre-order       
            if (type.Equals("pre"))
            {
                
               instance_binary_tree.preOrder(instance_binary_tree.getRoot());
                BT_TextArea.Text = "PRE-ORDER:" + instance_binary_tree.getTraversalString();
            }
            //in-order    
            else if (type.Equals("in"))
            {
                instance_binary_tree.inOrder(instance_binary_tree.getRoot());
                BT_TextArea.Text = "IN-ORDER:" + instance_binary_tree.getTraversalString();
            }
            //post-order    
            else if (type.Equals("post"))
            {
                instance_binary_tree.postOrder(instance_binary_tree.getRoot());
                BT_TextArea.Text = "POST-ORDER:" + instance_binary_tree.getTraversalString();
            }

            




        }

        private void preDisplay_button_Click(object sender, EventArgs e)
        {
            if (instance_binary_tree.count == 0)
            {
                BT_TextArea.Text = "No math questions have been set up.";
                return;
            }

            order_flag = "Pre";
            order("pre");

        }

        private void inDisplay_button_Click(object sender, EventArgs e)
        {
            if (instance_binary_tree.count == 0)
            {
                BT_TextArea.Text = "No math questions have been set up.";
                return;
            }
            order_flag = "In";
            order("in");

        }

        private void postDisplay_button_Click(object sender, EventArgs e)
        {
            if (instance_binary_tree.count == 0)
            {
                BT_TextArea.Text = "No math questions have been set up.";
                return;
            }

            order_flag = "Post";
            order("post");
        }

        private void search_button_Click(object sender, EventArgs e)
        {
           
           string searched_question = search_textBox.Text;

            if (searched_question == "")
            {
                MessageBox.Show("Please input a question and the answer.", "The text field is empty.", MessageBoxButtons.OK);
                return;
            }

            else if (!Regex.IsMatch(searched_question, @"^[0-9]{1,}[\+\-\*\/][0-9]{1,}=[0-9]{1,}"))
            {
                MessageBox.Show("The format is wrong", "Wrong format", MessageBoxButtons.OK);
                return;

            }



            //hash search method
                var question_hash_set = new HashSet<string>();
           

            foreach (Question each in question_list)
            {
 
                    question_hash_set.Add(each.First + each.Operator + each.Second + "=" + each.Answer);
               
            }


            if (question_hash_set.Contains(searched_question))
            {
                BT_TextArea.Text = searched_question + " found!";

            }
            else
            {
                BT_TextArea.Text = "";


            }







        }


        //For writing down ordered questions to text files.
        private void write_down(string order)
        {
            if (order_flag == null)
            {
                MessageBox.Show("No math question has been displayed.", "No questions displayed.", MessageBoxButtons.OK);
                return;


            }

            else if (order_flag != order)
            {
                MessageBox.Show("Please press " + order + "-order button.", "The questions are not shown correctly.", MessageBoxButtons.OK);
                return;


            }

            else
            {



                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                StreamWriter writer =
                  new StreamWriter(order + "_order.txt", true, sjisEnc);
                writer.WriteLine(BT_TextArea.Text);
                writer.Close();

                MessageBox.Show("The ordered data has been saved.", "Saving Succeeded.", MessageBoxButtons.OK);
                return;



            }

        }

        private void preSave_button_Click(object sender, EventArgs e)
        {
            write_down("Pre");

        }

        private void inSave_button_Click(object sender, EventArgs e)
        {
            write_down("In");

        }

        private void postSave_button_Click(object sender, EventArgs e)
        {
            write_down("Post");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Will you exit?", "EXIT OPTIONS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }

        }
    }
}
