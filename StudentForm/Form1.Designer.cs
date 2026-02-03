namespace StudentForm
{
    partial class FormStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentInfo));
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            textLastName = new TextBox();
            textStudentID = new TextBox();
            textFirstName = new TextBox();
            groupMajor = new GroupBox();
            radioIT = new RadioButton();
            radioWebDesign = new RadioButton();
            radioProgramming = new RadioButton();
            lblCourses = new Label();
            lblScore = new Label();
            checkBoxCIS103 = new CheckBox();
            checkBoxCIS104 = new CheckBox();
            textBoxScore1 = new TextBox();
            textBoxScore2 = new TextBox();
            textBoxScore3 = new TextBox();
            textBoxScore4 = new TextBox();
            checkBoxCIS101 = new CheckBox();
            checkBoxCIS102 = new CheckBox();
            buttonSubmit = new Button();
            textBoxResult = new TextBox();
            Hackster = new LinkLabel();
            pictureBoxDuckie = new PictureBox();
            comboCampus = new ComboBox();
            groupMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDuckie).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(41, 36);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(96, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(39, 77);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(41, 126);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // textLastName
            // 
            textLastName.Location = new Point(175, 123);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(567, 31);
            textLastName.TabIndex = 3;
            // 
            // textStudentID
            // 
            textStudentID.Location = new Point(175, 30);
            textStudentID.Name = "textStudentID";
            textStudentID.Size = new Size(567, 31);
            textStudentID.TabIndex = 4;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(175, 77);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(567, 31);
            textFirstName.TabIndex = 5;
            // 
            // groupMajor
            // 
            groupMajor.Controls.Add(radioIT);
            groupMajor.Controls.Add(radioWebDesign);
            groupMajor.Controls.Add(radioProgramming);
            groupMajor.Location = new Point(391, 207);
            groupMajor.Name = "groupMajor";
            groupMajor.Size = new Size(279, 158);
            groupMajor.TabIndex = 6;
            groupMajor.TabStop = false;
            groupMajor.Text = "Major";
            // 
            // radioIT
            // 
            radioIT.AutoSize = true;
            radioIT.Location = new Point(20, 113);
            radioIT.Name = "radioIT";
            radioIT.Size = new Size(51, 29);
            radioIT.TabIndex = 2;
            radioIT.TabStop = true;
            radioIT.Text = "IT";
            radioIT.UseVisualStyleBackColor = true;
            // 
            // radioWebDesign
            // 
            radioWebDesign.AutoSize = true;
            radioWebDesign.Location = new Point(20, 78);
            radioWebDesign.Name = "radioWebDesign";
            radioWebDesign.Size = new Size(133, 29);
            radioWebDesign.TabIndex = 1;
            radioWebDesign.TabStop = true;
            radioWebDesign.Text = "Web Design";
            radioWebDesign.UseVisualStyleBackColor = true;
            // 
            // radioProgramming
            // 
            radioProgramming.AutoSize = true;
            radioProgramming.Location = new Point(20, 43);
            radioProgramming.Name = "radioProgramming";
            radioProgramming.Size = new Size(147, 29);
            radioProgramming.TabIndex = 0;
            radioProgramming.TabStop = true;
            radioProgramming.Text = "Programming";
            radioProgramming.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Location = new Point(42, 176);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(67, 25);
            lblCourses.TabIndex = 7;
            lblCourses.Text = "Course";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(257, 176);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 25);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score";
            // 
            // checkBoxCIS103
            // 
            checkBoxCIS103.AutoSize = true;
            checkBoxCIS103.Location = new Point(42, 289);
            checkBoxCIS103.Name = "checkBoxCIS103";
            checkBoxCIS103.Size = new Size(94, 29);
            checkBoxCIS103.TabIndex = 11;
            checkBoxCIS103.Text = "CIS103";
            checkBoxCIS103.UseVisualStyleBackColor = true;
            // 
            // checkBoxCIS104
            // 
            checkBoxCIS104.AutoSize = true;
            checkBoxCIS104.Location = new Point(42, 324);
            checkBoxCIS104.Name = "checkBoxCIS104";
            checkBoxCIS104.Size = new Size(94, 29);
            checkBoxCIS104.TabIndex = 12;
            checkBoxCIS104.Text = "CIS104";
            checkBoxCIS104.UseVisualStyleBackColor = true;
            // 
            // textBoxScore1
            // 
            textBoxScore1.Location = new Point(216, 219);
            textBoxScore1.Name = "textBoxScore1";
            textBoxScore1.Size = new Size(150, 31);
            textBoxScore1.TabIndex = 13;
            // 
            // textBoxScore2
            // 
            textBoxScore2.Location = new Point(216, 256);
            textBoxScore2.Name = "textBoxScore2";
            textBoxScore2.Size = new Size(150, 31);
            textBoxScore2.TabIndex = 14;
            // 
            // textBoxScore3
            // 
            textBoxScore3.Location = new Point(216, 293);
            textBoxScore3.Name = "textBoxScore3";
            textBoxScore3.Size = new Size(150, 31);
            textBoxScore3.TabIndex = 15;
            // 
            // textBoxScore4
            // 
            textBoxScore4.Location = new Point(216, 330);
            textBoxScore4.Name = "textBoxScore4";
            textBoxScore4.Size = new Size(150, 31);
            textBoxScore4.TabIndex = 16;
            // 
            // checkBoxCIS101
            // 
            checkBoxCIS101.AutoSize = true;
            checkBoxCIS101.Location = new Point(42, 219);
            checkBoxCIS101.Name = "checkBoxCIS101";
            checkBoxCIS101.Size = new Size(94, 29);
            checkBoxCIS101.TabIndex = 17;
            checkBoxCIS101.Text = "CIS101";
            checkBoxCIS101.UseVisualStyleBackColor = true;
            // 
            // checkBoxCIS102
            // 
            checkBoxCIS102.AutoSize = true;
            checkBoxCIS102.Location = new Point(42, 254);
            checkBoxCIS102.Name = "checkBoxCIS102";
            checkBoxCIS102.Size = new Size(94, 29);
            checkBoxCIS102.TabIndex = 18;
            checkBoxCIS102.Text = "CIS102";
            checkBoxCIS102.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(20, 543);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(112, 34);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(145, 390);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(652, 217);
            textBoxResult.TabIndex = 20;
            // 
            // Hackster
            // 
            Hackster.AutoSize = true;
            Hackster.Location = new Point(234, 630);
            Hackster.Name = "Hackster";
            Hackster.Size = new Size(370, 25);
            Hackster.TabIndex = 21;
            Hackster.TabStop = true;
            Hackster.Text = "https://www.hackster.io/jamiedowden-duarte";
            Hackster.LinkClicked += Hackster_LinkClicked;
            // 
            // pictureBoxDuckie
            // 
            pictureBoxDuckie.Image = (Image)resources.GetObject("pictureBoxDuckie.Image");
            pictureBoxDuckie.Location = new Point(20, 400);
            pictureBoxDuckie.Name = "pictureBoxDuckie";
            pictureBoxDuckie.Size = new Size(93, 90);
            pictureBoxDuckie.TabIndex = 22;
            pictureBoxDuckie.TabStop = false;
            pictureBoxDuckie.Click += pictureBoxDuckie_Click;
            // 
            // comboCampus
            // 
            comboCampus.FormattingEnabled = true;
            comboCampus.Items.AddRange(new object[] { "Main", "Montoya", "Rio Rancho" });
            comboCampus.Location = new Point(705, 215);
            comboCampus.Name = "comboCampus";
            comboCampus.Size = new Size(182, 33);
            comboCampus.TabIndex = 23;
            comboCampus.Text = "Campus";
            // 
            // FormStudentInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 688);
            Controls.Add(comboCampus);
            Controls.Add(pictureBoxDuckie);
            Controls.Add(Hackster);
            Controls.Add(textBoxResult);
            Controls.Add(buttonSubmit);
            Controls.Add(checkBoxCIS102);
            Controls.Add(checkBoxCIS101);
            Controls.Add(textBoxScore4);
            Controls.Add(textBoxScore3);
            Controls.Add(textBoxScore2);
            Controls.Add(textBoxScore1);
            Controls.Add(checkBoxCIS104);
            Controls.Add(checkBoxCIS103);
            Controls.Add(lblScore);
            Controls.Add(lblCourses);
            Controls.Add(groupMajor);
            Controls.Add(textFirstName);
            Controls.Add(textStudentID);
            Controls.Add(textLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            Name = "FormStudentInfo";
            Text = "Student Info";
            groupMajor.ResumeLayout(false);
            groupMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDuckie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //labels
        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;

        //TXT box fill in
        private TextBox textLastName;
        private TextBox textStudentID;
        private TextBox textFirstName;

        //Radio buttons
        private GroupBox groupMajor;
        private RadioButton radioIT;
        private RadioButton radioWebDesign;
        private RadioButton radioProgramming;

        //Labels
        private Label lblCourses;
        private Label lblScore;

        //course check boxes
        private CheckBox checkBoxCIS101;
        private CheckBox checkBoxCIS102;
        private CheckBox checkBoxCIS103;
        private CheckBox checkBoxCIS104;

        //Scores
        private TextBox textBoxScore1;
        private TextBox textBoxScore2;
        private TextBox textBoxScore3;
        private TextBox textBoxScore4;
       
        //Submit
        private Button buttonSubmit;
        private TextBox textBoxResult;
        private LinkLabel Hackster;
        private PictureBox pictureBoxDuckie;
        private ComboBox comboCampus;
    }
}
