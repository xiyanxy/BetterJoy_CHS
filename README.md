<div align=center><img src="https://oscimg.oschina.net/oscnet/up-1xhr7zmon7atri87vn4j7fcouoltlpvh"/></div>

# BetterJoy v6.4α 非官方自定版本

提供任天堂Switch Pro手柄，Joycons，Switch SNES手柄与cemu(搭配Cemuhook), Citra，Dolphin，Yuzu以及系统范围通用的XInput支持。

允许使用陀螺仪控制鼠标并将特殊按钮（SL，SR，Capture）重新映射到您选择的按键。

# 原作者: [Davidobot](https://github.com/Davidobot)

#### 作者提醒
感谢您使用我的软件以及我得到的所有建设性反馈。 我开始写这个项目很久以前，从那时起，我就学到了很多有关编程和软件开发的知识。 我没有太多的时间来从事这个项目，但是我会尝试修复错误，如果它们出现的话。 也感谢您在这方面的耐心等待！

这真是一段疯狂的旅程，在GitHub上有近11万的官方下载，也许在午夜还会有更多。我认为这个项目给予我到目前为止得到的两个工作的帮助，所以我很自豪。

### 截图
![Example](https://wx3.sinaimg.cn/mw690/006advZlly1gjbxvhzcqlj30m10ou4am.jpg)

# 下载
去看看 [Releases栏](https://github.com/xiyanxy/BetterJoy_CHS/releases/)

# 如何使用
1. 安装驱动
    1. 阅读README.md
    1. 运行 *Drivers/ViGEmBus_Setup_1.16.116.exe*
2. 运行 *BetterJoyForCemu.exe*
3. 电脑连接你的手柄
4. 启动Cemu并确保CemuHook已选择手柄.
    1. 你如果使用的是Joycons, CemuHook会检测到俩手柄 - 每个都有所有的按钮，但是选择其中一个只是选择使用哪只手来控制陀螺仪。
5. 去cemu选项**输入设置**, 控制器API选择XInput并正常分配按钮.
    1. (忽略此项) 如果你因为某些原因不想这样做，只需要设置一个输入配置文件*Wii U Gamepad*作为控制器，并在 *GamePad motion source*下启用"也用于按钮/轴" . **版本3以不需要再去这样做**
    2. 如果你想要振动，调到70-80%。

* 从版本3开始，你可以使用Switch pro手柄和Joycons作为PC上的普通xbox手柄-用Steam试试

# 更多
请查看[WiKi](https://github.com/xiyanxy/BetterJoy_CHS/wiki)! 你会发现各种各样的优点，比如变更日志，应用程序设置的描述，常见问题和问题页面，以及如何让BetterJoy与Steam更好协同工作的信息.

# 连接/断开手柄连接(以Switch Pro手柄为例)
## 蓝牙模式
 * 比如按住Switch Pro手柄顶部配对小按钮5秒钟 - 这会使手柄进入广播扫描模式。
 * 在你的蓝牙设置中搜索并正常配对。
 * 要断开连接 - 按住主屏幕(Home)按钮（或截图按钮）2秒钟（或按顶部配对小按钮）。要重新连接 - 按下手柄上的任何按钮都可以。

## USB连接
 * 将手柄数据线插入计算机USB口.

## 移除手柄连接 \[Windows 10且以Switch Pro手柄为例]
1. 去"设置" -> "设备" -> "蓝牙和其他设备
2. 在"鼠标、键盘和笔" -> 有一个"Pro Controller"
3. 点击"Pro Controller"再点击"删除设备"

# 致谢
非常感谢[rajkosto](https://github.com/rajkosto/) 收到了17封电子邮件，并非常迅速地回复了我的愚蠢查询。UDP服务器也主要来自他的[ScpToolkit](https://github.com/rajkosto/ScpToolkit) 存储库

我也非常感谢[mfosse](https://github.com/mfosse/JoyCon-Driver) 向我指出正确的方向，并感谢[Looking-Glass](https://github.com/Looking-Glass/JoyconLib)， 没有他们我将无法解决任何问题。（在这里说明一下 - joycon代码是他的）

非常感谢[nefarius](https://github.com/ViGEm/ViGEmBus) 的的ViGEm项目！ 向*WiimoteHook*的创建者[Epigramx](https://github.com/epigramx)， 表示歉意和赞赏，他向我提供了驱动程序的想法，并让我继续使用他的批处理脚本，即使我未经许可使用了该脚本。感谢[MTCKC](https://github.com/MTCKC/ProconXInput) 提供灵感和批处理文件

最后感谢[dekuNukem](https://github.com/dekuNukem/Nintendo_Switch_Reverse_Engineering) 提供的文档，尤其是关于SPI校准数据和IMU传感器说明的文档

图标（已修改）：Chad Remsing通过[the Noun Project](http://thenounproject.com/) 重新设计 "[Switch Pro手柄](https://thenounproject.com/term/nintendo-switch/930119/)", "[
Switch左Joycon](https://thenounproject.com/remsing/uploads/?i=930115)", "[Switch右joycon](https://thenounproject.com/remsing/uploads/?i=930121)" 图标。 [Amy Alexander](https://www.linkedin.com/in/-amy-alexander/). 修改了Mark Davis从[the Noun Project](http://thenounproject.com/) 设计的[任天堂图标](https://thenounproject.com/themizarkshow/collection/vectogram/?i=193592)  图标
