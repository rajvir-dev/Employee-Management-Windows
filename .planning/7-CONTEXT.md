# Phase 7 Context: Profile & Leave Management

## Implementation Decisions
- **Profile Data**: Fetched via `EmployeeService.GetProfileAsync()`.
- **Bio Update**: Triggered via a "Save" button in the bio section; uses `EmployeeService.UpdateProfileAsync()`.
- **Leave Request**: 
  - `LeaveType`: 0=Vacation, 1=Sick, 2=Other.
  - `Status`: 0=Pending, 1=Approved, 2=Rejected.
- **Leave Item Component**: A small horizontal row displaying `LeaveType`, `DateRange`, `Reason` (truncated), and `Status`.
- **SignalR integration**: `ProfileView` will subscribe to `SignalRService.Instance.OnNotificationReceived` (which includes leave updates) to trigger a refresh of the leave history.

## UI Components
- `Views/ProfileView` (UserControl)
- `Forms/LeaveRequestForm` (Form)
- `Components/LeaveItem` (UserControl)
