# APITestDockerExample

This is a simple API testing project using RestSharp and SpecFlow in C#, with Docker support.

## Prerequisites

- [Docker](https://www.docker.com/products/docker-desktop) installed on your machine.
- [Docker Compose](https://docs.docker.com/compose/install/) installed on your machine.
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) installed on your machine.

## Project Structure

- `Features/`: Contains SpecFlow feature files.
- `StepDefinitions/`: Contains step definition classes.
- `APITestDockerExample.csproj`: The project file for the .NET application.
- `Dockerfile`: The Dockerfile used to create a Docker image for the API tests.
- `docker-compose.yml`: The Docker Compose file used to run the Docker container.

## Running the Project with Docker

1. **Build the Docker image:**

   Open a terminal in the root of the project and run the following command:

   ```bash
   docker build -t api-csharp-tests .
   ```

2. **Run the Docker container:**

   After the image is built, you can run the container with:

   ```bash
   docker run api-csharp-tests
   ```

   This will execute the API tests inside the Docker container.

## Running the Project with Docker Compose

1. **Start the container using Docker Compose:**

   You can use Docker Compose to manage and run the container. In the root of the project, run:

   ```bash
   docker-compose up
   ```

   Docker Compose will build the image (if not already built) and start the container.

2. **Stopping the container:**

   To stop the container, run:

   ```bash
   docker-compose down
   ```

## Notes

- This project assumes you are testing APIs using RestSharp and SpecFlow.
- You can modify the feature files and step definitions to match your specific API testing requirements.

## Troubleshooting

- Ensure Docker is running before trying to build or run the containers.
- If you encounter issues with running the tests, ensure that your Docker environment is correctly set up and that the necessary dependencies are installed.
