# pokedex-api

## Getting Started

To run the pokedex-api project locally, follow these steps:

1. Clone the repository: `git clone git@github.com:kapaha/pokedex-api.git`
2. Navigate to the project directory: `cd pokedex-api`
3. Install project dependencies: `dotnet restore`

## Configuration

The Pokedex application requires a database connection string to connect to the underlying database. To securely manage the connection string, we use the [Secret Manager Tool](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=linux#how-the-secret-manager-tool-works).

### Setting Up Secrets

The connection string can be stored securely in the project's secrets store. Here's how to set it up:

1. Open a terminal or command prompt
2. Navigate to the project's root directory
3. Run the following command to set the Pokedex connection string:

```bash
dotnet user-secrets set "Pokedex:ConnectionString" "<your-connection-string>"
```
