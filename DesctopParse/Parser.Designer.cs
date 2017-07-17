namespace DesctopParse
{
    partial class Parser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Products = new System.Windows.Forms.ListBox();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.NumEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(12, 12);
            this.Products.Name = "Products";
            this.Products.ScrollAlwaysVisible = true;
            this.Products.Size = new System.Drawing.Size(231, 277);
            this.Products.TabIndex = 0;
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(249, 29);
            this.NumStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(120, 20);
            this.NumStart.TabIndex = 1;
            this.NumStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumEnd
            // 
            this.NumEnd.Location = new System.Drawing.Point(249, 85);
            this.NumEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Size = new System.Drawing.Size(120, 20);
            this.NumEnd.TabIndex = 2;
            this.NumEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Point";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Parser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumEnd);
            this.Controls.Add(this.NumStart);
            this.Controls.Add(this.Products);
            this.Name = "Parser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.NumericUpDown NumEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

