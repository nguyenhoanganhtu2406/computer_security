namespace Encrypt
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCeasar = new System.Windows.Forms.Button();
            this.txtBanMa = new System.Windows.Forms.TextBox();
            this.btnDeCeasar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCeasar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoDoi = new System.Windows.Forms.TextBox();
            this.tabVigen = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVigenereDecrypt = new System.Windows.Forms.Button();
            this.btnVigenereEncrypt = new System.Windows.Forms.Button();
            this.txtVBanMa = new System.Windows.Forms.TextBox();
            this.txtVInput = new System.Windows.Forms.TextBox();
            this.txtVKey = new System.Windows.Forms.TextBox();
            this.tab3DS = new System.Windows.Forms.TabPage();
            this.btnDecrypt3DS = new System.Windows.Forms.Button();
            this.btnEncrypt3DS = new System.Windows.Forms.Button();
            this.txt3DSGiaiMa = new System.Windows.Forms.TextBox();
            this.txt3DSInput = new System.Windows.Forms.TextBox();
            this.txt3DSKey = new System.Windows.Forms.TextBox();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.btnDecryptRSA = new System.Windows.Forms.Button();
            this.btnEncryptRSA = new System.Windows.Forms.Button();
            this.txtRSADecrypt = new System.Windows.Forms.TextBox();
            this.txtRSAInput = new System.Windows.Forms.TextBox();
            this.txtRSAEncrypt = new System.Windows.Forms.TextBox();
            this.tabHash = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSHA2 = new System.Windows.Forms.Button();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.txtHashResult = new System.Windows.Forms.TextBox();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt3DSBanMa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiaiMa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVGiaiMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCeasar.SuspendLayout();
            this.tabVigen.SuspendLayout();
            this.tab3DS.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.tabHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 87);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(318, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnCeasar
            // 
            this.btnCeasar.Location = new System.Drawing.Point(357, 132);
            this.btnCeasar.Name = "btnCeasar";
            this.btnCeasar.Size = new System.Drawing.Size(100, 23);
            this.btnCeasar.TabIndex = 1;
            this.btnCeasar.Text = "Encrypt";
            this.btnCeasar.UseVisualStyleBackColor = true;
            this.btnCeasar.Click += new System.EventHandler(this.btnCeasar_Click);
            // 
            // txtBanMa
            // 
            this.txtBanMa.Location = new System.Drawing.Point(6, 132);
            this.txtBanMa.Name = "txtBanMa";
            this.txtBanMa.Size = new System.Drawing.Size(318, 20);
            this.txtBanMa.TabIndex = 2;
            // 
            // btnDeCeasar
            // 
            this.btnDeCeasar.Location = new System.Drawing.Point(357, 182);
            this.btnDeCeasar.Name = "btnDeCeasar";
            this.btnDeCeasar.Size = new System.Drawing.Size(100, 23);
            this.btnDeCeasar.TabIndex = 3;
            this.btnDeCeasar.Text = "Decrypt";
            this.btnDeCeasar.UseVisualStyleBackColor = true;
            this.btnDeCeasar.Click += new System.EventHandler(this.btnDeCeasar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCeasar);
            this.tabControl1.Controls.Add(this.tabVigen);
            this.tabControl1.Controls.Add(this.tab3DS);
            this.tabControl1.Controls.Add(this.tabRSA);
            this.tabControl1.Controls.Add(this.tabHash);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 304);
            this.tabControl1.TabIndex = 4;
            // 
            // tabCeasar
            // 
            this.tabCeasar.Controls.Add(this.label13);
            this.tabCeasar.Controls.Add(this.txtGiaiMa);
            this.tabCeasar.Controls.Add(this.label5);
            this.tabCeasar.Controls.Add(this.label4);
            this.tabCeasar.Controls.Add(this.label3);
            this.tabCeasar.Controls.Add(this.txtDoDoi);
            this.tabCeasar.Controls.Add(this.btnCeasar);
            this.tabCeasar.Controls.Add(this.btnDeCeasar);
            this.tabCeasar.Controls.Add(this.txtBanMa);
            this.tabCeasar.Controls.Add(this.txtInput);
            this.tabCeasar.Location = new System.Drawing.Point(4, 22);
            this.tabCeasar.Name = "tabCeasar";
            this.tabCeasar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCeasar.Size = new System.Drawing.Size(768, 278);
            this.tabCeasar.TabIndex = 0;
            this.tabCeasar.Text = "Ceasar";
            this.tabCeasar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bản rõ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bản mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key";
            // 
            // txtDoDoi
            // 
            this.txtDoDoi.Location = new System.Drawing.Point(6, 30);
            this.txtDoDoi.Name = "txtDoDoi";
            this.txtDoDoi.Size = new System.Drawing.Size(318, 20);
            this.txtDoDoi.TabIndex = 4;
            // 
            // tabVigen
            // 
            this.tabVigen.Controls.Add(this.label7);
            this.tabVigen.Controls.Add(this.txtVGiaiMa);
            this.tabVigen.Controls.Add(this.label14);
            this.tabVigen.Controls.Add(this.label8);
            this.tabVigen.Controls.Add(this.label6);
            this.tabVigen.Controls.Add(this.btnVigenereDecrypt);
            this.tabVigen.Controls.Add(this.btnVigenereEncrypt);
            this.tabVigen.Controls.Add(this.txtVBanMa);
            this.tabVigen.Controls.Add(this.txtVInput);
            this.tabVigen.Controls.Add(this.txtVKey);
            this.tabVigen.Location = new System.Drawing.Point(4, 22);
            this.tabVigen.Name = "tabVigen";
            this.tabVigen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigen.Size = new System.Drawing.Size(768, 278);
            this.tabVigen.TabIndex = 1;
            this.tabVigen.Text = "Vigenere";
            this.tabVigen.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bản rõ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key";
            // 
            // btnVigenereDecrypt
            // 
            this.btnVigenereDecrypt.Location = new System.Drawing.Point(420, 167);
            this.btnVigenereDecrypt.Name = "btnVigenereDecrypt";
            this.btnVigenereDecrypt.Size = new System.Drawing.Size(110, 23);
            this.btnVigenereDecrypt.TabIndex = 4;
            this.btnVigenereDecrypt.Text = "Decrypt";
            this.btnVigenereDecrypt.UseVisualStyleBackColor = true;
            this.btnVigenereDecrypt.Click += new System.EventHandler(this.btnVigenereDecrypt_Click);
            // 
            // btnVigenereEncrypt
            // 
            this.btnVigenereEncrypt.Location = new System.Drawing.Point(420, 123);
            this.btnVigenereEncrypt.Name = "btnVigenereEncrypt";
            this.btnVigenereEncrypt.Size = new System.Drawing.Size(110, 23);
            this.btnVigenereEncrypt.TabIndex = 3;
            this.btnVigenereEncrypt.Text = "Encrypt";
            this.btnVigenereEncrypt.UseVisualStyleBackColor = true;
            this.btnVigenereEncrypt.Click += new System.EventHandler(this.btnVigenereEncrypt_Click);
            // 
            // txtVBanMa
            // 
            this.txtVBanMa.Location = new System.Drawing.Point(6, 126);
            this.txtVBanMa.Name = "txtVBanMa";
            this.txtVBanMa.Size = new System.Drawing.Size(373, 20);
            this.txtVBanMa.TabIndex = 2;
            // 
            // txtVInput
            // 
            this.txtVInput.Location = new System.Drawing.Point(6, 79);
            this.txtVInput.Name = "txtVInput";
            this.txtVInput.Size = new System.Drawing.Size(373, 20);
            this.txtVInput.TabIndex = 1;
            // 
            // txtVKey
            // 
            this.txtVKey.Location = new System.Drawing.Point(6, 28);
            this.txtVKey.Name = "txtVKey";
            this.txtVKey.Size = new System.Drawing.Size(373, 20);
            this.txtVKey.TabIndex = 0;
            // 
            // tab3DS
            // 
            this.tab3DS.Controls.Add(this.label12);
            this.tab3DS.Controls.Add(this.label11);
            this.tab3DS.Controls.Add(this.label10);
            this.tab3DS.Controls.Add(this.txt3DSBanMa);
            this.tab3DS.Controls.Add(this.label9);
            this.tab3DS.Controls.Add(this.btnDecrypt3DS);
            this.tab3DS.Controls.Add(this.btnEncrypt3DS);
            this.tab3DS.Controls.Add(this.txt3DSGiaiMa);
            this.tab3DS.Controls.Add(this.txt3DSInput);
            this.tab3DS.Controls.Add(this.txt3DSKey);
            this.tab3DS.Location = new System.Drawing.Point(4, 22);
            this.tab3DS.Name = "tab3DS";
            this.tab3DS.Padding = new System.Windows.Forms.Padding(3);
            this.tab3DS.Size = new System.Drawing.Size(768, 278);
            this.tab3DS.TabIndex = 2;
            this.tab3DS.Text = "3DES";
            this.tab3DS.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt3DS
            // 
            this.btnDecrypt3DS.Location = new System.Drawing.Point(367, 173);
            this.btnDecrypt3DS.Name = "btnDecrypt3DS";
            this.btnDecrypt3DS.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt3DS.TabIndex = 5;
            this.btnDecrypt3DS.Text = "Decrypt";
            this.btnDecrypt3DS.UseVisualStyleBackColor = true;
            this.btnDecrypt3DS.Click += new System.EventHandler(this.btnDecrypt3DS_Click);
            // 
            // btnEncrypt3DS
            // 
            this.btnEncrypt3DS.Location = new System.Drawing.Point(367, 127);
            this.btnEncrypt3DS.Name = "btnEncrypt3DS";
            this.btnEncrypt3DS.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt3DS.TabIndex = 4;
            this.btnEncrypt3DS.Text = "Encrypt";
            this.btnEncrypt3DS.UseVisualStyleBackColor = true;
            this.btnEncrypt3DS.Click += new System.EventHandler(this.btnEncrypt3DS_Click);
            // 
            // txt3DSGiaiMa
            // 
            this.txt3DSGiaiMa.Location = new System.Drawing.Point(6, 173);
            this.txt3DSGiaiMa.Name = "txt3DSGiaiMa";
            this.txt3DSGiaiMa.Size = new System.Drawing.Size(313, 20);
            this.txt3DSGiaiMa.TabIndex = 3;
            // 
            // txt3DSInput
            // 
            this.txt3DSInput.Location = new System.Drawing.Point(6, 83);
            this.txt3DSInput.Name = "txt3DSInput";
            this.txt3DSInput.Size = new System.Drawing.Size(313, 20);
            this.txt3DSInput.TabIndex = 2;
            // 
            // txt3DSKey
            // 
            this.txt3DSKey.Location = new System.Drawing.Point(6, 34);
            this.txt3DSKey.Name = "txt3DSKey";
            this.txt3DSKey.Size = new System.Drawing.Size(313, 20);
            this.txt3DSKey.TabIndex = 0;
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.label17);
            this.tabRSA.Controls.Add(this.label16);
            this.tabRSA.Controls.Add(this.label15);
            this.tabRSA.Controls.Add(this.btnDecryptRSA);
            this.tabRSA.Controls.Add(this.btnEncryptRSA);
            this.tabRSA.Controls.Add(this.txtRSADecrypt);
            this.tabRSA.Controls.Add(this.txtRSAInput);
            this.tabRSA.Controls.Add(this.txtRSAEncrypt);
            this.tabRSA.Location = new System.Drawing.Point(4, 22);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSA.Size = new System.Drawing.Size(768, 278);
            this.tabRSA.TabIndex = 3;
            this.tabRSA.Text = "RSA";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // btnDecryptRSA
            // 
            this.btnDecryptRSA.Location = new System.Drawing.Point(365, 210);
            this.btnDecryptRSA.Name = "btnDecryptRSA";
            this.btnDecryptRSA.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptRSA.TabIndex = 10;
            this.btnDecryptRSA.Text = "Decrypt";
            this.btnDecryptRSA.UseVisualStyleBackColor = true;
            this.btnDecryptRSA.Click += new System.EventHandler(this.btnDecryptRSA_Click);
            // 
            // btnEncryptRSA
            // 
            this.btnEncryptRSA.Location = new System.Drawing.Point(365, 127);
            this.btnEncryptRSA.Name = "btnEncryptRSA";
            this.btnEncryptRSA.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptRSA.TabIndex = 9;
            this.btnEncryptRSA.Text = "Encrypt";
            this.btnEncryptRSA.UseVisualStyleBackColor = true;
            this.btnEncryptRSA.Click += new System.EventHandler(this.btnEncryptRSA_Click);
            // 
            // txtRSADecrypt
            // 
            this.txtRSADecrypt.Location = new System.Drawing.Point(15, 193);
            this.txtRSADecrypt.Multiline = true;
            this.txtRSADecrypt.Name = "txtRSADecrypt";
            this.txtRSADecrypt.Size = new System.Drawing.Size(308, 58);
            this.txtRSADecrypt.TabIndex = 8;
            // 
            // txtRSAInput
            // 
            this.txtRSAInput.Location = new System.Drawing.Point(15, 33);
            this.txtRSAInput.Multiline = true;
            this.txtRSAInput.Name = "txtRSAInput";
            this.txtRSAInput.Size = new System.Drawing.Size(308, 56);
            this.txtRSAInput.TabIndex = 7;
            // 
            // txtRSAEncrypt
            // 
            this.txtRSAEncrypt.Location = new System.Drawing.Point(15, 111);
            this.txtRSAEncrypt.Multiline = true;
            this.txtRSAEncrypt.Name = "txtRSAEncrypt";
            this.txtRSAEncrypt.Size = new System.Drawing.Size(308, 54);
            this.txtRSAEncrypt.TabIndex = 6;
            // 
            // tabHash
            // 
            this.tabHash.Controls.Add(this.label2);
            this.tabHash.Controls.Add(this.label1);
            this.tabHash.Controls.Add(this.btnSHA2);
            this.tabHash.Controls.Add(this.btnSHA1);
            this.tabHash.Controls.Add(this.btnMD5);
            this.tabHash.Controls.Add(this.txtHashResult);
            this.tabHash.Controls.Add(this.txtHashInput);
            this.tabHash.Location = new System.Drawing.Point(4, 22);
            this.tabHash.Name = "tabHash";
            this.tabHash.Padding = new System.Windows.Forms.Padding(3);
            this.tabHash.Size = new System.Drawing.Size(768, 278);
            this.tabHash.TabIndex = 4;
            this.tabHash.Text = "Hash Function";
            this.tabHash.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thông tin mã hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chuỗi cần mã hóa:";
            // 
            // btnSHA2
            // 
            this.btnSHA2.Location = new System.Drawing.Point(254, 105);
            this.btnSHA2.Name = "btnSHA2";
            this.btnSHA2.Size = new System.Drawing.Size(75, 30);
            this.btnSHA2.TabIndex = 4;
            this.btnSHA2.Text = "SHA2-512";
            this.btnSHA2.UseVisualStyleBackColor = true;
            this.btnSHA2.Click += new System.EventHandler(this.btnSHA2_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.Location = new System.Drawing.Point(139, 105);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(75, 30);
            this.btnSHA1.TabIndex = 3;
            this.btnSHA1.Text = "SHA1";
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(25, 105);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(75, 30);
            this.btnMD5.TabIndex = 2;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // txtHashResult
            // 
            this.txtHashResult.Location = new System.Drawing.Point(16, 172);
            this.txtHashResult.Multiline = true;
            this.txtHashResult.Name = "txtHashResult";
            this.txtHashResult.Size = new System.Drawing.Size(313, 91);
            this.txtHashResult.TabIndex = 1;
            // 
            // txtHashInput
            // 
            this.txtHashInput.Location = new System.Drawing.Point(16, 22);
            this.txtHashInput.Multiline = true;
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(313, 66);
            this.txtHashInput.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Key";
            // 
            // txt3DSBanMa
            // 
            this.txt3DSBanMa.Location = new System.Drawing.Point(6, 127);
            this.txt3DSBanMa.Name = "txt3DSBanMa";
            this.txt3DSBanMa.Size = new System.Drawing.Size(313, 20);
            this.txt3DSBanMa.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bản rõ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bản mã";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Giải mã";
            // 
            // txtGiaiMa
            // 
            this.txtGiaiMa.Location = new System.Drawing.Point(6, 182);
            this.txtGiaiMa.Name = "txtGiaiMa";
            this.txtGiaiMa.Size = new System.Drawing.Size(318, 20);
            this.txtGiaiMa.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Giải mã";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Bản mã";
            // 
            // txtVGiaiMa
            // 
            this.txtVGiaiMa.Location = new System.Drawing.Point(6, 167);
            this.txtVGiaiMa.Name = "txtVGiaiMa";
            this.txtVGiaiMa.Size = new System.Drawing.Size(373, 20);
            this.txtVGiaiMa.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giải mã";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Bản rõ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Bản mã";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Giải mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCeasar.ResumeLayout(false);
            this.tabCeasar.PerformLayout();
            this.tabVigen.ResumeLayout(false);
            this.tabVigen.PerformLayout();
            this.tab3DS.ResumeLayout(false);
            this.tab3DS.PerformLayout();
            this.tabRSA.ResumeLayout(false);
            this.tabRSA.PerformLayout();
            this.tabHash.ResumeLayout(false);
            this.tabHash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCeasar;
        private System.Windows.Forms.TextBox txtBanMa;
        private System.Windows.Forms.Button btnDeCeasar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCeasar;
        private System.Windows.Forms.TabPage tabVigen;
        private System.Windows.Forms.TextBox txtDoDoi;
        private System.Windows.Forms.Button btnVigenereDecrypt;
        private System.Windows.Forms.Button btnVigenereEncrypt;
        private System.Windows.Forms.TextBox txtVBanMa;
        private System.Windows.Forms.TextBox txtVInput;
        private System.Windows.Forms.TextBox txtVKey;
        private System.Windows.Forms.TabPage tab3DS;
        private System.Windows.Forms.Button btnDecrypt3DS;
        private System.Windows.Forms.Button btnEncrypt3DS;
        private System.Windows.Forms.TextBox txt3DSGiaiMa;
        private System.Windows.Forms.TextBox txt3DSInput;
        private System.Windows.Forms.TextBox txt3DSKey;
        private System.Windows.Forms.TabPage tabRSA;
        private System.Windows.Forms.Button btnDecryptRSA;
        private System.Windows.Forms.Button btnEncryptRSA;
        private System.Windows.Forms.TextBox txtRSADecrypt;
        private System.Windows.Forms.TextBox txtRSAInput;
        private System.Windows.Forms.TextBox txtRSAEncrypt;
        private System.Windows.Forms.TabPage tabHash;
        private System.Windows.Forms.Button btnSHA2;
        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.TextBox txtHashResult;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt3DSBanMa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGiaiMa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVGiaiMa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

