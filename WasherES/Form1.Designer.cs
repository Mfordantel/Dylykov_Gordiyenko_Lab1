namespace WasherES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pricebox = new System.Windows.Forms.NumericUpDown();
            this.Smallbox = new System.Windows.Forms.CheckBox();
            this.Medbox = new System.Windows.Forms.CheckBox();
            this.Largebox = new System.Windows.Forms.CheckBox();
            this.Heightbox = new System.Windows.Forms.NumericUpDown();
            this.Widthbox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.MoreFive = new System.Windows.Forms.CheckBox();
            this.ToFive = new System.Windows.Forms.CheckBox();
            this.Nfrbox = new System.Windows.Forms.CheckBox();
            this.Yfrbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.bGetRes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pricebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heightbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Widthbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите необходимую глубину барабана";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите необходимую высоту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите необходимую загрузку барабана";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Введите цену стиральной машины";
            // 
            // Pricebox
            // 
            this.Pricebox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricebox.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Pricebox.Location = new System.Drawing.Point(336, 43);
            this.Pricebox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(138, 29);
            this.Pricebox.TabIndex = 9;
            this.Pricebox.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // Smallbox
            // 
            this.Smallbox.AutoSize = true;
            this.Smallbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smallbox.Location = new System.Drawing.Point(383, 239);
            this.Smallbox.Name = "Smallbox";
            this.Smallbox.Size = new System.Drawing.Size(115, 24);
            this.Smallbox.TabIndex = 10;
            this.Smallbox.Text = "маленькая";
            this.Smallbox.UseVisualStyleBackColor = true;
            // 
            // Medbox
            // 
            this.Medbox.AutoSize = true;
            this.Medbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medbox.Location = new System.Drawing.Point(383, 267);
            this.Medbox.Name = "Medbox";
            this.Medbox.Size = new System.Drawing.Size(94, 24);
            this.Medbox.TabIndex = 11;
            this.Medbox.Text = "средняя";
            this.Medbox.UseVisualStyleBackColor = true;
            // 
            // Largebox
            // 
            this.Largebox.AutoSize = true;
            this.Largebox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Largebox.Location = new System.Drawing.Point(383, 300);
            this.Largebox.Name = "Largebox";
            this.Largebox.Size = new System.Drawing.Size(99, 24);
            this.Largebox.TabIndex = 12;
            this.Largebox.Text = "большая";
            this.Largebox.UseVisualStyleBackColor = true;
            // 
            // Heightbox
            // 
            this.Heightbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightbox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Heightbox.Location = new System.Drawing.Point(336, 76);
            this.Heightbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Heightbox.Name = "Heightbox";
            this.Heightbox.Size = new System.Drawing.Size(75, 29);
            this.Heightbox.TabIndex = 13;
            this.Heightbox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Widthbox
            // 
            this.Widthbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Widthbox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Widthbox.Location = new System.Drawing.Point(336, 112);
            this.Widthbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Widthbox.Name = "Widthbox";
            this.Widthbox.Size = new System.Drawing.Size(75, 29);
            this.Widthbox.TabIndex = 15;
            this.Widthbox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Введите необходимую ширину";
            // 
            // MoreFive
            // 
            this.MoreFive.AutoSize = true;
            this.MoreFive.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreFive.Location = new System.Drawing.Point(383, 195);
            this.MoreFive.Name = "MoreFive";
            this.MoreFive.Size = new System.Drawing.Size(154, 24);
            this.MoreFive.TabIndex = 17;
            this.MoreFive.Text = "от 6кг до 12кг";
            this.MoreFive.UseVisualStyleBackColor = true;
            // 
            // ToFive
            // 
            this.ToFive.AutoSize = true;
            this.ToFive.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToFive.Location = new System.Drawing.Point(383, 161);
            this.ToFive.Name = "ToFive";
            this.ToFive.Size = new System.Drawing.Size(156, 24);
            this.ToFive.TabIndex = 16;
            this.ToFive.Text = "от 3,5кг до 5кг";
            this.ToFive.UseVisualStyleBackColor = true;
            // 
            // Nfrbox
            // 
            this.Nfrbox.AutoSize = true;
            this.Nfrbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nfrbox.Location = new System.Drawing.Point(337, 378);
            this.Nfrbox.Name = "Nfrbox";
            this.Nfrbox.Size = new System.Drawing.Size(139, 24);
            this.Nfrbox.TabIndex = 22;
            this.Nfrbox.Text = "фронтальная";
            this.Nfrbox.UseVisualStyleBackColor = true;
            // 
            // Yfrbox
            // 
            this.Yfrbox.AutoSize = true;
            this.Yfrbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yfrbox.Location = new System.Drawing.Point(337, 343);
            this.Yfrbox.Name = "Yfrbox";
            this.Yfrbox.Size = new System.Drawing.Size(141, 24);
            this.Yfrbox.TabIndex = 21;
            this.Yfrbox.Text = "Вертикальная";
            this.Yfrbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите тип стиральной машины";
            // 
            // resultbox
            // 
            this.resultbox.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultbox.Location = new System.Drawing.Point(16, 491);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.ReadOnly = true;
            this.resultbox.Size = new System.Drawing.Size(513, 83);
            this.resultbox.TabIndex = 23;
            // 
            // bGetRes
            // 
            this.bGetRes.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGetRes.Location = new System.Drawing.Point(17, 418);
            this.bGetRes.Name = "bGetRes";
            this.bGetRes.Size = new System.Drawing.Size(513, 32);
            this.bGetRes.TabIndex = 24;
            this.bGetRes.Text = "Найти";
            this.bGetRes.UseVisualStyleBackColor = true;
            this.bGetRes.Click += new System.EventHandler(this.bGetRes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic CAT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bGetRes);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.Nfrbox);
            this.Controls.Add(this.Yfrbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MoreFive);
            this.Controls.Add(this.ToFive);
            this.Controls.Add(this.Widthbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Heightbox);
            this.Controls.Add(this.Largebox);
            this.Controls.Add(this.Medbox);
            this.Controls.Add(this.Smallbox);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Выбор стиральной машины";
            ((System.ComponentModel.ISupportInitialize)(this.Pricebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heightbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Widthbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Pricebox;
        private System.Windows.Forms.CheckBox Smallbox;
        private System.Windows.Forms.CheckBox Medbox;
        private System.Windows.Forms.CheckBox Largebox;
        private System.Windows.Forms.NumericUpDown Heightbox;
        private System.Windows.Forms.NumericUpDown Widthbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox MoreFive;
        private System.Windows.Forms.CheckBox ToFive;
        private System.Windows.Forms.CheckBox Nfrbox;
        private System.Windows.Forms.CheckBox Yfrbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Button bGetRes;
        private System.Windows.Forms.Label label6;
    }
}

