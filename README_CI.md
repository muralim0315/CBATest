
# Continuous Integration (CI) with GitHub Actions

This project includes a GitHub Actions workflow to automate the build, testing, and living documentation generation for your SpecFlow tests.

## CI Workflow Overview

The CI workflow is defined in the `.github/workflows/ci.yml` file. This workflow is triggered automatically on the following events:
- **Push**: The workflow runs whenever code is pushed to the `Murali-CBATest` branch.
- **Pull Request**: The workflow runs whenever a pull request is created or updated for the `Murali-CBATest` branch.

### Key Steps in the Workflow

1. **Checkout Code**: 
   - The workflow checks out your code from the repository to ensure that the runner has access to it.

2. **Set Up .NET Core**:
   - The workflow sets up the .NET Core environment using `actions/setup-dotnet@v2`. This step installs .NET SDK version 6.0.x.

3. **Install Dependencies**:
   - The workflow runs `dotnet restore` to install all the required NuGet packages.

4. **Build the Project**:
   - The workflow runs `dotnet build --no-restore` to build the project.

5. **Run Tests**:
   - The workflow runs `dotnet test --no-build --logger "trx;LogFileName=test_results.trx"` to execute the SpecFlow tests and save the results in a `.trx` file.

6. **Install SpecFlow.Plus.LivingDoc.CLI**:
   - The workflow installs the SpecFlow LivingDoc CLI tool using `dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`.

7. **Generate Living Documentation**:
   - The workflow runs `livingdoc test-assembly` to generate the SpecFlow Living Documentation from the test results.

8. **Upload Test Results**:
   - The workflow uploads the generated LivingDoc HTML report as an artifact using `actions/upload-artifact@v2`.

## How to Use the CI Workflow

1. **Push Code**: 
   - Push your changes to the `Murali-CBATest` branch, and the CI workflow will trigger automatically.

2. **Monitor Workflow**:
   - You can monitor the status of the workflow in the **Actions** tab of your GitHub repository.

3. **View Artifacts**:
   - After the workflow completes, download the test results and living documentation from the workflow run page.

## Workflow File Location

The CI workflow file is located at:
```
.github/workflows/ci.yml
```

Ensure that this file is correctly placed in your repository to enable the CI pipeline.

## Additional Information

- **Runs on**: The workflow runs on `ubuntu-latest`, which is the latest version of Ubuntu provided by GitHub as a hosted runner.
- **Triggers**: The workflow is triggered on `push` and `pull_request` events targeting the `Murali-CBATest` branch.

By using this CI setup, you can automate the process of building, testing, and generating documentation for your SpecFlow project.
