namespace AmazonDoMilhao;

partial class Home
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArquivoEntrada = new System.Windows.Forms.TextBox();
            this.buttonArquivoEntrada = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArquivoSaida = new System.Windows.Forms.TextBox();
            this.buttonArquivoSaida = new System.Windows.Forms.Button();
            this.dataGridViewReferencias = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGerarArquivoDeSaida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo de entrada (.txt):";
            // 
            // textBoxArquivoEntrada
            // 
            this.textBoxArquivoEntrada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxArquivoEntrada.Location = new System.Drawing.Point(12, 435);
            this.textBoxArquivoEntrada.Name = "textBoxArquivoEntrada";
            this.textBoxArquivoEntrada.ReadOnly = true;
            this.textBoxArquivoEntrada.Size = new System.Drawing.Size(424, 29);
            this.textBoxArquivoEntrada.TabIndex = 12;
            // 
            // buttonArquivoEntrada
            // 
            this.buttonArquivoEntrada.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonArquivoEntrada.Location = new System.Drawing.Point(12, 397);
            this.buttonArquivoEntrada.Name = "buttonArquivoEntrada";
            this.buttonArquivoEntrada.Size = new System.Drawing.Size(225, 32);
            this.buttonArquivoEntrada.TabIndex = 11;
            this.buttonArquivoEntrada.Text = "Escolher arquivo de entrada";
            this.buttonArquivoEntrada.UseVisualStyleBackColor = true;
            this.buttonArquivoEntrada.Click += new System.EventHandler(this.buttonArquivoEntrada_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arquivo de saída (.csv):";
            // 
            // textBoxArquivoSaida
            // 
            this.textBoxArquivoSaida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxArquivoSaida.Location = new System.Drawing.Point(442, 435);
            this.textBoxArquivoSaida.Name = "textBoxArquivoSaida";
            this.textBoxArquivoSaida.ReadOnly = true;
            this.textBoxArquivoSaida.Size = new System.Drawing.Size(424, 29);
            this.textBoxArquivoSaida.TabIndex = 14;
            // 
            // buttonArquivoSaida
            // 
            this.buttonArquivoSaida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonArquivoSaida.Location = new System.Drawing.Point(442, 397);
            this.buttonArquivoSaida.Name = "buttonArquivoSaida";
            this.buttonArquivoSaida.Size = new System.Drawing.Size(225, 32);
            this.buttonArquivoSaida.TabIndex = 13;
            this.buttonArquivoSaida.Text = "Escolher arquivo de saída";
            this.buttonArquivoSaida.UseVisualStyleBackColor = true;
            this.buttonArquivoSaida.Click += new System.EventHandler(this.buttonArquivoSaida_Click);
            // 
            // dataGridViewReferencias
            // 
            this.dataGridViewReferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReferencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReferencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.ASIN,
            this.SKU,
            this.URL});
            this.dataGridViewReferencias.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewReferencias.Name = "dataGridViewReferencias";
            this.dataGridViewReferencias.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewReferencias.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReferencias.RowTemplate.Height = 25;
            this.dataGridViewReferencias.Size = new System.Drawing.Size(848, 330);
            this.dataGridViewReferencias.TabIndex = 16;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // ASIN
            // 
            this.ASIN.HeaderText = "ASIN";
            this.ASIN.Name = "ASIN";
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Associações (SKU -> URL):";
            // 
            // buttonGerarArquivoDeSaida
            // 
            this.buttonGerarArquivoDeSaida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGerarArquivoDeSaida.Location = new System.Drawing.Point(301, 477);
            this.buttonGerarArquivoDeSaida.Name = "buttonGerarArquivoDeSaida";
            this.buttonGerarArquivoDeSaida.Size = new System.Drawing.Size(271, 38);
            this.buttonGerarArquivoDeSaida.TabIndex = 15;
            this.buttonGerarArquivoDeSaida.Text = "Gerar arquivo de saída";
            this.buttonGerarArquivoDeSaida.UseVisualStyleBackColor = true;
            this.buttonGerarArquivoDeSaida.Click += new System.EventHandler(this.buttonGerarArquivoDeSaida_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 527);
            this.Controls.Add(this.buttonGerarArquivoDeSaida);
            this.Controls.Add(this.dataGridViewReferencias);
            this.Controls.Add(this.buttonArquivoSaida);
            this.Controls.Add(this.buttonArquivoEntrada);
            this.Controls.Add(this.textBoxArquivoSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArquivoEntrada);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon do Milhão";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox textBoxArquivoEntrada;
    private Button buttonArquivoEntrada;
    private Label label2;
    private TextBox textBoxArquivoSaida;
    private Button buttonArquivoSaida;
    private DataGridView dataGridViewReferencias;
    private Label label3;
    private Button buttonGerarArquivoDeSaida;
    private DataGridViewTextBoxColumn Nome;
    private DataGridViewTextBoxColumn ASIN;
    private DataGridViewTextBoxColumn SKU;
    private DataGridViewTextBoxColumn URL;
}
