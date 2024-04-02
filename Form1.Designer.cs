namespace _02_Environmental_Emissions
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
            search_button = new Button();
            label1 = new Label();
            searchcompany_window = new TextBox();
            label2 = new Label();
            edit_button = new Button();
            filter_data = new Button();
            gridViewMain = new DataGridView();
            label3 = new Label();
            notFoundMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).BeginInit();
            SuspendLayout();
            // 
            // search_button
            // 
            search_button.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_button.Location = new Point(339, 415);
            search_button.Name = "search_button";
            search_button.Size = new Size(282, 62);
            search_button.TabIndex = 0;
            search_button.Text = "Find";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 212);
            label1.Name = "label1";
            label1.Size = new Size(347, 59);
            label1.TabIndex = 1;
            label1.Text = "Emission Search";
            // 
            // searchcompany_window
            // 
            searchcompany_window.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchcompany_window.Location = new Point(266, 330);
            searchcompany_window.Multiline = true;
            searchcompany_window.Name = "searchcompany_window";
            searchcompany_window.Size = new Size(446, 62);
            searchcompany_window.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 352);
            label2.Name = "label2";
            label2.Size = new Size(203, 40);
            label2.TabIndex = 3;
            label2.Text = "Source name: ";
            // 
            // edit_button
            // 
            edit_button.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_button.Location = new Point(487, 3);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(225, 74);
            edit_button.TabIndex = 4;
            edit_button.Text = "Edit";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
            // 
            // filter_data
            // 
            filter_data.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filter_data.Location = new Point(728, 3);
            filter_data.Name = "filter_data";
            filter_data.Size = new Size(225, 74);
            filter_data.TabIndex = 5;
            filter_data.Text = "Filter";
            filter_data.UseVisualStyleBackColor = true;
            filter_data.Click += filter_data_Click;
            // 
            // gridViewMain
            // 
            gridViewMain.BackgroundColor = SystemColors.Control;
            gridViewMain.BorderStyle = BorderStyle.None;
            gridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMain.Location = new Point(783, 286);
            gridViewMain.Name = "gridViewMain";
            gridViewMain.RowHeadersWidth = 82;
            gridViewMain.Size = new Size(542, 256);
            gridViewMain.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1001, 243);
            label3.Name = "label3";
            label3.Size = new Size(125, 40);
            label3.TabIndex = 8;
            label3.Text = "Output: ";
            // 
            // notFoundMessage
            // 
            notFoundMessage.AutoSize = true;
            notFoundMessage.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notFoundMessage.ForeColor = Color.Red;
            notFoundMessage.Location = new Point(48, 542);
            notFoundMessage.Name = "notFoundMessage";
            notFoundMessage.Size = new Size(0, 40);
            notFoundMessage.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1368, 646);
            Controls.Add(notFoundMessage);
            Controls.Add(label3);
            Controls.Add(gridViewMain);
            Controls.Add(filter_data);
            Controls.Add(edit_button);
            Controls.Add(label2);
            Controls.Add(searchcompany_window);
            Controls.Add(label1);
            Controls.Add(search_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search_button;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        public DataGridView gridViewMain;
        public Label notFoundMessage;
        public TextBox searchcompany_window;
        public Button edit_button;
        public Button filter_data;
    }
}
