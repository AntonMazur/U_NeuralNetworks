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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnClearInitPB.Location = new System.Drawing.Point(465, 361);
            this.btnClearInitPB.Name = "btnClearInitPB";
            this.btnClearInitPB.Size = new System.Drawing.Size(134, 47);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearInitPB);
            this.Controls.Add(this.picBoxCropped);
            this.Controls.Add(this.picBoxInit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCropped)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

