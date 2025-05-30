namespace Практика_6._2_РКИС
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.engainBtnOn = new System.Windows.Forms.Button();
            this.fariBtnOn = new System.Windows.Forms.Button();
            this.tBInfa = new System.Windows.Forms.TextBox();
            this.engineBtnOff = new System.Windows.Forms.Button();
            this.fariBtnOff = new System.Windows.Forms.Button();
            this.fuelBtnOff = new System.Windows.Forms.Button();
            this.fuelBtnOn = new System.Windows.Forms.Button();
            this.statuseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-61, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // engainBtnOn
            // 
            this.engainBtnOn.BackColor = System.Drawing.Color.RosyBrown;
            this.engainBtnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engainBtnOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.engainBtnOn.Location = new System.Drawing.Point(344, 21);
            this.engainBtnOn.Name = "engainBtnOn";
            this.engainBtnOn.Size = new System.Drawing.Size(144, 53);
            this.engainBtnOn.TabIndex = 1;
            this.engainBtnOn.Text = "Вкл двигателя";
            this.engainBtnOn.UseVisualStyleBackColor = false;
            this.engainBtnOn.Click += new System.EventHandler(this.engainBtnOn_Click);
            // 
            // fariBtnOn
            // 
            this.fariBtnOn.BackColor = System.Drawing.Color.RosyBrown;
            this.fariBtnOn.Location = new System.Drawing.Point(494, 21);
            this.fariBtnOn.Name = "fariBtnOn";
            this.fariBtnOn.Size = new System.Drawing.Size(144, 53);
            this.fariBtnOn.TabIndex = 2;
            this.fariBtnOn.Text = "Вкл фары";
            this.fariBtnOn.UseVisualStyleBackColor = false;
            this.fariBtnOn.Click += new System.EventHandler(this.fariBtnOn_Click);
            // 
            // tBInfa
            // 
            this.tBInfa.BackColor = System.Drawing.Color.RosyBrown;
            this.tBInfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBInfa.Location = new System.Drawing.Point(1, 1);
            this.tBInfa.Multiline = true;
            this.tBInfa.Name = "tBInfa";
            this.tBInfa.Size = new System.Drawing.Size(323, 199);
            this.tBInfa.TabIndex = 4;
            this.tBInfa.TextChanged += new System.EventHandler(this.tBInfa_TextChanged);
            // 
            // engineBtnOff
            // 
            this.engineBtnOff.BackColor = System.Drawing.Color.RosyBrown;
            this.engineBtnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineBtnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.engineBtnOff.Location = new System.Drawing.Point(344, 80);
            this.engineBtnOff.Name = "engineBtnOff";
            this.engineBtnOff.Size = new System.Drawing.Size(144, 53);
            this.engineBtnOff.TabIndex = 5;
            this.engineBtnOff.Text = "Выкл двигателя";
            this.engineBtnOff.UseVisualStyleBackColor = false;
            this.engineBtnOff.Click += new System.EventHandler(this.engineBtnOff_Click);
            // 
            // fariBtnOff
            // 
            this.fariBtnOff.BackColor = System.Drawing.Color.RosyBrown;
            this.fariBtnOff.Location = new System.Drawing.Point(494, 80);
            this.fariBtnOff.Name = "fariBtnOff";
            this.fariBtnOff.Size = new System.Drawing.Size(144, 53);
            this.fariBtnOff.TabIndex = 6;
            this.fariBtnOff.Text = "Выкл фары";
            this.fariBtnOff.UseVisualStyleBackColor = false;
            this.fariBtnOff.Click += new System.EventHandler(this.fariBtnOff_Click);
            // 
            // fuelBtnOff
            // 
            this.fuelBtnOff.BackColor = System.Drawing.Color.RosyBrown;
            this.fuelBtnOff.Location = new System.Drawing.Point(644, 80);
            this.fuelBtnOff.Name = "fuelBtnOff";
            this.fuelBtnOff.Size = new System.Drawing.Size(144, 53);
            this.fuelBtnOff.TabIndex = 7;
            this.fuelBtnOff.Text = "Отключить подачу топлива";
            this.fuelBtnOff.UseVisualStyleBackColor = false;
            this.fuelBtnOff.Click += new System.EventHandler(this.fuelBtnOff_Click);
            // 
            // fuelBtnOn
            // 
            this.fuelBtnOn.BackColor = System.Drawing.Color.RosyBrown;
            this.fuelBtnOn.Location = new System.Drawing.Point(644, 21);
            this.fuelBtnOn.Name = "fuelBtnOn";
            this.fuelBtnOn.Size = new System.Drawing.Size(144, 53);
            this.fuelBtnOn.TabIndex = 8;
            this.fuelBtnOn.Text = "Подача топлива";
            this.fuelBtnOn.UseVisualStyleBackColor = false;
            this.fuelBtnOn.Click += new System.EventHandler(this.fuelBtnOn_Click);
            // 
            // statuseBtn
            // 
            this.statuseBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.statuseBtn.Location = new System.Drawing.Point(1, 206);
            this.statuseBtn.Name = "statuseBtn";
            this.statuseBtn.Size = new System.Drawing.Size(82, 53);
            this.statuseBtn.TabIndex = 9;
            this.statuseBtn.Text = "Статус";
            this.statuseBtn.UseVisualStyleBackColor = false;
            this.statuseBtn.Click += new System.EventHandler(this.statuseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statuseBtn);
            this.Controls.Add(this.fuelBtnOn);
            this.Controls.Add(this.fuelBtnOff);
            this.Controls.Add(this.fariBtnOff);
            this.Controls.Add(this.engineBtnOff);
            this.Controls.Add(this.tBInfa);
            this.Controls.Add(this.fariBtnOn);
            this.Controls.Add(this.engainBtnOn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button engainBtnOn;
        private System.Windows.Forms.Button fariBtnOn;
        private System.Windows.Forms.TextBox tBInfa;
        private System.Windows.Forms.Button engineBtnOff;
        private System.Windows.Forms.Button fariBtnOff;
        private System.Windows.Forms.Button fuelBtnOff;
        private System.Windows.Forms.Button fuelBtnOn;
        private System.Windows.Forms.Button statuseBtn;
    }
}

