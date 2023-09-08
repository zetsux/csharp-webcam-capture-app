namespace PBKK2
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
            comboBoxWebcamList = new ComboBox();
            buttonStart = new Button();
            buttonCapt = new Button();
            buttonSave = new Button();
            buttonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            comboBoxWebcamList.FormattingEnabled = true;
            comboBoxWebcamList.Location = new Point(10, 345);
            comboBoxWebcamList.Name = "comboBoxWebcamList";
            comboBoxWebcamList.Size = new Size(207, 23);
            comboBoxWebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(591, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCapt
            // 
            buttonCapt.Location = new Point(507, 344);
            buttonCapt.Name = "buttonCapt";
            buttonCapt.Size = new Size(75, 23);
            buttonCapt.TabIndex = 2;
            buttonCapt.Text = "Capture";
            buttonCapt.UseVisualStyleBackColor = true;
            buttonCapt.Click += buttonCapt_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(589, 344);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 12);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(14, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(648, 186);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(327, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 51);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 6;
            label1.Text = "Camera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 51);
            label2.Name = "label2";
            label2.Size = new Size(134, 45);
            label2.TabIndex = 7;
            label2.Text = "Capture";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(678, 384);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(buttonCapt);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxWebcamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWebcamList;
        private Button buttonStart;
        private Button buttonCapt;
        private Button buttonSave;
        private Button buttonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}