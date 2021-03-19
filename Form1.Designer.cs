namespace Part_7___Lists__Collections_
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
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lblHeros = new System.Windows.Forms.Label();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.lblHero = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.btnAscending = new System.Windows.Forms.Button();
            this.btnDescending = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(87, 78);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(84, 23);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.Location = new System.Drawing.Point(177, 78);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(85, 23);
            this.btnSortNumbers.TabIndex = 1;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(83, 55);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(80, 20);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.Text = "Numbers";
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(87, 108);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(175, 121);
            this.lstNumbers.TabIndex = 3;
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHeroes.Location = new System.Drawing.Point(355, 77);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(80, 24);
            this.btnNewHeroes.TabIndex = 4;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.Location = new System.Drawing.Point(442, 77);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(80, 24);
            this.btnSortHeroes.TabIndex = 5;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lblHeros
            // 
            this.lblHeros.AutoSize = true;
            this.lblHeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeros.Location = new System.Drawing.Point(351, 54);
            this.lblHeros.Name = "lblHeros";
            this.lblHeros.Size = new System.Drawing.Size(67, 20);
            this.lblHeros.TabIndex = 6;
            this.lblHeros.Text = "Heroes";
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(355, 108);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(167, 121);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNumber.Location = new System.Drawing.Point(87, 246);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(212, 20);
            this.lblAddNumber.TabIndex = 8;
            this.lblAddNumber.Text = "Select a Number to Remove:";
            // 
            // lblHero
            // 
            this.lblHero.AutoSize = true;
            this.lblHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHero.Location = new System.Drawing.Point(351, 246);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(201, 20);
            this.lblHero.TabIndex = 9;
            this.lblHero.Text = "Enter a Hero Name to Add:";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(87, 269);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(76, 23);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(169, 269);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveAllNumbers.TabIndex = 11;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.Location = new System.Drawing.Point(461, 269);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(61, 23);
            this.btnAddHero.TabIndex = 12;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(355, 269);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 373);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 18);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status: ";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(351, 306);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(185, 20);
            this.lblRemove.TabIndex = 15;
            this.lblRemove.Text = "Enter a Hero to Remove:";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(355, 332);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(80, 20);
            this.txtRemoveHero.TabIndex = 16;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.Location = new System.Drawing.Point(442, 330);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveHero.TabIndex = 17;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // btnAscending
            // 
            this.btnAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscending.Location = new System.Drawing.Point(268, 109);
            this.btnAscending.Name = "btnAscending";
            this.btnAscending.Size = new System.Drawing.Size(81, 23);
            this.btnAscending.TabIndex = 18;
            this.btnAscending.Text = "Ascending";
            this.btnAscending.UseVisualStyleBackColor = true;
            this.btnAscending.Click += new System.EventHandler(this.btnAscending_Click);
            // 
            // btnDescending
            // 
            this.btnDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescending.Location = new System.Drawing.Point(268, 138);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(81, 23);
            this.btnDescending.TabIndex = 19;
            this.btnDescending.Text = "Descending";
            this.btnDescending.UseVisualStyleBackColor = true;
            this.btnDescending.Click += new System.EventHandler(this.btnDescending_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(352, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(16, 13);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "---";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(54, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(530, 25);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Foshay\'s Random Number and Hero List Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(646, 412);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDescending);
            this.Controls.Add(this.btnAscending);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblHero);
            this.Controls.Add(this.lblAddNumber);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lblHeros);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Name = "Form1";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Label lblHeros;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Label lblHero;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Button btnAscending;
        private System.Windows.Forms.Button btnDescending;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
    }
}

