using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterJoyForCemu {
    public partial class SettingsGuide : Form {
        public SettingsGuide() {
            InitializeComponent();
            mysettings.Text = "关于我";
            settingsinfo.Text = "欢迎使用(微博&Bilibili：曦颜XY)汉化定制优化的BetterJoy！有问题记得找我反馈(＾Ｕ＾)ノ~";
        }

        private void label2_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://weibo.com/xiyan1996");
        }

        private void mysettings_SelectedIndexChanged(object sender, EventArgs e) {
            if (mysettings.Text.Equals("IP")) {
                settingsinfo.Clear();
                settingsinfo.Text = "体感服务器IP：默认值为localhost；你可以将其更改为0.0.0.0（所有接口）或特定的LAN IP（如果要从网络中的另一台计算机访问服务器，也可用），默认: 127.0.0.1";
            }
            if (mysettings.Text.Equals("端口")) {
                settingsinfo.Clear();
                settingsinfo.Text = "体感服务器端口：默认为26760, 如果与电脑其他应用端口冲突，则将其设置为其他有效值，但也要相应地更改PadTest和cemuhook.ini中的端口";
            }
            if (mysettings.Text.Equals("启用体感服务")) {
                settingsinfo.Clear();
                settingsinfo.Text = "是否启用体感服务。 默认值：启用";
            }
            if (mysettings.Text.Equals("振动周期")) {
                settingsinfo.Clear();
                settingsinfo.Text = "以毫秒为单位的振动周期。较低意味着更细微的振动，较高则更稳重。振动响应不仅取决于此设置，始终都很高。默认值：300";
            }
            if (mysettings.Text.Equals("低频振动") || mysettings.Text.Equals("高频振动")) {
                settingsinfo.Clear();
                settingsinfo.Text = "手柄的HD振动设置用于低频/高频振动。更改以更改振动的声音调。注意：请勿将其设置在1200以上。默认值：低频40和高频120。若要使“更强”的振动声调，请尝试将低频/高频设置为160/320";
            }
            if (mysettings.Text.Equals("启用振动")) {
                settingsinfo.Clear();
                settingsinfo.Text = "是否启用振动。 默认值：启用";
            }
            if (mysettings.Text.Equals("启用晃动输入")) {
                settingsinfo.Clear();
                settingsinfo.Text = "当晃动手柄时启用输入，此功能目前仅用于DS4手柄，用于代替触摸板输入(DirectInput上的按钮13)";
            }
            if (mysettings.Text.Equals("晃动输入灵敏度")) {
                settingsinfo.Clear();
                settingsinfo.Text = "晃动检测灵敏度，默认值:10";
            }
            if (mysettings.Text.Equals("晃动输入时间间隔")) {
                settingsinfo.Clear();
                settingsinfo.Text = "晃动输入以毫秒为单位多久时间间隔运行，这个值不要低于15";
            }
            if (mysettings.Text.Equals("交换AB键")) {
                settingsinfo.Clear();
                settingsinfo.Text = "交换AB按钮；如果启用，则通过按钮名称而不是物理布局模拟（一半）Xbox布局";
            }
            if (mysettings.Text.Equals("交换XY键")) {
                settingsinfo.Clear();
                settingsinfo.Text = "交换XY按钮；如果启用，则通过按钮名称而不是物理布局模拟（一半）Xbox布局";
            }
            if (mysettings.Text.Equals("陀螺仪模拟")) {
                settingsinfo.Clear();
                settingsinfo.Text = "允许使用陀螺仪倾斜来完全控制滑块值（大触发器）, 适用于Switch Pro手柄和Joycons（Switch Pro手柄-组合触发器，Joycons-单独倾斜）";
            }
            if (mysettings.Text.Equals("陀螺仪模拟敏感度")) {
                settingsinfo.Clear();
                settingsinfo.Text = "改为-20可更改倾斜方向。如果向上，则表示上";
            }
            if (mysettings.Text.Equals("清除影响设备")) {
                settingsinfo.Clear();
                settingsinfo.Text = "确定程序是否应该在退出时清除受影响的设备列表。应该解决在程序后出现手柄无法使用的更多问题（可以阅读README.md也可以解决此问题）,默认：启用";
            }
            if (mysettings.Text.Equals("清除白名单")) {
                settingsinfo.Clear();
                settingsinfo.Text = "确定在启动时HidGuardian的进程白名单是否被清除。默认：启用";
            }
            if (mysettings.Text.Equals("使用HIDG")) {
                settingsinfo.Clear();
                settingsinfo.Text = "例如，如果同时使用Citra和Steam，可以关闭此项和 '以XInput显示' 项。如果你想让BetterJoy与Steam(或其他程序)无冲突，请查看HIDGuardian和Steam的wiki页面";
            }
            if (mysettings.Text.Equals("非原装手柄支持")) {
                settingsinfo.Clear();
                settingsinfo.Text = "确定是否启用对第三方手柄的支持。开启此项将显示“校准”按钮";
            }
            if (mysettings.Text.Equals("开启Home键LED灯")) {
                settingsinfo.Clear();
                settingsinfo.Text = "保持Switch Pro手柄HOME键LED环形灯一直亮着";
            }
            if (mysettings.Text.Equals("陀螺仪使用Joycons或鼠标")) {
                settingsinfo.Clear();
                settingsinfo.Text = "将陀螺仪运作方式改为 joycons操纵杆（文本框填入joy（未实现）或鼠标操控（文本框填入mouse），或者不使用此功能（文本框填入none）";
            }
            if (mysettings.Text.Equals("鼠标模拟陀螺仪敏感度")) {
                settingsinfo.Clear();
                settingsinfo.Text = "鼠标陀螺仪操作的敏感度";
            }
            if (mysettings.Text.Equals("通过按住或切换使用陀螺仪")) {
                settingsinfo.Clear();
                settingsinfo.Text = "勾选此设置将以按住按键方式激活使用陀螺仪，不勾选就是通过切换按键方式激活使用陀螺仪。如果使用的是手柄，一般默认勾选别管";
            }
            if (mysettings.Text.Equals("鼠标左陀螺仪")) {
                settingsinfo.Clear();
                settingsinfo.Text = "当两个joycon连接时，鼠标移动时，右joycon的陀螺仪运动。这个交换一下";
            }
            if (mysettings.Text.Equals("鼠标拖动")) {
                settingsinfo.Clear();
                settingsinfo.Text = "更改鼠标拖动行为。仅适用于被映射的鼠标按钮";
            }
            if (mysettings.Text.Equals("以XInput显示")) {
                settingsinfo.Clear();
                settingsinfo.Text = "确定程序是否将检测到的手柄以Xbox 360手柄识别";
            }
            if (mysettings.Text.Equals("以DS4显示")) {
                settingsinfo.Clear();
                settingsinfo.Text = "确定程序是否将检测到的手柄以DS4手柄识别";
            }
            if (mysettings.Text.Equals("自动断开连接")) {
                settingsinfo.Clear();
                settingsinfo.Text = "在程序退出时自动断开手柄连接";
            }
            if (mysettings.Text.Equals("不使用时自动断开连接")) {
                settingsinfo.Clear();
                settingsinfo.Text = "一段时间不使用后自动断开连接（以分钟为单位； -1表示禁用此功能）";
            }
            if (mysettings.Text.Equals("长按Home键断开连接")) {
                settingsinfo.Clear();
                settingsinfo.Text = "长时间按“截图”或“Home主页”按钮时，断开手柄连接（按2秒+）";
            }
            if (mysettings.Text.Equals("**关于我**")) {
                settingsinfo.Clear();
                settingsinfo.Text = "欢迎使用(微博&Bilibili：曦颜XY)汉化定制优化的BetterJoy！有问题记得找我反馈(＾Ｕ＾)ノ~";
            }
        }
    }
}
