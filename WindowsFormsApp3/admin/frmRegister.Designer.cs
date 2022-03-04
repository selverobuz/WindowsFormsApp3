namespace WindowsFormsApp3.admin
{
    partial class frmRegister
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
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasword2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfilePicture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(222, 50);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(200, 22);
            this.txtMemberName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye Adı:";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(222, 77);
            this.txtMemberSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(200, 22);
            this.txtMemberSurname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(222, 137);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(222, 193);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(200, 22);
            this.txtPasword.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre:";
            // 
            // txtPasword2
            // 
            this.txtPasword2.Location = new System.Drawing.Point(222, 221);
            this.txtPasword2.Name = "txtPasword2";
            this.txtPasword2.Size = new System.Drawing.Size(200, 22);
            this.txtPasword2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Şifre Tekrar:";
            // 
            // txtProfilePicture
            // 
            this.txtProfilePicture.Location = new System.Drawing.Point(222, 249);
            this.txtProfilePicture.Name = "txtProfilePicture";
            this.txtProfilePicture.Size = new System.Drawing.Size(200, 22);
            this.txtProfilePicture.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Profil Resmi:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(222, 110);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthday.TabIndex = 20;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(222, 165);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(200, 22);
            this.mtbPhone.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(128, 291);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(294, 23);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 374);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtProfilePicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPasword2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasword2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfilePicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Button btnRegister;
    }
}