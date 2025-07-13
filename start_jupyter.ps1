# Start Jupyter Lab with Python virtual environment and .NET kernels
Set-Location "c:\Users\micha\source\repos\QueueSimulation"

Write-Host "Activating Python virtual environment..." -ForegroundColor Green
& .\venv\Scripts\Activate.ps1

Write-Host "Starting Jupyter Lab..." -ForegroundColor Green
Write-Host "Available kernels:" -ForegroundColor Yellow
& jupyter kernelspec list

Write-Host "`nJupyter Lab will start on http://localhost:8888" -ForegroundColor Cyan
Write-Host "Press Ctrl+C to stop the server when done." -ForegroundColor Yellow

& jupyter lab --port=8888
