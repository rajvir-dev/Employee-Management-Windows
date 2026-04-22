# Requirements: EmployeeManagement_Windows

## High-Level Objective
Build a fully functional desktop client for the Employee Management API that allows employees to manage their tasks, profile, and leave requests with real-time notifications.

## Functional Requirements
1. **Authentication**:
   - Login with email/password.
   - JWT token storage in `SessionManager`.
   - Logout and session clearing.
2. **Dashboard**:
   - Navigation sidebar.
   - Top bar with user info and SignalR status.
   - Real-time notifications via SignalR and System Tray.
3. **Task Management**:
   - Kanban board (Pending, In Progress, Completed).
   - View task details, comments, and meetings.
   - Update task status and add comments.
4. **Profile Management**:
   - View personal details.
   - Update Bio and Photo.
5. **Leave Management**:
   - Request leaves.
   - View leave history and status.

## Non-Functional Requirements
- **Performance**: UI remains responsive during API calls.
- **Visuals**: Premium Dark Mode (Catppuccin Mocha).
- **Architecture**: Layered (UI -> Service -> Core -> Model).
