namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.wishList = new System.Windows.Forms.ListBox();
            this.fillBttn = new System.Windows.Forms.Button();
            this.sortBttn = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.countBttn = new System.Windows.Forms.Button();
            this.closeBttn = new System.Windows.Forms.Button();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wish List";
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(46, 343);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(54, 13);
            this.selection.TabIndex = 1;
            this.selection.Text = "Selection:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(46, 390);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(38, 13);
            this.count.TabIndex = 2;
            this.count.Text = "Count:";
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(49, 81);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(251, 225);
            this.wishList.TabIndex = 3;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // fillBttn
            // 
            this.fillBttn.Location = new System.Drawing.Point(352, 81);
            this.fillBttn.Name = "fillBttn";
            this.fillBttn.Size = new System.Drawing.Size(75, 23);
            this.fillBttn.TabIndex = 4;
            this.fillBttn.Text = "Fill";
            this.fillBttn.UseVisualStyleBackColor = true;
            this.fillBttn.Click += new System.EventHandler(this.fillBttn_Click);
            // 
            // sortBttn
            // 
            this.sortBttn.Location = new System.Drawing.Point(352, 127);
            this.sortBttn.Name = "sortBttn";
            this.sortBttn.Size = new System.Drawing.Size(75, 23);
            this.sortBttn.TabIndex = 5;
            this.sortBttn.Text = "Sort";
            this.sortBttn.UseVisualStyleBackColor = true;
            this.sortBttn.Click += new System.EventHandler(this.sortBttn_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Location = new System.Drawing.Point(352, 177);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(75, 23);
            this.clearBttn.TabIndex = 6;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // countBttn
            // 
            this.countBttn.Location = new System.Drawing.Point(352, 231);
            this.countBttn.Name = "countBttn";
            this.countBttn.Size = new System.Drawing.Size(75, 23);
            this.countBttn.TabIndex = 7;
            this.countBttn.Text = "Count";
            this.countBttn.UseVisualStyleBackColor = true;
            this.countBttn.Click += new System.EventHandler(this.countBttn_Click);
            // 
            // closeBttn
            // 
            this.closeBttn.Location = new System.Drawing.Point(352, 283);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(75, 23);
            this.closeBttn.TabIndex = 8;
            this.closeBttn.Text = "Close";
            this.closeBttn.UseVisualStyleBackColor = true;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(110, 340);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 9;
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(110, 387);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(100, 20);
            this.countOutputBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 454);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.closeBttn);
            this.Controls.Add(this.countBttn);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.sortBttn);
            this.Controls.Add(this.fillBttn);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.count);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Button fillBttn;
        private System.Windows.Forms.Button sortBttn;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.Button countBttn;
        private System.Windows.Forms.Button closeBttn;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox countOutputBox;
    }
}

