
# PetStore API Tests with SpecFlow and NUnit

This project contains automated tests for the PetStore API, implemented using BDD-style scenarios with SpecFlow and NUnit. The tests cover various scenarios for managing pets in the PetStore, including adding, updating, retrieving, deleting pets, and searching for pets by status.

## Prerequisites

- .NET SDK 6.0 or higher
- Visual Studio 2022 or Visual Studio Code
- RestSharp, SpecFlow, NUnit NuGet packages

### Installed NuGet Packages

- `RestSharp`
- `SpecFlow`
- `SpecFlow.NUnit`
- `SpecFlow.Tools.MsBuild.Generation`
- `NUnit`
- `NUnit3TestAdapter`

## Getting Started

1. **Clone the repository** or download the project files.
2. Open the project in **Visual Studio** or **Visual Studio Code**.
3. Restore the necessary NuGet packages using the following command in the terminal:
   ```bash
   dotnet restore
   ```

## Running the Tests

### 1. Via Visual Studio:
   1. **Open the Project**: Launch Visual Studio and open your project.
   2. **Restore NuGet Packages**: Right-click on your solution in **Solution Explorer** and select **Restore NuGet Packages**.
   3. **Open Test Explorer**: Navigate to **Test > Test Explorer** from the top menu.
   4. **Run the Tests**: In the Test Explorer, click **Run All** to execute all the tests in the project.
   5. **View Test Results**: Test results will be displayed in the Test Explorer, with any failed tests highlighted in red.

### 2. Via Command Line:
   1. **Open a Terminal**: Open a terminal or command prompt in your project's root directory.
   2. **Restore NuGet Packages**: Run the following command:
      ```bash
      dotnet restore
      ```
   3. **Run the Tests**: Execute the tests using the following command:
      ```bash
      dotnet test
      ```
   4. **View Test Results**: The test results will be displayed in the terminal.




## Project Structure

- **Features/**: Contains SpecFlow feature files describing BDD scenarios.
- **StepDefinitions/**: Contains step definition files that implement the logic for the feature steps.
- **specflow.json**: Configuration file for SpecFlow, including plugin settings and report generation options.

## Step Definitions Overview

This project includes step definitions for various scenarios, such as:

1. **FindPetsByStatusFeature**:
   - `FindPetsByStatusAvailable`
   - `FindPetsByStatusSold`
   - `FindPetsByInvalidStatus`

2. **AddPetFeature**: Adds a new pet to the store.
3. **UpdatePetFeature**: Updates an existing pet's details.
4. **DeletePetFeature**: Deletes a pet from the store.
5. **UploadPetImageFeature**: Uploads an image for a pet.
6. **UpdatePetWithFormDataFeature**: Updates a pet's details using form data.


## Troubleshooting

- **Tests not running**: Ensure that the `specflow.json` configuration is correct, and that the necessary plugins (`SpecFlow.Tools.MsBuild.Generation`, `SpecFlow.NUnit`, etc.) are installed.
- **Tests not discovered**: Ensure that the SpecFlow and NUnit packages are correctly installed and the project is rebuilt. Restart Visual Studio if necessary.
- **Missing Step Definitions**: Ensure that the step definitions are implemented and linked to the corresponding feature files. Rebuild the solution if necessary.

## SpecFlow Reporting

### Step 1: Install LivingDoc CLI

Run the following command to install the LivingDoc CLI globally on your machine:

```bash
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```

### Step 2: Generate Living Documentation

Once the tests have been executed, you can generate the living documentation using the following command:

```bash
livingdoc test-assembly "Path\PetStoreApiTestsBDD.dll" -t "Path\TestExecution.json"
```

- Replace the paths with the appropriate paths to your `.dll` and `TestExecution.json` files.

### Viewing the Living Documentation

- After generating the documentation, open the `LivingDoc.html` file in your web browser to view the living documentation generated from your SpecFlow scenarios.

## Additional Notes

- Ensure that you have the SpecFlow extension installed in Visual Studio for better BDD support.
- Clean and rebuild the project if tests are not running as expected.

