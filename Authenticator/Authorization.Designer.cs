namespace Authenticator
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordAutTB = new System.Windows.Forms.TextBox();
            this.LoginAutTB = new System.Windows.Forms.TextBox();
            this.LoginBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JakobXC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JakobXC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "Логин";
            // 
            // PasswordAutTB
            // 
            this.PasswordAutTB.Location = new System.Drawing.Point(210, 268);
            this.PasswordAutTB.Name = "PasswordAutTB";
            this.PasswordAutTB.Size = new System.Drawing.Size(100, 23);
            this.PasswordAutTB.TabIndex = 13;
            // 
            // LoginAutTB
            // 
            this.LoginAutTB.Location = new System.Drawing.Point(210, 217);
            this.LoginAutTB.Name = "LoginAutTB";
            this.LoginAutTB.Size = new System.Drawing.Size(100, 23);
            this.LoginAutTB.TabIndex = 12;
            // 
            // LoginBT
            // 
            this.LoginBT.Font = new System.Drawing.Font("JakobXC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBT.Location = new System.Drawing.Point(190, 367);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(129, 40);
            this.LoginBT.TabIndex = 16;
            this.LoginBT.Text = "Войти";
            this.LoginBT.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 507);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordAutTB);
            this.Controls.Add(this.LoginAutTB);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox PasswordAutTB;
        private TextBox LoginAutTB;
        private Button LoginBT;
    }
}