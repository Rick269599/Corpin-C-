namespace DataTypesPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            yearlevelBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            courseBox = new ComboBox();
            label3 = new Label();
            sectionBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            idnumberBox = new TextBox();
            label6 = new Label();
            lastnameBox = new TextBox();
            label7 = new Label();
            firstnameBox = new TextBox();
            label8 = new Label();
            middlenameBox = new TextBox();
            confirm = new Button();
            SuspendLayout();
            // 
            // yearlevelBox
            // 
            yearlevelBox.BackColor = SystemColors.ButtonFace;
            yearlevelBox.FormattingEnabled = true;
            yearlevelBox.Location = new Point(12, 226);
            yearlevelBox.Name = "yearlevelBox";
            yearlevelBox.Size = new Size(312, 23);
            yearlevelBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 208);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Year Level:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 267);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Course:";
            // 
            // courseBox
            // 
            courseBox.BackColor = SystemColors.ButtonFace;
            courseBox.FormattingEnabled = true;
            courseBox.Location = new Point(12, 285);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(312, 23);
            courseBox.TabIndex = 2;
            courseBox.SelectedIndexChanged += courseBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 4;
            label3.Text = "Student ID";
            // 
            // sectionBox
            // 
            sectionBox.BackColor = SystemColors.ButtonFace;
            sectionBox.Location = new Point(12, 171);
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(312, 23);
            sectionBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "ID Number:";
            // 
            // idnumberBox
            // 
            idnumberBox.BackColor = SystemColors.ButtonFace;
            idnumberBox.Location = new Point(12, 122);
            idnumberBox.Name = "idnumberBox";
            idnumberBox.Size = new Size(312, 23);
            idnumberBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Location = new Point(12, 50);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Last Name:";
            // 
            // lastnameBox
            // 
            lastnameBox.BackColor = SystemColors.ButtonFace;
            lastnameBox.Location = new Point(12, 68);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(153, 23);
            lastnameBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Location = new Point(171, 50);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 12;
            label7.Text = "First Name:";
            // 
            // firstnameBox
            // 
            firstnameBox.BackColor = SystemColors.ButtonFace;
            firstnameBox.Location = new Point(171, 68);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(153, 23);
            firstnameBox.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Location = new Point(330, 50);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 14;
            label8.Text = "Middle Name:";
            // 
            // middlenameBox
            // 
            middlenameBox.BackColor = SystemColors.ButtonFace;
            middlenameBox.Location = new Point(330, 68);
            middlenameBox.Name = "middlenameBox";
            middlenameBox.Size = new Size(153, 23);
            middlenameBox.TabIndex = 13;
            // 
            // confirm
            // 
            confirm.BackColor = SystemColors.ButtonFace;
            confirm.Location = new Point(364, 238);
            confirm.Name = "confirm";
            confirm.Size = new Size(82, 70);
            confirm.TabIndex = 15;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(491, 330);
            Controls.Add(confirm);
            Controls.Add(label8);
            Controls.Add(middlenameBox);
            Controls.Add(label7);
            Controls.Add(firstnameBox);
            Controls.Add(label6);
            Controls.Add(lastnameBox);
            Controls.Add(label5);
            Controls.Add(idnumberBox);
            Controls.Add(label4);
            Controls.Add(sectionBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(courseBox);
            Controls.Add(label1);
            Controls.Add(yearlevelBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox yearlevelBox;
        private Label label1;
        private Label label2;
        private ComboBox courseBox;
        private Label label3;
        private TextBox sectionBox;
        private Label label4;
        private Label label5;
        private TextBox idnumberBox;
        private Label label6;
        private TextBox lastnameBox;
        private Label label7;
        private TextBox firstnameBox;
        private Label label8;
        private TextBox middlenameBox;
        private Button confirm;
    }
}
