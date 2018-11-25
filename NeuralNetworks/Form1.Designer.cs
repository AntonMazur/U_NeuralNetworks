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
            this.btnClearInitPB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compImageResolution = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveSampleToFile = new System.Windows.Forms.Button();
            this.btnAddToSamples = new System.Windows.Forms.Button();
            this.btnLoadSamplesFromFile = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResDesc = new System.Windows.Forms.Label();
            this.showInputImage = new System.Windows.Forms.Button();
            this.btnResetSamples = new System.Windows.Forms.Button();
            this.rbthHamming = new System.Windows.Forms.RadioButton();
            this.rbtnHebb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxInit
            // 
            this.picBoxInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBoxInit.Location = new System.Drawing.Point(371, 35);
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
            this.picBoxCropped.Location = new System.Drawing.Point(768, 35);
            this.picBoxCropped.Name = "picBoxCropped";
            this.picBoxCropped.Size = new System.Drawing.Size(320, 320);
            this.picBoxCropped.TabIndex = 1;
            this.picBoxCropped.TabStop = false;
            // 
            // btnClearInitPB
            // 
            this.btnClearInitPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearInitPB.Location = new System.Drawing.Point(392, 377);
            this.btnClearInitPB.Name = "btnClearInitPB";
            this.btnClearInitPB.Size = new System.Drawing.Size(285, 66);
            this.btnClearInitPB.TabIndex = 2;
            this.btnClearInitPB.Text = "Очистить";
            this.btnClearInitPB.UseVisualStyleBackColor = true;
            this.btnClearInitPB.Click += new System.EventHandler(this.btnClearInitPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(770, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Обрабатываемое изображение";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.Location = new System.Drawing.Point(53, 46);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(261, 45);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Классифицировать";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.compImageResolution);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(28, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пар-ры обрабатываемого изображения";
            // 
            // compImageResolution
            // 
            this.compImageResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compImageResolution.Items.Add("4;4");
            this.compImageResolution.Items.Add("6;6");
            this.compImageResolution.Items.Add("8;8");
            this.compImageResolution.Items.Add("12;12");
            this.compImageResolution.Items.Add("16;16");
            this.compImageResolution.Location = new System.Drawing.Point(36, 139);
            this.compImageResolution.Name = "compImageResolution";
            this.compImageResolution.Size = new System.Drawing.Size(189, 30);
            this.compImageResolution.TabIndex = 0;
            this.compImageResolution.Text = "4;4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сегментов по \"X;Y\":\r\n";
            // 
            // btnSaveSampleToFile
            // 
            this.btnSaveSampleToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveSampleToFile.Location = new System.Drawing.Point(798, 372);
            this.btnSaveSampleToFile.Name = "btnSaveSampleToFile";
            this.btnSaveSampleToFile.Size = new System.Drawing.Size(261, 71);
            this.btnSaveSampleToFile.TabIndex = 4;
            this.btnSaveSampleToFile.Text = "Сохранить в файл как образец";
            this.btnSaveSampleToFile.UseVisualStyleBackColor = true;
            this.btnSaveSampleToFile.Click += new System.EventHandler(this.btnSaveSampleToFile_Click);
            // 
            // btnAddToSamples
            // 
            this.btnAddToSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToSamples.Location = new System.Drawing.Point(798, 463);
            this.btnAddToSamples.Name = "btnAddToSamples";
            this.btnAddToSamples.Size = new System.Drawing.Size(261, 66);
            this.btnAddToSamples.TabIndex = 4;
            this.btnAddToSamples.Text = "Использовать как один из образцов";
            this.btnAddToSamples.UseVisualStyleBackColor = true;
            this.btnAddToSamples.Click += new System.EventHandler(this.btnAddToSamples_Click);
            // 
            // btnLoadSamplesFromFile
            // 
            this.btnLoadSamplesFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadSamplesFromFile.Location = new System.Drawing.Point(798, 545);
            this.btnLoadSamplesFromFile.Name = "btnLoadSamplesFromFile";
            this.btnLoadSamplesFromFile.Size = new System.Drawing.Size(261, 66);
            this.btnLoadSamplesFromFile.TabIndex = 6;
            this.btnLoadSamplesFromFile.Text = "Загрузить образцы из файла";
            this.btnLoadSamplesFromFile.UseVisualStyleBackColor = true;
            this.btnLoadSamplesFromFile.Click += new System.EventHandler(this.btnLoadSamplesFromFile_Click);
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbResult.Location = new System.Drawing.Point(1132, 35);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(320, 320);
            this.pbResult.TabIndex = 7;
            this.pbResult.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1127, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Похоже на";
            // 
            // labelResDesc
            // 
            this.labelResDesc.AutoSize = true;
            this.labelResDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResDesc.Location = new System.Drawing.Point(1145, 372);
            this.labelResDesc.Name = "labelResDesc";
            this.labelResDesc.Size = new System.Drawing.Size(0, 25);
            this.labelResDesc.TabIndex = 9;
            // 
            // showInputImage
            // 
            this.showInputImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInputImage.Location = new System.Drawing.Point(392, 463);
            this.showInputImage.Name = "showInputImage";
            this.showInputImage.Size = new System.Drawing.Size(285, 66);
            this.showInputImage.TabIndex = 10;
            this.showInputImage.Text = "Показать обрабатываемое изображение";
            this.showInputImage.UseVisualStyleBackColor = true;
            this.showInputImage.Click += new System.EventHandler(this.showInputImage_Click);
            // 
            // btnResetSamples
            // 
            this.btnResetSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetSamples.Location = new System.Drawing.Point(798, 635);
            this.btnResetSamples.Name = "btnResetSamples";
            this.btnResetSamples.Size = new System.Drawing.Size(261, 66);
            this.btnResetSamples.TabIndex = 11;
            this.btnResetSamples.Text = "Удалить сохранённые образцы";
            this.btnResetSamples.UseVisualStyleBackColor = true;
            this.btnResetSamples.Click += new System.EventHandler(this.btnResetSamples_Click);
            // 
            // rbthHamming
            // 
            this.rbthHamming.AutoSize = true;
            this.rbthHamming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbthHamming.Location = new System.Drawing.Point(25, 37);
            this.rbthHamming.Name = "rbthHamming";
            this.rbthHamming.Size = new System.Drawing.Size(183, 29);
            this.rbthHamming.TabIndex = 12;
            this.rbthHamming.TabStop = true;
            this.rbthHamming.Text = "Сеть Хэмминга";
            this.rbthHamming.UseVisualStyleBackColor = true;
            this.rbthHamming.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtnHebb
            // 
            this.rbtnHebb.AutoSize = true;
            this.rbtnHebb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnHebb.Location = new System.Drawing.Point(25, 72);
            this.rbtnHebb.Name = "rbtnHebb";
            this.rbtnHebb.Size = new System.Drawing.Size(141, 29);
            this.rbtnHebb.TabIndex = 13;
            this.rbtnHebb.TabStop = true;
            this.rbtnHebb.Text = "Сеть Хэбба";
            this.rbtnHebb.UseVisualStyleBackColor = true;
            this.rbtnHebb.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnHebb);
            this.groupBox2.Controls.Add(this.rbthHamming);
            this.groupBox2.Location = new System.Drawing.Point(28, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 154);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Используемая сеть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 739);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnResetSamples);
            this.Controls.Add(this.showInputImage);
            this.Controls.Add(this.labelResDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.btnLoadSamplesFromFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddToSamples);
            this.Controls.Add(this.btnSaveSampleToFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearInitPB);
            this.Controls.Add(this.picBoxCropped);
            this.Controls.Add(this.picBoxInit);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxInit;
        private System.Windows.Forms.PictureBox picBoxCropped;
        private System.Windows.Forms.Button btnClearInitPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown compImageResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveSampleToFile;
        private System.Windows.Forms.Button btnAddToSamples;
        private System.Windows.Forms.Button btnLoadSamplesFromFile;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResDesc;
        private System.Windows.Forms.Button showInputImage;
        private System.Windows.Forms.Button btnResetSamples;
        private System.Windows.Forms.RadioButton rbthHamming;
        private System.Windows.Forms.RadioButton rbtnHebb;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

