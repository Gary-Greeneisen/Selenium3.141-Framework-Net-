@@echo off
REM filename RunMSTestCategory.cmd
Color 07

Set ProjectRootDir="C:\Projects\Selenium3.141-Framework(Net)"
Set TestResults="C:\Projects\Selenium3.141-Framework(Net)\TestResults"

set mstestPath="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE"

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
if Exist %TestResults%\TestResults.trx del %TestResults%\testResults.trx 

REM Run Tests Using MSTest
REM %mstestPath%\MSTest.exe /testcontainer:%TestRoot%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /category:GoogleSearchFeature /testsettings:%testSettingsFilename% /noisolation
REM %mstestPath%\MSTest.exe /testcontainer:%TestRoot%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /category:GoogleSearchFeature /testsettings:%testSettingsFilename% /resultsfile:testResults.trx
REM This did not work until I added the TestResults dir = /resultsfile:%TestRoot%\TestResults\testResults.trx
%mstestPath%\MSTest.exe /testcontainer:%ProjectRootDir%\AcceptanceTests\bin\Debug\AcceptanceTests.dll /category:GoogleSearchFeature /resultsfile:%TestResults%\testResults.trx /noisolation


:TestEnd
Set TIME=%TIME:~0,8%
If "%TIME:~0,1%"==" " Set TIM=0%TIME:~1,7%
Echo Test End Time: %TIME%
Echo.
:eof

REM ***************** Debug Msg *****************
REM pause
REM ***************** Debug Msg *****************
