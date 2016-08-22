# IE-ToolBar-BHO-C-
C# 实现的IE ToolBar, 
基础是如下项目。新增了DropDownList、Button 控件，增加了WebService服务。
http://www.codeproject.com/Articles/29215/Pretty-IE-Toolbar-in-C

在如下开发环境中
win7 64 旗舰版，visual studio Ultimate 2013, ie8
调试方法如下：

1 打开IEToolbarEngine 项目属性框，选择生成事件选项卡
2 在后期生成事件命令行中填写如下命令：

"C:\Program Files\Microsoft SDKs\Windows\v7.0A\bin\gacutil.exe" /u "$(TargetName)"

"C:\Program Files\Microsoft SDKs\Windows\v7.0A\bin\gacutil.exe" /f /i "$(TargetPath)"

"C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe" /unregister /codebase "$(TargetPath)"

"C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe" /codebase "$(TargetPath)"

3 查看 IEToolbarEngine 项目中 IEToolbarEngine.cs文件代码，找到如下代码，取消注释（代码中代码中注释代码中注释多，放开一处即可 ）

#if DEBUG
    Debugger.Launch();
#endif

或

System.Diagnostics.Debugger.Launch();

4 清理编译，重新生成调试方法
5 打开IEToolbarEngine，打开ie，会提示选择调试器，选择 IEToolbarEngine，即可单步调试。
