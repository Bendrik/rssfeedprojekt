namespace testprojekt
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
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxFreq = new System.Windows.Forms.ComboBox();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.txtPodName = new System.Windows.Forms.TextBox();
            this.catList = new System.Windows.Forms.ListBox();
            this.podBox = new System.Windows.Forms.ListBox();
            this.btnRemovePod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.episodeBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "uppdatera";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(61, 262);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(150, 22);
            this.textBoxUrl.TabIndex = 5;
            // 
            // comboBoxFreq
            // 
            this.comboBoxFreq.FormattingEnabled = true;
            this.comboBoxFreq.Location = new System.Drawing.Point(217, 233);
            this.comboBoxFreq.Name = "comboBoxFreq";
            this.comboBoxFreq.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFreq.TabIndex = 6;
            this.comboBoxFreq.SelectedIndexChanged += new System.EventHandler(this.comboBoxFreq_SelectedIndexChanged);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(343, 233);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCat.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(491, 194);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(179, 22);
            this.txtCategory.TabIndex = 8;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(584, 222);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(86, 23);
            this.btnSaveCat.TabIndex = 9;
            this.btnSaveCat.Text = "uppdatera";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kategorier:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(217, 262);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "ny";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewCat
            // 
            this.btnNewCat.Location = new System.Drawing.Point(491, 222);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(75, 23);
            this.btnNewCat.TabIndex = 12;
            this.btnNewCat.Text = "ny";
            this.btnNewCat.UseVisualStyleBackColor = true;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // txtPodName
            // 
            this.txtPodName.Location = new System.Drawing.Point(67, 233);
            this.txtPodName.Name = "txtPodName";
            this.txtPodName.Size = new System.Drawing.Size(141, 22);
            this.txtPodName.TabIndex = 13;
            // 
            // catList
            // 
            this.catList.FormattingEnabled = true;
            this.catList.ItemHeight = 16;
            this.catList.Location = new System.Drawing.Point(491, 32);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(277, 100);
            this.catList.TabIndex = 14;
            // 
            // podBox
            // 
            this.podBox.FormattingEnabled = true;
            this.podBox.ItemHeight = 16;
            this.podBox.Location = new System.Drawing.Point(12, 13);
            this.podBox.Name = "podBox";
            this.podBox.Size = new System.Drawing.Size(452, 196);
            this.podBox.TabIndex = 15;
            this.podBox.SelectedIndexChanged += new System.EventHandler(this.podBox_SelectedIndexChanged);
            // 
            // btnRemovePod
            // 
            this.btnRemovePod.Location = new System.Drawing.Point(389, 262);
            this.btnRemovePod.Name = "btnRemovePod";
            this.btnRemovePod.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePod.TabIndex = 16;
            this.btnRemovePod.Text = "ta bort";
            this.btnRemovePod.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Namn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "URL:";
            // 
            // episodeBox
            // 
            this.episodeBox.FormattingEnabled = true;
            this.episodeBox.ItemHeight = 16;
            this.episodeBox.Location = new System.Drawing.Point(15, 320);
            this.episodeBox.Name = "episodeBox";
            this.episodeBox.Size = new System.Drawing.Size(368, 116);
            this.episodeBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.episodeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemovePod);
            this.Controls.Add(this.podBox);
            this.Controls.Add(this.catList);
            this.Controls.Add(this.txtPodName);
            this.Controls.Add(this.btnNewCat);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.comboBoxFreq);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxFreq;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNewCat;
        private System.Windows.Forms.TextBox txtPodName;
        private System.Windows.Forms.ListBox catList;
        private System.Windows.Forms.ListBox podBox;
        private System.Windows.Forms.Button btnRemovePod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox episodeBox;
    }
}

