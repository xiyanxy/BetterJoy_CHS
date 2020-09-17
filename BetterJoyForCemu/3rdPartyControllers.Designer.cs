namespace BetterJoyForCemu {
    partial class _3rdPartyControllers {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3rdPartyControllers));
            this.手柄列表 = new System.Windows.Forms.ListBox();
            this.自定义手柄列表 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.group_props = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseType = new System.Windows.Forms.ComboBox();
            this.btn_applyAndClose = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.lbl_all = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tip_device = new System.Windows.Forms.ToolTip(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.group_props.SuspendLayout();
            this.SuspendLayout();
            // 
            // 手柄列表
            // 
            this.手柄列表.FormattingEnabled = true;
            this.手柄列表.ItemHeight = 20;
            this.手柄列表.Location = new System.Drawing.Point(18, 41);
            this.手柄列表.Margin = new System.Windows.Forms.Padding(4);
            this.手柄列表.Name = "手柄列表";
            this.手柄列表.Size = new System.Drawing.Size(155, 344);
            this.手柄列表.TabIndex = 0;
            this.手柄列表.SelectedValueChanged += new System.EventHandler(this.list_allControllers_SelectedValueChanged);
            this.手柄列表.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_allControllers_MouseDown);
            // 
            // 自定义手柄列表
            // 
            this.自定义手柄列表.FormattingEnabled = true;
            this.自定义手柄列表.ItemHeight = 20;
            this.自定义手柄列表.Location = new System.Drawing.Point(253, 41);
            this.自定义手柄列表.Margin = new System.Windows.Forms.Padding(4);
            this.自定义手柄列表.Name = "自定义手柄列表";
            this.自定义手柄列表.Size = new System.Drawing.Size(163, 164);
            this.自定义手柄列表.TabIndex = 1;
            this.自定义手柄列表.SelectedValueChanged += new System.EventHandler(this.list_customControllers_SelectedValueChanged);
            this.自定义手柄列表.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_customControllers_MouseDown);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(181, 41);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "->";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(181, 172);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(63, 36);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "<-";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // group_props
            // 
            this.group_props.Controls.Add(this.label2);
            this.group_props.Controls.Add(this.chooseType);
            this.group_props.Location = new System.Drawing.Point(183, 219);
            this.group_props.Margin = new System.Windows.Forms.Padding(4);
            this.group_props.Name = "group_props";
            this.group_props.Padding = new System.Windows.Forms.Padding(4);
            this.group_props.Size = new System.Drawing.Size(233, 124);
            this.group_props.TabIndex = 4;
            this.group_props.TabStop = false;
            this.group_props.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "手柄类型:";
            // 
            // chooseType
            // 
            this.chooseType.FormattingEnabled = true;
            this.chooseType.Location = new System.Drawing.Point(83, 33);
            this.chooseType.Margin = new System.Windows.Forms.Padding(4);
            this.chooseType.Name = "chooseType";
            this.chooseType.Size = new System.Drawing.Size(139, 28);
            this.chooseType.TabIndex = 0;
            this.chooseType.SelectedValueChanged += new System.EventHandler(this.chooseType_SelectedValueChanged);
            // 
            // btn_applyAndClose
            // 
            this.btn_applyAndClose.Location = new System.Drawing.Point(183, 352);
            this.btn_applyAndClose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_applyAndClose.Name = "btn_applyAndClose";
            this.btn_applyAndClose.Size = new System.Drawing.Size(110, 36);
            this.btn_applyAndClose.TabIndex = 5;
            this.btn_applyAndClose.Text = "应用并关闭";
            this.btn_applyAndClose.UseVisualStyleBackColor = true;
            this.btn_applyAndClose.Click += new System.EventHandler(this.btn_applyAndClose_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(301, 352);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(115, 36);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "应用";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_all
            // 
            this.lbl_all.AutoSize = true;
            this.lbl_all.Location = new System.Drawing.Point(18, 17);
            this.lbl_all.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_all.Name = "lbl_all";
            this.lbl_all.Size = new System.Drawing.Size(99, 20);
            this.lbl_all.TabIndex = 7;
            this.lbl_all.Text = "全部可用设备";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "自定义手柄";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(181, 87);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(63, 77);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // _3rdPartyControllers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 401);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_applyAndClose);
            this.Controls.Add(this.lbl_all);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.group_props);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.自定义手柄列表);
            this.Controls.Add(this.手柄列表);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_3rdPartyControllers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加第三方手柄";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._3rdPartyControllers_FormClosing);
            this.group_props.ResumeLayout(false);
            this.group_props.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox 手柄列表;
        private System.Windows.Forms.ListBox 自定义手柄列表;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.GroupBox group_props;
        private System.Windows.Forms.Button btn_applyAndClose;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tip_device;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseType;
    }
}
