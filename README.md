# Longest Increasing Subsequence

## Overview

This project implements a C# .NET solution to find the longest increasing
subsequence from a sequence of integers.

The input is provided as a single string containing integers separated by
single whitespace.

If multiple increasing subsequences have the same maximum length, the
earliest one is returned.

## Example

### Input

```text
6 1 5 9 2
Technology
C#
.NET 8
xUnit
GitHub Actions
Docker
Coverlet
ReportGenerator
Project Structure
LongestIncreasingSubsequence
│
├── Services
│   └── LongestIncreasingSubsequenceSolver.cs
│
├── Tests
│   └── LongestIncreasingSubsequence.Tests.csproj
│
├── Dockerfile
├── .dockerignore
├── .gitignore
├── LongestIncreasingSubsequence.slnx
└── Program.cs
Prerequisites

Install the following:

.NET 8 SDK
Docker Desktop
Git
Run Locally

Clone the repository:

git clone <YOUR_REPOSITORY_URL>
cd UUID

Restore dependencies:

dotnet restore

Build the solution:

dotnet build --configuration Release

Run the application:

dotnet run --project LongestIncreasingSubsequence

Enter the numbers when prompted.

Example:

Enter numbers: 6 1 5 9 2


Longest increasing sequence:
1 5 9
Run Unit Tests

Run all tests:

dotnet test --configuration Release

The test project contains test cases for validating the longest increasing
subsequence implementation.

Code Coverage

Run tests with code coverage:

dotnet test --collect:"XPlat Code Coverage"

The GitHub Actions workflow also generates the coverage report and uploads
the coverage artifact.

Code Formatting / Linting

The CI pipeline performs a code-format check using:

dotnet format --verify-no-changes

This ensures that the code follows the expected .NET formatting rules.

Docker

Build the Docker image locally:

docker build -t longest-increasing-subsequence .

Run the container:

docker run --rm -it longest-increasing-subsequence

Example:

Enter numbers: 10 9 2 5 3 7 101 18


Longest increasing sequence:
2 5 7 101
GitHub Actions CI

The project uses GitHub Actions for continuous integration.

The workflow is triggered when code is pushed to the master branch or when
a pull request targets the master branch.

The CI pipeline performs the following steps:

Checkout source code
Setup .NET 8
Check code formatting
Restore NuGet packages
Build the solution
Execute unit tests
Generate code coverage
Generate the coverage report
Upload the coverage report
Build the Docker image
Login to GitHub Container Registry
Push the Docker image to GHCR
Docker Image

The Docker image is published to GitHub Container Registry.

Pull the latest image:

docker pull ghcr.io/gitab12/uuid:latest

Run the image:

docker run --rm -it ghcr.io/gitab12/uuid:latest
Verification

The solution can be verified using the following steps:

1. Build
dotnet build --configuration Release

A successful build confirms that the application compiles correctly.

2. Test
dotnet test --configuration Release

All unit tests should pass.

3. Docker
docker build -t longest-increasing-subsequence .

Then:

docker run --rm -it longest-increasing-subsequence
4. GitHub Actions

Open the repository's Actions tab.

A successful CI run should show green checks for:

Build
Tests
Code formatting
Code coverage
Docker image build
Docker image push
5. Container Registry

The published Docker image can be verified under the repository's
Packages section.

The latest image should be available as:

ghcr.io/gitab12/uuid:latest
License

This project was created as part of a coding exercise.



### One important correction before you commit


Your repository is currently named **`UUID`**. The PDF says:


> "Create a public repository in GitHub where the repository name is a UUID." :contentReference[oaicite:1]{index=1}


So **`UUID` is probably not compliant** if they literally mean a UUID such as:


```text
550e8400-e29b-41d4-a716-446655440000

Don't rename it blindly yet, because your existing GitHub Actions/Docker package are already working. We should verify what they mean by UUID from the exercise wording before changing the repository.

Also, your README should not mention the company's name, because the PDF explicitly prohibits that.

Once you add README.md, do:

git add README.md
git commit -m "Add project documentation"
git push origin master

That push should trigger your CI again.
