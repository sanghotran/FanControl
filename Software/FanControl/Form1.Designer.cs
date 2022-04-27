namespace FanControl
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
            this.components = new System.ComponentModel.Container();
            this.btn_ToggleDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_setPWM = new System.Windows.Forms.TextBox();
            this.btn_EnablePWM = new System.Windows.Forms.Button();
            this.btn_SetPWM = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cbo_Com = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_ToggleDir
            // 
            this.btn_ToggleDir.Location = new System.Drawing.Point(12, 12);
            this.btn_ToggleDir.Name = "btn_ToggleDir";
            this.btn_ToggleDir.Size = new System.Drawing.Size(92, 76);
            this.btn_ToggleDir.TabIndex = 0;
            this.btn_ToggleDir.Text = "ToggleDir";
            this.btn_ToggleDir.UseVisualStyleBackColor = true;
            this.btn_ToggleDir.Click += new System.EventHandler(this.btn_ToggleDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "%";
            // 
            // txt_setPWM
            // 
            this.txt_setPWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_setPWM.Location = new System.Drawing.Point(205, 12);
            this.txt_setPWM.Name = "txt_setPWM";
            this.txt_setPWM.Size = new System.Drawing.Size(82, 38);
            this.txt_setPWM.TabIndex = 2;
            // 
            // btn_EnablePWM
            // 
            this.btn_EnablePWM.Location = new System.Drawing.Point(122, 13);
            this.btn_EnablePWM.Name = "btn_EnablePWM";
            this.btn_EnablePWM.Size = new System.Drawing.Size(75, 75);
            this.btn_EnablePWM.TabIndex = 3;
            this.btn_EnablePWM.Text = "Enable PWM";
            this.btn_EnablePWM.UseVisualStyleBackColor = true;
            this.btn_EnablePWM.Click += new System.EventHandler(this.btn_EnablePWM_Click);
            // 
            // btn_SetPWM
            // 
            this.btn_SetPWM.Location = new System.Drawing.Point(205, 57);
            this.btn_SetPWM.Name = "btn_SetPWM";
            this.btn_SetPWM.Size = new System.Drawing.Size(130, 31);
            this.btn_SetPWM.TabIndex = 4;
            this.btn_SetPWM.Text = "Set PWM";
            this.btn_SetPWM.UseVisualStyleBackColor = true;
            this.btn_SetPWM.Click += new System.EventHandler(this.btn_SetPWM_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(122, 94);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 35);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cbo_Com
            // 
            this.cbo_Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Com.FormattingEnabled = true;
            this.cbo_Com.Location = new System.Drawing.Point(205, 94);
            this.cbo_Com.Name = "cbo_Com";
            this.cbo_Com.Size = new System.Drawing.Size(130, 37);
            this.cbo_Com.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 141);
            this.Controls.Add(this.cbo_Com);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_SetPWM);
            this.Controls.Add(this.btn_EnablePWM);
            this.Controls.Add(this.txt_setPWM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ToggleDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FanControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ToggleDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_setPWM;
        private System.Windows.Forms.Button btn_EnablePWM;
        private System.Windows.Forms.Button btn_SetPWM;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cbo_Com;
    }
}

