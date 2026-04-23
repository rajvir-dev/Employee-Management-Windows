# Phase 6 Plan: Task Details & Interactions

## Objective
Enable employees to deep-dive into tasks, communicate through comments, and schedule collaborative meetings.

## Context & Decisions
- **View Type**: `UserControl` named `TaskDetailsView` in `Views/` folder.
- **Navigation**:
  - `OnBackClicked` event to notify `MainDashboard` to return to `KanbanBoard`.
  - Dashboard must handle the swap back to the existing or a new `KanbanBoard` instance.
- **Comments Display**: A `FlowLayoutPanel` named `flowComments` using `CommentItem` controls.
- **Meeting Form**: A modal `Form` named `ScheduleMeetingForm` for scheduling meetings.
- **Styling**: 
  - Comments from the current user should have a subtle highlight.
  - Timestamps formatted as "Time Ago".

## Agent Tasks (Phase 6)

### 🏗️ Winston (Architect)
- Ensure the `TaskDetailsView` receives a `TaskDto` or `encryptedId` upon initialization.
- Implement the "Back" event.

### 🎨 Sally (UX)
- Design the comment input area to be docked at the bottom of the details view.
- Ensure the meeting button is prominent but doesn't distract from the primary comment flow.

### 💻 Amelia (Dev)
- **Step 1**: Create `Views/TaskDetailsView.cs` and `Views/TaskDetailsView.Designer.cs`.
- **Step 2**: Create `Components/CommentItem.cs`.
- **Step 3**: Create `Forms/ScheduleMeetingForm.cs`.
- **Step 4**: Wire up the API calls in the "Post" and "Schedule" buttons.

## Verification (Murat)
- [ ] **Verification 1**: Navigating from Kanban to Details loads the correct task title and description.
- [ ] **Verification 2**: Posting a comment with "2 hours" logged correctly reflects in the API (verify via fresh fetch).
- [ ] **Verification 3**: Scheduling a meeting adds a new entry to the meetings list (Phase 7 related) or shows success.
