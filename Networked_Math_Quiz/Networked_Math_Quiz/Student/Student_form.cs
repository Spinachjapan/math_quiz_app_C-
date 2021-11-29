/*
 * File name: Student_form.cs
 * Purpose: For the gui of student project
 * Author: Kohei Kaburaki
 * Date: 25th October, 2021
 * Version: 1.0
 * Note: This file will continue to be fixed and updated by Kohei or authoratized developers.
 */


using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace Networked_Math_Quiz
{
    public partial class Student_form : Form
    {
        public bool exitStatus = false; 
        public const int BYTE_SIZE = 1024; 
        public const string HOST_NAME = "localhost"; 
        public const int PORT_NUMBER = 8888;
        private TcpClient clientSocket;
        private NetworkStream netStream;
        private Thread clientThread = null;
        delegate void SetTextCallback(string text);

        private List<string> receive_list;

        private string result;



        public Student_form()
        {
            InitializeComponent();
            StartClient();
           
        
        }



        private void StartClient()
        {
            try
            {

                clientSocket = new TcpClient(HOST_NAME, PORT_NUMBER);
                netStream = clientSocket.GetStream(); 
                clientThread = new Thread(ReceiveStream);
                clientThread.Start();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Application.Exit();

            }
            
        }

        
        public void ReceiveStream()
        {
            byte[] bytesReceived = new byte[BYTE_SIZE];
            receive_list = new List<string>();
            while (! exitStatus)
            { 
                try
                {
                   
                    int bytesRead = netStream.Read(bytesReceived, 0, bytesReceived.Length);

                    

                    receive_list.Add(Encoding.ASCII.GetString(bytesReceived, 0, bytesRead));

                    this.SetText(receive_list[0]);

                  


                  
                
                }catch (System.IO.IOException)                
                {
                    Console.WriteLine("Server has exited!");
                    exitStatus = true;
                }
               



            }

           
        }


        
        private void SetText(string text)
        {

            if (this.question_textBox.InvokeRequired)
            {
                
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { 
                    text });
            }else{
                //For setting a question.
                this.question_textBox.Text = text + "=?";
                question_textBox.Enabled = true;
                answer_textBox.Enabled = true;
                submit_button.Enabled = true;
            }
        }


       




        







            private void submit_button_Click(object sender, EventArgs e)
        {
            // error check of input answer
            if (answer_textBox.Text == "")
            {
                MessageBox.Show("Please input a number.", "Answer Error", MessageBoxButtons.OK);
                return;
            }

            else
            {
                try
                {
                    int.Parse(answer_textBox.Text);
                }

                catch (System.FormatException)
                {
                    MessageBox.Show("The answer is not numeric.", "Answer Error", MessageBoxButtons.OK);
                    return;

                }


            }




            if (answer_textBox.Text == receive_list[1])
            {
                //answer was correct
                result = "y";

            }
            else
            {
                //answer was incorrect
                result = "n";
            }


           
                byte[] bytesToSend = Encoding.ASCII.GetBytes(result);
                netStream.Write(bytesToSend, 0, bytesToSend.Length);

            question_textBox.Text = "";
            answer_textBox.Text = "";


            question_textBox.Enabled = false;
            answer_textBox.Enabled = false;
            submit_button.Enabled = false;
            receive_list.Clear();
           

            }

        private void student_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (clientThread.IsAlive)
            {
                Console.WriteLine("Client thread is alive"); 
                clientThread.Interrupt(); if (clientThread.IsAlive) 
                {
                    Console.WriteLine("Client thread is now terminated"); 
                } 
            } else 
            {
                Console.WriteLine("Client thread is terminated"); 
            } 
             Environment.Exit(0);

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
