namespace AspNetVS2017.Capitulo01.Troco
{
    partial class Troco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troco));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, "25.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, "1.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.valorCompraTextbox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.valorTrocoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasImageList = new System.Windows.Forms.ImageList(this.components);
            this.moedasListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.valorTrocoTextBox);
            this.groupBox1.Controls.Add(this.valorPagoTextBox);
            this.groupBox1.Controls.Add(this.valorCompraTextbox);
            this.groupBox1.Controls.Add(this.calcularButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Troco";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(17, 120);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(237, 23);
            this.calcularButton.TabIndex = 1;
            this.calcularButton.Text = "&Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            // 
            // valorCompraTextbox
            // 
            this.valorCompraTextbox.Location = new System.Drawing.Point(132, 13);
            this.valorCompraTextbox.Name = "valorCompraTextbox";
            this.valorCompraTextbox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextbox.TabIndex = 2;
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.Location = new System.Drawing.Point(132, 46);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorPagoTextBox.TabIndex = 2;
            // 
            // valorTrocoTextBox
            // 
            this.valorTrocoTextBox.Location = new System.Drawing.Point(132, 79);
            this.valorTrocoTextBox.Name = "valorTrocoTextBox";
            this.valorTrocoTextBox.ReadOnly = true;
            this.valorTrocoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTrocoTextBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.moedasListView);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            // 
            // moedasImageList
            // 
            this.moedasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasImageList.ImageStream")));
            this.moedasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasImageList.Images.SetKeyName(0, "1.png");
            this.moedasImageList.Images.SetKeyName(1, "5.png");
            this.moedasImageList.Images.SetKeyName(2, "10.png");
            this.moedasImageList.Images.SetKeyName(3, "25.png");
            this.moedasImageList.Images.SetKeyName(4, "50.png");
            this.moedasImageList.Images.SetKeyName(5, "100.png");
            // 
            // moedasListView
            // 
            this.moedasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.moedasListView.LargeImageList = this.moedasImageList;
            this.moedasListView.Location = new System.Drawing.Point(3, 16);
            this.moedasListView.Name = "moedasListView";
            this.moedasListView.Size = new System.Drawing.Size(516, 230);
            this.moedasListView.TabIndex = 2;
            this.moedasListView.UseCompatibleStateImageBehavior = false;
            // 
            // Troco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Troco";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valorTrocoTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox valorCompraTextbox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView moedasListView;
        private System.Windows.Forms.ImageList moedasImageList;
    }
}

