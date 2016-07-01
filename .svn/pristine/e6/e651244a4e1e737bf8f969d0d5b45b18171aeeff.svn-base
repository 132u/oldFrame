@ECHO OFF
SET /P FILEPATH=Please enter destination folder:
CLS

ECHO Files will be retrieved from folder: %FILEPATH% 

ECHO Moving ApplicationConfiguration.xml back to Config file repo
COPY /-Y "%~dp0\EuromoneyAutomationPack\Configuration\ApplicationConfiguration.xml" "%~dp0\..\EuromoneyAutomationPackConfigFiles\%FILEPATH%" 
ECHO.
ECHO Moving PageControls.xml back to Config file repo
COPY /-Y "%~dp0\PageObjects\GeneratedControls\PageControls.xml" "%~dp0\..\EuromoneyAutomationPackConfigFiles\%FILEPATH%"
ECHO.
ECHO Files Moved. Happy Commit!
PAUSE


