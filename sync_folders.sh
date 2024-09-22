#!/bin/bash

# execute this command before running the script : chmod +x sync_folders.sh
# Define the main project and test project directories
mainProjectDir="./CodilityProject"
testProjectDir="./CodilityTests"

# Function to create corresponding test folder and file
create_test_structure() {
    local mainDir=$1
    local testDir=$2

    # Find all .cs files in the main project directory, excluding Program.cs and ignoring bin and obj folders
    find "$mainDir" -type d \( -name "bin" -o -name "obj" \) -prune -o -type f -name "*.cs" ! -name "Program.cs" -print | while read -r item; do
        # Get the relative path of the item
        relativePath="${item#$mainDir/}"

        # Create the corresponding test file in the test project
        fileName=$(basename "$relativePath" | sed 's/\(.*\)\..*/\1/')
        fileExtension="${relativePath##*.}"
        testFileName="${fileName}Tests.${fileExtension}"
        testFilePath="$testDir/$(dirname "$relativePath")/$testFileName"
        if [ ! -f "$testFilePath" ]; then
            mkdir -p "$(dirname "$testFilePath")"
            touch "$testFilePath"
            echo "Created file: $testFilePath"
        fi
    done
}

# Run the function to create the test structure
create_test_structure "$mainProjectDir" "$testProjectDir"