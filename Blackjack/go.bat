@tools\nant\bin\NAnt.exe -buildfile:Blackjack.build %*
@if not %errorlevel% equ 0 pause
