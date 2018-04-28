﻿# LLHelper_AutoPlay
Use to play lovelive on virtual-android-device automatically  
  
这是一个在Win上使用安卓模拟器自动打歌的工具  
  

# 如何使用
准备:  
1.一台不算太差的电脑  
2.安卓模拟器(测试用的是蓝叠,目前仅在win10x64上做过测试)  
3.net framework 4.0  
4.winpcap: https://www.winpcap.org/install/default.htm

使用:  
1.在模拟器中添加9个虚拟按键(asdf空格hjkl)  
2.打开工具的监听与抓包,选择歌曲进入,等待工具下方文本框显示抓取谱面后,使用快捷键开始.  
快捷键:  
F6开始 F7停止 F8前移 F9后移

# 注意事项:  
1.需要提升管理员权限.  
2.如果没有历史数据,并且抓包失败,意味着打歌失败.(除非你真的能手动用键盘打完一首歌)  
3.`!!随机谱不会被保存下来,尽管随机谱歌曲会读取现有数据,但实质上它完全依靠抓包,使用请注意.`  
4.`仅支持日服.`  
5.有封号风险,祝君好运. 

# 目前打歌支持:
1.普通  
2.滑键  
3.AC  
4.传统  
5.SM  
6.CF  
7.协力  

# 视频教程
https://www.bilibili.com/video/av18586488/

# 关于图色打歌
(测试版)图色打歌工具需要先制作一张定位图(参照工具内的说明).使用前需要将打歌图标在设置中调整为第三种.为保证稳定性,需要将打歌速度调整为3速以下(建议3速).使用的时候直接在打歌前点击启动即可,F7停止.如果工具帧率小于40fps,不推荐使用.

# 其他
1.如果有什么bug,请直接在issues里提交,谢谢  
2.图色方式打歌没有想到什么好主意.目前采用的是dx屏幕截图,然后定点识别圆圈.如果你有什么好的主意或者别的方法,欢迎留言!
