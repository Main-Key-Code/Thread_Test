
namespace _TestThread
{
    partial class MainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.btnCreate = new System.Windows.Forms.Button();
            this.TxtBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.Location = new System.Drawing.Point(13, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Thread Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // TxtBoxLog
            // 
            this.TxtBoxLog.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBoxLog.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtBoxLog.ForeColor = System.Drawing.Color.White;
            this.TxtBoxLog.Location = new System.Drawing.Point(13, 55);
            this.TxtBoxLog.Name = "TxtBoxLog";
            this.TxtBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtBoxLog.Size = new System.Drawing.Size(1014, 383);
            this.TxtBoxLog.TabIndex = 1;
            this.TxtBoxLog.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(227, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Thread Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSuspend.Location = new System.Drawing.Point(441, 14);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(158, 23);
            this.btnSuspend.TabIndex = 0;
            this.btnSuspend.Text = "Thread Suspended";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResume.Location = new System.Drawing.Point(655, 14);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(158, 23);
            this.btnResume.TabIndex = 0;
            this.btnResume.Text = "Thread Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAbort.Location = new System.Drawing.Point(869, 14);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(158, 23);
            this.btnAbort.TabIndex = 0;
            this.btnAbort.Text = "Thread Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.TxtBoxLog);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestThread";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox TxtBoxLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnAbort;
    }
}

