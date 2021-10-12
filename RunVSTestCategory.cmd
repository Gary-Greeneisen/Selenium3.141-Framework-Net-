@@echo off
REM filename RunVSTestCategory.cmd
Color 07

Set ProjectRootDir="C:\Projects\Selenium3.141-Framework(Net)"
Set TestResults="C:\Projects\Selenium3.141-Framework(Net)\TestResults"

set vstestPath="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\Extensions\TestPlatform"


REM Switch To The Target Drive Location
rem %TargetDrive%:

REM MD %TargetDir%
rem CD %TargetDir%
Echo.
echo Starting Test(s) in %ProjectRootDir% 

:StartTheTest
Set TIME=%TIME:~0,8%
Echo.
Echo Test Start Time: %TIME%
Echo.

REM Delete the previous Test Results file
if Exist %TestResults%\*.trx del %TestResults%\*.trx 

REM Run Test Using VSTest
rem *****************************************************************************************
rem /TestCaseFilter:"TestCategory=GoogleSearchFeature" is the Feature name in Test Explorer
rem *****************************************************************************************
%vstestPath%\vstest.console.exe %ProjectRootDir%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /TestCaseFilter:"TestCategory=GoogleSearchFeature" /logger:trx;LogFileName=TestResults.trx /InIsolation


:TestEnd
Set TIME=%TIME:~0,8%
If "%TIME:~0,1%"==" " Set TIM=0%TIME:~1,7%
Echo Test End Time: %TIME%
Echo.
:eof

REM ***************** Debug Msg *****************
REM pause
REM ***************** Debug Msg *****************
