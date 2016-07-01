@ECHO OFF
SET /P FILEPATH=Please enter source folder:
CLS

ECHO Files will be retrieved from folder: %FILEPATH% 

ECHO Moving ApplicationConfiguration.xml to Solution
COPY /Y "%~dp0\..\EuromoneyAutomationPackConfigFiles\%FILEPATH%\ApplicationConfiguration.xml" "%~dp0\EuromoneyAutomationPack\Configuration"
ECHO.
ECHO Moving PageControls.xml to Solution
COPY /Y "%~dp0\..\EuromoneyAutomationPackConfigFiles\%FILEPATH%\PageControls.xml" "%~dp0\PageObjects\GeneratedControls"
ECHO.
ECHO Files Moved. Happy Testing!
PAUSE


