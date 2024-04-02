namespace _02_Environmental_Emissions
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            sourse_search = new TextBox();
            dataGridView1 = new DataGridView();
            filterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 51);
            label1.Name = "label1";
            label1.Size = new Size(568, 45);
            label1.TabIndex = 1;
            label1.Text = "Count max/min/avarage emissions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 185);
            label2.Name = "label2";
            label2.Size = new Size(380, 45);
            label2.TabIndex = 2;
            label2.Text = "Enter a name of source";
            // 
            // sourse_search
            // 
            sourse_search.Location = new Point(462, 185);
            sourse_search.Multiline = true;
            sourse_search.Name = "sourse_search";
            sourse_search.Size = new Size(365, 49);
            sourse_search.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(225, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(696, 268);
            dataGridView1.TabIndex = 4;
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.Location = new Point(431, 277);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(273, 61);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter result";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 665);
            Controls.Add(filterButton);
            Controls.Add(dataGridView1);
            Controls.Add(sourse_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox sourse_search;
        private Button filterButton;
        public DataGridView dataGridView1;
    }
}