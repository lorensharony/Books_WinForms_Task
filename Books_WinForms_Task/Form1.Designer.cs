namespace Books_WinForms_Task
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
            this.label1header = new System.Windows.Forms.Label();
            this.label2bookName = new System.Windows.Forms.Label();
            this.label3bookDescription = new System.Windows.Forms.Label();
            this.label4catalogNumber = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.textBookDescription = new System.Windows.Forms.TextBox();
            this.textCatalogNumber = new System.Windows.Forms.TextBox();
            this.bntEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1header
            // 
            this.label1header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1header.AutoSize = true;
            this.label1header.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1header.Location = new System.Drawing.Point(571, 9);
            this.label1header.Name = "label1header";
            this.label1header.Size = new System.Drawing.Size(217, 38);
            this.label1header.TabIndex = 0;
            this.label1header.Text = "מערכת ספרים";
            // 
            // label2bookName
            // 
            this.label2bookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2bookName.AutoSize = true;
            this.label2bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2bookName.Location = new System.Drawing.Point(1127, 75);
            this.label2bookName.Name = "label2bookName";
            this.label2bookName.Size = new System.Drawing.Size(85, 25);
            this.label2bookName.TabIndex = 1;
            this.label2bookName.Text = ":שם הספר";
            // 
            // label3bookDescription
            // 
            this.label3bookDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3bookDescription.AutoSize = true;
            this.label3bookDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3bookDescription.Location = new System.Drawing.Point(1105, 153);
            this.label3bookDescription.Name = "label3bookDescription";
            this.label3bookDescription.Size = new System.Drawing.Size(107, 25);
            this.label3bookDescription.TabIndex = 2;
            this.label3bookDescription.Text = ":תיאור הספר";
            // 
            // label4catalogNumber
            // 
            this.label4catalogNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4catalogNumber.AutoSize = true;
            this.label4catalogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4catalogNumber.Location = new System.Drawing.Point(1154, 281);
            this.label4catalogNumber.Name = "label4catalogNumber";
            this.label4catalogNumber.Size = new System.Drawing.Size(58, 25);
            this.label4catalogNumber.TabIndex = 3;
            this.label4catalogNumber.Text = ":מק\"ט";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 179);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textBookName
            // 
            this.textBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBookName.Location = new System.Drawing.Point(109, 75);
            this.textBookName.Multiline = true;
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(990, 42);
            this.textBookName.TabIndex = 5;
            this.textBookName.TextChanged += new System.EventHandler(this.textBookName_TextChanged);
            // 
            // textBookDescription
            // 
            this.textBookDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBookDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBookDescription.Location = new System.Drawing.Point(109, 144);
            this.textBookDescription.Multiline = true;
            this.textBookDescription.Name = "textBookDescription";
            this.textBookDescription.Size = new System.Drawing.Size(990, 101);
            this.textBookDescription.TabIndex = 6;
            // 
            // textCatalogNumber
            // 
            this.textCatalogNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCatalogNumber.Enabled = false;
            this.textCatalogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textCatalogNumber.Location = new System.Drawing.Point(109, 276);
            this.textCatalogNumber.Name = "textCatalogNumber";
            this.textCatalogNumber.Size = new System.Drawing.Size(990, 30);
            this.textCatalogNumber.TabIndex = 7;
            // 
            // bntEdit
            // 
            this.bntEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bntEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntEdit.Location = new System.Drawing.Point(1018, 378);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(81, 34);
            this.bntEdit.TabIndex = 8;
            this.bntEdit.Text = "עריכה";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(881, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(1127, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 599);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.textCatalogNumber);
            this.Controls.Add(this.textBookDescription);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4catalogNumber);
            this.Controls.Add(this.label3bookDescription);
            this.Controls.Add(this.label2bookName);
            this.Controls.Add(this.label1header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1header;
        private System.Windows.Forms.Label label2bookName;
        private System.Windows.Forms.Label label3bookDescription;
        private System.Windows.Forms.Label label4catalogNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.TextBox textBookDescription;
        private System.Windows.Forms.TextBox textCatalogNumber;
        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

