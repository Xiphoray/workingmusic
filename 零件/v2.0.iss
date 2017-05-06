; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "workingmusic"
#define MyAppVersion "2.0"
#define MyAppPublisher "Xiphoray"
#define MyAppURL "https://github.com/Xiphoray"
#define MyAppExeName "workingmusic.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (�����µ�GUID����� ����|��IDE������GUID��)
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
LicenseFile=D:\project C#\workingmusic\workingmusic\���\lis.txt
OutputDir=D:\project C#\workingmusic\workingmusic\���
OutputBaseFilename=workingmusic V2.0
SetupIconFile=D:\project C#\workingmusic\workingmusic\���\icon.ico
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
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon


[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

