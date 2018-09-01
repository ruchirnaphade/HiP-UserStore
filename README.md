# HiP-UserStore

Microservice that manages user data including profile pictures.

## Development Environment Setup
For testing purposes, install & run Event Store and MongoDB on your local machine. Steps on Windows:

* [Download Event Store](https://eventstore.org/downloads/)
    * Run with `EventStore.ClusterNode.exe --db ./db --log ./logs`
    * For further information, see documentation: [Connecting to a Server](https://eventstore.org/docs/dotnet-api/4.0.0/connecting-to-a-server/), especially section "URIs"
* [Download MongoDB](https://www.mongodb.com/download-center?jmp=docs)
    * Run with `mongod.exe`
    * Default database path: `C:\data\db` (if installed on drive C:)
    * For further information, see documentation: [Install on Windows](https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/) and [The Mongo Shell](https://docs.mongodb.com/manual/mongo/)
* Configure the app
  * Create a file `appsettings.Development.json` in the same folder as `HiP-UserStore.csproj`
  * Specify valid values for "ClientId" and "ClientSecret" according to [appsettings.json](https://github.com/HiP-App/HiP-UserStore/blob/develop/HiP-UserStore/appsettings.json)
* Launch the app
  * via Visual Studio: Open the solution (*.sln) and run the app (F5)
  * via Terminal: Execute `dotnet run` from the project folder containing `HiP-UserStore.csproj`

The app is preconfigured to run on dev machines with minimal manual configuration (using the event store and Mongo database on `localhost`). See [appsettings.json](https://github.com/HiP-App/HiP-UserStore/blob/develop/HiP-UserStore/appsettings.json) for a list of configuration fields and their default values.
To be able to provide test values for local development, make a copy of the appsettings.json and rename it to `appsettings.Development.json` (see [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-2.1) for more information)
