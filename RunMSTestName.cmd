@@echo off
REM filename RunMSTestName.cmd
Color 07

REM Set Environment Variables Used in the Batch File
Set TargetDrive=C
Set TargetDir=Test1

Set ProjectRoot="C:\Projects\Selenium3.141-Framework(Net)"
Set TestResults="C:\Projects\Selenium3.141-Framework(Net)\TestResults"

set mstestPath="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"

REM Switch To The Target Drive Location
%TargetDrive%:

REM MD %TargetDir%
CD %TargetDir%
Echo.
echo Starting Test(s) in %ProjectRoot%

:StartTheTest
Set TIME=%TIME:~0,8%
Echo.
Echo Test Start Time: %TIME%
Echo.

REM Run Test Using MSTest
REM Delete the previous Test Results file
if Exist %ProjectRoot% del %ProjectRoot%\testResults.trx 
REM %mstestPath%\MSTest.exe /testcontainer:%ProjectRoot%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /test:GoogleSearchFeature 
%mstestPath%\MSTest.exe /testcontainer:%ProjectRoot%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /test:GoogleSearchFeature /resultsfile:%TestResults%\testResults.trx


:TestEnd
Set TIME=%TIME:~0,8%
If "%TIME:~0,1%"==" " Set TIM=0%TIME:~1,7%
Echo Test End Time: %TIME%
Echo.
:eof

REM ***************** Debug Msg *****************
REM pause
REM ***************** Debug Msg *****************
