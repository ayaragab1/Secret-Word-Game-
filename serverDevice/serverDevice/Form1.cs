using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serverDevice
{

    public partial class Server : Form
    {
        public string myproperty { get; set; }
        TcpListener _ASserver;
        Socket _ASconnection;
        NetworkStream _ASStream;
        BinaryWriter _ASbr;
        BinaryReader _ASrbr;
        string path;
        int _ASf = 1;
        string result;
        int countServer = 0;
        int countclient = 0;
        byte[] data;
        string _ARword;
        ServerConfig sr = new ServerConfig();

        ServerConfig _ArserverConfig;
        private int _BwrongGuesses = 0;
     

        private string _BCopyCurrentWord = "";
        public Server()
        {
            InitializeComponent();
            byte[] _ASbt = new byte[] { 127, 0, 0, 1 };
            IPAddress _ASip = new IPAddress(_ASbt);
            _ASserver = new TcpListener(_ASip, 1025);
             path =  Directory.GetCurrentDirectory() + "\\result.txt";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void _ASconnectionStartthread()
        {
            _ASserver.Start();
            _ASconnection = _ASserver.AcceptSocket();
            _ASStream = new NetworkStream(_ASconnection);
            
        }

        private void _ASstart_Click(object sender, EventArgs e)
        {
            try
            {
                Thread _ASconnectionStart = new Thread(new ThreadStart(_ASconnectionStartthread));
                _ASconnectionStart.IsBackground = true;
                _ASconnectionStart.Start();
                MessageBox.Show("Server Connection started");


            }

            catch (Exception)
            {
                MessageBox.Show("is really started");
            }


            sr.ShowDialog();
        }
        public object ArserverConfig { get { return _ArserverConfig; } }
        public void _ASreceivecclient()
        {
            do
            {
                _ASrbr = new BinaryReader(_ASStream);
                string s = _ASrbr.ReadString();
                   if (s == "0")
                {
                    MessageBox.Show("Player want to play");
                }
               else if (s == "1")
                {
                    MessageBox.Show("SYou lose");
                    countclient++;
                    
                    result = $"Server values is {countServer} client value is{countclient} \n";
                    data = new UTF8Encoding(true).GetBytes(result);
                    using (FileStream fileStream = new FileStream(path, FileMode.Append))
                    {
                        fileStream.Write(data, 0, data.Length);
                    }

                    _AScolose.Visible = true;
                    _ASstart.Visible = true;

                    button2.Visible = true;
                    lblshowWord.Visible = false;
                    btnA.Visible = false;
                    btnB.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    button15.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    button18.Visible = false;
                    button19.Visible = false;
                    button20.Visible = false;
                    button21.Visible = false;
                    button22.Visible = false;
                    button23.Visible = false;
                    button24.Visible = false;
                    button26.Visible = false;
                    button27.Visible = false;
                    foreach (Control a in this.Controls)
                    {
                        a.Enabled = true;
                    }

                }
              
                else if (Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                {
                    this.Invoke(new MethodInvoker(delegate

                    {
                        foreach (Control b in this.Controls)
                        {
                            if (b.Text == s)
                            {
                                b.Visible = false;
                            }

                        }

                      }));
            }
                if (s == "4")
                {
                    _AScolose.Visible = true;
                    _ASstart.Visible = true;

                    button2.Visible = true;
                    lblshowWord.Visible = false;
                    btnA.Visible = false;
                    btnB.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    button15.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    button18.Visible = false;
                    button19.Visible = false;
                    button20.Visible = false;
                    button21.Visible = false;
                    button22.Visible = false;
                    button23.Visible = false;
                    button24.Visible = false;
                    button26.Visible = false;
                    button27.Visible = false;
                    foreach (Control a in this.Controls)
                    {
                        a.Enabled = true;
                    }
                }
                if (s == "7")
                {
                    this.Invoke(new MethodInvoker(delegate

                    {
                        foreach (Control b in this.Controls)
                        {

                            b.Enabled = true;

                        }
                       }));

                }
                else if(s=="18"){
                    foreach (Control i in this.Controls)
                    {
                        i.Enabled = true;
                    }
                }
             
          
                else if (s.Length >= 3 && s.Length <= 6)
                {
                    _BCopyCurrentWord = s;
                    _BDisplayWordInDashLine();

                }

            }
            while (_ASf == 1);
        }
        private void _AScolose_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime now = DateTime.Now;
                result = now.ToString() + "\n";
                data = new UTF8Encoding(true).GetBytes(result);
                using (FileStream fileStream = new FileStream(path, FileMode.Append))
                {
                    fileStream.Write(data, 0, data.Length);
                }
                _ASStream.Close();
            
                try
                {

                    _ASconnection.Shutdown(SocketShutdown.Both);

                }
                finally
                {
                    _ASf = 0;
                    _ASconnection.Close();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("no connection");
            }


        }

        private void messageboxclient_Click(object sender, EventArgs e)
        {
            _ASsetid("2");

        }
        public void _ASsetid(string _ASi)
        {
            try
            {
                _ASbr = new BinaryWriter(_ASStream);
                _ASbr.Write(_ASi);
            }
            catch (Exception)
            {

                MessageBox.Show("something went wrong");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Thread _ASmserverthread = new Thread(new ThreadStart(_ASreceivecclient));
            _ASmserverthread.IsBackground = false;
            _ASmserverthread.Start();

            _ARword = sr._ARSelectedWord;
            string all;

            all = "5" + "," + sr._ARcategory + "," + sr._ARLevel + "," + _ARword;
            _ASsetid(all);
            _AScolose.Visible = false;
            _ASstart.Visible = false;

            button2.Visible = false;
            lblshowWord.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            label1.Visible = false; 




            _BPrepareWordInDashLine();
            foreach(Control i in this.Controls)
            {
                i.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void _BPrepareWordInDashLine()
        {
            _ARword = _ARword.Replace(" ", "").ToUpper();
            MessageBox.Show($"form diplayfunctiom{_ARword}");
            _BCopyCurrentWord = "";
            for (int i = 0; i < _ARword.Length; i++)
            {
                _BCopyCurrentWord += "_";
            }
            _BDisplayWordInDashLine();


        }
        private void _BDisplayWordInDashLine()
        {
            lblshowWord.Text = "";

            for (int i = 0; i < _BCopyCurrentWord.Length; i++)
            {

                lblshowWord.Text += _BCopyCurrentWord.Substring(i, 1);
                lblshowWord.Text += " ";
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {

         
        }

        private void btnA_Click_1(object sender, EventArgs e)
        {
          
            Button btnChoise = sender as Button;
          
            btnChoise.Enabled = false;
            if (_ARword.Contains(btnChoise.Text))
            {
               
                char[] _BTemp = _BCopyCurrentWord.ToCharArray();
               
                char[] _Bfind = _ARword.ToCharArray();
              
                char _BGussChar = btnChoise.Text.ElementAt(0);
                for (int i = 0; i < _Bfind.Length; i++)
                {
                    if (_Bfind[i] == _BGussChar)
                    {
                        _BTemp[i] = _BGussChar;
                    }
                }
              
                _BCopyCurrentWord = new string(_BTemp);
                _BDisplayWordInDashLine();
                btnChoise.Visible = false;
                _ASsetid(btnChoise.Text);
                _ASsetid(_BCopyCurrentWord);
                if (_BCopyCurrentWord == _ARword)
                {
                    
                    MessageBox.Show("Scongratulation\nYou Win");
                    _ASsetid("1");
                    countServer++;
                    result = $"Server values is {countServer} client value is {countclient} \n";
                    data = new UTF8Encoding(true).GetBytes(result);
                    using (FileStream fileStream = new FileStream(path, FileMode.Append))
                    {
                        fileStream.Write(data, 0, data.Length);
                    }

                    _AScolose.Visible = true;
                    _ASstart.Visible = true;

                    button2.Visible = true;
                    lblshowWord.Visible = false;
                    btnA.Visible = false;
                    btnB.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    button15.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    button18.Visible = false;
                    button19.Visible = false;
                    button20.Visible = false;
                    button21.Visible = false;
                    button22.Visible = false;
                    button23.Visible = false;
                    button24.Visible = false;
                    button26.Visible = false;
                    button27.Visible = false;
                    foreach (Control a in this.Controls)
                    {
                        a.Enabled = true;
                    }
                }

            }

            else
            {


                Thread t = new Thread(() => _ASsetid(btnChoise.Text)
                );
                t.IsBackground = true;
                t.Start();
                btnChoise.Visible = false;
                    foreach (Control b in this.Controls)
                {

                    b.Enabled = false;

                }
                _ASsetid("7");
               
                
            }



        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            string path = Directory.GetCurrentDirectory() + "\\result.txt";
            File.OpenRead(path);
            StreamReader sr = new StreamReader(path);
            frm.Label = sr.ReadToEnd();
            frm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblshowWord_Click(object sender, EventArgs e)
        {

        }
    }
}
