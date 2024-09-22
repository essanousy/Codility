# Define the main project and test project directories
$mainProjectDir = "CodilityProject"
$testProjectDir = "CodilityTests"

# Function to create corresponding test folder and file
function Create-TestStructure {
    param (
        [string]$mainDir,
        [string]$testDir
    )

    # Get all directories and files in the main project directory
    $items = Get-ChildItem -Path $mainDir -Recurse

    foreach ($item in $items) {
        # Get the relative path of the item
        $relativePath = $item.FullName.Substring($mainProjectDir.Length + 1)

        if ($item.PSIsContainer) {
            # Create the corresponding directory in the test project
            $testDirPath = Join-Path $testProjectDir $relativePath
            if (-not (Test-Path $testDirPath)) {
                New-Item -ItemType Directory -Path $testDirPath
                Write-Output "Created directory: $testDirPath"
            }
        } else {
            # Create the corresponding test file in the test project
            $fileName = [System.IO.Path]::GetFileNameWithoutExtension($relativePath)
            $fileExtension = [System.IO.Path]::GetExtension($relativePath)
            $testFileName = "${fileName}Tests${fileExtension}"
            $testFilePath = Join-Path $testProjectDir (Join-Path ([System.IO.Path]::GetDirectoryName($relativePath)) $testFileName)
            if (-not (Test-Path $testFilePath)) {
                New-Item -ItemType File -Path $testFilePath
                Write-Output "Created file: $testFilePath"
            }
        }
    }
}

# Run the function to create the test structure
Create-TestStructure -mainDir $mainProjectDir -testDir $testProjectDir