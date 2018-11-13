REM %1 is the solution directory (i.e. C:\...\OrbitSlackBot\)
REM %2 is the project directory (i.e. C:\...\OrbitSlackBot\Apteco.OrbitSlackBot.Core\)
REM %3 is the out directory (i.e. bin\Debug)
REM Note that %~1 is the same as %1 but it removes any enclosing quote marks

set SOLUTION_DIR=%~1
set PROJECT_DIR=%~2
set OUT_DIR=%~3

cd "%PROJECT_DIR%%OUT_DIR%"

del /f /s /q InstallerSources
rmdir /s /q InstallerSources
mkdir InstallerSources
mkdir InstallerSources\ProgramFiles

cd InstallerSources\ProgramFiles

xcopy /f "..\..\Apteco.*.dll" .
xcopy /f "..\..\OrbitSlackBot.exe" .
xcopy /f "..\..\Newtonsoft*.dll" .
xcopy /f "..\..\RestSharp*.dll" .
xcopy /f "..\..\SlackAPI*.dll" .

copy NUL ".\OrbitSlackBot.exe.config"
xcopy /f /y "%SOLUTION_DIR%Apteco.OrbitSlackBot.Service\Template.App.config" ".\OrbitSlackBot.exe.config"

xcopy /f "%SOLUTION_DIR%Apteco.OrbitSlackBot.Resources\Images\App.ico" .

copy NUL ".\InstallerBanner.bmp"
xcopy /f /y "%SOLUTION_DIR%Apteco.OrbitSlackBot.Resources\Images\InstallerBannerWix.bmp" ".\InstallerBanner.bmp"

copy NUL ".\InstallerDialog.bmp"
xcopy /f /y "%SOLUTION_DIR%Apteco.OrbitSlackBot.Resources\Images\InstallerDialogWix.bmp" ".\InstallerDialog.bmp"