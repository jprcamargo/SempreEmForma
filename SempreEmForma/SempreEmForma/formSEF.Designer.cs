namespace SempreEmForma
{
    partial class formSEF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumSala = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblVEstado = new System.Windows.Forms.Label();
            this.lblVArea = new System.Windows.Forms.Label();
            this.lblVLoc = new System.Windows.Forms.Label();
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.cbSocio = new System.Windows.Forms.ComboBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.lblVNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.sempreEmFormaDataSet = new SempreEmForma.SempreEmFormaDataSet();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new SempreEmForma.SempreEmFormaDataSetTableAdapters.ReservaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sempreEmFormaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSala
            // 
            this.lblNumSala.AutoSize = true;
            this.lblNumSala.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSala.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSala.ForeColor = System.Drawing.Color.Black;
            this.lblNumSala.Location = new System.Drawing.Point(114, 70);
            this.lblNumSala.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSala.Name = "lblNumSala";
            this.lblNumSala.Size = new System.Drawing.Size(156, 25);
            this.lblNumSala.TabIndex = 2;
            this.lblNumSala.Text = "Número da sala:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblData.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(587, 70);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(60, 25);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(587, 111);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 25);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Black;
            this.lblLoc.Location = new System.Drawing.Point(1061, 145);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(122, 25);
            this.lblLoc.TabIndex = 12;
            this.lblLoc.Text = "Localização:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArea.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.Location = new System.Drawing.Point(1061, 107);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(58, 25);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(1061, 68);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblVEstado
            // 
            this.lblVEstado.AutoSize = true;
            this.lblVEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblVEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVEstado.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVEstado.ForeColor = System.Drawing.Color.Black;
            this.lblVEstado.Location = new System.Drawing.Point(1247, 67);
            this.lblVEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVEstado.Name = "lblVEstado";
            this.lblVEstado.Size = new System.Drawing.Size(66, 25);
            this.lblVEstado.TabIndex = 13;
            this.lblVEstado.Text = "label4";
            this.lblVEstado.Visible = false;
            // 
            // lblVArea
            // 
            this.lblVArea.AutoSize = true;
            this.lblVArea.BackColor = System.Drawing.Color.Transparent;
            this.lblVArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVArea.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVArea.ForeColor = System.Drawing.Color.Black;
            this.lblVArea.Location = new System.Drawing.Point(1247, 106);
            this.lblVArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVArea.Name = "lblVArea";
            this.lblVArea.Size = new System.Drawing.Size(66, 25);
            this.lblVArea.TabIndex = 14;
            this.lblVArea.Text = "label5";
            this.lblVArea.Visible = false;
            // 
            // lblVLoc
            // 
            this.lblVLoc.AutoSize = true;
            this.lblVLoc.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVLoc.ForeColor = System.Drawing.Color.Black;
            this.lblVLoc.Location = new System.Drawing.Point(1247, 144);
            this.lblVLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVLoc.Name = "lblVLoc";
            this.lblVLoc.Size = new System.Drawing.Size(66, 25);
            this.lblVLoc.TabIndex = 15;
            this.lblVLoc.Text = "label6";
            this.lblVLoc.Visible = false;
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumSocio.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSocio.ForeColor = System.Drawing.Color.Black;
            this.lblNumSocio.Location = new System.Drawing.Point(114, 108);
            this.lblNumSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(168, 25);
            this.lblNumSocio.TabIndex = 18;
            this.lblNumSocio.Text = "Número do Sócio:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnConfirmar.Location = new System.Drawing.Point(507, 228);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 64);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(802, 228);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 64);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnPesquisar.Location = new System.Drawing.Point(223, 228);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(140, 64);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(337, 67);
            this.cbSala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(148, 28);
            this.cbSala.TabIndex = 22;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // cbSocio
            // 
            this.cbSocio.FormattingEnabled = true;
            this.cbSocio.Location = new System.Drawing.Point(337, 105);
            this.cbSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSocio.Name = "cbSocio";
            this.cbSocio.Size = new System.Drawing.Size(148, 28);
            this.cbSocio.TabIndex = 23;
            this.cbSocio.SelectedIndexChanged += new System.EventHandler(this.cbSocio_SelectedIndexChanged);
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(802, 67);
            this.mtxtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtData.Mask = "0000-00-00";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(140, 26);
            this.mtxtData.TabIndex = 25;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtData_MaskInputRejected);
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(802, 108);
            this.mtxtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtHora.Mask = "90:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(140, 26);
            this.mtxtHora.TabIndex = 26;
            this.mtxtHora.ValidatingType = typeof(System.DateTime);
            this.mtxtHora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtHora_MaskInputRejected);
            // 
            // lblVNome
            // 
            this.lblVNome.AutoSize = true;
            this.lblVNome.BackColor = System.Drawing.Color.Transparent;
            this.lblVNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVNome.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNome.ForeColor = System.Drawing.Color.Black;
            this.lblVNome.Location = new System.Drawing.Point(332, 147);
            this.lblVNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVNome.Name = "lblVNome";
            this.lblVNome.Size = new System.Drawing.Size(66, 25);
            this.lblVNome.TabIndex = 31;
            this.lblVNome.Text = "label4";
            this.lblVNome.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(114, 147);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 25);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnLimpar.Location = new System.Drawing.Point(1066, 229);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 63);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar Filtros";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AllowUserToResizeColumns = false;
            this.dgvReserva.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvReserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dgvReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvReserva.Location = new System.Drawing.Point(71, 347);
            this.dgvReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReserva.Name = "dgvReserva";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dgvReserva.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReserva.Size = new System.Drawing.Size(1284, 433);
            this.dgvReserva.TabIndex = 0;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSquash_CellContentClick);
            this.dgvReserva.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReserva_RowHeaderMouseClick);
            // 
            // sempreEmFormaDataSet
            // 
            this.sempreEmFormaDataSet.DataSetName = "SempreEmFormaDataSet";
            this.sempreEmFormaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.sempreEmFormaDataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // formSEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1425, 837);
            this.Controls.Add(this.lblNumSocio);
            this.Controls.Add(this.lblVNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mtxtHora);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNumSala);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.cbSocio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.lblVLoc);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblVArea);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblVEstado);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblLoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formSEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sempre em Forma";
            this.Load += new System.EventHandler(this.formSEF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sempreEmFormaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumSala;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblVEstado;
        private System.Windows.Forms.Label lblVArea;
        private System.Windows.Forms.Label lblVLoc;
        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.ComboBox cbSocio;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        private System.Windows.Forms.Label lblVNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvReserva;
        private SempreEmFormaDataSet sempreEmFormaDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private SempreEmFormaDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
    }
}

