namespace Lecture_2_Multithreading
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
            btnSync = new Button();
            rtbDisplay = new RichTextBox();
            btnAsync = new Button();
            btnMultipleAsync = new Button();
            txtNumberOfLoops = new TextBox();
            btnReturnValue = new Button();
            Callback = new Button();
            Clear = new Button();
            btnAddNumbers = new Button();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(94, 80);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(208, 43);
            btnSync.TabIndex = 0;
            btnSync.Text = "Run Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(362, 59);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.Size = new Size(739, 525);
            rtbDisplay.TabIndex = 1;
            rtbDisplay.Text = "";
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(94, 176);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(208, 49);
            btnAsync.TabIndex = 2;
            btnAsync.Text = "Run Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // btnMultipleAsync
            // 
            btnMultipleAsync.Location = new Point(44, 281);
            btnMultipleAsync.Name = "btnMultipleAsync";
            btnMultipleAsync.Size = new Size(188, 49);
            btnMultipleAsync.TabIndex = 3;
            btnMultipleAsync.Text = "Run Multiple";
            btnMultipleAsync.UseVisualStyleBackColor = true;
            btnMultipleAsync.Click += btnMultipleAsync_Click;
            // 
            // txtNumberOfLoops
            // 
            txtNumberOfLoops.Location = new Point(249, 290);
            txtNumberOfLoops.Name = "txtNumberOfLoops";
            txtNumberOfLoops.Size = new Size(68, 31);
            txtNumberOfLoops.TabIndex = 4;
            // 
            // btnReturnValue
            // 
            btnReturnValue.Location = new Point(1137, 68);
            btnReturnValue.Name = "btnReturnValue";
            btnReturnValue.Size = new Size(194, 36);
            btnReturnValue.TabIndex = 5;
            btnReturnValue.Text = "Returning Values";
            btnReturnValue.UseVisualStyleBackColor = true;
            btnReturnValue.Click += btnReturnValue_Click;
            // 
            // Callback
            // 
            Callback.Location = new Point(1137, 140);
            Callback.Name = "Callback";
            Callback.Size = new Size(194, 34);
            Callback.TabIndex = 6;
            Callback.Text = "btnCallback";
            Callback.UseVisualStyleBackColor = true;
            Callback.Click += Callback_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(619, 602);
            Clear.Name = "Clear";
            Clear.Size = new Size(221, 34);
            Clear.TabIndex = 7;
            Clear.Text = "btnClear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // btnAddNumbers
            // 
            btnAddNumbers.Location = new Point(1137, 207);
            btnAddNumbers.Name = "btnAddNumbers";
            btnAddNumbers.Size = new Size(194, 34);
            btnAddNumbers.TabIndex = 8;
            btnAddNumbers.Text = "AddNumbers";
            btnAddNumbers.UseVisualStyleBackColor = true;
            btnAddNumbers.Click += btnAddNumbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 666);
            Controls.Add(btnAddNumbers);
            Controls.Add(Clear);
            Controls.Add(Callback);
            Controls.Add(btnReturnValue);
            Controls.Add(txtNumberOfLoops);
            Controls.Add(btnMultipleAsync);
            Controls.Add(btnAsync);
            Controls.Add(rtbDisplay);
            Controls.Add(btnSync);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private RichTextBox rtbDisplay;
        private Button btnAsync;
        private Button btnMultipleAsync;
        private TextBox txtNumberOfLoops;
        private Button btnReturnValue;
        private Button Callback;
        private Button Clear;
        private Button btnAddNumbers;
    }
}