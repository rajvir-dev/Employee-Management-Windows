# Project: EmployeeManagement_Windows

## Context
A professional Windows Forms (.NET Framework 4.7.2) client for the EmployeeManagement_API. Designed with a modern, dark-themed UI (Catppuccin Mocha) and real-time capabilities via SignalR.

## Tech Stack
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms (WinForms)
- **Networking**: HttpClient (Singleton), Microsoft.AspNet.SignalR.Client
- **Serialization**: Newtonsoft.Json
- **Design System**: Catppuccin Mocha Dark Theme

## Standards
- **Async/Await**: Mandatory for all network operations.
- **Thread Safety**: Use `Invoke/BeginInvoke` for UI updates from background threads.
- **IDs**: Treat all API IDs (EmployeeId, TaskId, etc.) as opaque `string` types.
- **HttpClient**: Use the singleton `ApiClient`.
