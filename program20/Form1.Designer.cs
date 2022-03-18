
namespace program20
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.timer.AnimationSpeed = 500;
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timer.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timer.InnerMargin = 2;
            this.timer.InnerWidth = -1;
            this.timer.Location = new System.Drawing.Point(205, 12);
            this.timer.MarqueeAnimationSpeed = 2000;
            this.timer.Name = "timer";
            this.timer.OuterColor = System.Drawing.Color.Gray;
            this.timer.OuterMargin = -25;
            this.timer.OuterWidth = 26;
            this.timer.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timer.ProgressWidth = 15;
            this.timer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.timer.Size = new System.Drawing.Size(250, 250);
            this.timer.StartAngle = 270;
            this.timer.SubscriptColor = System.Drawing.Color.Aqua;
            this.timer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.timer.SubscriptText = "";
            this.timer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.timer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.timer.SuperscriptText = "";
            this.timer.TabIndex = 0;
            this.timer.Text = "Timer";
            this.timer.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.timer.Value = 68;
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar timer;
    }
}

