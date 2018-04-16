namespace WaifuEx
{
    partial class WaifuExMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ModelDisplayButton = new System.Windows.Forms.Button();
            this.ModelHideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModelDisplayButton
            // 
            this.ModelDisplayButton.Location = new System.Drawing.Point(12, 201);
            this.ModelDisplayButton.Name = "ModelDisplayButton";
            this.ModelDisplayButton.Size = new System.Drawing.Size(75, 23);
            this.ModelDisplayButton.TabIndex = 0;
            this.ModelDisplayButton.Text = "显示助手";
            this.ModelDisplayButton.UseVisualStyleBackColor = true;
            this.ModelDisplayButton.Click += new System.EventHandler(this.ModelDisplayButton_Click);
            // 
            // ModelHideButton
            // 
            this.ModelHideButton.Location = new System.Drawing.Point(93, 201);
            this.ModelHideButton.Name = "ModelHideButton";
            this.ModelHideButton.Size = new System.Drawing.Size(75, 23);
            this.ModelHideButton.TabIndex = 1;
            this.ModelHideButton.Text = "隐藏助手";
            this.ModelHideButton.UseVisualStyleBackColor = true;
            this.ModelHideButton.Click += new System.EventHandler(this.ModelHideButton_Click);
            // 
            // WaifuExMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModelHideButton);
            this.Controls.Add(this.ModelDisplayButton);
            this.Name = "WaifuExMain";
            this.Text = "WaifuEx";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModelDisplayButton;
        private System.Windows.Forms.Button ModelHideButton;
    }
}

