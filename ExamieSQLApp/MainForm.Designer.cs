namespace ExamieSQLApp
{
    partial class MainForm
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
            panel2=new Panel();
            CloseButton=new Label();
            Label1=new Label();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor=Color.FromArgb(255, 255, 192);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock=DockStyle.Fill;
            MainPanel.Location=new Point(0, 0);
            MainPanel.Name="MainPanel";
            MainPanel.Size=new Size(800, 450);
            MainPanel.TabIndex=1;
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
            Label1.Text="Головний екран";
            Label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle=FormBorderStyle.None;
            Name="MainForm";
            StartPosition=FormStartPosition.CenterScreen;
            Text="MainForm";
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel2;
        private Label CloseButton;
        private Label Label1;
    }
}