namespace ExamieSQLApp
{
    partial class LoginForm
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
            buttonLogin=new Button();
            passField=new TextBox();
            loginField=new TextBox();
            pictureBox2=new PictureBox();
            pictureBox1=new PictureBox();
            panel2=new Panel();
            CloseButton=new Label();
            Label1=new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor=Color.FromArgb(255, 255, 192);
            MainPanel.Controls.Add(RegisterLabel);
            MainPanel.Controls.Add(buttonLogin);
            MainPanel.Controls.Add(passField);
            MainPanel.Controls.Add(loginField);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock=DockStyle.Fill;
            MainPanel.Location=new Point(0, 0);
            MainPanel.Name="MainPanel";
            MainPanel.Size=new Size(474, 644);
            MainPanel.TabIndex=0;
            MainPanel.MouseDown+=MainPanel_MouseDown;
            MainPanel.MouseMove+=MainPanel_MouseMove;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize=true;
            RegisterLabel.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLabel.Location=new Point(160, 614);
            RegisterLabel.Name="RegisterLabel";
            RegisterLabel.Size=new Size(148, 21);
            RegisterLabel.TabIndex=4;
            RegisterLabel.Text="ВІдсутній акаунт?";
            RegisterLabel.TextAlign=ContentAlignment.BottomCenter;
            RegisterLabel.Click+=RegisterLabel_Click;
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
            buttonLogin.Click+=ButtonLogin_Click;
            // 
            // passField
            // 
            passField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location=new Point(133, 268);
            passField.Name="passField";
            passField.Size=new Size(251, 48);
            passField.TabIndex=2;
            passField.UseSystemPasswordChar=true;
            passField.TextChanged+=TextBox1_TextChanged;
            // 
            // loginField
            // 
            loginField.Font=new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location=new Point(133, 183);
            loginField.Multiline=true;
            loginField.Name="loginField";
            loginField.Size=new Size(251, 64);
            loginField.TabIndex=2;
            loginField.TextChanged+=TextBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources._lock;
            pictureBox2.Location=new Point(63, 268);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(64, 64);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=1;
            pictureBox2.TabStop=false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.user;
            pictureBox1.Location=new Point(63, 183);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(64, 64);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            // 
            // panel2
            // 
            panel2.BackColor=Color.Navy;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(Label1);
            panel2.Dock=DockStyle.Top;
            panel2.Location=new Point(0, 0);
            panel2.Name="panel2";
            panel2.Size=new Size(474, 155);
            panel2.TabIndex=0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize=true;
            CloseButton.Cursor=Cursors.Hand;
            CloseButton.Dock=DockStyle.Right;
            CloseButton.Font=new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor=Color.FromArgb(224, 224, 224);
            CloseButton.Location=new Point(446, 0);
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
            Label1.Size=new Size(474, 155);
            Label1.TabIndex=0;
            Label1.Text="Авторизація";
            Label1.TextAlign=ContentAlignment.MiddleCenter;
            Label1.Click+=Label1_Click;
            Label1.MouseDown+=Label1_MouseDown;
            Label1.MouseMove+=Label1_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(474, 644);
            Controls.Add(MainPanel);
            FormBorderStyle=FormBorderStyle.None;
            Name="LoginForm";
            Text="LoginForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel2;
        private Label Label1;
        private Label CloseButton;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private Button buttonLogin;
        private TextBox passField;
        private PictureBox pictureBox2;
        private Label RegisterLabel;
    }
}