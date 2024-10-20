using System.Windows.Forms;

namespace Lab1_StepanovDmitriy_6411
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtProbabilities = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompression = new System.Windows.Forms.TextBox();
            this.txtEncodedSize = new System.Windows.Forms.TextBox();
            this.txtOriginalSize = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtProbabilities2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompression2 = new System.Windows.Forms.TextBox();
            this.txtEncodedSize2 = new System.Windows.Forms.TextBox();
            this.txtOriginalSize2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnHuffmanEncode = new System.Windows.Forms.Button();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFIO2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCompression3 = new System.Windows.Forms.TextBox();
            this.txtEncodedSize3 = new System.Windows.Forms.TextBox();
            this.txtOriginalSize3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAlgEncode = new System.Windows.Forms.Button();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFIO3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(557, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtProbabilities);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCompression);
            this.tabPage1.Controls.Add(this.txtEncodedSize);
            this.tabPage1.Controls.Add(this.txtOriginalSize);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFIO);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шеннона-Фано";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtProbabilities
            // 
            this.txtProbabilities.Location = new System.Drawing.Point(8, 172);
            this.txtProbabilities.Multiline = true;
            this.txtProbabilities.Name = "txtProbabilities";
            this.txtProbabilities.ReadOnly = true;
            this.txtProbabilities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProbabilities.Size = new System.Drawing.Size(446, 151);
            this.txtProbabilities.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Порядок вероятностей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Объём строки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Объём закодированной строки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сжатие";
            // 
            // txtCompression
            // 
            this.txtCompression.Location = new System.Drawing.Point(545, 301);
            this.txtCompression.Name = "txtCompression";
            this.txtCompression.ReadOnly = true;
            this.txtCompression.Size = new System.Drawing.Size(210, 22);
            this.txtCompression.TabIndex = 10;
            // 
            // txtEncodedSize
            // 
            this.txtEncodedSize.Location = new System.Drawing.Point(545, 236);
            this.txtEncodedSize.Name = "txtEncodedSize";
            this.txtEncodedSize.ReadOnly = true;
            this.txtEncodedSize.Size = new System.Drawing.Size(210, 22);
            this.txtEncodedSize.TabIndex = 9;
            // 
            // txtOriginalSize
            // 
            this.txtOriginalSize.Location = new System.Drawing.Point(545, 173);
            this.txtOriginalSize.Name = "txtOriginalSize";
            this.txtOriginalSize.ReadOnly = true;
            this.txtOriginalSize.Size = new System.Drawing.Size(210, 22);
            this.txtOriginalSize.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(749, 29);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(164, 23);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Закодировать";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(8, 86);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(718, 22);
            this.txtCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(8, 31);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(718, 22);
            this.txtFIO.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtProbabilities2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtCompression2);
            this.tabPage2.Controls.Add(this.txtEncodedSize2);
            this.tabPage2.Controls.Add(this.txtOriginalSize2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btnHuffmanEncode);
            this.tabPage2.Controls.Add(this.txtCode2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtFIO2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Хаффмана";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProbabilities2
            // 
            this.txtProbabilities2.Location = new System.Drawing.Point(8, 172);
            this.txtProbabilities2.Multiline = true;
            this.txtProbabilities2.Name = "txtProbabilities2";
            this.txtProbabilities2.ReadOnly = true;
            this.txtProbabilities2.Size = new System.Drawing.Size(446, 151);
            this.txtProbabilities2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Порядок вероятностей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Объём строки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Объём закодированной строки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Сжатие";
            // 
            // txtCompression2
            // 
            this.txtCompression2.Location = new System.Drawing.Point(545, 301);
            this.txtCompression2.Name = "txtCompression2";
            this.txtCompression2.ReadOnly = true;
            this.txtCompression2.Size = new System.Drawing.Size(210, 22);
            this.txtCompression2.TabIndex = 24;
            // 
            // txtEncodedSize2
            // 
            this.txtEncodedSize2.Location = new System.Drawing.Point(545, 236);
            this.txtEncodedSize2.Name = "txtEncodedSize2";
            this.txtEncodedSize2.ReadOnly = true;
            this.txtEncodedSize2.Size = new System.Drawing.Size(210, 22);
            this.txtEncodedSize2.TabIndex = 23;
            // 
            // txtOriginalSize2
            // 
            this.txtOriginalSize2.Location = new System.Drawing.Point(545, 173);
            this.txtOriginalSize2.Name = "txtOriginalSize2";
            this.txtOriginalSize2.ReadOnly = true;
            this.txtOriginalSize2.Size = new System.Drawing.Size(210, 22);
            this.txtOriginalSize2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(749, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Декодировать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnHuffmanEncode
            // 
            this.btnHuffmanEncode.Location = new System.Drawing.Point(749, 29);
            this.btnHuffmanEncode.Name = "btnHuffmanEncode";
            this.btnHuffmanEncode.Size = new System.Drawing.Size(164, 23);
            this.btnHuffmanEncode.TabIndex = 20;
            this.btnHuffmanEncode.Text = "Закодировать";
            this.btnHuffmanEncode.UseVisualStyleBackColor = true;
            this.btnHuffmanEncode.Click += new System.EventHandler(this.btnHuffmanEncode_Click);
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(8, 86);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(718, 22);
            this.txtCode2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Код";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "ФИО";
            // 
            // txtFIO2
            // 
            this.txtFIO2.Location = new System.Drawing.Point(8, 31);
            this.txtFIO2.Name = "txtFIO2";
            this.txtFIO2.Size = new System.Drawing.Size(718, 22);
            this.txtFIO2.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtCompression3);
            this.tabPage3.Controls.Add(this.txtEncodedSize3);
            this.tabPage3.Controls.Add(this.txtOriginalSize3);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.btnAlgEncode);
            this.tabPage3.Controls.Add(this.txtCode3);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtFIO3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(930, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Арифметический";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Объём строки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(542, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Объём закодированной строки";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(545, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Сжатие";
            // 
            // txtCompression3
            // 
            this.txtCompression3.Location = new System.Drawing.Point(545, 301);
            this.txtCompression3.Name = "txtCompression3";
            this.txtCompression3.ReadOnly = true;
            this.txtCompression3.Size = new System.Drawing.Size(210, 22);
            this.txtCompression3.TabIndex = 24;
            // 
            // txtEncodedSize3
            // 
            this.txtEncodedSize3.Location = new System.Drawing.Point(545, 236);
            this.txtEncodedSize3.Name = "txtEncodedSize3";
            this.txtEncodedSize3.ReadOnly = true;
            this.txtEncodedSize3.Size = new System.Drawing.Size(210, 22);
            this.txtEncodedSize3.TabIndex = 23;
            // 
            // txtOriginalSize3
            // 
            this.txtOriginalSize3.Location = new System.Drawing.Point(545, 173);
            this.txtOriginalSize3.Name = "txtOriginalSize3";
            this.txtOriginalSize3.ReadOnly = true;
            this.txtOriginalSize3.Size = new System.Drawing.Size(210, 22);
            this.txtOriginalSize3.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(749, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Декодировать";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAlgEncode
            // 
            this.btnAlgEncode.Location = new System.Drawing.Point(749, 29);
            this.btnAlgEncode.Name = "btnAlgEncode";
            this.btnAlgEncode.Size = new System.Drawing.Size(164, 23);
            this.btnAlgEncode.TabIndex = 20;
            this.btnAlgEncode.Text = "Закодировать";
            this.btnAlgEncode.UseVisualStyleBackColor = true;
            this.btnAlgEncode.Click += new System.EventHandler(this.btnAlgEncode_Click);
            // 
            // txtCode3
            // 
            this.txtCode3.Location = new System.Drawing.Point(8, 86);
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(718, 22);
            this.txtCode3.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(3, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "Код";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(3, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "ФИО";
            // 
            // txtFIO3
            // 
            this.txtFIO3.Location = new System.Drawing.Point(8, 31);
            this.txtFIO3.Name = "txtFIO3";
            this.txtFIO3.Size = new System.Drawing.Size(718, 22);
            this.txtFIO3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompression;
        private System.Windows.Forms.TextBox txtEncodedSize;
        private System.Windows.Forms.TextBox txtOriginalSize;
        private System.Windows.Forms.TextBox txtProbabilities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProbabilities2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCompression2;
        private System.Windows.Forms.TextBox txtEncodedSize2;
        private System.Windows.Forms.TextBox txtOriginalSize2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHuffmanEncode;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFIO2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCompression3;
        private System.Windows.Forms.TextBox txtEncodedSize3;
        private System.Windows.Forms.TextBox txtOriginalSize3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAlgEncode;
        private System.Windows.Forms.TextBox txtCode3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFIO3;
    }
}

