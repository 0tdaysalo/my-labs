namespace Laba5_2form
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcBtn = new System.Windows.Forms.Button();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumn,
            this.yColumn,
            this.mathColumn,
            this.diffColumn,
            this.itterColumn});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(13, 136);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(243, 177);
            this.dataGridView.TabIndex = 0;
            // 
            // xColumn
            // 
            this.xColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.xColumn.HeaderText = "X";
            this.xColumn.MinimumWidth = 6;
            this.xColumn.Name = "xColumn";
            this.xColumn.ReadOnly = true;
            this.xColumn.Width = 44;
            // 
            // yColumn
            // 
            this.yColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.yColumn.HeaderText = "MathTaylor";
            this.yColumn.MinimumWidth = 6;
            this.yColumn.Name = "yColumn";
            this.yColumn.ReadOnly = true;
            this.yColumn.Width = 104;
            // 
            // mathColumn
            // 
            this.mathColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mathColumn.HeaderText = "Math.Ln(X+1)";
            this.mathColumn.MinimumWidth = 6;
            this.mathColumn.Name = "mathColumn";
            this.mathColumn.ReadOnly = true;
            this.mathColumn.Width = 112;
            // 
            // diffColumn
            // 
            this.diffColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.diffColumn.HeaderText = "Difference";
            this.diffColumn.MinimumWidth = 6;
            this.diffColumn.Name = "diffColumn";
            this.diffColumn.ReadOnly = true;
            this.diffColumn.Width = 97;
            // 
            // itterColumn
            // 
            this.itterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itterColumn.HeaderText = "Itterations";
            this.itterColumn.MinimumWidth = 6;
            this.itterColumn.Name = "itterColumn";
            this.itterColumn.ReadOnly = true;
            this.itterColumn.Width = 93;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(13, 82);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(243, 28);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Рассчитать";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(56, 17);
            this.x1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(64, 22);
            this.x1TextBox.TabIndex = 2;
            this.x1TextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Х1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Х2";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(190, 18);
            this.x2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(66, 22);
            this.x2TextBox.TabIndex = 5;
            this.x2TextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "dX";
            // 
            // dxTextBox
            // 
            this.dxTextBox.Location = new System.Drawing.Point(56, 50);
            this.dxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(64, 22);
            this.dxTextBox.TabIndex = 7;
            this.dxTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eps";
            // 
            // epsTextBox
            // 
            this.epsTextBox.Location = new System.Drawing.Point(190, 52);
            this.epsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.epsTextBox.Name = "epsTextBox";
            this.epsTextBox.Size = new System.Drawing.Size(66, 22);
            this.epsTextBox.TabIndex = 9;
            this.epsTextBox.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 349);
            this.Controls.Add(this.epsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dxTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "5_2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itterColumn;
    }
}

