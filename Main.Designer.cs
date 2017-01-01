namespace Neobroker___Email_Bulk
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPages_View = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_email_sever_ = new System.Windows.Forms.Label();
            this.label_con_Status = new System.Windows.Forms.Label();
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparListaASerEnviadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testarSMPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarManualmenteAoServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_LISTA = new System.Windows.Forms.RichTextBox();
            this.btn_AbrirLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CarregarMSG = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.pictureBox_panfletovirtual = new System.Windows.Forms.PictureBox();
            this.progressBar_Progresso_Envio = new System.Windows.Forms.ProgressBar();
            this.label_contador = new System.Windows.Forms.Label();
            this.label_status_ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_PARAR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_progresso_enviados = new System.Windows.Forms.Label();
            this.lbl_progresso_falhados = new System.Windows.Forms.Label();
            this.lbl_tamanho_da_lista = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPages_View.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_panfletovirtual)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.bulkToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparEnvioToolStripMenuItem,
            this.limparListaASerEnviadaToolStripMenuItem,
            this.cancelarEnvioToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // bulkToolStripMenuItem
            // 
            this.bulkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testarSMPTToolStripMenuItem,
            this.conectarManualmenteAoServidorToolStripMenuItem});
            this.bulkToolStripMenuItem.Name = "bulkToolStripMenuItem";
            this.bulkToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.bulkToolStripMenuItem.Text = "Bulk";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ajudaToolStripMenuItem.Text = "Sobre";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.sobreToolStripMenuItem.Text = "Sobre o NeoBroker- Email Bulk";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // tabPages_View
            // 
            this.tabPages_View.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPages_View.Controls.Add(this.tabPage1);
            this.tabPages_View.Controls.Add(this.tabPage2);
            this.tabPages_View.Controls.Add(this.tabPage3);
            this.tabPages_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages_View.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages_View.Location = new System.Drawing.Point(0, 25);
            this.tabPages_View.Name = "tabPages_View";
            this.tabPages_View.SelectedIndex = 0;
            this.tabPages_View.Size = new System.Drawing.Size(945, 486);
            this.tabPages_View.TabIndex = 2;
            this.tabPages_View.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.tabPages_View_ChangeUICues);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lbl_tamanho_da_lista);
            this.tabPage2.Controls.Add(this.lbl_progresso_falhados);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_PARAR);
            this.tabPage2.Controls.Add(this.lbl_progresso_enviados);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label_status_);
            this.tabPage2.Controls.Add(this.label_contador);
            this.tabPage2.Controls.Add(this.progressBar_Progresso_Envio);
            this.tabPage2.Controls.Add(this.pictureBox_panfletovirtual);
            this.tabPage2.Controls.Add(this.btn_Enviar);
            this.tabPage2.Controls.Add(this.btn_CarregarMSG);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_AbrirLista);
            this.tabPage2.Controls.Add(this.rtb_LISTA);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bulk";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "E-mail Analyzer ";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = global::Neobroker___Email_Bulk.Properties.Resources.email_icon3;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label_email_sever_);
            this.tabPage1.Controls.Add(this.label_con_Status);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StartPage";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(345, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seja bem vindo, envie E-mail em massa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(341, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "NeoBroker Email BULK";
            // 
            // label_email_sever_
            // 
            this.label_email_sever_.AutoSize = true;
            this.label_email_sever_.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_sever_.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label_email_sever_.Location = new System.Drawing.Point(18, 419);
            this.label_email_sever_.Name = "label_email_sever_";
            this.label_email_sever_.Size = new System.Drawing.Size(314, 18);
            this.label_email_sever_.TabIndex = 6;
            this.label_email_sever_.Text = "SMTP.Google.com - neobrokerterminal@gmail.com";
            // 
            // label_con_Status
            // 
            this.label_con_Status.AutoSize = true;
            this.label_con_Status.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_con_Status.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_con_Status.Location = new System.Drawing.Point(854, 418);
            this.label_con_Status.Name = "label_con_Status";
            this.label_con_Status.Size = new System.Drawing.Size(50, 19);
            this.label_con_Status.TabIndex = 5;
            this.label_con_Status.Text = "Online";
            // 
            // abrirAquivoDeListaDeEmailsToolStripMenuItem
            // 
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem.Name = "abrirAquivoDeListaDeEmailsToolStripMenuItem";
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.abrirAquivoDeListaDeEmailsToolStripMenuItem.Text = "Abrir aquivo de Lista de Emails";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(319, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // limparEnvioToolStripMenuItem
            // 
            this.limparEnvioToolStripMenuItem.Name = "limparEnvioToolStripMenuItem";
            this.limparEnvioToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.limparEnvioToolStripMenuItem.Text = "Limpar Envio";
            // 
            // limparListaASerEnviadaToolStripMenuItem
            // 
            this.limparListaASerEnviadaToolStripMenuItem.Name = "limparListaASerEnviadaToolStripMenuItem";
            this.limparListaASerEnviadaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.limparListaASerEnviadaToolStripMenuItem.Text = "Limpar Lista a ser enviada";
            // 
            // cancelarEnvioToolStripMenuItem
            // 
            this.cancelarEnvioToolStripMenuItem.Name = "cancelarEnvioToolStripMenuItem";
            this.cancelarEnvioToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.cancelarEnvioToolStripMenuItem.Text = "Cancelar Envio";
            // 
            // testarSMPTToolStripMenuItem
            // 
            this.testarSMPTToolStripMenuItem.Name = "testarSMPTToolStripMenuItem";
            this.testarSMPTToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.testarSMPTToolStripMenuItem.Text = "Testar SMPT";
            // 
            // conectarManualmenteAoServidorToolStripMenuItem
            // 
            this.conectarManualmenteAoServidorToolStripMenuItem.Name = "conectarManualmenteAoServidorToolStripMenuItem";
            this.conectarManualmenteAoServidorToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.conectarManualmenteAoServidorToolStripMenuItem.Text = "Conectar Manualmente ao Servidor";
            // 
            // rtb_LISTA
            // 
            this.rtb_LISTA.Location = new System.Drawing.Point(8, 33);
            this.rtb_LISTA.Name = "rtb_LISTA";
            this.rtb_LISTA.Size = new System.Drawing.Size(327, 379);
            this.rtb_LISTA.TabIndex = 0;
            this.rtb_LISTA.Text = "";
            // 
            // btn_AbrirLista
            // 
            this.btn_AbrirLista.Location = new System.Drawing.Point(8, 418);
            this.btn_AbrirLista.Name = "btn_AbrirLista";
            this.btn_AbrirLista.Size = new System.Drawing.Size(327, 23);
            this.btn_AbrirLista.TabIndex = 1;
            this.btn_AbrirLista.Text = "Abrir a lista dentro do Bulk";
            this.btn_AbrirLista.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(73, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de Emails a ser enviada";
            // 
            // btn_CarregarMSG
            // 
            this.btn_CarregarMSG.Location = new System.Drawing.Point(604, 418);
            this.btn_CarregarMSG.Name = "btn_CarregarMSG";
            this.btn_CarregarMSG.Size = new System.Drawing.Size(327, 23);
            this.btn_CarregarMSG.TabIndex = 10;
            this.btn_CarregarMSG.Text = "Carregar Panfleto Virtual para Enviar";
            this.btn_CarregarMSG.UseVisualStyleBackColor = true;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Enviar.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(341, 413);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(257, 28);
            this.btn_Enviar.TabIndex = 11;
            this.btn_Enviar.Text = "ENVIAR";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            // 
            // pictureBox_panfletovirtual
            // 
            this.pictureBox_panfletovirtual.Location = new System.Drawing.Point(604, 33);
            this.pictureBox_panfletovirtual.Name = "pictureBox_panfletovirtual";
            this.pictureBox_panfletovirtual.Size = new System.Drawing.Size(325, 379);
            this.pictureBox_panfletovirtual.TabIndex = 12;
            this.pictureBox_panfletovirtual.TabStop = false;
            // 
            // progressBar_Progresso_Envio
            // 
            this.progressBar_Progresso_Envio.Location = new System.Drawing.Point(341, 328);
            this.progressBar_Progresso_Envio.Name = "progressBar_Progresso_Envio";
            this.progressBar_Progresso_Envio.Size = new System.Drawing.Size(257, 23);
            this.progressBar_Progresso_Envio.TabIndex = 13;
            // 
            // label_contador
            // 
            this.label_contador.AutoSize = true;
            this.label_contador.Location = new System.Drawing.Point(359, 354);
            this.label_contador.Name = "label_contador";
            this.label_contador.Size = new System.Drawing.Size(211, 16);
            this.label_contador.TabIndex = 14;
            this.label_contador.Text = "Processando.... 12 de 1984 Restantes";
            // 
            // label_status_
            // 
            this.label_status_.AutoSize = true;
            this.label_status_.Location = new System.Drawing.Point(352, 308);
            this.label_status_.Name = "label_status_";
            this.label_status_.Size = new System.Drawing.Size(237, 16);
            this.label_status_.TabIndex = 15;
            this.label_status_.Text = "Enviando para seuclient@yahoo.com.br ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(661, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Certifique-se da Arte antes de Enviar";
            // 
            // btn_PARAR
            // 
            this.btn_PARAR.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_PARAR.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PARAR.ForeColor = System.Drawing.Color.White;
            this.btn_PARAR.Location = new System.Drawing.Point(341, 383);
            this.btn_PARAR.Name = "btn_PARAR";
            this.btn_PARAR.Size = new System.Drawing.Size(257, 28);
            this.btn_PARAR.TabIndex = 18;
            this.btn_PARAR.Text = "PARAR";
            this.btn_PARAR.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(338, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "NeoBroker Email BULK";
            // 
            // lbl_progresso_enviados
            // 
            this.lbl_progresso_enviados.AutoSize = true;
            this.lbl_progresso_enviados.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progresso_enviados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_progresso_enviados.Location = new System.Drawing.Point(398, 148);
            this.lbl_progresso_enviados.Name = "lbl_progresso_enviados";
            this.lbl_progresso_enviados.Size = new System.Drawing.Size(125, 24);
            this.lbl_progresso_enviados.TabIndex = 17;
            this.lbl_progresso_enviados.Text = "Enviados : 12";
            // 
            // lbl_progresso_falhados
            // 
            this.lbl_progresso_falhados.AutoSize = true;
            this.lbl_progresso_falhados.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progresso_falhados.ForeColor = System.Drawing.Color.Red;
            this.lbl_progresso_falhados.Location = new System.Drawing.Point(398, 181);
            this.lbl_progresso_falhados.Name = "lbl_progresso_falhados";
            this.lbl_progresso_falhados.Size = new System.Drawing.Size(114, 24);
            this.lbl_progresso_falhados.TabIndex = 20;
            this.lbl_progresso_falhados.Text = "Falhados  : 0";
            // 
            // lbl_tamanho_da_lista
            // 
            this.lbl_tamanho_da_lista.AutoSize = true;
            this.lbl_tamanho_da_lista.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamanho_da_lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_tamanho_da_lista.Location = new System.Drawing.Point(378, 115);
            this.lbl_tamanho_da_lista.Name = "lbl_tamanho_da_lista";
            this.lbl_tamanho_da_lista.Size = new System.Drawing.Size(172, 24);
            this.lbl_tamanho_da_lista.TabIndex = 21;
            this.lbl_tamanho_da_lista.Text = "Tamanho da Lista : ";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 533);
            this.Controls.Add(this.tabPages_View);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(961, 571);
            this.MinimumSize = new System.Drawing.Size(961, 571);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neobroker - Email Bulk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPages_View.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_panfletovirtual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabPages_View;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_con_Status;
        private System.Windows.Forms.Label label_email_sever_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem abrirAquivoDeListaDeEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparListaASerEnviadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testarSMPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarManualmenteAoServidorToolStripMenuItem;
        private System.Windows.Forms.Button btn_PARAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_status_;
        private System.Windows.Forms.Label label_contador;
        private System.Windows.Forms.ProgressBar progressBar_Progresso_Envio;
        private System.Windows.Forms.PictureBox pictureBox_panfletovirtual;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_CarregarMSG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AbrirLista;
        private System.Windows.Forms.RichTextBox rtb_LISTA;
        private System.Windows.Forms.Label lbl_progresso_falhados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_progresso_enviados;
        private System.Windows.Forms.Label lbl_tamanho_da_lista;
    }
}

