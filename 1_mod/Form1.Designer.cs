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
            this.SwitchButton = new System.Windows.Forms.Button();
            this.DrawFigureButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(769, 453);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(125, 23);
            this.SwitchButton.TabIndex = 1;
            this.SwitchButton.Text = "Переключить";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // DrawFigureButton
            // 
            this.DrawFigureButton.Location = new System.Drawing.Point(769, 503);
            this.DrawFigureButton.Name = "DrawFigureButton";
            this.DrawFigureButton.Size = new System.Drawing.Size(125, 23);
            this.DrawFigureButton.TabIndex = 2;
            this.DrawFigureButton.Text = "DrawFigure";
            this.DrawFigureButton.UseVisualStyleBackColor = true;
            this.DrawFigureButton.Click += new System.EventHandler(this.DrawFigureButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(426, 453);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Запуск";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(426, 503);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 640);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.DrawFigureButton);
            this.Controls.Add(this.SwitchButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.Button DrawFigureButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
    }
}

