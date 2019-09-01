

rem copy assemblies to collection folder
copy "..\source\AddonSamples\bin\Debug\*.dll" ".\Samples\"

rem delete collection zip file
del "Samples\Samples.zip"

rem create new colllection zip file
c:
cd "Samples"
"c:\program files\7-zip\7z.exe" a "Samples.zip"
cd ..

rem upload to contensive application
c:
cd "Samples"
cc -a app20190821v51 --installFile "Samples.zip"
cd ..

rem iisreset

