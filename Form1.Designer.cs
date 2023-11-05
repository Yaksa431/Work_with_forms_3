namespace Работа_с_формами_3
{
    partial class CandyShop
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
            this.STEP = new System.Windows.Forms.RadioButton();
            this.Marsianka = new System.Windows.Forms.RadioButton();
            this.Twix = new System.Windows.Forms.RadioButton();
            this.Snickers = new System.Windows.Forms.RadioButton();
            this.Yarche = new System.Windows.Forms.RadioButton();
            this.Arbuzik = new System.Windows.Forms.RadioButton();
            this.Attache = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Packaging = new System.Windows.Forms.CheckBox();
            this.ChGarden = new System.Windows.Forms.CheckBox();
            this.BirthDay = new System.Windows.Forms.CheckBox();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.Sat_Fri = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Total_cost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Сalculation = new System.Windows.Forms.Button();
            this.Total_quantity = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // STEP
            // 
            this.STEP.AutoSize = true;
            this.STEP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STEP.Location = new System.Drawing.Point(18, 40);
            this.STEP.Name = "STEP";
            this.STEP.Size = new System.Drawing.Size(77, 25);
            this.STEP.TabIndex = 0;
            this.STEP.TabStop = true;
            this.STEP.Text = "СТЕП";
            this.STEP.UseVisualStyleBackColor = true;
            this.STEP.CheckedChanged += new System.EventHandler(this.STEP_CheckedChanged);
            // 
            // Marsianka
            // 
            this.Marsianka.AutoSize = true;
            this.Marsianka.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Marsianka.Location = new System.Drawing.Point(18, 68);
            this.Marsianka.Name = "Marsianka";
            this.Marsianka.Size = new System.Drawing.Size(116, 25);
            this.Marsianka.TabIndex = 1;
            this.Marsianka.TabStop = true;
            this.Marsianka.Text = "Марсианка";
            this.Marsianka.UseVisualStyleBackColor = true;
            this.Marsianka.CheckedChanged += new System.EventHandler(this.Marsianka_CheckedChanged);
            // 
            // Twix
            // 
            this.Twix.AutoSize = true;
            this.Twix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Twix.Location = new System.Drawing.Point(18, 96);
            this.Twix.Name = "Twix";
            this.Twix.Size = new System.Drawing.Size(101, 25);
            this.Twix.TabIndex = 2;
            this.Twix.TabStop = true;
            this.Twix.Text = "Twix mini";
            this.Twix.UseVisualStyleBackColor = true;
            this.Twix.CheckedChanged += new System.EventHandler(this.Twix_CheckedChanged);
            // 
            // Snickers
            // 
            this.Snickers.AutoSize = true;
            this.Snickers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Snickers.Location = new System.Drawing.Point(18, 122);
            this.Snickers.Name = "Snickers";
            this.Snickers.Size = new System.Drawing.Size(128, 25);
            this.Snickers.TabIndex = 3;
            this.Snickers.TabStop = true;
            this.Snickers.Text = "Snickers mini";
            this.Snickers.UseVisualStyleBackColor = true;
            this.Snickers.CheckedChanged += new System.EventHandler(this.Snickers_CheckedChanged);
            // 
            // Yarche
            // 
            this.Yarche.AutoSize = true;
            this.Yarche.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yarche.Location = new System.Drawing.Point(18, 149);
            this.Yarche.Name = "Yarche";
            this.Yarche.Size = new System.Drawing.Size(75, 25);
            this.Yarche.TabIndex = 4;
            this.Yarche.TabStop = true;
            this.Yarche.Text = "Ярче!";
            this.Yarche.UseVisualStyleBackColor = true;
            this.Yarche.CheckedChanged += new System.EventHandler(this.Yarche_CheckedChanged);
            // 
            // Arbuzik
            // 
            this.Arbuzik.AutoSize = true;
            this.Arbuzik.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arbuzik.Location = new System.Drawing.Point(18, 176);
            this.Arbuzik.Name = "Arbuzik";
            this.Arbuzik.Size = new System.Drawing.Size(96, 25);
            this.Arbuzik.TabIndex = 5;
            this.Arbuzik.TabStop = true;
            this.Arbuzik.Text = "Арбузик";
            this.Arbuzik.UseVisualStyleBackColor = true;
            this.Arbuzik.CheckedChanged += new System.EventHandler(this.Arbuzik_CheckedChanged);
            // 
            // Attache
            // 
            this.Attache.AutoSize = true;
            this.Attache.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attache.Location = new System.Drawing.Point(18, 203);
            this.Attache.Name = "Attache";
            this.Attache.Size = new System.Drawing.Size(85, 25);
            this.Attache.TabIndex = 6;
            this.Attache.TabStop = true;
            this.Attache.Text = "Attache";
            this.Attache.UseVisualStyleBackColor = true;
            this.Attache.CheckedChanged += new System.EventHandler(this.Attache_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Yarche);
            this.panel1.Controls.Add(this.Attache);
            this.panel1.Controls.Add(this.STEP);
            this.panel1.Controls.Add(this.Arbuzik);
            this.panel1.Controls.Add(this.Snickers);
            this.panel1.Controls.Add(this.Twix);
            this.panel1.Controls.Add(this.Marsianka);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 249);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(244, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "69,9 руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(244, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "46,0 руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(244, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "43,5 руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(244, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "46,5 руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(244, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "69,9 руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(244, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "39,9 руб.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена за 100 грамм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Конфеты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(244, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "52,0 руб.";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(150, 245);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // Packaging
            // 
            this.Packaging.AutoSize = true;
            this.Packaging.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Packaging.Location = new System.Drawing.Point(7, 32);
            this.Packaging.Name = "Packaging";
            this.Packaging.Size = new System.Drawing.Size(178, 25);
            this.Packaging.TabIndex = 8;
            this.Packaging.Text = "Упаковка (+5 руб.)";
            this.Packaging.UseVisualStyleBackColor = true;
            this.Packaging.CheckedChanged += new System.EventHandler(this.Packaging_CheckedChanged);
            // 
            // ChGarden
            // 
            this.ChGarden.AutoSize = true;
            this.ChGarden.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChGarden.Location = new System.Drawing.Point(7, 92);
            this.ChGarden.Name = "ChGarden";
            this.ChGarden.Size = new System.Drawing.Size(151, 25);
            this.ChGarden.TabIndex = 9;
            this.ChGarden.Text = "Дет. сад (-15%)";
            this.ChGarden.UseVisualStyleBackColor = true;
            this.ChGarden.CheckedChanged += new System.EventHandler(this.ChGarden_CheckedChanged);
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDay.Location = new System.Drawing.Point(7, 123);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(211, 25);
            this.BirthDay.TabIndex = 10;
            this.BirthDay.Text = "День рождения (-10%)";
            this.BirthDay.UseVisualStyleBackColor = true;
            this.BirthDay.CheckedChanged += new System.EventHandler(this.BirthDay_CheckedChanged);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sunday.Location = new System.Drawing.Point(7, 154);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(179, 25);
            this.Sunday.TabIndex = 11;
            this.Sunday.Text = "Воскресенье (-5%)";
            this.Sunday.UseVisualStyleBackColor = true;
            this.Sunday.CheckedChanged += new System.EventHandler(this.Sunday_CheckedChanged);
            // 
            // Sat_Fri
            // 
            this.Sat_Fri.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sat_Fri.Location = new System.Drawing.Point(7, 185);
            this.Sat_Fri.Name = "Sat_Fri";
            this.Sat_Fri.Size = new System.Drawing.Size(190, 47);
            this.Sat_Fri.TabIndex = 12;
            this.Sat_Fri.Text = "Суббота / Пятница (+100 гр.)";
            this.Sat_Fri.UseVisualStyleBackColor = true;
            this.Sat_Fri.CheckedChanged += new System.EventHandler(this.Sat_Fri_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Sunday);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Sat_Fri);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Packaging);
            this.panel2.Controls.Add(this.ChGarden);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.BirthDay);
            this.panel2.Location = new System.Drawing.Point(346, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 247);
            this.panel2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Скидка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Дополнительно";
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(222, 63);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity.Location = new System.Drawing.Point(12, 293);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(105, 29);
            this.Quantity.TabIndex = 14;
            this.Quantity.Text = "0";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Вес (в граммах)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "ИТОГО:";
            // 
            // Total_cost
            // 
            this.Total_cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_cost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total_cost.Location = new System.Drawing.Point(12, 396);
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.Size = new System.Drawing.Size(105, 25);
            this.Total_cost.TabIndex = 18;
            this.Total_cost.Text = "0,00";
            this.Total_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total_cost.TextChanged += new System.EventHandler(this.Total_cost_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(123, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "руб.";
            // 
            // Сalculation
            // 
            this.Сalculation.AutoSize = true;
            this.Сalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Сalculation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Сalculation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Сalculation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сalculation.Location = new System.Drawing.Point(298, 325);
            this.Сalculation.Name = "Сalculation";
            this.Сalculation.Size = new System.Drawing.Size(128, 34);
            this.Сalculation.TabIndex = 20;
            this.Сalculation.Text = "Рассчитать";
            this.Сalculation.UseVisualStyleBackColor = false;
            this.Сalculation.Click += new System.EventHandler(this.Сalculation_Click);
            // 
            // Total_quantity
            // 
            this.Total_quantity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total_quantity.Location = new System.Drawing.Point(10, 369);
            this.Total_quantity.Name = "Total_quantity";
            this.Total_quantity.Size = new System.Drawing.Size(150, 23);
            this.Total_quantity.TabIndex = 21;
            this.Total_quantity.Text = "0 гр.";
            this.Total_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(298, 369);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(128, 34);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Обнулить";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CandyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 496);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Total_quantity);
            this.Controls.Add(this.Сalculation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Total_cost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CandyShop";
            this.Text = "Магазин конфет";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton STEP;
        private System.Windows.Forms.RadioButton Marsianka;
        private System.Windows.Forms.RadioButton Twix;
        private System.Windows.Forms.RadioButton Snickers;
        private System.Windows.Forms.RadioButton Yarche;
        private System.Windows.Forms.RadioButton Arbuzik;
        private System.Windows.Forms.RadioButton Attache;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Packaging;
        private System.Windows.Forms.CheckBox ChGarden;
        private System.Windows.Forms.CheckBox BirthDay;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Sat_Fri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Total_cost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Сalculation;
        private System.Windows.Forms.Label Total_quantity;
        private System.Windows.Forms.Button Exit;
    }
}

