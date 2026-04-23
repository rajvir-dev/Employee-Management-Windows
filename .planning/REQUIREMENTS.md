# Requirements: EmployeeManagement_Windows

## High-Level Objective
Build a fully functional desktop client for the Employee Management API that allows employees to manage their tasks, profile, and leave requests with real-time notifications.

## Functional Requirements
1. **Authentication**:
   - Login with email/password. [ ] (Phase 11)
   - JWT token storage in `SessionManager`. [ ] (Phase 11)
   - Logout and session clearing. [ ] (Phase 3)
2. **Dashboard**:
   - Navigation sidebar. [ ] (Phase 3)
   - Top bar with user info and SignalR status. [ ] (Phase 12)
   - Real-time notifications via SignalR and System Tray. [ ] (Phase 3)
3. **Task Management**:
   - Kanban board (Pending, In Progress, Completed). [ ] (Phase 11)
   - View task details, comments, and meetings. [ ] (Phase 6)
   - Update task status and add comments. [ ] (Phase 6)
4. **Profile Management**:
   - View personal details. [ ] (Phase 7)
   - Update Bio and Photo. [ ] (Phase 7)
5. **Leave Management**:
   - Request leaves. [ ] (Phase 7)
   - View leave history and status. [ ] (Phase 7)

## Non-Functional Requirements
- **Performance**: UI remains responsive during API calls.
- **Visuals**: Premium Dark Mode (Catppuccin Mocha).
- **Architecture**: Layered (UI -> Service -> Core -> Model).
