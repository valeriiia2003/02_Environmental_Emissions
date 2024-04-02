namespace _02_Environmental_Emissions
{
    partial class Form2
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
            sourse_number = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addNewSourseButton = new Button();
            dataGridView = new DataGridView();
            emission_name = new TextBox();
            count_ems = new TextBox();
            textDescription = new TextBox();
            addInfo = new Label();
            update_button = new Button();
            mainMenu_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 84);
            label1.Name = "label1";
            label1.Size = new Size(601, 50);
            label1.TabIndex = 0;
            label1.Text = "Add a new source emission case";
            // 
            // sourse_number
            // 
            sourse_number.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sourse_number.Location = new Point(336, 183);
            sourse_number.Multiline = true;
            sourse_number.Name = "sourse_number";
            sourse_number.Size = new Size(355, 72);
            sourse_number.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 199);
            label2.Name = "label2";
            label2.Size = new Size(247, 45);
            label2.TabIndex = 6;
            label2.Text = "Sourse number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 297);
            label3.Name = "label3";
            label3.Size = new Size(226, 45);
            label3.TabIndex = 7;
            label3.Text = "Emission type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(171, 395);
            label4.Name = "label4";
            label4.Size = new Size(148, 45);
            label4.TabIndex = 8;
            label4.Text = "Measure";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 494);
            label5.Name = "label5";
            label5.Size = new Size(192, 45);
            label5.TabIndex = 9;
            label5.Text = "Description";
            // 
            // addNewSourseButton
            // 
            addNewSourseButton.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewSourseButton.Location = new Point(426, 583);
            addNewSourseButton.Name = "addNewSourseButton";
            addNewSourseButton.Size = new Size(265, 53);
            addNewSourseButton.TabIndex = 11;
            addNewSourseButton.Text = "Add";
            addNewSourseButton.UseVisualStyleBackColor = true;
            addNewSourseButton.Click += addNewSourseButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(875, 163);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(728, 385);
            dataGridView.TabIndex = 12;
            // 
            // emission_name
            // 
            emission_name.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emission_name.Location = new Point(336, 281);
            emission_name.Multiline = true;
            emission_name.Name = "emission_name";
            emission_name.Size = new Size(485, 72);
            emission_name.TabIndex = 13;
            // 
            // count_ems
            // 
            count_ems.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            count_ems.Location = new Point(336, 378);
            count_ems.Multiline = true;
            count_ems.Name = "count_ems";
            count_ems.Size = new Size(380, 72);
            count_ems.TabIndex = 14;
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescription.Location = new Point(336, 476);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(485, 72);
            textDescription.TabIndex = 15;
            // 
            // addInfo
            // 
            addInfo.AutoSize = true;
            addInfo.Location = new Point(743, 595);
            addInfo.Name = "addInfo";
            addInfo.Size = new Size(96, 32);
            addInfo.TabIndex = 16;
            addInfo.Text = "addInfo";
            // 
            // update_button
            // 
            update_button.Location = new Point(1426, 111);
            update_button.Name = "update_button";
            update_button.Size = new Size(150, 46);
            update_button.TabIndex = 17;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // mainMenu_button
            // 
            mainMenu_button.Location = new Point(2, 3);
            mainMenu_button.Name = "mainMenu_button";
            mainMenu_button.Size = new Size(150, 46);
            mainMenu_button.TabIndex = 18;
            mainMenu_button.Text = "Back";
            mainMenu_button.UseVisualStyleBackColor = true;
            mainMenu_button.Click += mainMenu_button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 706);
            Controls.Add(mainMenu_button);
            Controls.Add(update_button);
            Controls.Add(addInfo);
            Controls.Add(textDescription);
            Controls.Add(count_ems);
            Controls.Add(emission_name);
            Controls.Add(dataGridView);
            Controls.Add(addNewSourseButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sourse_number);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox sourse_number;
        public Button addNewSourseButton;
        public TextBox emission_name;
        public TextBox count_ems;
        public TextBox textDescription;
        public DataGridView dataGridView;
        public Label addInfo;
        private Button update_button;
        private Button mainMenu_button;
    }
}