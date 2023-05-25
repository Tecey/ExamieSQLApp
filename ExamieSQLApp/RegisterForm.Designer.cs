namespace ExamieSQLApp
{
    partial class RegisterForm
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
            MainPanel=new Panel();
            RegisterLabel=new Label();
            UserSurnameField=new TextBox();
            UserNameField=new TextBox();
            ButtonRegiston=new Button();
            buttonLogin=new Button();
            PassField=new TextBox();
            LoginField=new TextBox();
            PictureBox2=new PictureBox();
            PictureBox1=new PictureBox();
            panel2=new Panel();
            CloseButton=new Label();
            Label1=new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor=Color.FromArgb(255, 255, 192);
            MainPanel.Controls.Add(RegisterLabel);
            MainPanel.Controls.Add(UserSurnameField);
            MainPanel.Controls.Add(UserNameField);
            MainPanel.Controls.Add(ButtonRegiston);
            MainPanel.Controls.Add(buttonLogin);
            MainPanel.Controls.Add(PassField);
            MainPanel.Controls.Add(LoginField);
            MainPanel.Controls.Add(PictureBox2);
            MainPanel.Controls.Add(PictureBox1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock=DockStyle.Fill;
            MainPanel.Location=new Point(0, 0);
            MainPanel.Name="MainPanel";
            MainPanel.Size=new Size(800, 450);
            MainPanel.TabIndex=1;
            MainPanel.MouseDown+=MainPanel_MouseDown;
            MainPanel.MouseMove+=MainPanel_MouseMove;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize=true;
            RegisterLabel.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLabel.Location=new Point(327, 424);
            RegisterLabel.Name="RegisterLabel";
            RegisterLabel.Size=new Size(141, 21);
            RegisterLabel.TabIndex=7;
            RegisterLabel.Text="Авторизуватись!";
            RegisterLabel.TextAlign=ContentAlignment.BottomCenter;
            RegisterLabel.Click+=RegisterLabel_Click;
            // 
            // UserSurnameField
            // 
            UserSurnameField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserSurnameField.Location=new Point(501, 196);
            UserSurnameField.Multiline=true;
            UserSurnameField.Name="UserSurnameField";
            UserSurnameField.Size=new Size(251, 64);
            UserSurnameField.TabIndex=6;
            UserSurnameField.Enter+=UserSurnameField_Enter;
            UserSurnameField.Leave+=UserSurnameField_Leave;
            // 
            // UserNameField
            // 
            UserNameField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameField.Location=new Point(113, 196);
            UserNameField.Multiline=true;
            UserNameField.Name="UserNameField";
            UserNameField.Size=new Size(251, 64);
            UserNameField.TabIndex=5;
            UserNameField.Enter+=UserNameField_Enter;
            UserNameField.Leave+=UserNameField_Leave;
            // 
            // ButtonRegiston
            // 
            ButtonRegiston.BackColor=Color.Green;
            ButtonRegiston.FlatAppearance.BorderColor=Color.Blue;
            ButtonRegiston.FlatAppearance.BorderSize=2;
            ButtonRegiston.FlatAppearance.MouseDownBackColor=Color.FromArgb(128, 255, 128);
            ButtonRegiston.FlatAppearance.MouseOverBackColor=Color.FromArgb(0, 64, 0);
            ButtonRegiston.FlatStyle=FlatStyle.Flat;
            ButtonRegiston.Font=new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRegiston.ForeColor=Color.White;
            ButtonRegiston.Location=new Point(235, 376);
            ButtonRegiston.Name="ButtonRegiston";
            ButtonRegiston.Size=new Size(321, 45);
            ButtonRegiston.TabIndex=4;
            ButtonRegiston.Text="Реєстрація";
            ButtonRegiston.UseVisualStyleBackColor=false;
            ButtonRegiston.Click+=ButtonRegiston_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor=Color.Green;
            buttonLogin.FlatAppearance.BorderColor=Color.Blue;
            buttonLogin.FlatAppearance.BorderSize=2;
            buttonLogin.FlatAppearance.MouseDownBackColor=Color.FromArgb(128, 255, 128);
            buttonLogin.FlatAppearance.MouseOverBackColor=Color.FromArgb(0, 64, 0);
            buttonLogin.FlatStyle=FlatStyle.Flat;
            buttonLogin.Font=new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor=Color.White;
            buttonLogin.Location=new Point(69, 495);
            buttonLogin.Name="buttonLogin";
            buttonLogin.Size=new Size(321, 45);
            buttonLogin.TabIndex=3;
            buttonLogin.Text="Увійти";
            buttonLogin.UseVisualStyleBackColor=false;
            // 
            // PassField
            // 
            PassField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            PassField.Location=new Point(501, 292);
            PassField.Name="PassField";
            PassField.Size=new Size(251, 48);
            PassField.TabIndex=2;
            PassField.UseSystemPasswordChar=true;
            PassField.Enter+=PassField_Enter;
            PassField.Leave+=PassField_Leave;
            // 
            // LoginField
            // 
            LoginField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginField.Location=new Point(113, 292);
            LoginField.Multiline=true;
            LoginField.Name="LoginField";
            LoginField.Size=new Size(251, 64);
            LoginField.TabIndex=2;
            LoginField.Enter+=LoginField_Enter;
            LoginField.Leave+=LoginField_Leave;
            // 
            // PictureBox2
            // 
            PictureBox2.Image=Properties.Resources._lock;
            PictureBox2.Location=new Point(431, 292);
            PictureBox2.Name="PictureBox2";
            PictureBox2.Size=new Size(64, 64);
            PictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            PictureBox2.TabIndex=1;
            PictureBox2.TabStop=false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image=Properties.Resources.user;
            PictureBox1.Location=new Point(43, 292);
            PictureBox1.Name="PictureBox1";
            PictureBox1.Size=new Size(64, 64);
            PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex=1;
            PictureBox1.TabStop=false;
            // 
            // panel2
            // 
            panel2.BackColor=Color.Navy;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(Label1);
            panel2.Dock=DockStyle.Top;
            panel2.Location=new Point(0, 0);
            panel2.Name="panel2";
            panel2.Size=new Size(800, 155);
            panel2.TabIndex=0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize=true;
            CloseButton.Cursor=Cursors.Hand;
            CloseButton.Dock=DockStyle.Right;
            CloseButton.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor=Color.FromArgb(224, 224, 224);
            CloseButton.Location=new Point(772, 0);
            CloseButton.Name="CloseButton";
            CloseButton.Size=new Size(28, 32);
            CloseButton.TabIndex=1;
            CloseButton.Text="X";
            CloseButton.TextAlign=ContentAlignment.TopRight;
            CloseButton.Click+=CloseButton_Click;
            CloseButton.MouseEnter+=CloseButton_MouseEnter;
            CloseButton.MouseLeave+=CloseButton_MouseLeave;
            // 
            // Label1
            // 
            Label1.BackColor=Color.LightSkyBlue;
            Label1.Dock=DockStyle.Fill;
            Label1.Font=new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.ForeColor=Color.FromArgb(0, 0, 192);
            Label1.Location=new Point(0, 0);
            Label1.Name="Label1";
            Label1.Size=new Size(800, 155);
            Label1.TabIndex=0;
            Label1.Text="Реєстрація";
            Label1.TextAlign=ContentAlignment.MiddleCenter;
            Label1.MouseDown+=Label1_MouseDown;
            Label1.MouseMove+=Label1_MouseMove;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle=FormBorderStyle.None;
            Name="RegisterForm";
            Text="RegisterForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button buttonLogin;
        private TextBox PassField;
        private TextBox LoginField;
        private PictureBox PictureBox2;
        private PictureBox PictureBox1;
        private Panel panel2;
        private Label CloseButton;
        private Label Label1;
        private Button ButtonRegiston;
        private TextBox UserSurnameField;
        private TextBox UserNameField;
        private Label RegisterLabel;
    }
}