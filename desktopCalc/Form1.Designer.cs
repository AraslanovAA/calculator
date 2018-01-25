namespace desktopCalc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCalc = new System.Windows.Forms.Button();
            this.LbOperations_old = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInPut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbOperations = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalc.Location = new System.Drawing.Point(116, 169);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 25);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Выполнить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // LbOperations_old
            // 
            this.LbOperations_old.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbOperations_old.FormattingEnabled = true;
            this.LbOperations_old.Items.AddRange(new object[] {
            "Опер_1",
            "Опер_2",
            "Опер_3"});
            this.LbOperations_old.Location = new System.Drawing.Point(267, 0);
            this.LbOperations_old.Name = "LbOperations_old";
            this.LbOperations_old.Size = new System.Drawing.Size(243, 60);
            this.LbOperations_old.TabIndex = 2;
            this.LbOperations_old.SelectedIndexChanged += new System.EventHandler(this.lbOperations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите данные";
            // 
            // tbInPut
            // 
            this.tbInPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInPut.Location = new System.Drawing.Point(116, 145);
            this.tbInPut.Name = "tbInPut";
            this.tbInPut.Size = new System.Drawing.Size(448, 20);
            this.tbInPut.TabIndex = 4;
            this.tbInPut.TextChanged += new System.EventHandler(this.tbInPut_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0554F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCalc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbInPut, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbOperations, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.57214F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42786F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 254);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // LbOperations
            // 
            this.LbOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbOperations.FormattingEnabled = true;
            this.LbOperations.Location = new System.Drawing.Point(116, 3);
            this.LbOperations.Name = "LbOperations";
            this.LbOperations.Size = new System.Drawing.Size(448, 136);
            this.LbOperations.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 254);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox LbOperations_old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox LbOperations;
    }
}

