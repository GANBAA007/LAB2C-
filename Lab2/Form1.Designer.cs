namespace Lab2
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            Flno = new TextBox();
            Cusno = new TextBox();
            Pasno = new TextBox();
            Loc = new ComboBox();
            Des = new ComboBox();
            Date = new DateTimePicker();
            Type = new ComboBox();
            Serv = new CheckedListBox();
            цэвэрлэх = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(219, 41);
            label1.Name = "label1";
            label1.Size = new Size(327, 28);
            label1.TabIndex = 0;
            label1.Text = "Нислэгийн захиалгын дэлгэрэнгүй";
            // 
            // button1
            // 
            button1.Location = new Point(252, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Шалгах";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Нислэгийн №:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 155);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "Зорчигчийн нэр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 182);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 4;
            label4.Text = "Паспорт №:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 215);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Хаанаас:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 246);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 6;
            label6.Text = "Хаашаа:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 279);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 7;
            label7.Text = "Нислэгийн огноо:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 305);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "Ангилал:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(203, 331);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 10;
            label10.Text = "Үйлчилгээ:";
            // 
            // Flno
            // 
            Flno.AccessibleName = "Flno";
            Flno.Location = new Point(321, 120);
            Flno.Name = "Flno";
            Flno.Size = new Size(100, 23);
            Flno.TabIndex = 11;
            // 
            // Cusno
            // 
            Cusno.Location = new Point(321, 147);
            Cusno.Name = "Cusno";
            Cusno.Size = new Size(100, 23);
            Cusno.TabIndex = 12;
            // 
            // Pasno
            // 
            Pasno.Location = new Point(321, 179);
            Pasno.Name = "Pasno";
            Pasno.Size = new Size(100, 23);
            Pasno.TabIndex = 13;
            // 
            // Loc
            // 
            Loc.FormattingEnabled = true;
            Loc.Location = new Point(321, 212);
            Loc.Name = "Loc";
            Loc.Size = new Size(121, 23);
            Loc.TabIndex = 14;
            // 
            // Des
            // 
            Des.FormattingEnabled = true;
            Des.Location = new Point(321, 243);
            Des.Name = "Des";
            Des.Size = new Size(121, 23);
            Des.TabIndex = 15;
            // 
            // Date
            // 
            Date.Location = new Point(321, 273);
            Date.Name = "Date";
            Date.Size = new Size(200, 23);
            Date.TabIndex = 16;
            // 
            // Type
            // 
            Type.FormattingEnabled = true;
            Type.Location = new Point(321, 302);
            Type.Name = "Type";
            Type.Size = new Size(121, 23);
            Type.TabIndex = 17;
            // 
            // Serv
            // 
            Serv.FormattingEnabled = true;
            Serv.Location = new Point(322, 331);
            Serv.Name = "Serv";
            Serv.Size = new Size(120, 40);
            Serv.TabIndex = 18;
            // 
            // цэвэрлэх
            // 
            цэвэрлэх.Location = new Point(411, 431);
            цэвэрлэх.Name = "цэвэрлэх";
            цэвэрлэх.Size = new Size(75, 23);
            цэвэрлэх.TabIndex = 19;
            цэвэрлэх.Text = "цэвэрлэх";
            цэвэрлэх.UseVisualStyleBackColor = true;
            цэвэрлэх.Click += цэвэрлэх_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(цэвэрлэх);
            Controls.Add(Serv);
            Controls.Add(Type);
            Controls.Add(Date);
            Controls.Add(Des);
            Controls.Add(Loc);
            Controls.Add(Pasno);
            Controls.Add(Cusno);
            Controls.Add(Flno);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox Flno;
        private TextBox Cusno;
        private TextBox Pasno;
        private ComboBox Loc;
        private ComboBox Des;
        private DateTimePicker Date;
        private ComboBox Type;
        private CheckedListBox Serv;
        private Button цэвэрлэх;
    }
}
