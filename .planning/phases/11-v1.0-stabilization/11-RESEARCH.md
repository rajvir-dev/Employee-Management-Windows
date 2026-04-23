# Phase 11 Research: v1.0 Stabilization

## Session Persistence (Profile Photo)
- **Problem**: Profile photo is lost on application restart.
- **Root Cause**: In `ProfileView.cs`, `LoadProfileAsync()` calls `SessionManager.SaveSession()` after updating `SessionManager.PhotoBase64` with the value from the API. If the API returns an empty `PhotoBase64` (e.g., if the user hasn't uploaded a photo in the current DB but has a local cached one, or if the API endpoint `api/employee/me` doesn't consistently return the photo), the local cache is overwritten with an empty string.
- **Evidence**: `ProfileView.cs:60-61` and `SessionManager.cs:97`.
- **Fix**: 
  - Update `ProfileView` to only overwrite the session photo if the API response contains data.
  - Implement a "Sync" logic that prefers the most recent data but doesn't clear the cache on null responses.

## Kanban Status Mapping
- **Problem**: Completed tasks occasionally disappear or fail to render in the correct column.
- **Root Cause**: `KanbanBoard.cs` uses a mix of `StatusId` and string-based comparisons (`"completed"`, `"done"`, etc.). If the API returns a status that doesn't exactly match these strings (e.g., "Finished" or a null Status with a StatusId other than 1-3), the task is ignored by the `if/else if` block and not added to any column.
- **Evidence**: `KanbanBoard.cs:70-81`.
- **Fix**: 
  - Standardize status mapping using a shared `TaskStatus` enum or helper.
  - Ensure the "Completed" column catches all terminal states (`StatusId == 3` or `IsCompleted == true`).
  - Add a fallback to the "Pending" column for any unmapped tasks so they aren't lost from view.

## Async Stability
- **Problem**: Potential race conditions during view initialization.
- **Root Cause**: `UserControl.OnLoad` is overridden as `async void`. If the control is disposed before the async call completes, it can cause "ObjectDisposedException" or UI thread blocking.
- **Fix**: 
  - Wrap `OnLoad` calls in `try/catch` and check `IsDisposed` before updating UI.
  - Use `Invoke` correctly for any background updates.
