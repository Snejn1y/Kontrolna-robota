namespace Kontrolna_robota
{
    partial class Form1
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Назва = new DataGridViewTextBoxColumn();
            Ціна = new DataGridViewTextBoxColumn();
            Швидкість = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(61, 82);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 39);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(61, 173);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 39);
            numericUpDown2.TabIndex = 0;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(61, 266);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(180, 39);
            numericUpDown3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 36);
            label1.TabIndex = 1;
            label1.Text = "Тролі";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 124);
            label2.Name = "label2";
            label2.Size = new Size(119, 36);
            label2.TabIndex = 1;
            label2.Text = "Дракони";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 215);
            label3.Name = "label3";
            label3.Size = new Size(90, 36);
            label3.TabIndex = 1;
            label3.Text = "Гними";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Назва, Ціна, Швидкість });
            dataGridView1.Location = new Point(280, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1186, 632);
            dataGridView1.TabIndex = 2;
            // 
            // Назва
            // 
            Назва.HeaderText = "Назва";
            Назва.MinimumWidth = 8;
            Назва.Name = "Назва";
            Назва.Width = 97;
            // 
            // Ціна
            // 
            Ціна.HeaderText = "Ціна";
            Ціна.MinimumWidth = 8;
            Ціна.Name = "Ціна";
            Ціна.Width = 84;
            // 
            // Швидкість
            // 
            Швидкість.HeaderText = "Швидкість";
            Швидкість.MinimumWidth = 8;
            Швидкість.Name = "Швидкість";
            Швидкість.Width = 132;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(61, 347);
            button1.Name = "button1";
            button1.Size = new Size(180, 42);
            button1.TabIndex = 3;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 726);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Назва;
        private DataGridViewTextBoxColumn Ціна;
        private DataGridViewTextBoxColumn Швидкість;
    }
}