namespace ComputerSimGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._mainTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._entryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._accumulatorTextBox = new System.Windows.Forms.TextBox();
            this._programCounterTextBox = new System.Windows.Forms.TextBox();
            this._opcodeTextBox = new System.Windows.Forms.TextBox();
            this._operandTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._loadProgramFromTextboxButton = new System.Windows.Forms.Button();
            this._loadFromFileButton = new System.Windows.Forms.Button();
            this._runButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23711F));
            this.tableLayoutPanel1.Controls.Add(this._mainTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _mainTextBox
            // 
            this._mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTextBox.Location = new System.Drawing.Point(3, 3);
            this._mainTextBox.Multiline = true;
            this._mainTextBox.Name = "_mainTextBox";
            this.tableLayoutPanel1.SetRowSpan(this._mainTextBox, 2);
            this._mainTextBox.Size = new System.Drawing.Size(262, 455);
            this._mainTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._entryTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this._accumulatorTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this._programCounterTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._opcodeTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this._operandTextBox, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(271, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(522, 184);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Area:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _entryTextBox
            // 
            this._entryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._entryTextBox.Location = new System.Drawing.Point(264, 3);
            this._entryTextBox.Name = "_entryTextBox";
            this._entryTextBox.Size = new System.Drawing.Size(255, 20);
            this._entryTextBox.TabIndex = 1;
            this._entryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accumulator:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Program Counter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "OpCode:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Operand:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _accumulatorTextBox
            // 
            this._accumulatorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._accumulatorTextBox.Location = new System.Drawing.Point(264, 85);
            this._accumulatorTextBox.Name = "_accumulatorTextBox";
            this._accumulatorTextBox.Size = new System.Drawing.Size(255, 20);
            this._accumulatorTextBox.TabIndex = 6;
            this._accumulatorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _programCounterTextBox
            // 
            this._programCounterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._programCounterTextBox.Location = new System.Drawing.Point(264, 106);
            this._programCounterTextBox.Name = "_programCounterTextBox";
            this._programCounterTextBox.Size = new System.Drawing.Size(255, 20);
            this._programCounterTextBox.TabIndex = 7;
            this._programCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _opcodeTextBox
            // 
            this._opcodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._opcodeTextBox.Location = new System.Drawing.Point(264, 132);
            this._opcodeTextBox.Name = "_opcodeTextBox";
            this._opcodeTextBox.Size = new System.Drawing.Size(255, 20);
            this._opcodeTextBox.TabIndex = 8;
            this._opcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _operandTextBox
            // 
            this._operandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._operandTextBox.Location = new System.Drawing.Point(264, 156);
            this._operandTextBox.Name = "_operandTextBox";
            this._operandTextBox.Size = new System.Drawing.Size(255, 20);
            this._operandTextBox.TabIndex = 9;
            this._operandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3382F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.6618F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.Controls.Add(this._loadProgramFromTextboxButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._loadFromFileButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._runButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(271, 401);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(522, 57);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _loadProgramFromTextboxButton
            // 
            this._loadProgramFromTextboxButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loadProgramFromTextboxButton.Location = new System.Drawing.Point(3, 3);
            this._loadProgramFromTextboxButton.Name = "_loadProgramFromTextboxButton";
            this._loadProgramFromTextboxButton.Size = new System.Drawing.Size(210, 51);
            this._loadProgramFromTextboxButton.TabIndex = 0;
            this._loadProgramFromTextboxButton.Text = "Load From Textbox";
            this._loadProgramFromTextboxButton.UseVisualStyleBackColor = true;
            this._loadProgramFromTextboxButton.Click += new System.EventHandler(this.LoadFromTextBoxButtonClick);
            // 
            // _loadFromFileButton
            // 
            this._loadFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loadFromFileButton.Location = new System.Drawing.Point(219, 3);
            this._loadFromFileButton.Name = "_loadFromFileButton";
            this._loadFromFileButton.Size = new System.Drawing.Size(198, 51);
            this._loadFromFileButton.TabIndex = 1;
            this._loadFromFileButton.Text = "Load From File";
            this._loadFromFileButton.UseVisualStyleBackColor = true;
            this._loadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButtonClick);
            // 
            // _runButton
            // 
            this._runButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._runButton.Location = new System.Drawing.Point(423, 3);
            this._runButton.Name = "_runButton";
            this._runButton.Size = new System.Drawing.Size(96, 51);
            this._runButton.TabIndex = 2;
            this._runButton.Text = "Run";
            this._runButton.UseVisualStyleBackColor = true;
            this._runButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Simulation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _mainTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _entryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _accumulatorTextBox;
        private System.Windows.Forms.TextBox _programCounterTextBox;
        private System.Windows.Forms.TextBox _opcodeTextBox;
        private System.Windows.Forms.TextBox _operandTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button _loadProgramFromTextboxButton;
        private System.Windows.Forms.Button _loadFromFileButton;
        private System.Windows.Forms.Button _runButton;
    }
}

