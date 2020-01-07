namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도형SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.동그라미ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.별ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다중삼각형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직선ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.빨간색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.노란색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초록색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파란색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.굵게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.얇게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도형SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(267, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도형SToolStripMenuItem
            // 
            this.도형SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동그라미ToolStripMenuItem,
            this.사각형ToolStripMenuItem,
            this.별ToolStripMenuItem,
            this.다중삼각형ToolStripMenuItem,
            this.직선ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.빨간색ToolStripMenuItem,
            this.노란색ToolStripMenuItem,
            this.초록색ToolStripMenuItem,
            this.파란색ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.굵게ToolStripMenuItem,
            this.중간ToolStripMenuItem,
            this.얇게ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.종료ToolStripMenuItem});
            this.도형SToolStripMenuItem.Name = "도형SToolStripMenuItem";
            this.도형SToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.도형SToolStripMenuItem.Text = "도형(&S)";
            this.도형SToolStripMenuItem.Click += new System.EventHandler(this.도형SToolStripMenuItem_Click);
            // 
            // 동그라미ToolStripMenuItem
            // 
            this.동그라미ToolStripMenuItem.Checked = true;
            this.동그라미ToolStripMenuItem.CheckOnClick = true;
            this.동그라미ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.동그라미ToolStripMenuItem.Name = "동그라미ToolStripMenuItem";
            this.동그라미ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.동그라미ToolStripMenuItem.Text = "동그라미";
            this.동그라미ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.동그라미ToolStripMenuItem_CheckedChanged);
            // 
            // 사각형ToolStripMenuItem
            // 
            this.사각형ToolStripMenuItem.CheckOnClick = true;
            this.사각형ToolStripMenuItem.Name = "사각형ToolStripMenuItem";
            this.사각형ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.사각형ToolStripMenuItem.Text = "사각형";
            this.사각형ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.사각형ToolStripMenuItem_CheckedChanged);
            // 
            // 별ToolStripMenuItem
            // 
            this.별ToolStripMenuItem.CheckOnClick = true;
            this.별ToolStripMenuItem.Name = "별ToolStripMenuItem";
            this.별ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.별ToolStripMenuItem.Text = "별";
            this.별ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.별ToolStripMenuItem_CheckedChanged);
            // 
            // 다중삼각형ToolStripMenuItem
            // 
            this.다중삼각형ToolStripMenuItem.CheckOnClick = true;
            this.다중삼각형ToolStripMenuItem.Name = "다중삼각형ToolStripMenuItem";
            this.다중삼각형ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.다중삼각형ToolStripMenuItem.Text = "다중 삼각형";
            this.다중삼각형ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.다중삼각형ToolStripMenuItem_CheckedChanged);
            // 
            // 직선ToolStripMenuItem
            // 
            this.직선ToolStripMenuItem.CheckOnClick = true;
            this.직선ToolStripMenuItem.Name = "직선ToolStripMenuItem";
            this.직선ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.직선ToolStripMenuItem.Text = "직선";
            this.직선ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.직선ToolStripMenuItem_CheckedChanged);
            this.직선ToolStripMenuItem.Click += new System.EventHandler(this.직선ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // 빨간색ToolStripMenuItem
            // 
            this.빨간색ToolStripMenuItem.CheckOnClick = true;
            this.빨간색ToolStripMenuItem.Name = "빨간색ToolStripMenuItem";
            this.빨간색ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.빨간색ToolStripMenuItem.Text = "빨간색";
            this.빨간색ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.빨간색ToolStripMenuItem_CheckedChanged);
            // 
            // 노란색ToolStripMenuItem
            // 
            this.노란색ToolStripMenuItem.CheckOnClick = true;
            this.노란색ToolStripMenuItem.Name = "노란색ToolStripMenuItem";
            this.노란색ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.노란색ToolStripMenuItem.Text = "노란색";
            this.노란색ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.노란색ToolStripMenuItem_CheckedChanged);
            // 
            // 초록색ToolStripMenuItem
            // 
            this.초록색ToolStripMenuItem.CheckOnClick = true;
            this.초록색ToolStripMenuItem.Name = "초록색ToolStripMenuItem";
            this.초록색ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.초록색ToolStripMenuItem.Text = "초록색";
            this.초록색ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.초록색ToolStripMenuItem_CheckedChanged);
            // 
            // 파란색ToolStripMenuItem
            // 
            this.파란색ToolStripMenuItem.CheckOnClick = true;
            this.파란색ToolStripMenuItem.Name = "파란색ToolStripMenuItem";
            this.파란색ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.파란색ToolStripMenuItem.Text = "파란색";
            this.파란색ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.파란색ToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // 굵게ToolStripMenuItem
            // 
            this.굵게ToolStripMenuItem.CheckOnClick = true;
            this.굵게ToolStripMenuItem.Name = "굵게ToolStripMenuItem";
            this.굵게ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.굵게ToolStripMenuItem.Text = "굵게";
            this.굵게ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.굵게ToolStripMenuItem_CheckedChanged);
            // 
            // 중간ToolStripMenuItem
            // 
            this.중간ToolStripMenuItem.CheckOnClick = true;
            this.중간ToolStripMenuItem.Name = "중간ToolStripMenuItem";
            this.중간ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.중간ToolStripMenuItem.Text = "중간";
            this.중간ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.중간ToolStripMenuItem_CheckedChanged);
            // 
            // 얇게ToolStripMenuItem
            // 
            this.얇게ToolStripMenuItem.CheckOnClick = true;
            this.얇게ToolStripMenuItem.Name = "얇게ToolStripMenuItem";
            this.얇게ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.얇게ToolStripMenuItem.Text = "얇게";
            this.얇게ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.얇게ToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 264);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "20162872(김가람)";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도형SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 동그라미ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 별ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다중삼각형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 빨간색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 노란색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 초록색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파란색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 굵게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중간ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 얇게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

