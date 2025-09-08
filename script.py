import os

# Get current working directory
current_dir = "F:\Db Connections POCs"
file_path = os.path.join(current_dir, "logs.txt")

# Return instead of print so UiPath can capture it
def run():
    with open(file_path, 'w') as f:
        f.write('Starting script! \n')
        f.write('Computing!\n')
        f.write('Finishing script!\n')
        result = 56 + 24
    return f"Happy Automation - UiPath - {result}"

run()
