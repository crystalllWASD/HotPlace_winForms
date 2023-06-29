namespace HotPleasure_winForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cashboxBtn = new System.Windows.Forms.Button();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.delBookBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FreeDGV = new System.Windows.Forms.DataGridView();
            this.bookDGV = new System.Windows.Forms.DataGridView();
            this.paymentDGV = new System.Windows.Forms.DataGridView();
            this.cleanerDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.infoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanerDGV)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cashboxBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cleanBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.delBookBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bookBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cashboxBtn
            // 
            this.cashboxBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashboxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashboxBtn.Location = new System.Drawing.Point(10, 320);
            this.cashboxBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.cashboxBtn.Name = "cashboxBtn";
            this.cashboxBtn.Size = new System.Drawing.Size(174, 53);
            this.cashboxBtn.TabIndex = 5;
            this.cashboxBtn.Text = "Касса";
            this.cashboxBtn.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanBtn.Location = new System.Drawing.Point(10, 194);
            this.cleanBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(174, 53);
            this.cleanBtn.TabIndex = 3;
            this.cleanBtn.Text = "Уборка";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // delBookBtn
            // 
            this.delBookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBookBtn.Location = new System.Drawing.Point(10, 131);
            this.delBookBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.delBookBtn.Name = "delBookBtn";
            this.delBookBtn.Size = new System.Drawing.Size(174, 53);
            this.delBookBtn.TabIndex = 2;
            this.delBookBtn.Text = "Отменить бронь";
            this.delBookBtn.UseVisualStyleBackColor = true;
            // 
            // bookBtn
            // 
            this.bookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookBtn.Location = new System.Drawing.Point(10, 68);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(174, 53);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "Забронировать";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 444);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FreeDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(580, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свободно";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bookDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Забронировано";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.paymentDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(580, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оплачено";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cleanerDGV);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(580, 282);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Уборка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FreeDGV
            // 
            this.FreeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreeDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreeDGV.Location = new System.Drawing.Point(3, 3);
            this.FreeDGV.Name = "FreeDGV";
            this.FreeDGV.RowHeadersWidth = 51;
            this.FreeDGV.RowTemplate.Height = 24;
            this.FreeDGV.Size = new System.Drawing.Size(574, 276);
            this.FreeDGV.TabIndex = 0;
            // 
            // bookDGV
            // 
            this.bookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDGV.Location = new System.Drawing.Point(3, 3);
            this.bookDGV.Name = "bookDGV";
            this.bookDGV.RowHeadersWidth = 51;
            this.bookDGV.RowTemplate.Height = 24;
            this.bookDGV.Size = new System.Drawing.Size(574, 276);
            this.bookDGV.TabIndex = 1;
            // 
            // paymentDGV
            // 
            this.paymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDGV.Location = new System.Drawing.Point(3, 3);
            this.paymentDGV.Name = "paymentDGV";
            this.paymentDGV.RowHeadersWidth = 51;
            this.paymentDGV.RowTemplate.Height = 24;
            this.paymentDGV.Size = new System.Drawing.Size(574, 276);
            this.paymentDGV.TabIndex = 1;
            // 
            // cleanerDGV
            // 
            this.cleanerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cleanerDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanerDGV.Location = new System.Drawing.Point(0, 0);
            this.cleanerDGV.Name = "cleanerDGV";
            this.cleanerDGV.RowHeadersWidth = 51;
            this.cleanerDGV.RowTemplate.Height = 24;
            this.cleanerDGV.Size = new System.Drawing.Size(580, 282);
            this.cleanerDGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обязательно здороваемся с клиентами. Внимательно слушаем.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.infoBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 383);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(588, 58);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // infoBtn
            // 
            this.infoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Location = new System.Drawing.Point(3, 3);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(582, 28);
            this.infoBtn.TabIndex = 0;
            this.infoBtn.Text = "Показать подробную информацию";
            this.infoBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Не забываем предлагать помощь и желать всего хорошего.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hot Pleasure";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FreeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanerDGV)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cashboxBtn;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Button delBookBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView FreeDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView bookDGV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView paymentDGV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView cleanerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label label2;
    }
}

