namespace _1_mod
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Flag = new System.Windows.Forms.Button();
            this.drawfigure = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flag
            // 
            this.Flag.Location = new System.Drawing.Point(769, 453);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(125, 23);
            this.Flag.TabIndex = 1;
            this.Flag.Text = "Переключить";
            this.Flag.UseVisualStyleBackColor = true;
            this.Flag.Click += new System.EventHandler(this.Flag_Click);
            // 
            // drawfigure
            // 
            this.drawfigure.Location = new System.Drawing.Point(769, 503);
            this.drawfigure.Name = "drawfigure";
            this.drawfigure.Size = new System.Drawing.Size(125, 23);
            this.drawfigure.TabIndex = 2;
            this.drawfigure.Text = "DrawFigure";
            this.drawfigure.UseVisualStyleBackColor = true;
            this.drawfigure.Click += new System.EventHandler(this.drawfigure_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(426, 453);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 3;
            this.run.Text = "Запуск";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(426, 503);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 640);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.run);
            this.Controls.Add(this.drawfigure);
            this.Controls.Add(this.Flag);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Flag;
        private System.Windows.Forms.Button drawfigure;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop;
    }
}

