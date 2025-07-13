# Jupyter Notebook with Python Virtual Environment and .NET Integration

This project demonstrates how to set up and use Jupyter notebooks with both Python and .NET kernels for queue simulation analysis.

## Setup Summary

### What's Installed
- **Python 3.12** in a virtual environment
- **Jupyter Lab and Jupyter Notebook**
- **Data Science Libraries**: NumPy, Pandas, Matplotlib, Seaborn
- **.NET Interactive** for C#, F#, and PowerShell integration
- **All kernels** are properly registered with Jupyter

### Available Kernels
- `python3` - Python 3 kernel
- `.net-csharp` - C# kernel
- `.net-fsharp` - F# kernel  
- `.net-powershell` - PowerShell kernel

## Getting Started

### 1. Activate the Virtual Environment
```powershell
cd "c:\Users\micha\source\repos\QueueSimulation"
.\venv\Scripts\Activate.ps1
```

### 2. Start Jupyter Lab
```powershell
jupyter lab
```

### 3. Start Jupyter Notebook (Classic)
```powershell
jupyter notebook
```

## Sample Notebooks

### 1. `python_example.ipynb`
- Basic Python data analysis
- Queue simulation data generation
- Data visualization with matplotlib and seaborn

### 2. `csharp_queue_simulation.ipynb`
- Pure C# queue simulation
- Object-oriented queue modeling
- Statistical analysis in C#

### 3. `mixed_python_dotnet.ipynb`
- **Demonstrates Python ↔ .NET integration**
- Python generates data → C# processes it → Python visualizes results
- Shows file-based data exchange between kernels
- Complete workflow example

## Key Features

### Python Capabilities
- Full data science stack (NumPy, Pandas, Matplotlib, Seaborn)
- Interactive data exploration
- Advanced visualization
- Machine learning ready (scikit-learn can be added)

### .NET Capabilities  
- C#, F#, and PowerShell support
- NuGet package integration
- Object-oriented modeling
- High-performance computation
- Strong typing and IntelliSense

### Integration Patterns
1. **File-based exchange**: JSON, CSV data sharing
2. **Sequential processing**: Python → .NET → Python workflow
3. **Specialized tasks**: Use each language for its strengths

## Common Commands

### Virtual Environment Management
```powershell
# Activate environment
.\venv\Scripts\Activate.ps1

# Deactivate environment
deactivate

# Install additional Python packages
pip install package-name
```

### Jupyter Commands
```powershell
# List available kernels
jupyter kernelspec list

# Start Jupyter Lab (recommended)
jupyter lab

# Start classic Jupyter Notebook
jupyter notebook

# Install new kernel
dotnet interactive jupyter install
```

### .NET Interactive Commands
```powershell
# Install .NET packages in notebook
#r "nuget: PackageName"

# Reference local assemblies
#r "path/to/assembly.dll"

# Load C# script files
#load "script.csx"
```

## Workflow Examples

### Data Analysis Workflow
1. **Python**: Data collection and initial exploration
2. **C#**: Complex business logic and processing
3. **Python**: Final visualization and reporting

### Queue Simulation Workflow
1. **Python**: Generate random arrival/service data
2. **C#**: Implement queue algorithms and statistics
3. **Python**: Create dashboards and reports

## Tips for Mixed Development

### Best Practices
- Use JSON for data exchange between kernels
- Keep data files in the project directory
- Document data formats clearly
- Use descriptive variable names across languages

### Performance Considerations
- Use .NET for CPU-intensive calculations
- Use Python for data manipulation and visualization
- Consider data size when choosing exchange format

### Debugging
- Test each kernel separately first
- Use print/Console.WriteLine for debugging
- Check file paths and permissions
- Verify JSON format when exchanging data

## Troubleshooting

### Virtual Environment Issues
```powershell
# If activation fails, try:
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser

# Then activate again:
.\venv\Scripts\Activate.ps1
```

### Kernel Issues
```powershell
# Reinstall .NET kernels if needed:
dotnet interactive jupyter install

# Refresh kernel list:
jupyter kernelspec list
```

### Package Issues
```powershell
# Upgrade pip:
python -m pip install --upgrade pip

# Install specific versions:
pip install numpy==1.21.0
```

## Next Steps

1. **Explore the sample notebooks** to understand the integration patterns
2. **Add more Python packages** as needed: `pip install scikit-learn plotly dash`
3. **Experiment with F# and PowerShell** kernels for different use cases
4. **Create your own queue simulation models** using both languages
5. **Build interactive dashboards** combining Python visualization with .NET backend logic

## Additional Resources

- [.NET Interactive Documentation](https://github.com/dotnet/interactive)
- [Jupyter Documentation](https://jupyter.org/documentation)
- [Python Data Science Handbook](https://jakevdp.github.io/PythonDataScienceHandbook/)
- [Queue Theory and Simulation](https://en.wikipedia.org/wiki/Queueing_theory)

Happy coding with Python and .NET in Jupyter! 🚀
