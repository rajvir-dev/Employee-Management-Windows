# 🏗️ WinForms Implementation Plan: Employee Management System

As a Senior Architect, I have designed this blueprint to ensure your WinForms application is scalable, maintainable, and visually premium. This plan bridges your .NET 8 API with a robust .NET Framework desktop client.

---

## 1. 🧩 System Architecture

### Layered Design
*   **UI Layer**: Windows Forms and UserControls using `TableLayoutPanel` and `FlowLayoutPanel` for responsive-like behavior.
*   **Service Layer**: Handles business logic (e.g., calculating total hours worked, validating leave dates).
*   **API Client Layer**: A wrapper around `HttpClient` for typed requests and centralized error handling.
*   **Model Layer**: DTOs (Data Transfer Objects) matching your API structure and ViewModels for UI data binding.

### Folder Structure
```text
/EMS.Desktop
  /Components
    - TaskCard.cs (UserControl)
    - NotificationItem.cs (UserControl)
    - ShimmerLoader.cs
  /Core
    - ApiClient.cs (Singleton)
    - SessionManager.cs (JWT Storage)
    - SignalRService.cs
  /Forms
    - LoginForm.cs
    - MainDashboard.cs
    - TaskDetailPopup.cs
  /Models
    - EmployeeDto.cs
    - TaskDto.cs
  /Services
    - TaskService.cs
    - LeaveService.cs
```

---

## 2. 🖥️ Screen-by-Screen UI Plan

### 🔑 Login Form (`LoginForm.cs`)
*   **Controls**: `Bunifu` or standard `TextBox` (PasswordChar: `*`), `Button` (Submit), `Label` (Error feedback).
*   **User Flow**: 
    1. Enter Email/Password.
    2. API Call: `POST /api/auth/login`.
    3. Success: Store Token/EmployeeId in `SessionManager` -> Show `MainDashboard`.
*   **UX**: Show a `ProgressBar` (Marquee) during authentication.

### 🚀 Dashboard (`MainDashboard.cs`)
*   **Layout**: Sidebar (Navigation) + Main Panel (Dynamic Content).
*   **API Integration**: `GET /api/employee/me` on load to show name/photo in header.
*   **Feature**: Real-time Notification Badge in the top right.

### 📋 Task Board (`ucTaskBoard.cs`)
*   **Controls**: 3 `FlowLayoutPanel` (Pending, In Progress, Completed).
*   **Integration**: `GET /api/task`. Loop through results and add `TaskCard` control to the correct panel.
*   **Action**: Drag a card to another panel -> Trigger `PUT /api/task/{id}/status`.

---

## 3. 🔌 API Integration Strategy

### HttpClient Singleton
```csharp
public static class ApiClient {
    private static readonly HttpClient _client = new HttpClient();
    
    static ApiClient() {
        _client.BaseAddress = new Uri("https://your-api-url.com/");
    }

    public static async Task<T> GetAsync<T>(string endpoint) {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.Token);
        var response = await _client.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
    }
}
```

---

## 4. ⚡ Real-time Implementation (SignalR)

*   **Setup**: Use NuGet `Microsoft.AspNet.SignalR.Client`.
*   **Connection**:
    ```csharp
    var hubConnection = new HubConnection(BaseUrl);
    hubConnection.Headers.Add("Authorization", "Bearer " + token);
    var hubProxy = hubConnection.CreateHubProxy("NotificationHub");
    
    hubProxy.On<string>("ReceiveNotification", message => {
        dashboardForm.Invoke((MethodInvoker)delegate {
            ShowToast(message);
            UpdateNotificationCount();
        });
    });
    ```

---

## 🧱 Reusable Components

### TaskCard (UserControl)
*   **UI**: Panel with shadow, Labels for Title/Project, Status Badge.
*   **Events**: `Click` opens `TaskDetailPopup`.

---

## 🚀 Advanced Features

### ⏱️ Focus Mode Timer
*   **Logic**: A `Timer` control increments a `TimeSpan`.
*   **Integration**: On "Stop", open a modal with the pre-filled `hoursWorked` and `minutesWorked`. Send to `POST /api/task/{id}/comments`.

### 📂 Image Upload (Base64)
*   **Action**: `OpenFileDialog` -> `File.ReadAllBytes()` -> `Convert.ToBase64String()` -> `PUT /api/employee/me`.

---

## 🛠️ Implementation Roadmap

1.  **Step 1: Core Setup**: Create WinForms project (.NET 4.8), install `Newtonsoft.Json` and `SignalR.Client`.
2.  **Step 2: Security Layer**: Implement `ApiClient` and `SessionManager` for JWT handling.
3.  **Step 3: Auth Flow**: Build the `LoginForm` and test against the API.
4.  **Step 4: Infrastructure**: Set up the `MainDashboard` with a side navigation menu.
5.  **Step 5: Task Management**: Build `TaskCard` and the Kanban board.
6.  **Step 6: Real-time**: Add SignalR logic to the dashboard.

---

## ⚠️ Common Mistakes to Avoid

1.  **Threading**: Never update a Control from a background thread. Always use `control.InvokeRequired`.
2.  **HttpClient**: Do NOT wrap `HttpClient` in a `using` block. It will cause socket exhaustion.
3.  **Encrypted IDs**: The API returns strings for IDs (e.g., `XyZ123`). Pass these back exactly as-is to the API. Do not try to convert them to `long`.
