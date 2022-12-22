@echo off
copy D:\WORK\Vinamotor_Source_DT\Sm\CyberMayChamCong\cham_cong\cham_cong\Driver\*.dll %windir%\syswow64\

regsvr32.exe %windir%\syswow64\zkemkeeper.dll

exit