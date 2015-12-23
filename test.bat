@ECHO off
>output.tmp git describe --abbrev=0 --tags

<output.tmp (
  set /p currenttag=
)

>branch.tmp git rev-parse --abbrev-ref HEAD
<branch.tmp (
	set /p storedbranch=
)

if %storedbranch%==master (
	set finalversion=%currenttag%
) else if %storedbranch%==develop (
	set finalversion=%currenttag%-dev
) else if %storedbranch:~0,7%==feature (
	set finalversion=%currenttag%-dev
) else if %storedbranch:~0,7%==release (
	set finalversion=%storedbranch:~8%-rc
) else if %storedbranch:~0,6%==hotfix (
	set finalversion=%storedbranch:~7%-rc
) else if %storedbranch:~0,7%==support (
	set finalversion=%currenttag%-%storedbranch:~8%
)
echo %finalversion%