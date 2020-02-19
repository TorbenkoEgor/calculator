namespace View
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
            this.components = new System.ComponentModel.Container();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.stdDevButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressBox = new System.Windows.Forms.TextBox();
            this.repeatButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.FormattingEnabled = true;
            this.historyBox.Location = new System.Drawing.Point(12, 12);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(536, 199);
            this.historyBox.TabIndex = 0;
            this.historyBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 217);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(536, 20);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(21, 325);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(102, 325);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 3;
            this.squareButton.Text = "^^2";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(183, 325);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 4;
            this.logButton.Text = "log[a]";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Location = new System.Drawing.Point(183, 354);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(75, 23);
            this.factorialButton.TabIndex = 7;
            this.factorialButton.Text = "x!";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(102, 354);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(75, 23);
            this.powerButton.TabIndex = 6;
            this.powerButton.Text = "^^y";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(21, 354);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 23);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // meanButton
            // 
            this.meanButton.Location = new System.Drawing.Point(183, 383);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(75, 23);
            this.meanButton.TabIndex = 10;
            this.meanButton.Text = "mean";
            this.meanButton.UseVisualStyleBackColor = true;
            this.meanButton.Click += new System.EventHandler(this.MeanButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(102, 383);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 23);
            this.sqrtButton.TabIndex = 9;
            this.sqrtButton.Text = "sqrt";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(21, 383);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // stdDevButton
            // 
            this.stdDevButton.Location = new System.Drawing.Point(183, 412);
            this.stdDevButton.Name = "stdDevButton";
            this.stdDevButton.Size = new System.Drawing.Size(75, 23);
            this.stdDevButton.TabIndex = 13;
            this.stdDevButton.Text = "StdDev";
            this.stdDevButton.UseVisualStyleBackColor = true;
            this.stdDevButton.Click += new System.EventHandler(this.StdDevButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Location = new System.Drawing.Point(102, 412);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(75, 23);
            this.rootButton.TabIndex = 12;
            this.rootButton.Text = "n root";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.RootButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(21, 412);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 11;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(385, 325);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 16;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(466, 325);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(466, 354);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 243);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(536, 23);
            this.progressBar.TabIndex = 17;
            this.progressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // progressBox
            // 
            this.progressBox.Location = new System.Drawing.Point(12, 272);
            this.progressBox.Multiline = true;
            this.progressBox.Name = "progressBox";
            this.progressBox.ReadOnly = true;
            this.progressBox.Size = new System.Drawing.Size(536, 47);
            this.progressBox.TabIndex = 19;
            this.progressBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // repeatButton
            // 
            this.repeatButton.Location = new System.Drawing.Point(304, 325);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(75, 23);
            this.repeatButton.TabIndex = 22;
            this.repeatButton.Text = "Repeat";
            this.repeatButton.UseVisualStyleBackColor = true;
            this.repeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(304, 354);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 21;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(304, 383);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(385, 354);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(75, 23);
            this.cloneButton.TabIndex = 23;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stdDevButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.meanButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.historyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button stdDevButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox progressBox;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

