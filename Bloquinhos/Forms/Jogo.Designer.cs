namespace Bloquinhos
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGirar = new System.Windows.Forms.Label();
            this.lblColorir = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGirarAntiHorario = new System.Windows.Forms.Button();
            this.btnGirarHorario = new System.Windows.Forms.Button();
            this.btnRandomico = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Solucionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox_Movimenta_C = new System.Windows.Forms.CheckBox();
            this.checkBox_Solucao_Hard = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Cores = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Matriz = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4_Retornar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Numero_PC = new System.Windows.Forms.Label();
            this.lbl_Numero_Jog = new System.Windows.Forms.Label();
            this.pontuacao_jog = new System.Windows.Forms.Label();
            this.pontuacao_comp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_colorir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnVermelho.ForeColor = System.Drawing.Color.Black;
            this.btnVermelho.Location = new System.Drawing.Point(1177, 175);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(71, 50);
            this.btnVermelho.TabIndex = 13;
            this.btnVermelho.UseVisualStyleBackColor = false;
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Enabled = false;
            this.btnAzul.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.Black;
            this.btnAzul.Location = new System.Drawing.Point(1177, 231);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(71, 50);
            this.btnAzul.TabIndex = 14;
            this.btnAzul.UseVisualStyleBackColor = false;
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Enabled = false;
            this.btnVerde.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.Black;
            this.btnVerde.Location = new System.Drawing.Point(1177, 287);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(71, 50);
            this.btnVerde.TabIndex = 15;
            this.btnVerde.UseVisualStyleBackColor = false;
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.Enabled = false;
            this.btnAmarelo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarelo.ForeColor = System.Drawing.Color.Black;
            this.btnAmarelo.Location = new System.Drawing.Point(1177, 348);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(71, 50);
            this.btnAmarelo.TabIndex = 16;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            // 
            // btnLaranja
            // 
            this.btnLaranja.BackColor = System.Drawing.Color.Orange;
            this.btnLaranja.Enabled = false;
            this.btnLaranja.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaranja.ForeColor = System.Drawing.Color.Black;
            this.btnLaranja.Location = new System.Drawing.Point(1177, 404);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(71, 50);
            this.btnLaranja.TabIndex = 17;
            this.btnLaranja.UseVisualStyleBackColor = false;
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.Color.Pink;
            this.btnRosa.Enabled = false;
            this.btnRosa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosa.ForeColor = System.Drawing.Color.Black;
            this.btnRosa.Location = new System.Drawing.Point(1177, 460);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(71, 50);
            this.btnRosa.TabIndex = 18;
            this.btnRosa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1068, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pontuação";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblPontuacao.ForeColor = System.Drawing.Color.Black;
            this.lblPontuacao.Location = new System.Drawing.Point(1123, 617);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(26, 29);
            this.lblPontuacao.TabIndex = 20;
            this.lblPontuacao.Text = "0";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTempo.ForeColor = System.Drawing.Color.Black;
            this.lblTempo.Location = new System.Drawing.Point(959, 617);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(52, 29);
            this.lblTempo.TabIndex = 21;
            this.lblTempo.Text = "120";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGirar
            // 
            this.lblGirar.AutoSize = true;
            this.lblGirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirar.Location = new System.Drawing.Point(716, 119);
            this.lblGirar.Name = "lblGirar";
            this.lblGirar.Size = new System.Drawing.Size(64, 25);
            this.lblGirar.TabIndex = 26;
            this.lblGirar.Text = "Girar";
            // 
            // lblColorir
            // 
            this.lblColorir.AutoSize = true;
            this.lblColorir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorir.Location = new System.Drawing.Point(944, 313);
            this.lblColorir.Name = "lblColorir";
            this.lblColorir.Size = new System.Drawing.Size(82, 25);
            this.lblColorir.TabIndex = 28;
            this.lblColorir.Text = "Colorir";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitulo.Location = new System.Drawing.Point(829, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 60);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Bloquinhos";
            // 
            // btnGirarAntiHorario
            // 
            this.btnGirarAntiHorario.BackColor = System.Drawing.Color.Transparent;
            this.btnGirarAntiHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirarAntiHorario.BackgroundImage")));
            this.btnGirarAntiHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGirarAntiHorario.Location = new System.Drawing.Point(675, 161);
            this.btnGirarAntiHorario.Name = "btnGirarAntiHorario";
            this.btnGirarAntiHorario.Size = new System.Drawing.Size(68, 64);
            this.btnGirarAntiHorario.TabIndex = 25;
            this.btnGirarAntiHorario.UseVisualStyleBackColor = false;
            this.btnGirarAntiHorario.Click += new System.EventHandler(this.btnGirarAntiHorario_Click);
            // 
            // btnGirarHorario
            // 
            this.btnGirarHorario.BackColor = System.Drawing.Color.Transparent;
            this.btnGirarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGirarHorario.BackgroundImage")));
            this.btnGirarHorario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGirarHorario.Location = new System.Drawing.Point(749, 161);
            this.btnGirarHorario.Name = "btnGirarHorario";
            this.btnGirarHorario.Size = new System.Drawing.Size(69, 64);
            this.btnGirarHorario.TabIndex = 24;
            this.btnGirarHorario.UseVisualStyleBackColor = false;
            this.btnGirarHorario.Click += new System.EventHandler(this.btnGirarHorario_Click);
            // 
            // btnRandomico
            // 
            this.btnRandomico.BackColor = System.Drawing.SystemColors.Info;
            this.btnRandomico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRandomico.BackgroundImage")));
            this.btnRandomico.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomico.ForeColor = System.Drawing.Color.Black;
            this.btnRandomico.Location = new System.Drawing.Point(958, 243);
            this.btnRandomico.Name = "btnRandomico";
            this.btnRandomico.Size = new System.Drawing.Size(68, 67);
            this.btnRandomico.TabIndex = 23;
            this.btnRandomico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRandomico.UseVisualStyleBackColor = false;
            this.btnRandomico.Click += new System.EventHandler(this.btnRandomico_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClock.BackgroundImage")));
            this.btnClock.Location = new System.Drawing.Point(952, 520);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(68, 65);
            this.btnClock.TabIndex = 30;
            this.btnClock.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(930, 588);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(119, 29);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Tempo(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1021, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 60);
            this.label2.TabIndex = 32;
            this.label2.Text = "Coloridos";
            // 
            // btn_Solucionar
            // 
            this.btn_Solucionar.Location = new System.Drawing.Point(897, 445);
            this.btn_Solucionar.Name = "btn_Solucionar";
            this.btn_Solucionar.Size = new System.Drawing.Size(75, 36);
            this.btn_Solucionar.TabIndex = 33;
            this.btn_Solucionar.Text = "Solucionar";
            this.btn_Solucionar.UseVisualStyleBackColor = true;
            this.btn_Solucionar.Click += new System.EventHandler(this.btn_Solucionar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1033, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 67);
            this.button1.TabIndex = 34;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1028, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Reiniciar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(978, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Passo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1059, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 37;
            this.button3.Text = "Animar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox_Movimenta_C
            // 
            this.checkBox_Movimenta_C.AutoSize = true;
            this.checkBox_Movimenta_C.Location = new System.Drawing.Point(1020, 422);
            this.checkBox_Movimenta_C.Name = "checkBox_Movimenta_C";
            this.checkBox_Movimenta_C.Size = new System.Drawing.Size(114, 17);
            this.checkBox_Movimenta_C.TabIndex = 38;
            this.checkBox_Movimenta_C.Text = "Movimenta Coluna";
            this.checkBox_Movimenta_C.UseVisualStyleBackColor = true;
            this.checkBox_Movimenta_C.CheckedChanged += new System.EventHandler(this.checkBox_Movimenta_C_CheckedChanged);
            // 
            // checkBox_Solucao_Hard
            // 
            this.checkBox_Solucao_Hard.AutoSize = true;
            this.checkBox_Solucao_Hard.Location = new System.Drawing.Point(897, 422);
            this.checkBox_Solucao_Hard.Name = "checkBox_Solucao_Hard";
            this.checkBox_Solucao_Hard.Size = new System.Drawing.Size(91, 17);
            this.checkBox_Solucao_Hard.TabIndex = 39;
            this.checkBox_Solucao_Hard.Text = "Solução Hard";
            this.checkBox_Solucao_Hard.UseVisualStyleBackColor = true;
            this.checkBox_Solucao_Hard.CheckedChanged += new System.EventHandler(this.checkBox_Solucao_Hard_CheckedChanged);
            // 
            // numericUpDown_Cores
            // 
            this.numericUpDown_Cores.Location = new System.Drawing.Point(897, 385);
            this.numericUpDown_Cores.Name = "numericUpDown_Cores";
            this.numericUpDown_Cores.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Cores.TabIndex = 40;
            this.numericUpDown_Cores.ValueChanged += new System.EventHandler(this.numericUpDown_Cores_ValueChanged);
            // 
            // numericUpDown_Matriz
            // 
            this.numericUpDown_Matriz.Location = new System.Drawing.Point(1058, 385);
            this.numericUpDown_Matriz.Name = "numericUpDown_Matriz";
            this.numericUpDown_Matriz.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Matriz.TabIndex = 41;
            this.numericUpDown_Matriz.ValueChanged += new System.EventHandler(this.numericUpDown_Matriz_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1053, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Matriz";
            // 
            // button4_Retornar
            // 
            this.button4_Retornar.Location = new System.Drawing.Point(989, 143);
            this.button4_Retornar.Name = "button4_Retornar";
            this.button4_Retornar.Size = new System.Drawing.Size(92, 38);
            this.button4_Retornar.TabIndex = 44;
            this.button4_Retornar.Text = "Matriz Inicial";
            this.button4_Retornar.UseVisualStyleBackColor = true;
            this.button4_Retornar.Click += new System.EventHandler(this.button4_Retornar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(639, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Número de jogadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Computador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(781, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Jogador";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_Numero_PC
            // 
            this.lbl_Numero_PC.AutoSize = true;
            this.lbl_Numero_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero_PC.Location = new System.Drawing.Point(682, 345);
            this.lbl_Numero_PC.Name = "lbl_Numero_PC";
            this.lbl_Numero_PC.Size = new System.Drawing.Size(19, 20);
            this.lbl_Numero_PC.TabIndex = 48;
            this.lbl_Numero_PC.Text = "0";
            // 
            // lbl_Numero_Jog
            // 
            this.lbl_Numero_Jog.AutoSize = true;
            this.lbl_Numero_Jog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero_Jog.Location = new System.Drawing.Point(799, 345);
            this.lbl_Numero_Jog.Name = "lbl_Numero_Jog";
            this.lbl_Numero_Jog.Size = new System.Drawing.Size(19, 20);
            this.lbl_Numero_Jog.TabIndex = 49;
            this.lbl_Numero_Jog.Text = "0";
            // 
            // pontuacao_jog
            // 
            this.pontuacao_jog.AutoSize = true;
            this.pontuacao_jog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacao_jog.Location = new System.Drawing.Point(793, 462);
            this.pontuacao_jog.Name = "pontuacao_jog";
            this.pontuacao_jog.Size = new System.Drawing.Size(19, 20);
            this.pontuacao_jog.TabIndex = 54;
            this.pontuacao_jog.Text = "0";
            // 
            // pontuacao_comp
            // 
            this.pontuacao_comp.AutoSize = true;
            this.pontuacao_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacao_comp.Location = new System.Drawing.Point(676, 462);
            this.pontuacao_comp.Name = "pontuacao_comp";
            this.pontuacao_comp.Size = new System.Drawing.Size(19, 20);
            this.pontuacao_comp.TabIndex = 53;
            this.pontuacao_comp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(775, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Jogador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(634, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Computador";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(633, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "Número de Blocos";
            // 
            // txt_colorir
            // 
            this.txt_colorir.Location = new System.Drawing.Point(989, 205);
            this.txt_colorir.Name = "txt_colorir";
            this.txt_colorir.Size = new System.Drawing.Size(100, 20);
            this.txt_colorir.TabIndex = 55;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1260, 655);
            this.Controls.Add(this.txt_colorir);
            this.Controls.Add(this.pontuacao_jog);
            this.Controls.Add(this.pontuacao_comp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_Numero_Jog);
            this.Controls.Add(this.lbl_Numero_PC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4_Retornar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_Matriz);
            this.Controls.Add(this.numericUpDown_Cores);
            this.Controls.Add(this.checkBox_Solucao_Hard);
            this.Controls.Add(this.checkBox_Movimenta_C);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Solucionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblColorir);
            this.Controls.Add(this.lblGirar);
            this.Controls.Add(this.btnGirarAntiHorario);
            this.Controls.Add(this.btnGirarHorario);
            this.Controls.Add(this.btnRandomico);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnLaranja);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.ForeColor = System.Drawing.Color.Blue;
            this.MinimizeBox = false;
            this.Name = "Jogo";
            this.Text = "Bloquinhos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnLaranja;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRandomico;
        private System.Windows.Forms.Button btnGirarHorario;
        private System.Windows.Forms.Button btnGirarAntiHorario;
        private System.Windows.Forms.Label lblGirar;
     
        private System.Windows.Forms.Label lblColorir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Solucionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox_Movimenta_C;
        private System.Windows.Forms.CheckBox checkBox_Solucao_Hard;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cores;
        private System.Windows.Forms.NumericUpDown numericUpDown_Matriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4_Retornar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Numero_PC;
        private System.Windows.Forms.Label lbl_Numero_Jog;
        private System.Windows.Forms.Label pontuacao_jog;
        private System.Windows.Forms.Label pontuacao_comp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_colorir;
    }
}