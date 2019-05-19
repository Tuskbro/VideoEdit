namespace TimeLine
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.axTimelineControl1 = new AxTimelineAxLib.AxTimelineControl();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTimelineControl1
            // 
            this.axTimelineControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTimelineControl1.Enabled = true;
            this.axTimelineControl1.Location = new System.Drawing.Point(0, 0);
            this.axTimelineControl1.Name = "axTimelineControl1";
            this.axTimelineControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTimelineControl1.OcxState")));
            this.axTimelineControl1.Size = new System.Drawing.Size(911, 367);
            this.axTimelineControl1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axTimelineControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(911, 367);
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxTimelineAxLib.AxTimelineControl axTimelineControl1;
    }
}
