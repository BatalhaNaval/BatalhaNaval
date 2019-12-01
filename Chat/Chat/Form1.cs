using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint endPointLocal, endPointRemote;

        public Form1()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtIP_1.Text = GetLocal();
            txtIP_2.Text = GetLocal();
        }

        public string GetLocal()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        public void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                int tam = socket.EndReceiveFrom(asyncResult, ref endPointRemote);


                if (tam > 0)
                {
                    byte[] receiveData = (byte[])asyncResult.AsyncState;

                    ASCIIEncoding ecg = new ASCIIEncoding();

                    string receiveMessage = ecg.GetString(receiveData);

                    listMessage.Items.Add(txtName_2.Text + " disse: " + receiveMessage);
                }

                byte[] buffer = new byte[1500];

                socket.BeginReceiveFrom(buffer, 0, buffer.Length, 
                                        SocketFlags.None, ref endPointRemote, 
                                        new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtIP_1.Enabled = false;
            txtIP_2.Enabled = false;
            txtName_1.Enabled = false;
            txtName_2.Enabled = false;
            txtPort_1.Enabled = false;
            txtPort_2.Enabled = false;

            try
            {
                endPointLocal = new IPEndPoint(IPAddress.Parse(txtIP_1.Text), Convert.ToInt32(txtPort_1.Text));
                socket.Bind(endPointLocal);

                endPointRemote = new IPEndPoint(IPAddress.Parse(txtIP_2.Text), Convert.ToInt32(txtPort_2.Text));
                socket.Connect(endPointRemote);

                byte[] buffer = new byte[1500];

                socket.BeginReceiveFrom(buffer, 0, buffer.Length,
                                        SocketFlags.None, ref endPointRemote,
                                        new AsyncCallback(MessageCallBack), buffer);

                btnConnect.Enabled = false;
                txtMessage.Enabled = true;
                txtMessage.Focus();

                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var coluna_1 = (groupJogador1.Width - 20) / 10;
            var altura_1 = (groupJogador1.Height - 25) / 10;
            var coluna_2 = (groupJogador2.Width - 20) / 10;
            var altura_2 = (groupJogador2.Height - 25) / 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var novoBotao1 = new Button()
                    {
                        Name = i + "x" + j,
                        BackColor = Color.Gray,
                        Location = new Point(10 + (i * coluna_1), (15 + (j * altura_1))),
                        Width = coluna_1,
                        Height = altura_1

                    };

                    var novoBotao2 = new Button()
                    {
                        Name = i + "x" + j,
                        BackColor = Color.Gray,
                        Location = new Point(10 + (i * coluna_2), (15 + (j * altura_2))),
                        Width = coluna_2,
                        Height = altura_2

                    };

                    groupJogador1.Controls.Add(novoBotao1);
                    groupJogador2.Controls.Add(novoBotao2);

                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                byte[] msg = enc.GetBytes(txtMessage.Text);

                socket.Send(msg);

                listMessage.Items.Add(txtName_1.Text + " disse:" + txtMessage.Text);
                txtMessage.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
