@ECHO off
>output.tmp git describe --abbrev=0 --tags

<output.tmp (
  set /p line1=
)
echo %line1%