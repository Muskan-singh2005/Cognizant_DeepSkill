namespace KafkaChatClient
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
            rtbChat = new RichTextBox();
            btnSend = new Button();
            txtMessage = new TextBox();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(92, 47);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(558, 162);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(443, 215);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(207, 27);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 215);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(444, 27);
            txtMessage.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(rtbChat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private Button btnSend;
        private TextBox txtMessage;
    }
}
