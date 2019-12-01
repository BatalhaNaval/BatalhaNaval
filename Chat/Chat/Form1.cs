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
        Jogo game;
        Barco b1 = new Barco() { Orientacao = true, Tamanho = 1 };
        Barco b2 = new Barco() { Orientacao = true, Tamanho = 2 };
        Barco b3 = new Barco() { Orientacao = true, Tamanho = 3 };
        Barco b4 = new Barco() { Orientacao = true, Tamanho = 4 };
        Barco b5 = new Barco() { Orientacao = true, Tamanho = 5 };
        int UltimoBarco = 0;

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

                    if (receiveMessage.Contains("!@#$%Venceu"))
                    {
                        MessageBox.Show("Ganhou Ka!@#$%lho");
                        this.Close();
                    } else if (receiveMessage.Contains("!@#$% - Acertou ")) {

                        var aux = receiveMessage.Replace("!@#$% - Acertou : ", "");
                        var x = Convert.ToInt32(aux.Split('x')[0]);
                        var y = Convert.ToInt32(aux.Split('x')[1]);

                        var butaos = new List<Button>();
                        
                        for (int i = 0; i < groupJogador2.Controls.Count; i++)
                        {
                            butaos.Add((Button)groupJogador2.Controls[i]);
                        }

                        var botao = butaos.FirstOrDefault(q => q.Name == x + "x" + y);
                        botao.BackColor = Color.Green;


                    } else if (receiveMessage.Contains("!@#$% - Errou "))
                    {

                        var aux = receiveMessage.Replace("!@#$% - Errou : ", "");
                        var x = Convert.ToInt32(aux.Split('x')[0]);
                        var y = Convert.ToInt32(aux.Split('x')[1]);

                        var butaos = new List<Button>();

                        for (int i = 0; i < groupJogador2.Controls.Count; i++)
                        {
                            butaos.Add((Button)groupJogador2.Controls[i]);
                        }

                        var botao = butaos.FirstOrDefault(q => q.Name == x + "x" + y);
                        botao.BackColor = Color.Purple;

                    }
                    else if (receiveMessage.Contains("#?!,.Comando: "))
                    {
                        groupJogador2.Enabled = true;
                        var butaos = new List<Button>();

                        var aux = receiveMessage.Replace("#?!,.Comando: ", "");
                        var x = Convert.ToInt32(aux.Split('x')[0]);
                        var y = Convert.ToInt32(aux.Split('x')[1]);

                        for (int i = 0; i < groupJogador1.Controls.Count; i++)
                        {
                            butaos.Add((Button)groupJogador1.Controls[i]);
                        }

                        var botaoSelecionado = butaos.FirstOrDefault(w => w.Name == x + "x" + y);
                        botaoSelecionado.BackColor = Color.Red;

                        if (game.Matriz_Jogo[x, y] == 1)
                        {

                            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                            byte[] msg = enc.GetBytes("!@#$% - Acertou : " + x + "x" + y);

                            socket.Send(msg);
                        }
                        else
                        {
                            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                            byte[] msg = enc.GetBytes("!@#$% - Errou : " + x + "x" + y);

                            socket.Send(msg);
                        }

                        var ListaButaos = new List<Button>();

                        for (int a = 0; a < groupJogador1.Controls.Count; a++)
                        {
                            ListaButaos.Add((Button)groupJogador1.Controls[a]);
                        }
                        bool status = true;
                        for (int i = 0; i < Math.Sqrt(game.Matriz_Jogo.Length); i++)
                        {
                            for (int j = 0; j < Math.Sqrt(game.Matriz_Jogo.Length); j++)
                            {
                                if (game.Matriz_Jogo[i, j] == 1 && ListaButaos.FirstOrDefault(p => p.Name == (i + "x" + j)).BackColor != Color.Red)
                                {
                                    status = false;
                                }
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Você perdeu!");
                            try
                            {
                                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                                byte[] msg = enc.GetBytes("!@#$%Venceu");

                                socket.Send(msg);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        listMessage.Items.Add(txtName_2.Text + " disse: " + receiveMessage);
                    }
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
            groupJogador1.Enabled = false;
            
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

                groupJogador2.Enabled = true;

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
            int[,] resposta = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    resposta[i, j] = 0;
                }
            }

            game = new Jogo(txtName_1.Text, txtName_2.Text, resposta, resposta);

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

                    novoBotao1.Click += (s, elemento) => {

                        Button botao = (Button)s;

                        Barco barcoSelecionado;

                        var ListaButaos = new List<Button>();

                        for (int a = 0; a < groupJogador1.Controls.Count; a++)
                        {
                            ListaButaos.Add((Button)groupJogador1.Controls[a]);
                        }

                        switch (UltimoBarco) 
                        {
                            case 1:
                                barcoSelecionado = b1;
                                break;
                            case 2:
                                barcoSelecionado = b2;
                                break;
                            case 3:
                                barcoSelecionado = b3;
                                break;
                            case 4:
                                barcoSelecionado = b4;
                                break;
                            case 5:
                                barcoSelecionado = b5;
                                break;
                            default:
                                return;
                        }

                        if (!barcoSelecionado.Ativo)
                            return;

                        var aux = new int[10,10];
                      
                        for(int a = 0; a < 10; a++)
                        {
                            for (int b = 0; b < 10; b++)
                            {
                                aux[a, b] = game.Matriz_Jogo[a, b];
                            
                            }
                        }
                        
                        bool erro = false;
                        var x = Convert.ToInt32(botao.Name.Split('x')[0]);
                        var y = Convert.ToInt32(botao.Name.Split('x')[1]);

                        for (int w = 0; w < barcoSelecionado.Tamanho; w++)
                        {
                            if (barcoSelecionado.Orientacao)
                            {
                                if (Math.Sqrt(aux.Length) <= (y + w ))
                                {
                                    erro = true;
                                }
                                else if ( aux[x, y + w] == 0)
                                {
                                    aux[x, y + w] = 1;
                                }
                                else 
                                {
                                    erro = true;
                                }
                            }
                            else 
                            {
                                if (Math.Sqrt(aux.Length) <= (x + w ))
                                {
                                    erro = true;
                                }
                                else if ( aux[x+w, y ] == 0)
                                {
                                    aux[x+w, y ] = 1;
                                }
                                else
                                {
                                    erro = true;
                                }
                            }
                        }

                        if (!erro)
                        {
                            game.Matriz_Jogo = aux;

                            for (int a = 0; a < 10; a++)
                            {
                                for (int b = 0; b < 10; b++)
                                {
                                    if (game.Matriz_Jogo[a, b] == 1)
                                    {
                                        var Butao = ListaButaos.FirstOrDefault(k => k.Name == a + "x" + b);
                                        Butao.BackColor = Color.Blue;
                                        barcoSelecionado.Ativo = false;
                                    }

                                }
                            }

                        }
                        else 
                        {
                            MessageBox.Show("Não pode colocar barco ai.");
                        }

                    };

                    novoBotao2.Click += (s , elemento) => {

                        var botaoClicado = (Button)s;
                        if (botaoClicado.BackColor != Color.Green && botaoClicado.BackColor != Color.Purple)
                        {
                            try
                            {
                                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                                byte[] msg = enc.GetBytes("#?!,.Comando: " + botaoClicado.Name);
                                socket.Send(msg);
                                groupJogador2.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                    }; 

                    groupJogador1.Controls.Add(novoBotao1);
                    groupJogador2.Controls.Add(novoBotao2);

                }

            }
        }

        private void Barco1_Click(object sender, EventArgs e)
        {
            UltimoBarco = 1;
        }

        private void Barco2_Click(object sender, EventArgs e)
        {
            UltimoBarco = 2;
        }

        private void Barco3_Click(object sender, EventArgs e)
        {
            UltimoBarco = 3;
        }

        private void Barco4_Click(object sender, EventArgs e)
        {
            UltimoBarco = 4;
        }

        private void Barco5_Click(object sender, EventArgs e)
        {
            UltimoBarco = 5;
        }

        private void Barco1_DoubleClick(object sender, EventArgs e)
        {
            b1.Orientacao = !b1.Orientacao;
            lblBarco1.Text = new string(lblBarco1.Text.Reverse().ToArray());
        }

        private void Barco2_DoubleClick(object sender, EventArgs e)
        {
            b2.Orientacao = !b2.Orientacao;
            lblBarco2.Text = new string(lblBarco2.Text.Reverse().ToArray());
        }

        private void Barco3_DoubleClick(object sender, EventArgs e)
        {
            b3.Orientacao = !b3.Orientacao;
            lblBarco3.Text = new string(lblBarco3.Text.Reverse().ToArray());
        }

        private void Barco4_DoubleClick(object sender, EventArgs e)
        {
            b4.Orientacao = !b4.Orientacao;
            lblBarco4.Text = new string(lblBarco4.Text.Reverse().ToArray());
        }

        private void Barco5_DoubleClick(object sender, EventArgs e)
        {
            b5.Orientacao = !b5.Orientacao;
            lblBarco5.Text = new string(lblBarco5.Text.Reverse().ToArray());
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
