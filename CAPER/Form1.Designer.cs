
namespace CAPER
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
            this.components = new System.ComponentModel.Container();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelBombCount = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.textBoxBomb = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(32, 46);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(238, 38);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "РАЗМЕР ПОЛЯ";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSize.Location = new System.Drawing.Point(276, 46);
            this.textBoxSize.Multiline = true;
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 38);
            this.textBoxSize.TabIndex = 1;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(32, 96);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(203, 71);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelBombCount
            // 
            this.labelBombCount.AutoSize = true;
            this.labelBombCount.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBombCount.Location = new System.Drawing.Point(497, 53);
            this.labelBombCount.Name = "labelBombCount";
            this.labelBombCount.Size = new System.Drawing.Size(205, 28);
            this.labelBombCount.TabIndex = 3;
            this.labelBombCount.Text = "Количество бомб";
            this.labelBombCount.Visible = false;
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCount.Location = new System.Drawing.Point(476, 104);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(226, 28);
            this.labelTotalCount.TabIndex = 4;
            this.labelTotalCount.Text = "Количество плиток";
            this.labelTotalCount.Visible = false;
            // 
            // textBoxBomb
            // 
            this.textBoxBomb.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBomb.Location = new System.Drawing.Point(719, 44);
            this.textBoxBomb.Multiline = true;
            this.textBoxBomb.Name = "textBoxBomb";
            this.textBoxBomb.ReadOnly = true;
            this.textBoxBomb.Size = new System.Drawing.Size(69, 49);
            this.textBoxBomb.TabIndex = 5;
            this.textBoxBomb.Visible = false;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.Location = new System.Drawing.Point(719, 104);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(69, 49);
            this.textBoxTotal.TabIndex = 6;
            this.textBoxTotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxBomb);
            this.Controls.Add(this.labelTotalCount);
            this.Controls.Add(this.labelBombCount);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Сапер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelBombCount;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.TextBox textBoxBomb;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

