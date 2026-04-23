# Phase 11 Validation Strategy: v1.0 Stabilization

## Automated Checks
- [ ] **Build Check**: Ensure project builds without errors after refactoring `SessionManager` and `KanbanBoard`.

## Manual Verification (UAT)

### 1. Profile Photo Persistence
- **Action**: Log in, upload a profile photo, save profile. Verify photo is visible.
- **Action**: Restart the application.
- **Success Criteria**: Photo is still visible in the Profile View without needing to re-upload.
- **Action**: View profile again (triggering `LoadProfileAsync`). Restart again.
- **Success Criteria**: Photo is still preserved in `session.json`.

### 2. Kanban Status Coverage
- **Action**: Trigger a "Refresh" on the Kanban board.
- **Success Criteria**: Check that the total count of tasks in all columns matches the total count returned by the API (verify via logs or debugger).
- **Action**: Complete a task.
- **Success Criteria**: Task moves to "Completed" column and stays there after refresh.

### 3. Navigation Stability (Rapid Switching)
- **Action**: Rapidly click between "Kanban Board", "My Profile", and "My Leaves" buttons.
- **Success Criteria**: No `ObjectDisposedException` or application crashes occur.

## Regression Testing
- Verify that "Logout" still correctly clears the session and returns the user to the login screen.
