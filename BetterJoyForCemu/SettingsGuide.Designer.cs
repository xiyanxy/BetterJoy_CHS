namespace BetterJoyForCemu {
    partial class SettingsGuide {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsGuide));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mysettings = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "选取设置: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本编辑者: 曦颜XY  个人版本: 2.00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mysettings
            // 
            this.mysettings.FormattingEnabled = true;
            this.mysettings.Items.AddRange(new object[] {
            "**关于我**",
            "IP",
            "端口",
            "启用体感服务",
            "振动周期",
            "低频振动",
            "高频振动",
            "启用振动",
            "启用晃动输入",
            "晃动输入灵敏度",
            "晃动输入时间间隔",
            "交换AB键",
            "交换XY键",
            "陀螺仪模拟",
            "陀螺仪模拟敏感度",
            "清除影响设备",
            "清除白名单",
            "使用HIDG",
            "非原装手柄支持",
            "开启Home键LED灯",
            "陀螺仪使用Joycons或鼠标",
            "鼠标模拟陀螺仪敏感度",
            "通过按住或切换使用陀螺仪",
            "鼠标左陀螺仪",
            "鼠标拖动",
            "以XInput显示",
            "以DS4显示",
            "自动断开连接",
            "不使用时自动断开连接",
            "长按Home键断开连接"});
            this.mysettings.Location = new System.Drawing.Point(126, 83);
            this.mysettings.Name = "mysettings";
            this.mysettings.Size = new System.Drawing.Size(211, 28);
            this.mysettings.TabIndex = 3;
            this.mysettings.SelectedIndexChanged += new System.EventHandler(this.mysettings_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "设置说明: ";
            // 
            // settingsinfo
            // 
            this.settingsinfo.Location = new System.Drawing.Point(126, 130);
            this.settingsinfo.Multiline = true;
            this.settingsinfo.Name = "settingsinfo";
            this.settingsinfo.ReadOnly = true;
            this.settingsinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.settingsinfo.Size = new System.Drawing.Size(211, 131);
            this.settingsinfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "说明：原作者GitHub搜Davidobot，版权归他(除部分代码)";
            // 
            // SettingsGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 312);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.settingsinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mysettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置指南";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mysettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox settingsinfo;
        private System.Windows.Forms.Label label4;
    }
}
