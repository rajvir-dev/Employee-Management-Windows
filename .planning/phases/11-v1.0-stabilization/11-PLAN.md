---
wave: 1
depends_on: []
files_modified:
  - Core/SessionManager.cs
  - Views/KanbanBoard.cs
  - Views/ProfileView.cs
autonomous: true
---

# Phase 11 Plan: v1.0 Stabilization (Wave 1)

<tasks>
<task id="11-01-01">
<read_first>
- Views/ProfileView.cs
- Core/SessionManager.cs
</read_first>
<action>
Update `ProfileView.LoadProfileAsync` to only overwrite `SessionManager.PhotoBase64` if the API response is not null or empty.
Ensure that if a local photo exists but the API returns empty, the local photo is preserved.
</action>
<acceptance_criteria>
- Photo is not cleared from `session.json` when the profile is viewed but the API photo field is empty.
- Photo persists after application restart.
</acceptance_criteria>
</task>

<task id="11-01-02">
<read_first>
- Views/KanbanBoard.cs
</read_first>
<action>
Refactor the status mapping logic in `LoadTasks()`.
Add a fallback that puts any task with an unknown status into the "Pending" column instead of dropping it.
Ensure `IsCompleted` flag is checked for the "Completed" column.
</action>
<acceptance_criteria>
- All tasks returned by the API appear in at least one column.
- Tasks with `IsCompleted: true` consistently appear in the "Completed" column.
</acceptance_criteria>
</task>

<task id="11-01-03">
<read_first>
- Views/KanbanBoard.cs
- Views/ProfileView.cs
</read_first>
<action>
Add `if (this.IsDisposed) return;` checks after every `await` call in `OnLoad` and other async event handlers.
Wrap API calls in `try/catch` with user-friendly error messages that don't crash the app.
</action>
<acceptance_criteria>
- Switching tabs (switching views) rapidly does not cause `ObjectDisposedException`.
- API timeouts/errors are handled gracefully with a message box.
</acceptance_criteria>
</task>
</tasks>

<must_haves>
- Profile photo persistence is fixed.
- Kanban rendering is consistent for all tasks.
- App stability improved during navigation.
</must_haves>
