namespace NeuralNetworks
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
            this.picBoxInit = new System.Windows.Forms.PictureBox();
            this.picBoxCropped = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResDesc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.используемыеОбразцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходноеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОбрабатываемоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакОбразецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обрабатываемоеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.используемаяНейроннаяСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сетьХеммингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сетьХеббаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обучитьСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускСетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxInit
            // 
            this.picBoxInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBoxInit.Location = new System.Drawing.Point(20, 84);
            this.picBoxInit.Name = "picBoxInit";
            this.picBoxInit.Size = new System.Drawing.Size(320, 320);
            this.picBoxInit.TabIndex = 0;
            this.picBoxInit.TabStop = false;
            this.picBoxInit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxInit_MouseDown);
            this.picBoxInit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxInit_MouseMove);
            this.picBoxInit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxInit_MouseUp);
            // 
            // picBoxCropped
            // 
            this.picBoxCropped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBoxCropped.Location = new System.Drawing.Point(346, 84);
            this.picBoxCropped.Name = "picBoxCropped";
            this.picBoxCropped.Size = new System.Drawing.Size(320, 320);
            this.picBoxCropped.TabIndex = 1;
            this.picBoxCropped.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Обрабатываемое изображение";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbResult.Location = new System.Drawing.Point(672, 84);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(320, 320);
            this.pbResult.TabIndex = 7;
            this.pbResult.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(685, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Похоже на";
            // 
            // labelResDesc
            // 
            this.labelResDesc.AutoSize = true;
            this.labelResDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResDesc.Location = new System.Drawing.Point(685, 421);
            this.labelResDesc.Name = "labelResDesc";
            this.labelResDesc.Size = new System.Drawing.Size(0, 25);
            this.labelResDesc.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem,
            this.обучитьСетьToolStripMenuItem,
            this.запускСетиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьЗагрузитьОбразцыToolStripMenuItem
            // 
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.используемыеОбразцыToolStripMenuItem,
            this.исходноеИзображениеToolStripMenuItem,
            this.обрабатываемоеИзображениеToolStripMenuItem,
            this.используемаяНейроннаяСетьToolStripMenuItem});
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem.Name = "сохранитьЗагрузитьОбразцыToolStripMenuItem";
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.сохранитьЗагрузитьОбразцыToolStripMenuItem.Text = "Меню";
            // 
            // используемыеОбразцыToolStripMenuItem
            // 
            this.используемыеОбразцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1,
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem});
            this.используемыеОбразцыToolStripMenuItem.Name = "используемыеОбразцыToolStripMenuItem";
            this.используемыеОбразцыToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.используемыеОбразцыToolStripMenuItem.Text = "Используемые образцы";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(406, 26);
            this.saveToolStripMenuItem.Text = "Сохранить образцы в файл";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // загрузитьОбразцыИзФайлаToolStripMenuItem1
            // 
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1.Name = "загрузитьОбразцыИзФайлаToolStripMenuItem1";
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1.Size = new System.Drawing.Size(406, 26);
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1.Text = "Загрузить образцы из файла";
            this.загрузитьОбразцыИзФайлаToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьОбразцыИзФайлаToolStripMenuItem1_Click);
            // 
            // очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem
            // 
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem.Name = "очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem";
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem.Size = new System.Drawing.Size(406, 26);
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem.Text = "Очистить коллекцию используемых образцов";
            this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem.Click += new System.EventHandler(this.очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem_Click);
            // 
            // исходноеИзображениеToolStripMenuItem
            // 
            this.исходноеИзображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьОбрабатываемоеToolStripMenuItem,
            this.сохранитьКакОбразецToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.исходноеИзображениеToolStripMenuItem.Name = "исходноеИзображениеToolStripMenuItem";
            this.исходноеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.исходноеИзображениеToolStripMenuItem.Text = "Исходное изображение";
            // 
            // показатьОбрабатываемоеToolStripMenuItem
            // 
            this.показатьОбрабатываемоеToolStripMenuItem.Name = "показатьОбрабатываемоеToolStripMenuItem";
            this.показатьОбрабатываемоеToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.показатьОбрабатываемоеToolStripMenuItem.Text = "Показать обрабатываемое изображение";
            this.показатьОбрабатываемоеToolStripMenuItem.Click += new System.EventHandler(this.показатьОбрабатываемоеToolStripMenuItem_Click);
            // 
            // сохранитьКакОбразецToolStripMenuItem
            // 
            this.сохранитьКакОбразецToolStripMenuItem.Name = "сохранитьКакОбразецToolStripMenuItem";
            this.сохранитьКакОбразецToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.сохранитьКакОбразецToolStripMenuItem.Text = "Сохранить как образец";
            this.сохранитьКакОбразецToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакОбразецToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // обрабатываемоеИзображениеToolStripMenuItem
            // 
            this.обрабатываемоеИзображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.обрабатываемоеИзображениеToolStripMenuItem.Name = "обрабатываемоеИзображениеToolStripMenuItem";
            this.обрабатываемоеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.обрабатываемоеИзображениеToolStripMenuItem.Text = "Обрабатываемое изображение";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(399, 26);
            this.toolStripMenuItem2.Text = "Количество сегментов вдоль каждой из осей";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "6";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "8";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem7.Text = "12";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem8.Text = "16";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // используемаяНейроннаяСетьToolStripMenuItem
            // 
            this.используемаяНейроннаяСетьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.используемаяНейроннаяСетьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сетьХеммингаToolStripMenuItem,
            this.сетьХеббаToolStripMenuItem});
            this.используемаяНейроннаяСетьToolStripMenuItem.Name = "используемаяНейроннаяСетьToolStripMenuItem";
            this.используемаяНейроннаяСетьToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.используемаяНейроннаяСетьToolStripMenuItem.Text = "Используемая нейронная сеть";
            // 
            // сетьХеммингаToolStripMenuItem
            // 
            this.сетьХеммингаToolStripMenuItem.Name = "сетьХеммингаToolStripMenuItem";
            this.сетьХеммингаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.сетьХеммингаToolStripMenuItem.Text = "Сеть Хэмминга";
            this.сетьХеммингаToolStripMenuItem.Click += new System.EventHandler(this.сетьХеммингаToolStripMenuItem_Click);
            // 
            // сетьХеббаToolStripMenuItem
            // 
            this.сетьХеббаToolStripMenuItem.Name = "сетьХеббаToolStripMenuItem";
            this.сетьХеббаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.сетьХеббаToolStripMenuItem.Text = "Сеть Хэбба";
            this.сетьХеббаToolStripMenuItem.Click += new System.EventHandler(this.сетьХеббаToolStripMenuItem_Click);
            // 
            // обучитьСетьToolStripMenuItem
            // 
            this.обучитьСетьToolStripMenuItem.Name = "обучитьСетьToolStripMenuItem";
            this.обучитьСетьToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.обучитьСетьToolStripMenuItem.Text = "Обучить сеть";
            this.обучитьСетьToolStripMenuItem.Click += new System.EventHandler(this.обучитьСетьToolStripMenuItem_Click);
            // 
            // запускСетиToolStripMenuItem
            // 
            this.запускСетиToolStripMenuItem.Name = "запускСетиToolStripMenuItem";
            this.запускСетиToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.запускСетиToolStripMenuItem.Text = "Классифицировать";
            this.запускСетиToolStripMenuItem.Click += new System.EventHandler(this.запускСетиToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Исходное изоражение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelResDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxCropped);
            this.Controls.Add(this.picBoxInit);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxInit;
        private System.Windows.Forms.PictureBox picBoxCropped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResDesc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЗагрузитьОбразцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходноеИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОбрабатываемоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem используемыеОбразцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьОбразцыИзФайлаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьКоллекциюИспользуемыхОбразцовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обрабатываемоеИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem используемаяНейроннаяСетьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сетьХеббаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сетьХеммингаToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакОбразецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучитьСетьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускСетиToolStripMenuItem;
    }
}

