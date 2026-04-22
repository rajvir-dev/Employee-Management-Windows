# Project Context: EmployeeManagement_Windows

## Overview
A professional Windows Forms (.NET Framework 4.7.2) client for the EmployeeManagement_API. Designed with a modern, dark-themed UI (Catppuccin Mocha) and real-time capabilities via SignalR.

## Technical Stack
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms (WinForms)
- **Networking**: HttpClient (Singleton), Microsoft.AspNet.SignalR.Client
- **Serialization**: Newtonsoft.Json
- **Design System**: Catppuccin Mocha Dark Theme

## Architecture (N-Tier Desktop)
1. **Forms**: Main container forms (Dashboard, Login).
2. **Components**: Reusable UserControls (TaskCard, SidebarItem).
3. **Services**: Domain logic wrapping API calls (AuthService, TaskService).
4. **Core**: Infrastructure (ApiClient, SessionManager, SignalRService).
5. **Models**: DTOs matching API contracts.
6. **Helpers**: UI utilities (ThemeColors, ImageHelper).

## Development Rules
- **Encrypted IDs**: The API uses URL-safe Base64 strings for IDs (EmployeeId, TaskId). These MUST be handled as `string` types in the WinForms client.
- **Thread Safety**: All SignalR events and background callbacks MUST use `Invoke/BeginInvoke` when touching the UI.
- **Async/Await**: Use Task-based asynchronous patterns for all network operations to prevent UI freezing.
- **Singleton Pattern**: Use a single `HttpClient` instance provided by `ApiClient.cs`.
- **Token Management**: JWT tokens are managed by `SessionManager` and automatically attached to requests by `ApiClient`.

## API Endpoints Reference
- Auth: `api/auth/login`, `api/auth/logout`
- Employee: `api/employee/me` (GET/PUT)
- Tasks: `api/task`, `api/task/{id}`, `api/task/{id}/status`, `api/task/{id}/comments`
- Leaves: `api/leave` (GET/POST/DELETE)
- Notifications: `api/notification`, `api/notification/{id}/read`
- SignalR Hub: `/hubs/notifications`
