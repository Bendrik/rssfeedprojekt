﻿namespace testprojekt
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
            this.btnRemovePod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPodcast = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAvsnitt = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvsnitt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(482, 254);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 21);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "uppdatera";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(14, 296);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(203, 20);
            this.textBoxUrl.TabIndex = 5;
            // 
            // comboBoxFreq
            // 
            this.comboBoxFreq.FormattingEnabled = true;
            this.comboBoxFreq.Location = new System.Drawing.Point(250, 254);
            this.comboBoxFreq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFreq.Name = "comboBoxFreq";
            this.comboBoxFreq.Size = new System.Drawing.Size(144, 21);
            this.comboBoxFreq.TabIndex = 6;
            this.comboBoxFreq.SelectedIndexChanged += new System.EventHandler(this.comboBoxFreq_SelectedIndexChanged);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(250, 295);
            this.comboBoxCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCat.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(579, 255);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(135, 20);
            this.txtCategory.TabIndex = 8;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(672, 280);
            this.btnSaveCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(80, 22);
            this.btnSaveCat.TabIndex = 9;
            this.btnSaveCat.Text = "uppdatera";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kategorier:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(398, 254);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 21);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "ny";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNy_Click);
            // 
            // btnNewCat
            // 
            this.btnNewCat.Location = new System.Drawing.Point(579, 280);
            this.btnNewCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(80, 21);
            this.btnNewCat.TabIndex = 12;
            this.btnNewCat.Text = "ny";
            this.btnNewCat.UseVisualStyleBackColor = true;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // txtPodName
            // 
            this.txtPodName.Location = new System.Drawing.Point(14, 254);
            this.txtPodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPodName.Name = "txtPodName";
            this.txtPodName.Size = new System.Drawing.Size(203, 20);
            this.txtPodName.TabIndex = 13;
            // 
            // catList
            // 
            this.catList.FormattingEnabled = true;
            this.catList.Location = new System.Drawing.Point(579, 24);
            this.catList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(209, 212);
            this.catList.TabIndex = 14;
            // 
            // btnRemovePod
            // 
            this.btnRemovePod.Location = new System.Drawing.Point(398, 295);
            this.btnRemovePod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemovePod.Name = "btnRemovePod";
            this.btnRemovePod.Size = new System.Drawing.Size(80, 21);
            this.btnRemovePod.TabIndex = 16;
            this.btnRemovePod.Text = "ta bort";
            this.btnRemovePod.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Namn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "URL:";
            // 
            // dataGridViewPodcast
            // 
            this.dataGridViewPodcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodcast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5});
            this.dataGridViewPodcast.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPodcast.Name = "dataGridViewPodcast";
            this.dataGridViewPodcast.ReadOnly = true;
            this.dataGridViewPodcast.RowHeadersWidth = 51;
            this.dataGridViewPodcast.Size = new System.Drawing.Size(562, 224);
            this.dataGridViewPodcast.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Namn";
            this.Column1.HeaderText = "Namn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Kategori";
            this.Column4.HeaderText = "Kategori";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Uppdatering";
            this.Column3.HeaderText = "Uppdaterings- intervall";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "antalAvsnitt";
            this.Column2.HeaderText = "Antal avsnitt";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "nyaAvsnitt";
            this.Column5.HeaderText = "Nytt avsnitt finns";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Uppdateringsintervall:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kategorinamn:";
            // 
            // dataGridViewAvsnitt
            // 
            this.dataGridViewAvsnitt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvsnitt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.dataGridViewAvsnitt.Location = new System.Drawing.Point(14, 326);
            this.dataGridViewAvsnitt.Name = "dataGridViewAvsnitt";
            this.dataGridViewAvsnitt.ReadOnly = true;
            this.dataGridViewAvsnitt.RowHeadersWidth = 51;
            this.dataGridViewAvsnitt.Size = new System.Drawing.Size(560, 227);
            this.dataGridViewAvsnitt.TabIndex = 23;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Titel";
            this.Column6.HeaderText = "Avsnitt";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "ta bort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAvsnitt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemovePod);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodcast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvsnitt)).EndInit();
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
        private System.Windows.Forms.Button btnRemovePod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPodcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAvsnitt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
    }
}

