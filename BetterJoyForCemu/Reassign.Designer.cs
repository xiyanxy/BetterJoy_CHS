using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BetterJoyForCemu {
    // from https://stackoverflow.com/a/27173509
    public class SplitButton : Button {
        [DefaultValue(null), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ContextMenuStrip Menu { get; set; }

        [DefaultValue(20), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SplitWidth { get; set; }

        public SplitButton() {
            SplitWidth = 20;
        }

        protected override void OnMouseDown(MouseEventArgs mevent) {
            var splitRect = new Rectangle(this.Width - this.SplitWidth, 0, this.SplitWidth, this.Height);

            // Figure out if the button click was on the button itself or the menu split
            if (Menu != null &&
                ((mevent.Button == MouseButtons.Left &&
                splitRect.Contains(mevent.Location)) || mevent.Button == MouseButtons.Right)) {
                Menu.Tag = this;
                Menu.Show(this, 0, this.Height);    // Shows menu under button
            } else {
                base.OnMouseDown(mevent);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            base.OnPaint(pevent);

            if (this.Menu != null && this.SplitWidth > 0) {
                // Draw the arrow glyph on the right side of the button
                int arrowX = ClientRectangle.Width - 14;
                int arrowY = ClientRectangle.Height / 2 - 1;

                var arrowBrush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;
                var arrows = new[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
                pevent.Graphics.FillPolygon(arrowBrush, arrows);

                // Draw a dashed separator on the left of the arrow
                int lineX = ClientRectangle.Width - this.SplitWidth;
                int lineYFrom = arrowY - 4;
                int lineYTo = arrowY + 8;
                using (var separatorPen = new Pen(Brushes.DarkGray) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot }) {
                    pevent.Graphics.DrawLine(separatorPen, lineX, lineYFrom, lineX, lineYTo);
                }
            }
        }
    }

    partial class Reassign {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reassign));
            this.lbl_capture = new System.Windows.Forms.Label();
            this.lbl_home = new System.Windows.Forms.Label();
            this.lbl_sl_l = new System.Windows.Forms.Label();
            this.lbl_sr_l = new System.Windows.Forms.Label();
            this.lbl_sl_r = new System.Windows.Forms.Label();
            this.lbl_sr_r = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.tip_reassign = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_reset_mouse = new System.Windows.Forms.Label();
            this.lbl_activate_gyro = new System.Windows.Forms.Label();
            this.lbl_shake = new System.Windows.Forms.Label();
            this.btn_shake = new BetterJoyForCemu.SplitButton();
            this.btn_active_gyro = new BetterJoyForCemu.SplitButton();
            this.btn_reset_mouse = new BetterJoyForCemu.SplitButton();
            this.btn_sr_r = new BetterJoyForCemu.SplitButton();
            this.btn_sl_r = new BetterJoyForCemu.SplitButton();
            this.btn_sr_l = new BetterJoyForCemu.SplitButton();
            this.btn_sl_l = new BetterJoyForCemu.SplitButton();
            this.btn_home = new BetterJoyForCemu.SplitButton();
            this.btn_capture = new BetterJoyForCemu.SplitButton();
            this.SuspendLayout();
            // 
            // lbl_capture
            // 
            this.lbl_capture.AutoSize = true;
            this.lbl_capture.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_capture.Location = new System.Drawing.Point(35, 23);
            this.lbl_capture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_capture.Name = "lbl_capture";
            this.lbl_capture.Size = new System.Drawing.Size(39, 20);
            this.lbl_capture.TabIndex = 2;
            this.lbl_capture.Text = "截图";
            this.lbl_capture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home.Location = new System.Drawing.Point(35, 56);
            this.lbl_home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(39, 20);
            this.lbl_home.TabIndex = 4;
            this.lbl_home.Text = "主页";
            this.lbl_home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sl_l
            // 
            this.lbl_sl_l.AutoSize = true;
            this.lbl_sl_l.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sl_l.Location = new System.Drawing.Point(35, 88);
            this.lbl_sl_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sl_l.Name = "lbl_sl_l";
            this.lbl_sl_l.Size = new System.Drawing.Size(92, 20);
            this.lbl_sl_l.TabIndex = 6;
            this.lbl_sl_l.Text = "SL左Joycon";
            this.lbl_sl_l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sr_l
            // 
            this.lbl_sr_l.AutoSize = true;
            this.lbl_sr_l.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sr_l.Location = new System.Drawing.Point(35, 123);
            this.lbl_sr_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sr_l.Name = "lbl_sr_l";
            this.lbl_sr_l.Size = new System.Drawing.Size(94, 20);
            this.lbl_sr_l.TabIndex = 8;
            this.lbl_sr_l.Text = "SR左Joycon";
            this.lbl_sr_l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sl_r
            // 
            this.lbl_sl_r.AutoSize = true;
            this.lbl_sl_r.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sl_r.Location = new System.Drawing.Point(35, 158);
            this.lbl_sl_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sl_r.Name = "lbl_sl_r";
            this.lbl_sl_r.Size = new System.Drawing.Size(92, 20);
            this.lbl_sl_r.TabIndex = 10;
            this.lbl_sl_r.Text = "SL右Joycon";
            this.lbl_sl_r.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_sr_r
            // 
            this.lbl_sr_r.AutoSize = true;
            this.lbl_sr_r.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sr_r.Location = new System.Drawing.Point(35, 193);
            this.lbl_sr_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sr_r.Name = "lbl_sr_r";
            this.lbl_sr_r.Size = new System.Drawing.Size(94, 20);
            this.lbl_sr_r.TabIndex = 12;
            this.lbl_sr_r.Text = "SR右Joycon";
            this.lbl_sr_r.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(35, 340);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 30);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_apply.Location = new System.Drawing.Point(143, 340);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(117, 30);
            this.btn_apply.TabIndex = 14;
            this.btn_apply.Text = "确定并关闭";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_reset_mouse
            // 
            this.lbl_reset_mouse.AutoSize = true;
            this.lbl_reset_mouse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_reset_mouse.Location = new System.Drawing.Point(35, 228);
            this.lbl_reset_mouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reset_mouse.Name = "lbl_reset_mouse";
            this.lbl_reset_mouse.Size = new System.Drawing.Size(84, 20);
            this.lbl_reset_mouse.TabIndex = 16;
            this.lbl_reset_mouse.Text = "重置陀螺仪";
            this.lbl_reset_mouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_activate_gyro
            // 
            this.lbl_activate_gyro.AutoSize = true;
            this.lbl_activate_gyro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_activate_gyro.Location = new System.Drawing.Point(35, 263);
            this.lbl_activate_gyro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_activate_gyro.Name = "lbl_activate_gyro";
            this.lbl_activate_gyro.Size = new System.Drawing.Size(84, 20);
            this.lbl_activate_gyro.TabIndex = 17;
            this.lbl_activate_gyro.Text = "启用陀螺仪";
            this.lbl_activate_gyro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_shake
            // 
            this.lbl_shake.AutoSize = true;
            this.lbl_shake.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_shake.Location = new System.Drawing.Point(35, 298);
            this.lbl_shake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_shake.Name = "lbl_shake";
            this.lbl_shake.Size = new System.Drawing.Size(69, 20);
            this.lbl_shake.TabIndex = 20;
            this.lbl_shake.Text = "晃动输入";
            this.lbl_shake.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_shake
            // 
            this.btn_shake.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_shake.Location = new System.Drawing.Point(135, 295);
            this.btn_shake.Name = "btn_shake";
            this.btn_shake.Size = new System.Drawing.Size(125, 30);
            this.btn_shake.TabIndex = 19;
            this.btn_shake.UseVisualStyleBackColor = true;
            // 
            // btn_active_gyro
            // 
            this.btn_active_gyro.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_active_gyro.Location = new System.Drawing.Point(135, 260);
            this.btn_active_gyro.Name = "btn_active_gyro";
            this.btn_active_gyro.Size = new System.Drawing.Size(125, 30);
            this.btn_active_gyro.TabIndex = 18;
            this.btn_active_gyro.UseVisualStyleBackColor = true;
            // 
            // btn_reset_mouse
            // 
            this.btn_reset_mouse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset_mouse.Location = new System.Drawing.Point(135, 225);
            this.btn_reset_mouse.Name = "btn_reset_mouse";
            this.btn_reset_mouse.Size = new System.Drawing.Size(125, 30);
            this.btn_reset_mouse.TabIndex = 15;
            this.btn_reset_mouse.UseVisualStyleBackColor = true;
            // 
            // btn_sr_r
            // 
            this.btn_sr_r.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sr_r.Location = new System.Drawing.Point(135, 190);
            this.btn_sr_r.Name = "btn_sr_r";
            this.btn_sr_r.Size = new System.Drawing.Size(125, 30);
            this.btn_sr_r.TabIndex = 11;
            this.btn_sr_r.UseVisualStyleBackColor = true;
            // 
            // btn_sl_r
            // 
            this.btn_sl_r.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sl_r.Location = new System.Drawing.Point(135, 155);
            this.btn_sl_r.Name = "btn_sl_r";
            this.btn_sl_r.Size = new System.Drawing.Size(125, 30);
            this.btn_sl_r.TabIndex = 9;
            this.btn_sl_r.UseVisualStyleBackColor = true;
            // 
            // btn_sr_l
            // 
            this.btn_sr_l.Location = new System.Drawing.Point(135, 120);
            this.btn_sr_l.Name = "btn_sr_l";
            this.btn_sr_l.Size = new System.Drawing.Size(125, 30);
            this.btn_sr_l.TabIndex = 7;
            this.btn_sr_l.UseVisualStyleBackColor = true;
            // 
            // btn_sl_l
            // 
            this.btn_sl_l.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sl_l.Location = new System.Drawing.Point(135, 85);
            this.btn_sl_l.Name = "btn_sl_l";
            this.btn_sl_l.Size = new System.Drawing.Size(125, 30);
            this.btn_sl_l.TabIndex = 5;
            this.btn_sl_l.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_home.Location = new System.Drawing.Point(135, 50);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 30);
            this.btn_home.TabIndex = 3;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // btn_capture
            // 
            this.btn_capture.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_capture.Location = new System.Drawing.Point(135, 15);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(125, 30);
            this.btn_capture.TabIndex = 0;
            this.btn_capture.UseVisualStyleBackColor = true;
            // 
            // Reassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 390);
            this.Controls.Add(this.lbl_shake);
            this.Controls.Add(this.btn_shake);
            this.Controls.Add(this.btn_active_gyro);
            this.Controls.Add(this.lbl_activate_gyro);
            this.Controls.Add(this.lbl_reset_mouse);
            this.Controls.Add(this.btn_reset_mouse);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_sr_r);
            this.Controls.Add(this.btn_sr_r);
            this.Controls.Add(this.lbl_sl_r);
            this.Controls.Add(this.btn_sl_r);
            this.Controls.Add(this.lbl_sr_l);
            this.Controls.Add(this.btn_sr_l);
            this.Controls.Add(this.lbl_sl_l);
            this.Controls.Add(this.btn_sl_l);
            this.Controls.Add(this.lbl_home);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_capture);
            this.Controls.Add(this.btn_capture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reassign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "特殊按键映射";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reassign_FormClosing);
            this.Load += new System.EventHandler(this.Reassign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitButton btn_capture;
        private System.Windows.Forms.Label lbl_capture;
        private System.Windows.Forms.Label lbl_home;
        private SplitButton btn_home;
        private System.Windows.Forms.Label lbl_sl_l;
        private SplitButton btn_sl_l;
        private System.Windows.Forms.Label lbl_sr_l;
        private SplitButton btn_sr_l;
        private System.Windows.Forms.Label lbl_sl_r;
        private SplitButton btn_sl_r;
        private System.Windows.Forms.Label lbl_sr_r;
        private SplitButton btn_sr_r;
        private Button btn_close;
        private Button btn_apply;
        private System.Windows.Forms.ToolTip tip_reassign;
        private System.Windows.Forms.Label lbl_reset_mouse;
        private SplitButton btn_reset_mouse;
        private Label lbl_activate_gyro;
        private SplitButton btn_active_gyro;
        private Label lbl_shake;
        private SplitButton btn_shake;
    }
}
