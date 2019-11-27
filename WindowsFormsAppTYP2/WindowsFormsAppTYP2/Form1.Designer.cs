namespace WindowsFormsAppTYP2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonLoadFromFile = new System.Windows.Forms.Button();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.listBoxID = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewHF = new System.Windows.Forms.DataGridView();
			this.dataGridViewSimple = new System.Windows.Forms.DataGridView();
			this.ColumnHF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnHFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.richTextBoxHfResult = new System.Windows.Forms.RichTextBox();
			this.richTextBoxSimpleResult = new System.Windows.Forms.RichTextBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimple)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLoadFromFile
			// 
			this.buttonLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonLoadFromFile.Location = new System.Drawing.Point(12, 12);
			this.buttonLoadFromFile.Name = "buttonLoadFromFile";
			this.buttonLoadFromFile.Size = new System.Drawing.Size(377, 34);
			this.buttonLoadFromFile.TabIndex = 0;
			this.buttonLoadFromFile.Text = "Загрузить индентефикаторы из файла";
			this.buttonLoadFromFile.UseVisualStyleBackColor = true;
			this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
			// 
			// buttonExecute
			// 
			this.buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonExecute.Location = new System.Drawing.Point(395, 12);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(137, 34);
			this.buttonExecute.TabIndex = 1;
			this.buttonExecute.Text = "Выполнить";
			this.buttonExecute.UseVisualStyleBackColor = true;
			// 
			// listBoxID
			// 
			this.listBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.listBoxID.FormattingEnabled = true;
			this.listBoxID.ItemHeight = 20;
			this.listBoxID.Location = new System.Drawing.Point(12, 104);
			this.listBoxID.Name = "listBoxID";
			this.listBoxID.Size = new System.Drawing.Size(159, 384);
			this.listBoxID.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(12, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Идентификаторы";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(199, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Рехэширование";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(482, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Упорядоченный список";
			// 
			// dataGridViewHF
			// 
			this.dataGridViewHF.AllowUserToAddRows = false;
			this.dataGridViewHF.AllowUserToDeleteRows = false;
			this.dataGridViewHF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHF,
            this.ColumnHFID});
			this.dataGridViewHF.Location = new System.Drawing.Point(203, 93);
			this.dataGridViewHF.Name = "dataGridViewHF";
			this.dataGridViewHF.ReadOnly = true;
			this.dataGridViewHF.RowHeadersVisible = false;
			this.dataGridViewHF.RowTemplate.Height = 24;
			this.dataGridViewHF.Size = new System.Drawing.Size(277, 237);
			this.dataGridViewHF.TabIndex = 6;
			// 
			// dataGridViewSimple
			// 
			this.dataGridViewSimple.AllowUserToAddRows = false;
			this.dataGridViewSimple.AllowUserToDeleteRows = false;
			this.dataGridViewSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridViewSimple.Location = new System.Drawing.Point(486, 93);
			this.dataGridViewSimple.Name = "dataGridViewSimple";
			this.dataGridViewSimple.ReadOnly = true;
			this.dataGridViewSimple.RowHeadersVisible = false;
			this.dataGridViewSimple.RowTemplate.Height = 24;
			this.dataGridViewSimple.Size = new System.Drawing.Size(276, 237);
			this.dataGridViewSimple.TabIndex = 7;
			// 
			// ColumnHF
			// 
			this.ColumnHF.HeaderText = "ХФ";
			this.ColumnHF.Name = "ColumnHF";
			this.ColumnHF.ReadOnly = true;
			// 
			// ColumnHFID
			// 
			this.ColumnHFID.HeaderText = "Идентификатор";
			this.ColumnHFID.Name = "ColumnHFID";
			this.ColumnHFID.ReadOnly = true;
			this.ColumnHFID.Width = 120;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(294, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(225, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Введите идентификатор";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.textBoxSearch.Location = new System.Drawing.Point(298, 371);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(155, 26);
			this.textBoxSearch.TabIndex = 9;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonSearch.Location = new System.Drawing.Point(459, 366);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(99, 36);
			this.buttonSearch.TabIndex = 10;
			this.buttonSearch.Text = "Поиск";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// richTextBoxHfResult
			// 
			this.richTextBoxHfResult.Location = new System.Drawing.Point(203, 408);
			this.richTextBoxHfResult.Name = "richTextBoxHfResult";
			this.richTextBoxHfResult.Size = new System.Drawing.Size(224, 80);
			this.richTextBoxHfResult.TabIndex = 11;
			this.richTextBoxHfResult.Text = "";
			// 
			// richTextBoxSimpleResult
			// 
			this.richTextBoxSimpleResult.Location = new System.Drawing.Point(466, 408);
			this.richTextBoxSimpleResult.Name = "richTextBoxSimpleResult";
			this.richTextBoxSimpleResult.Size = new System.Drawing.Size(224, 80);
			this.richTextBoxSimpleResult.TabIndex = 12;
			this.richTextBoxSimpleResult.Text = "";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Идентификатор";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 120;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 514);
			this.Controls.Add(this.richTextBoxSimpleResult);
			this.Controls.Add(this.richTextBoxHfResult);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataGridViewSimple);
			this.Controls.Add(this.dataGridViewHF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxID);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.buttonLoadFromFile);
			this.Name = "Form1";
			this.Text = "Список идентификаторов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimple)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLoadFromFile;
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.ListBox listBoxID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewHF;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHF;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHFID;
		private System.Windows.Forms.DataGridView dataGridViewSimple;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.RichTextBox richTextBoxHfResult;
		private System.Windows.Forms.RichTextBox richTextBoxSimpleResult;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}

