@@echo off
REM filename RunMSTestName.cmd
Color 07

REM Set Environment Variables Used in the Batch File
Rem Set TargetDrive=C
REM Set TargetDir=Test1

Set ProjectRootDir="C:\Projects\Selenium3.141-Framework(Net)"
Set TestResults="C:\Projects\Selenium3.141-Framework(Net)\TestResults"

set mstestPath="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"

REM Switch To The Target Drive Location
REM %TargetDrive%:

REM MD %TargetDir%
Rem CD %TargetDir%
Echo.
echo Starting Test(s) in %ProjectRootDir%

rem Debug
pause

:StartTheTest
Set TIME=%TIME:~0,8%
Echo.
Echo Test Start Time: %TIME%
Echo.

REM Delete the previous Test Results file
if Exist %TestResults%\TestResults.trx del %TestResults%\testResults.trx 

REM Run Test Using MSTest
%mstestPath%\MSTest.exe /testcontainer:%ProjectRootDir%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /test:GoogleSearchFeature /resultsfile:%TestResults%\testResults.trx /noisolation
rem %mstestPath%\MSTest.exe /testcontainer:%ProjectRootDir%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /test:TestBrowserDrivers /resultsfile:%TestResults%\testResults.trx /noisolation


rem Debug
pause

:TestEnd
Set TIME=%TIME:~0,8%
If "%TIME:~0,1%"==" " Set TIM=0%TIME:~1,7%
Echo Test End Time: %TIME%
Echo.
:eof

REM ***************** Debug Msg *****************
REM pause
REM ***************** Debug Msg *****************
