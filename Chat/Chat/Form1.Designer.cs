namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_1 = new System.Windows.Forms.TextBox();
            this.txtPort_1 = new System.Windows.Forms.TextBox();
            this.txtIP_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_2 = new System.Windows.Forms.TextBox();
            this.txtPort_2 = new System.Windows.Forms.TextBox();
            this.txtIP_2 = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.groupJogador2 = new System.Windows.Forms.GroupBox();
            this.groupJogador1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName_1);
            this.groupBox1.Controls.Add(this.txtPort_1);
            this.groupBox1.Controls.Add(this.txtIP_1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seu nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "I. P.";
            // 
            // txtName_1
            // 
            this.txtName_1.Location = new System.Drawing.Point(192, 87);
            this.txtName_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName_1.Name = "txtName_1";
            this.txtName_1.Size = new System.Drawing.Size(159, 22);
            this.txtName_1.TabIndex = 5;
            // 
            // txtPort_1
            // 
            this.txtPort_1.Location = new System.Drawing.Point(111, 55);
            this.txtPort_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort_1.Name = "txtPort_1";
            this.txtPort_1.Size = new System.Drawing.Size(240, 22);
            this.txtPort_1.TabIndex = 4;
            // 
            // txtIP_1
            // 
            this.txtIP_1.Location = new System.Drawing.Point(111, 23);
            this.txtIP_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP_1.Name = "txtIP_1";
            this.txtIP_1.Size = new System.Drawing.Size(240, 22);
            this.txtIP_1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(368, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtName_2);
            this.groupBox3.Controls.Add(this.txtPort_2);
            this.groupBox3.Controls.Add(this.txtIP_2);
            this.groupBox3.Location = new System.Drawing.Point(392, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(360, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apelido para amigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Porta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "I. P.";
            // 
            // txtName_2
            // 
            this.txtName_2.Location = new System.Drawing.Point(192, 87);
            this.txtName_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName_2.Name = "txtName_2";
            this.txtName_2.Size = new System.Drawing.Size(159, 22);
            this.txtName_2.TabIndex = 2;
            // 
            // txtPort_2
            // 
            this.txtPort_2.Location = new System.Drawing.Point(111, 55);
            this.txtPort_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort_2.Name = "txtPort_2";
            this.txtPort_2.Size = new System.Drawing.Size(240, 22);
            this.txtPort_2.TabIndex = 1;
            // 
            // txtIP_2
            // 
            this.txtIP_2.Location = new System.Drawing.Point(111, 23);
            this.txtIP_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP_2.Name = "txtIP_2";
            this.txtIP_2.Size = new System.Drawing.Size(240, 22);
            this.txtIP_2.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(16, 553);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(735, 50);
            this.txtMessage.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Enabled = false;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(760, 553);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 50);
            this.btnSend.TabIndex = 7;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(760, 39);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 98);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(16, 460);
            this.listMessage.Margin = new System.Windows.Forms.Padding(4);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(853, 68);
            this.listMessage.TabIndex = 2;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // groupJogador2
            // 
            this.groupJogador2.Location = new System.Drawing.Point(392, 182);
            this.groupJogador2.Name = "groupJogador2";
            this.groupJogador2.Size = new System.Drawing.Size(360, 214);
            this.groupJogador2.TabIndex = 12;
            this.groupJogador2.TabStop = false;
            this.groupJogador2.Text = "Jogador 2";
            // 
            // groupJogador1
            // 
            this.groupJogador1.Location = new System.Drawing.Point(16, 182);
            this.groupJogador1.Name = "groupJogador1";
            this.groupJogador1.Size = new System.Drawing.Size(360, 214);
            this.groupJogador1.TabIndex = 11;
            this.groupJogador1.TabStop = false;
            this.groupJogador1.Text = "Jogador 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(891, 616);
            this.Controls.Add(this.groupJogador2);
            this.Controls.Add(this.groupJogador1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bate-Papo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName_1;
        private System.Windows.Forms.TextBox txtPort_1;
        private System.Windows.Forms.TextBox txtIP_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName_2;
        private System.Windows.Forms.TextBox txtPort_2;
        private System.Windows.Forms.TextBox txtIP_2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.GroupBox groupJogador2;
        private System.Windows.Forms.GroupBox groupJogador1;
    }
}

