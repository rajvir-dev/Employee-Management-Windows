# Phase 5 Context: Kanban Board

## Implementation Decisions
- **Container**: `UserControl` named `KanbanBoard` residing in `Views/` folder.
- **Layout**: `TableLayoutPanel` (1 Row, 3 Columns) with `Dock = Fill`. Each cell contains a `FlowLayoutPanel`.
- **Columns**:
  - Column 1: "Pending" (Status 1) - Yellow Accent.
  - Column 2: "In Progress" (Status 2) - Peach Accent.
  - Column 3: "Completed" (Status 3) - Green Accent.
- **Data Flow**: `LoadTasksAsync` is called on `Load` event. It uses `TaskService.GetMyTasksAsync()`.
- **Concurrency**: Use `Task.WhenAll` if multiple data sources were needed (not currently), but ensure `Invoke` is used when adding controls to the columns from the async callback.
- **Navigation**: Dashboard will listen to a custom event `TaskSelected` from the Kanban board to navigate to details.

## Dependencies
- `TaskService.cs` (Service Layer)
- `TaskCard.cs` (Component Layer)
- `MainDashboard.cs` (Shell Layer)
