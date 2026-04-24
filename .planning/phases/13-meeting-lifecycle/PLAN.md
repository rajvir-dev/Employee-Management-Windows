# Plan: Phase 13 - Meeting Lifecycle Management

## Objective
Implement Edit, Cancel, and Delete functionality for meeting cards in the Windows application. Functionality should be gated by meeting status, following MVC logic and leveraging API endpoints.

## Context
- **MVC Logic**: 
  - Edit/Cancel allowed only for `Scheduled` (21) and `Rescheduled` (25).
  - Delete allowed only for `Ongoing` (22), `Concluded` (23), and `Cancelled` (24).
- **Existing Files**:
  - `MeetingCard.cs`: UI component for individual meetings.
  - `TaskService.cs`: API communication layer.
  - `ScheduleMeetingForm.cs`: Form for creating meetings (to be updated for editing).
  - `TaskController.cs` (API): Needs update support.

## Tasks

### 1. API Enhancements
- [ ] **Task 1.1**: Add `UpdateMeeting` endpoint to `TaskController.cs` in `EmployeeManagement_API`.
- [ ] **Task 1.2**: Ensure `TaskRepository` and `ITaskRepository` support updating meetings.

### 2. Windows Service Layer
- [ ] **Task 2.1**: Update `TaskService.cs` with:
  - `CancelMeetingAsync(string encryptedId)`
  - `DeleteMeetingAsync(string encryptedId)`
  - `UpdateMeetingAsync(string encryptedTaskId, MeetingRequest meeting, string encryptedMeetingId)`

### 3. UI Component Updates
- [ ] **Task 3.1**: Add `btnEdit`, `btnCancel`, and `btnDelete` to `MeetingCard.Designer.cs`. Style them following the provided reference image (Purple for Edit/Cancel, Red for Delete).
- [ ] **Task 3.2**: Implement visibility logic in `MeetingCard.cs` `LoadData()` based on `StatusText` or `StatusId`.
- [ ] **Task 3.3**: Implement click event handlers in `MeetingCard.cs` to call `TaskService` and notify parent view.

### 4. Meeting Form Updates
- [ ] **Task 4.1**: Modify `ScheduleMeetingForm.cs` to accept a `CommentDto` for editing.
- [ ] **Task 4.2**: Update form title and button text based on mode (Schedule vs Update).
- [ ] **Task 4.3**: Implement Update logic in `btnSchedule_Click`.

### 5. View Integration
- [ ] **Task 5.1**: Ensure `MeetingListView.cs` handles refresh events from `MeetingCard`.

## Verification
- [ ] Verify `Edit` and `Cancel` buttons appear ONLY for Scheduled/Rescheduled meetings.
- [ ] Verify `Delete` button appears ONLY for Ongoing/Concluded/Cancelled meetings.
- [ ] Verify `Cancel` successfully updates status in database.
- [ ] Verify `Delete` successfully removes record.
- [ ] Verify `Edit` opens form with pre-filled data and saves changes correctly.
