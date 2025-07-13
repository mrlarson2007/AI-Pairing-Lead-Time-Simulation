@echo off
cd /d "c:\Users\micha\source\repos\QueueSimulation"
call .\venv\Scripts\Activate.ps1
jupyter lab --no-browser --port=8888
pause
