
namespace RSA
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
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fresh = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_savetodb = new System.Windows.Forms.Button();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_rinktisdb = new System.Windows.Forms.Button();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_fn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(16, 24);
            this.textBox_p.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(60, 20);
            this.textBox_p.TabIndex = 0;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(80, 24);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(54, 20);
            this.textBox_q.TabIndex = 1;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(16, 185);
            this.button_encrypt.Margin = new System.Windows.Forms.Padding(2);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(75, 30);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.Text = "Encryption";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "q";
            // 
            // textBox_fresh
            // 
            this.textBox_fresh.Location = new System.Drawing.Point(16, 48);
            this.textBox_fresh.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fresh.Multiline = true;
            this.textBox_fresh.Name = "textBox_fresh";
            this.textBox_fresh.Size = new System.Drawing.Size(350, 133);
            this.textBox_fresh.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 382);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(99, 185);
            this.button_decrypt.Margin = new System.Windows.Forms.Padding(2);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(75, 30);
            this.button_decrypt.TabIndex = 7;
            this.button_decrypt.Text = "Decryption";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_result.Location = new System.Drawing.Point(16, 228);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(350, 147);
            this.textBox_result.TabIndex = 8;
            // 
            // button_savetodb
            // 
            this.button_savetodb.Location = new System.Drawing.Point(16, 379);
            this.button_savetodb.Margin = new System.Windows.Forms.Padding(2);
            this.button_savetodb.Name = "button_savetodb";
            this.button_savetodb.Size = new System.Drawing.Size(148, 27);
            this.button_savetodb.TabIndex = 9;
            this.button_savetodb.Text = "Save to database";
            this.button_savetodb.UseVisualStyleBackColor = true;
            this.button_savetodb.Click += new System.EventHandler(this.button_savetodb_Click);
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(254, 24);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.ReadOnly = true;
            this.textBox_e.Size = new System.Drawing.Size(53, 20);
            this.textBox_e.TabIndex = 10;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(311, 24);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.ReadOnly = true;
            this.textBox_d.Size = new System.Drawing.Size(55, 20);
            this.textBox_d.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "d";
            // 
            // button_rinktisdb
            // 
            this.button_rinktisdb.Location = new System.Drawing.Point(303, 382);
            this.button_rinktisdb.Margin = new System.Windows.Forms.Padding(2);
            this.button_rinktisdb.Name = "button_rinktisdb";
            this.button_rinktisdb.Size = new System.Drawing.Size(63, 20);
            this.button_rinktisdb.TabIndex = 14;
            this.button_rinktisdb.Text = "Open";
            this.button_rinktisdb.UseVisualStyleBackColor = true;
            this.button_rinktisdb.Click += new System.EventHandler(this.button_rinktisdb_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(197, 24);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.Size = new System.Drawing.Size(53, 20);
            this.textBox_n.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "n";
            // 
            // textBox_fn
            // 
            this.textBox_fn.Location = new System.Drawing.Point(138, 24);
            this.textBox_fn.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fn.Name = "textBox_fn";
            this.textBox_fn.ReadOnly = true;
            this.textBox_fn.Size = new System.Drawing.Size(55, 20);
            this.textBox_fn.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "φ(n)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(377, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_fn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.button_rinktisdb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.button_savetodb);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_fresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_savetodb;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_rinktisdb;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_fn;
        private System.Windows.Forms.Label label6;
    }
}

