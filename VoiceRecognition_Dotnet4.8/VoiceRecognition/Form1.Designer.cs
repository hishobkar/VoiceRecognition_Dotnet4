namespace VoiceRecognition
{
    partial class Form1
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
            this.btn_disable_voice = new System.Windows.Forms.Button();
            this.btn_enable_voice = new System.Windows.Forms.Button();
            this.btn_talk = new System.Windows.Forms.Button();
            this.rt_echo = new System.Windows.Forms.RichTextBox();
            this.btn_print_command = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_disable_voice
            // 
            this.btn_disable_voice.Location = new System.Drawing.Point(12, 267);
            this.btn_disable_voice.Name = "btn_disable_voice";
            this.btn_disable_voice.Size = new System.Drawing.Size(75, 23);
            this.btn_disable_voice.TabIndex = 0;
            this.btn_disable_voice.Text = "DisableVoice";
            this.btn_disable_voice.UseVisualStyleBackColor = true;
            this.btn_disable_voice.Click += new System.EventHandler(this.btn_disable_voice_Click);
            // 
            // btn_enable_voice
            // 
            this.btn_enable_voice.Location = new System.Drawing.Point(93, 267);
            this.btn_enable_voice.Name = "btn_enable_voice";
            this.btn_enable_voice.Size = new System.Drawing.Size(75, 23);
            this.btn_enable_voice.TabIndex = 1;
            this.btn_enable_voice.Text = "EnableVoice";
            this.btn_enable_voice.UseVisualStyleBackColor = true;
            this.btn_enable_voice.Click += new System.EventHandler(this.btn_enable_voice_Click);
            // 
            // btn_talk
            // 
            this.btn_talk.Location = new System.Drawing.Point(304, 267);
            this.btn_talk.Name = "btn_talk";
            this.btn_talk.Size = new System.Drawing.Size(75, 23);
            this.btn_talk.TabIndex = 2;
            this.btn_talk.Text = "Talk";
            this.btn_talk.UseVisualStyleBackColor = true;
            this.btn_talk.Click += new System.EventHandler(this.btn_talk_Click);
            // 
            // rt_echo
            // 
            this.rt_echo.Location = new System.Drawing.Point(3, 2);
            this.rt_echo.Name = "rt_echo";
            this.rt_echo.Size = new System.Drawing.Size(483, 259);
            this.rt_echo.TabIndex = 3;
            this.rt_echo.Text = "";
            // 
            // btn_print_command
            // 
            this.btn_print_command.Location = new System.Drawing.Point(385, 267);
            this.btn_print_command.Name = "btn_print_command";
            this.btn_print_command.Size = new System.Drawing.Size(75, 23);
            this.btn_print_command.TabIndex = 4;
            this.btn_print_command.Text = "PrintCommand";
            this.btn_print_command.UseVisualStyleBackColor = true;
            this.btn_print_command.Click += new System.EventHandler(this.btn_print_command_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 299);
            this.Controls.Add(this.btn_print_command);
            this.Controls.Add(this.btn_talk);
            this.Controls.Add(this.btn_enable_voice);
            this.Controls.Add(this.btn_disable_voice);
            this.Controls.Add(this.rt_echo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_disable_voice;
        private System.Windows.Forms.Button btn_enable_voice;
        private System.Windows.Forms.Button btn_talk;
        private System.Windows.Forms.RichTextBox rt_echo;
        private System.Windows.Forms.Button btn_print_command;
    }
}