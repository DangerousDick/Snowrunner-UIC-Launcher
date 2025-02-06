:: set the path to snowrunner
set snowrunnerPath=C:\Program Files (x86)\Steam\steamapps\common\SnowRunner\Sources\Bin
:: launch snowrunner
start /d "%snowrunnerPath%" SnowRunner.exe
:: wait 5 seconds
timeout 5 > NUL
:: launch SRUIC
start /d "%snowrunnerPath%" SRUICInjector.exe
