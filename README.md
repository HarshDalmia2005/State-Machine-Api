# State Machine API

A minimal ASP.NET Core Web API for defining and executing state machine workflows.

## Features

- Define workflow states and actions
- Start workflow instances
- Execute actions to transition between states
- In-memory storage for definitions and instances
- OpenAPI/Swagger documentation

## Getting Started

### 1. Clone the repository

```sh
git clone https://github.com/HarshDalmia2005/State-Machine-Api.git
cd State-Machine-Api/state_machine_api
```

### 2. Run the API

```sh
dotnet watch run
```

### 3. API Documentation

Visit [http://localhost:5122/swagger](http://localhost:5122/swagger) after starting the app.

## Folder Structure

```
state_machine_api/
├── Controllers/         # API endpoints
│   └── WorkflowController.cs
├── Models/              # Workflow data models
│   ├── Action.cs
│   ├── State.cs
│   ├── WorkflowDefinition.cs
│   └── WorkflowInstance.cs
├── Services/            # Business logic and workflow services
│   ├── IWorkflowService.cs
│   └── WorkflowService.cs
├── Storage/             # In-memory storage implementation
│   └── InMemoryStorage.cs
├── Properties/          # Project properties (launchSettings.json, etc.)
│   └── launchSettings.json
├── Program.cs           # Application entry point
├── state_machine_api.csproj
├── appsettings.json
├── appsettings.Development.json
└── state_machine_api.http
```

## Example API Usage

- **Create Definition:** `POST /api/workflow/definitions`
- **Start Instance:** `POST /api/workflow/instances`
- **Execute Action:** `POST /api/workflow/instances/{id}/actions/{actionId}`
- **Get Definition/Instance:** `GET /api/workflow/definitions/{id}` / `GET /api/workflow/instances/{id}`