; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "workingmusic"
#define MyAppVersion "2.0"
#define MyAppPublisher "Xiphoray"
#define MyAppURL "https://github.com/Xiphoray"
#define MyAppExeName "workingmusic.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{57E75110-8EB8-4BAA-876C-1762DA7B7FD3}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=D:\project C#\workingmusic\workingmusic\零件\lis.txt
OutputDir=D:\project C#\workingmusic\workingmusic\零件
OutputBaseFilename=workingmusic V2.0
SetupIconFile=D:\project C#\workingmusic\workingmusic\零件\icon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"
Name: "english"; MessagesFile: "compiler:Languages\English.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: checkablealone

[Files]
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\workingmusic.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\music\fire.mp4"; DestDir: "{app}\music"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\music\people.mp4"; DestDir: "{app}\music"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\music\rain.mp4"; DestDir: "{app}\music"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\music\thunder.mp4"; DestDir: "{app}\music"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\AxInterop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\project C#\workingmusic\workingmusic\workingmusic\bin\Release\Interop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon


[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

