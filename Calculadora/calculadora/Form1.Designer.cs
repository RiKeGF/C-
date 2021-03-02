
namespace calculadora
{
   partial class Form1
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.panel2 = new System.Windows.Forms.Panel();
         this.textBoxNumber2 = new System.Windows.Forms.TextBox();
         this.textBoxNumber1 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.panel3 = new System.Windows.Forms.Panel();
         this.button9 = new System.Windows.Forms.Button();
         this.button6 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button8 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.buttonPoint = new System.Windows.Forms.Button();
         this.button00 = new System.Windows.Forms.Button();
         this.button0 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button7 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.panel4 = new System.Windows.Forms.Panel();
         this.buttonClearField = new System.Windows.Forms.Button();
         this.buttonClear = new System.Windows.Forms.Button();
         this.buttonPlus = new System.Windows.Forms.Button();
         this.buttonMult = new System.Windows.Forms.Button();
         this.buttonMin = new System.Windows.Forms.Button();
         this.buttonDiv = new System.Windows.Forms.Button();
         this.labelTitleResult = new System.Windows.Forms.Label();
         this.labelResult = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.labelLastOperation = new System.Windows.Forms.Label();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel4.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.textBoxNumber2);
         this.panel2.Controls.Add(this.textBoxNumber1);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.label1);
         this.panel2.Location = new System.Drawing.Point(12, 58);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(502, 64);
         this.panel2.TabIndex = 4;
         // 
         // textBoxNumber2
         // 
         this.textBoxNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.textBoxNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxNumber2.ForeColor = System.Drawing.SystemColors.Control;
         this.textBoxNumber2.Location = new System.Drawing.Point(258, 23);
         this.textBoxNumber2.Name = "textBoxNumber2";
         this.textBoxNumber2.Size = new System.Drawing.Size(226, 36);
         this.textBoxNumber2.TabIndex = 0;
         this.textBoxNumber2.Click += new System.EventHandler(this.textBoxNumber2_Click);
         // 
         // textBoxNumber1
         // 
         this.textBoxNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.textBoxNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxNumber1.ForeColor = System.Drawing.SystemColors.Control;
         this.textBoxNumber1.Location = new System.Drawing.Point(14, 23);
         this.textBoxNumber1.Name = "textBoxNumber1";
         this.textBoxNumber1.Size = new System.Drawing.Size(226, 36);
         this.textBoxNumber1.TabIndex = 0;
         this.textBoxNumber1.Click += new System.EventHandler(this.textBoxNumber1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.SystemColors.Control;
         this.label2.Location = new System.Drawing.Point(310, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(138, 20);
         this.label2.TabIndex = 7;
         this.label2.Text = "Segundo Número";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.SystemColors.Control;
         this.label1.Location = new System.Drawing.Point(51, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(136, 20);
         this.label1.TabIndex = 7;
         this.label1.Text = "Primeiro Número";
         // 
         // panel3
         // 
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel3.Controls.Add(this.button9);
         this.panel3.Controls.Add(this.button6);
         this.panel3.Controls.Add(this.button3);
         this.panel3.Controls.Add(this.button8);
         this.panel3.Controls.Add(this.button5);
         this.panel3.Controls.Add(this.buttonPoint);
         this.panel3.Controls.Add(this.button00);
         this.panel3.Controls.Add(this.button0);
         this.panel3.Controls.Add(this.button2);
         this.panel3.Controls.Add(this.button7);
         this.panel3.Controls.Add(this.button4);
         this.panel3.Controls.Add(this.button1);
         this.panel3.Location = new System.Drawing.Point(12, 128);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(241, 301);
         this.panel3.TabIndex = 5;
         // 
         // button9
         // 
         this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button9.ForeColor = System.Drawing.SystemColors.Control;
         this.button9.Location = new System.Drawing.Point(156, 12);
         this.button9.Name = "button9";
         this.button9.Size = new System.Drawing.Size(65, 65);
         this.button9.TabIndex = 0;
         this.button9.Text = "9";
         this.button9.UseVisualStyleBackColor = false;
         this.button9.Click += new System.EventHandler(this.button9_Click);
         // 
         // button6
         // 
         this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button6.ForeColor = System.Drawing.SystemColors.Control;
         this.button6.Location = new System.Drawing.Point(156, 83);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(65, 65);
         this.button6.TabIndex = 0;
         this.button6.Text = "6";
         this.button6.UseVisualStyleBackColor = false;
         this.button6.Click += new System.EventHandler(this.button6_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button3.ForeColor = System.Drawing.SystemColors.Control;
         this.button3.Location = new System.Drawing.Point(156, 154);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(65, 65);
         this.button3.TabIndex = 0;
         this.button3.Text = "3";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button8
         // 
         this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button8.ForeColor = System.Drawing.SystemColors.Control;
         this.button8.Location = new System.Drawing.Point(85, 12);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(65, 65);
         this.button8.TabIndex = 0;
         this.button8.Text = "8";
         this.button8.UseVisualStyleBackColor = false;
         this.button8.Click += new System.EventHandler(this.button8_Click);
         // 
         // button5
         // 
         this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button5.ForeColor = System.Drawing.SystemColors.Control;
         this.button5.Location = new System.Drawing.Point(85, 83);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(65, 65);
         this.button5.TabIndex = 0;
         this.button5.Text = "5";
         this.button5.UseVisualStyleBackColor = false;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // buttonPoint
         // 
         this.buttonPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonPoint.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonPoint.Location = new System.Drawing.Point(14, 225);
         this.buttonPoint.Name = "buttonPoint";
         this.buttonPoint.Size = new System.Drawing.Size(65, 65);
         this.buttonPoint.TabIndex = 0;
         this.buttonPoint.Text = ",";
         this.buttonPoint.UseVisualStyleBackColor = false;
         this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
         // 
         // button00
         // 
         this.button00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button00.ForeColor = System.Drawing.SystemColors.Control;
         this.button00.Location = new System.Drawing.Point(156, 225);
         this.button00.Name = "button00";
         this.button00.Size = new System.Drawing.Size(65, 65);
         this.button00.TabIndex = 0;
         this.button00.Text = "00";
         this.button00.UseVisualStyleBackColor = false;
         this.button00.Click += new System.EventHandler(this.button00_Click);
         // 
         // button0
         // 
         this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button0.ForeColor = System.Drawing.SystemColors.Control;
         this.button0.Location = new System.Drawing.Point(85, 225);
         this.button0.Name = "button0";
         this.button0.Size = new System.Drawing.Size(65, 65);
         this.button0.TabIndex = 0;
         this.button0.Text = "0";
         this.button0.UseVisualStyleBackColor = false;
         this.button0.Click += new System.EventHandler(this.button0_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.ForeColor = System.Drawing.SystemColors.Control;
         this.button2.Location = new System.Drawing.Point(85, 154);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(65, 65);
         this.button2.TabIndex = 0;
         this.button2.Text = "2";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button7
         // 
         this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button7.ForeColor = System.Drawing.SystemColors.Control;
         this.button7.Location = new System.Drawing.Point(14, 12);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(65, 65);
         this.button7.TabIndex = 0;
         this.button7.Text = "7";
         this.button7.UseVisualStyleBackColor = false;
         this.button7.Click += new System.EventHandler(this.button7_Click);
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button4.ForeColor = System.Drawing.SystemColors.Control;
         this.button4.Location = new System.Drawing.Point(14, 83);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(65, 65);
         this.button4.TabIndex = 0;
         this.button4.Text = "4";
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.SystemColors.Control;
         this.button1.Location = new System.Drawing.Point(14, 154);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(65, 65);
         this.button1.TabIndex = 0;
         this.button1.Text = "1";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // panel4
         // 
         this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel4.Controls.Add(this.buttonClearField);
         this.panel4.Controls.Add(this.buttonClear);
         this.panel4.Controls.Add(this.buttonPlus);
         this.panel4.Controls.Add(this.buttonMult);
         this.panel4.Controls.Add(this.buttonMin);
         this.panel4.Controls.Add(this.buttonDiv);
         this.panel4.Location = new System.Drawing.Point(271, 192);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(243, 237);
         this.panel4.TabIndex = 6;
         // 
         // buttonClearField
         // 
         this.buttonClearField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonClearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonClearField.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonClearField.Location = new System.Drawing.Point(122, 12);
         this.buttonClearField.Name = "buttonClearField";
         this.buttonClearField.Size = new System.Drawing.Size(100, 65);
         this.buttonClearField.TabIndex = 0;
         this.buttonClearField.Text = "CE";
         this.buttonClearField.UseVisualStyleBackColor = false;
         this.buttonClearField.Click += new System.EventHandler(this.buttonClearField_Click);
         // 
         // buttonClear
         // 
         this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonClear.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonClear.Location = new System.Drawing.Point(16, 12);
         this.buttonClear.Name = "buttonClear";
         this.buttonClear.Size = new System.Drawing.Size(100, 65);
         this.buttonClear.TabIndex = 0;
         this.buttonClear.Text = "C";
         this.buttonClear.UseVisualStyleBackColor = false;
         this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
         // 
         // buttonPlus
         // 
         this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonPlus.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonPlus.Location = new System.Drawing.Point(16, 83);
         this.buttonPlus.Name = "buttonPlus";
         this.buttonPlus.Size = new System.Drawing.Size(100, 65);
         this.buttonPlus.TabIndex = 0;
         this.buttonPlus.Text = "+";
         this.buttonPlus.UseVisualStyleBackColor = false;
         this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
         // 
         // buttonMult
         // 
         this.buttonMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonMult.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonMult.Location = new System.Drawing.Point(123, 83);
         this.buttonMult.Name = "buttonMult";
         this.buttonMult.Size = new System.Drawing.Size(100, 65);
         this.buttonMult.TabIndex = 0;
         this.buttonMult.Text = "*";
         this.buttonMult.UseVisualStyleBackColor = false;
         this.buttonMult.Click += new System.EventHandler(this.buttonMultiply_Click);
         // 
         // buttonMin
         // 
         this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonMin.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonMin.Location = new System.Drawing.Point(16, 154);
         this.buttonMin.Name = "buttonMin";
         this.buttonMin.Size = new System.Drawing.Size(100, 65);
         this.buttonMin.TabIndex = 0;
         this.buttonMin.Text = "-";
         this.buttonMin.UseVisualStyleBackColor = false;
         this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
         // 
         // buttonDiv
         // 
         this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonDiv.ForeColor = System.Drawing.SystemColors.Control;
         this.buttonDiv.Location = new System.Drawing.Point(122, 154);
         this.buttonDiv.Name = "buttonDiv";
         this.buttonDiv.Size = new System.Drawing.Size(100, 65);
         this.buttonDiv.TabIndex = 0;
         this.buttonDiv.Text = "/";
         this.buttonDiv.UseVisualStyleBackColor = false;
         this.buttonDiv.Click += new System.EventHandler(this.buttonShare_Click);
         // 
         // labelTitleResult
         // 
         this.labelTitleResult.AutoSize = true;
         this.labelTitleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelTitleResult.ForeColor = System.Drawing.SystemColors.Control;
         this.labelTitleResult.Location = new System.Drawing.Point(12, 9);
         this.labelTitleResult.Name = "labelTitleResult";
         this.labelTitleResult.Size = new System.Drawing.Size(134, 29);
         this.labelTitleResult.TabIndex = 7;
         this.labelTitleResult.Text = "Resultado:";
         // 
         // labelResult
         // 
         this.labelResult.AutoSize = true;
         this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelResult.ForeColor = System.Drawing.SystemColors.Control;
         this.labelResult.Location = new System.Drawing.Point(161, 9);
         this.labelResult.MaximumSize = new System.Drawing.Size(300, 0);
         this.labelResult.Name = "labelResult";
         this.labelResult.Size = new System.Drawing.Size(0, 29);
         this.labelResult.TabIndex = 7;
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.labelLastOperation);
         this.panel1.Location = new System.Drawing.Point(271, 128);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(243, 58);
         this.panel1.TabIndex = 8;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.SystemColors.Control;
         this.label3.Location = new System.Drawing.Point(51, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(135, 20);
         this.label3.TabIndex = 0;
         this.label3.Text = "Ultima Operação";
         // 
         // labelLastOperation
         // 
         this.labelLastOperation.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelLastOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelLastOperation.ForeColor = System.Drawing.SystemColors.Control;
         this.labelLastOperation.Location = new System.Drawing.Point(0, 0);
         this.labelLastOperation.Name = "labelLastOperation";
         this.labelLastOperation.Size = new System.Drawing.Size(241, 56);
         this.labelLastOperation.TabIndex = 0;
         this.labelLastOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.ClientSize = new System.Drawing.Size(526, 447);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelResult);
         this.Controls.Add(this.labelTitleResult);
         this.Controls.Add(this.panel4);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "Form1";
         this.Text = "Calculadora";
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel4.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.TextBox textBoxNumber1;
      private System.Windows.Forms.Button button9;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Button buttonPoint;
      private System.Windows.Forms.Button button00;
      private System.Windows.Forms.Button button0;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button buttonClearField;
      private System.Windows.Forms.Button buttonClear;
      private System.Windows.Forms.Button buttonPlus;
      private System.Windows.Forms.Button buttonMult;
      private System.Windows.Forms.Button buttonMin;
      private System.Windows.Forms.Button buttonDiv;
      private System.Windows.Forms.Label labelTitleResult;
      private System.Windows.Forms.Label labelResult;
      private System.Windows.Forms.TextBox textBoxNumber2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label labelLastOperation;
      private System.Windows.Forms.Label label3;
   }
}

