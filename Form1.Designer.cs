namespace WindowAdjuster
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WindowsWidthLabel = new System.Windows.Forms.Label();
            this.WindowHeightLabel = new System.Windows.Forms.Label();
            this.WindowScreenXlabel = new System.Windows.Forms.Label();
            this.WindowScreenYLabel = new System.Windows.Forms.Label();
            this.WindowActivationButton = new System.Windows.Forms.Button();
            this.WindowWidthInput = new System.Windows.Forms.NumericUpDown();
            this.WindowHeightInput = new System.Windows.Forms.NumericUpDown();
            this.WindowScreenXInput = new System.Windows.Forms.NumericUpDown();
            this.WindowScreenYInput = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.WindowApplicationList = new System.Windows.Forms.ListBox();
            this.WindowReloadApplicationsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowHeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowScreenXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowScreenYInput)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel2.Controls.Add(this.WindowsWidthLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WindowHeightLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.WindowScreenXlabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.WindowScreenYLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.WindowActivationButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.WindowWidthInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.WindowHeightInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.WindowScreenXInput, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.WindowScreenYInput, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(391, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 420);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // WindowsWidthLabel
            // 
            this.WindowsWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowsWidthLabel.AutoSize = true;
            this.WindowsWidthLabel.Location = new System.Drawing.Point(3, 0);
            this.WindowsWidthLabel.Name = "WindowsWidthLabel";
            this.WindowsWidthLabel.Size = new System.Drawing.Size(84, 84);
            this.WindowsWidthLabel.TabIndex = 0;
            this.WindowsWidthLabel.Text = "Width";
            this.WindowsWidthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WindowHeightLabel
            // 
            this.WindowHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowHeightLabel.AutoSize = true;
            this.WindowHeightLabel.Location = new System.Drawing.Point(3, 84);
            this.WindowHeightLabel.Name = "WindowHeightLabel";
            this.WindowHeightLabel.Size = new System.Drawing.Size(84, 84);
            this.WindowHeightLabel.TabIndex = 1;
            this.WindowHeightLabel.Text = "Height";
            this.WindowHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WindowScreenXlabel
            // 
            this.WindowScreenXlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowScreenXlabel.AutoSize = true;
            this.WindowScreenXlabel.Location = new System.Drawing.Point(3, 168);
            this.WindowScreenXlabel.Name = "WindowScreenXlabel";
            this.WindowScreenXlabel.Size = new System.Drawing.Size(84, 84);
            this.WindowScreenXlabel.TabIndex = 2;
            this.WindowScreenXlabel.Text = "screen x";
            this.WindowScreenXlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WindowScreenYLabel
            // 
            this.WindowScreenYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowScreenYLabel.AutoSize = true;
            this.WindowScreenYLabel.Location = new System.Drawing.Point(3, 252);
            this.WindowScreenYLabel.Name = "WindowScreenYLabel";
            this.WindowScreenYLabel.Size = new System.Drawing.Size(84, 84);
            this.WindowScreenYLabel.TabIndex = 3;
            this.WindowScreenYLabel.Text = "screen y";
            this.WindowScreenYLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WindowActivationButton
            // 
            this.WindowActivationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowActivationButton.Location = new System.Drawing.Point(93, 339);
            this.WindowActivationButton.Name = "WindowActivationButton";
            this.WindowActivationButton.Size = new System.Drawing.Size(286, 78);
            this.WindowActivationButton.TabIndex = 4;
            this.WindowActivationButton.Text = "Automatic Adjust: Disabled";
            this.WindowActivationButton.UseVisualStyleBackColor = true;
            this.WindowActivationButton.Click += new System.EventHandler(this.WindowActivationButton_Click);
            // 
            // WindowWidthInput
            // 
            this.WindowWidthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowWidthInput.Location = new System.Drawing.Point(93, 3);
            this.WindowWidthInput.Maximum = new decimal(new int[] {
            38400,
            0,
            0,
            0});
            this.WindowWidthInput.Minimum = new decimal(new int[] {
            38400,
            0,
            0,
            -2147483648});
            this.WindowWidthInput.Name = "WindowWidthInput";
            this.WindowWidthInput.Size = new System.Drawing.Size(286, 20);
            this.WindowWidthInput.TabIndex = 5;
            this.WindowWidthInput.ValueChanged += new System.EventHandler(this.WindowWidthInput_ValueChanged);
            // 
            // WindowHeightInput
            // 
            this.WindowHeightInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowHeightInput.Location = new System.Drawing.Point(93, 87);
            this.WindowHeightInput.Maximum = new decimal(new int[] {
            38400,
            0,
            0,
            0});
            this.WindowHeightInput.Minimum = new decimal(new int[] {
            38400,
            0,
            0,
            -2147483648});
            this.WindowHeightInput.Name = "WindowHeightInput";
            this.WindowHeightInput.Size = new System.Drawing.Size(286, 20);
            this.WindowHeightInput.TabIndex = 6;
            this.WindowHeightInput.ValueChanged += new System.EventHandler(this.WindowHeightInput_ValueChanged);
            // 
            // WindowScreenXInput
            // 
            this.WindowScreenXInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowScreenXInput.Location = new System.Drawing.Point(93, 171);
            this.WindowScreenXInput.Maximum = new decimal(new int[] {
            38400,
            0,
            0,
            0});
            this.WindowScreenXInput.Minimum = new decimal(new int[] {
            38400,
            0,
            0,
            -2147483648});
            this.WindowScreenXInput.Name = "WindowScreenXInput";
            this.WindowScreenXInput.Size = new System.Drawing.Size(286, 20);
            this.WindowScreenXInput.TabIndex = 7;
            this.WindowScreenXInput.ValueChanged += new System.EventHandler(this.WindowScreenXInput_ValueChanged);
            // 
            // WindowScreenYInput
            // 
            this.WindowScreenYInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowScreenYInput.Location = new System.Drawing.Point(93, 255);
            this.WindowScreenYInput.Maximum = new decimal(new int[] {
            38400,
            0,
            0,
            0});
            this.WindowScreenYInput.Minimum = new decimal(new int[] {
            38400,
            0,
            0,
            -2147483648});
            this.WindowScreenYInput.Name = "WindowScreenYInput";
            this.WindowScreenYInput.Size = new System.Drawing.Size(286, 20);
            this.WindowScreenYInput.TabIndex = 8;
            this.WindowScreenYInput.ValueChanged += new System.EventHandler(this.WindowScreenYInput_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.WindowApplicationList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.WindowReloadApplicationsButton, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 420);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // WindowApplicationList
            // 
            this.WindowApplicationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowApplicationList.FormattingEnabled = true;
            this.WindowApplicationList.Location = new System.Drawing.Point(3, 3);
            this.WindowApplicationList.Name = "WindowApplicationList";
            this.WindowApplicationList.Size = new System.Drawing.Size(376, 329);
            this.WindowApplicationList.TabIndex = 1;
            this.WindowApplicationList.SelectedIndexChanged += new System.EventHandler(this.WindowApplicationList_SelectedIndexChanged);
            // 
            // WindowReloadApplicationsButton
            // 
            this.WindowReloadApplicationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowReloadApplicationsButton.Location = new System.Drawing.Point(3, 339);
            this.WindowReloadApplicationsButton.Name = "WindowReloadApplicationsButton";
            this.WindowReloadApplicationsButton.Size = new System.Drawing.Size(376, 78);
            this.WindowReloadApplicationsButton.TabIndex = 2;
            this.WindowReloadApplicationsButton.Text = "Reload Application list";
            this.WindowReloadApplicationsButton.UseVisualStyleBackColor = true;
            this.WindowReloadApplicationsButton.Click += new System.EventHandler(this.WindowReloadApplicationsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Window Adjuster";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowHeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowScreenXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowScreenYInput)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox WindowApplicationList;
        private System.Windows.Forms.Label WindowsWidthLabel;
        private System.Windows.Forms.Label WindowHeightLabel;
        private System.Windows.Forms.Label WindowScreenXlabel;
        private System.Windows.Forms.Label WindowScreenYLabel;
        private System.Windows.Forms.Button WindowActivationButton;
        private System.Windows.Forms.NumericUpDown WindowWidthInput;
        private System.Windows.Forms.NumericUpDown WindowHeightInput;
        private System.Windows.Forms.NumericUpDown WindowScreenXInput;
        private System.Windows.Forms.NumericUpDown WindowScreenYInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button WindowReloadApplicationsButton;
    }
}

