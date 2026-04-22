# Phase 7 Plan: Profile & Leave Management

## Objective
Implement a unified Identity and Leave management experience, allowing employees to manage their personal info and track their time-off requests.

## Context & Decisions
- **Profile Layout**: 
  - Top: Profile header with Avatar, Name, and Email.
  - Middle: Editable "Bio" section.
  - Bottom: "My Leaves" section with a history list.
- **Leave Request**: Modal dialog `LeaveRequestForm`.
- **Real-time**: Use `SignalRService` events to refresh the "My Leaves" list when status updates are received from the server.
- **Navigation**: Sidebar "Profile" button leads here.

## Agent Tasks (Phase 7)

### 🏗️ Winston (Architect)
- Wire the `SignalRService.OnLeaveStatusUpdated` event to a local refresh method in `ProfileView`.
- Ensure profile photos are handled as Base64 or URLs as per API capability.

### 🎨 Sally (UX)
- Design the `LeaveItem` component to use Catppuccin color coding for statuses (Yellow=Pending, Green=Approved, Red=Rejected).
- Add a "Loading..." placeholder for the leave history list.

### 💻 Amelia (Dev)
- **Step 1**: Create `Views/ProfileView.cs` and `Views/ProfileView.Designer.cs`.
- **Step 2**: Create `Forms/LeaveRequestForm.cs` and its designer.
- **Step 3**: Create `Components/LeaveItem.cs` for the history list.
- **Step 4**: Update `MainDashboard.cs` to enable the Profile button.

## Verification (Murat)
- [ ] **Verification 1**: Profile loads correct data for the currently logged-in user.
- [ ] **Verification 2**: "Request Leave" button opens the modal and successfully posts to the API.
- [ ] **Verification 3**: Leave status is accurately reflected in the history list (Approval/Rejection).
- [ ] **Verification 4**: SignalR connection remains stable during profile updates.
