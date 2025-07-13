# Software Development Workflow Queue Simulation

This project simulates and analyzes different software development workflows to understand their impact on team productivity, lead times, and overall efficiency. Using SimPy discrete event simulation, it models real-world scenarios including traditional PR workflows, AI-enhanced development, and pair programming.

## Overview

The simulation compares four development approaches:

- **Traditional PR Workflow** - Standard pull request review process
- **AI-Enhanced PR** - PR workflow with AI-assisted development
- **Pair Programming** - Real-time collaborative development
- **AI-Enhanced Pairs** - Pair programming with AI assistance

## Setup Summary

### What's Installed

- **Python 3.12+** in a virtual environment
- **Jupyter Lab and Jupyter Notebook**
- **Simulation Libraries**: SimPy for discrete event simulation
- **Data Science Stack**: NumPy, Pandas, Matplotlib, Seaborn
- **Statistical Analysis**: Comprehensive metrics and visualizations

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

## Simulation Notebook

### `workflow_queue_simulation.ipynb`

The main notebook contains a complete software development workflow simulation with:

- **Queue Theory Modeling** - SimPy-based discrete event simulation
- **Multiple Scenarios** - Traditional PR, AI-enhanced PR, pair programming, and AI-enhanced pairs
- **Realistic Parameters** - Based on industry research and best practices
- **Comprehensive Analysis** - Lead time trends, throughput metrics, and statistical comparisons
- **Professional Visualizations** - Charts and graphs for presenting results

## Key Simulation Features

### Realistic Modeling

- **Developer Defect Rates**: 30% for individual work, 18% for pair programming
- **AI Speed Enhancement**: 1.3x coding speed improvement
- **Rework Cycles**: Up to 3 cycles with diminishing defect rates
- **Context Switching**: 30-minute penalties for task switching
- **Queue Dynamics**: Realistic PR review bottlenecks

### Simulation Scenarios

1. **Traditional PR Workflow** (7 developers)
   - Individual development → PR submission → Review queue → Rework cycles
   - One dedicated reviewer, queue-based bottlenecks

2. **AI-Enhanced PR** (7 developers)
   - Same workflow with 1.3x coding speed
   - Reduced development time, same review process

3. **Pair Programming** (4 pairs = 8 developers)
   - Immediate commit with lower defect rates
   - No PR queue, immediate feedback cycles

4. **AI-Enhanced Pairs** (4 pairs = 8 developers)
   - Fastest coding with lowest defect rates
   - Combined benefits of AI and pairing

## Simulation Results

The notebook generates comprehensive analysis including:

- **Lead Time Comparison** - Average completion times across all scenarios
- **Throughput Analysis** - Total tickets completed per scenario  
- **Rework Statistics** - Average rework cycles and patterns
- **Queue Performance** - PR review bottlenecks and wait times
- **Trend Analysis** - Daily metrics and performance evolution
- **Statistical Significance** - Distribution analysis and confidence intervals

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
# Start Jupyter Lab (recommended)
jupyter lab

# Start classic Jupyter Notebook
jupyter notebook

# Install additional packages in the environment
pip install simpy matplotlib seaborn pandas numpy
```

## Key Insights from Simulation

The simulation reveals important findings about software development workflows:

### Lead Time Performance Ranking

1. **AI-Enhanced Pairs** - Fastest delivery with lowest defect rates
2. **Pair Programming** - Fast delivery with immediate feedback
3. **AI-Enhanced PR** - Moderate improvement over traditional approaches  
4. **Traditional PR** - Longest lead times due to queue bottlenecks

### Critical Factors

- **Queue Bottlenecks** - PR review queues significantly impact lead times
- **Context Switching** - Task switching penalties add substantial overhead
- **Defect Rates** - Pair programming dramatically reduces defects (18% vs 30%)
- **AI Enhancement** - Consistent 30% speed improvement across all scenarios

## Troubleshooting

### Virtual Environment Issues

```powershell
# If activation fails, try:
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser

# Then activate again:
.\venv\Scripts\Activate.ps1
```

### Package Issues

```powershell
# Upgrade pip:
python -m pip install --upgrade pip

# Install specific versions:
pip install simpy==4.0.1 pandas==1.5.0
```

## Next Steps

1. **Run the simulation** to see current results
2. **Experiment with parameters** - Adjust defect rates, team sizes, AI speed multipliers
3. **Add new scenarios** - Model other development approaches
4. **Extend the analysis** - Add cost analysis, quality metrics, or team satisfaction
5. **Create presentations** - Use the generated charts for stakeholder discussions

## Technical Architecture

### Simulation Components

- **SimPy Environment** - Discrete event simulation engine
- **Resource Queues** - PR review bottlenecks and capacity constraints  
- **Process Flows** - Developer workflows with realistic timing
- **Data Collection** - Metrics tracking and statistical analysis
- **Visualization** - Professional charts and trend analysis

### Data Model

- **Tickets** - Work items with creation, completion, and rework tracking
- **Developers** - Configurable AI enhancement and pairing capabilities
- **Scenarios** - Different workflow implementations with team structures
- **Metrics** - Daily tracking and summary statistics

## Additional Resources

- [SimPy Documentation](https://simpy.readthedocs.io/) - Discrete event simulation framework
- [Queue Theory](https://en.wikipedia.org/wiki/Queueing_theory) - Mathematical foundations
- [Pair Programming Research](https://www.computer.org/csdl/magazine/so/2000/03/s3032/13rRUygT7DO) - Academic studies on effectiveness
- [DevOps Research](https://www.devops-research.com/research.html) - Industry benchmarks and metrics

Happy simulating! 🚀📊
