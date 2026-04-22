# Phase 5 Plan: Kanban Board Implementation

## Objective
Implement a professional 3-column Kanban board allowing employees to view and manage their tasks in real-time.

## Context & Decisions
- **Layout**: 1x3 `TableLayoutPanel` containing 3 `FlowLayoutPanel` columns (Pending, In Progress, Completed).
- **Refresh**: Initial Load + SignalR triggers + Manual Refresh button.
- **Interactions**: Swap Dashboard panel to TaskDetails view upon card click.
- **Movement**: Action buttons on `TaskCard` for rapid status transitions (Status 1 -> 2 -> 3).
- **Theme**: Catppuccin Mocha surface colors for columns and headers.

## Agent Tasks (Phase 5)

### 🏗️ Winston (Architect) - Infrastructure
- Ensure the `KanbanBoard` uses `TaskService` exclusively.
- Implement the "View Swap" event: `OnTaskSelected(TaskDto)`.

### 🎨 Sally (UX) - Visuals
- Create a header panel for each column with distinct accent colors (Yellow, Peach, Green).
- Ensure `FlowLayoutPanel` uses `AutoScroll = true`.

### 💻 Amelia (Dev) - Implementation
- **Step 1**: Create `Views/KanbanBoard.cs` and `Views/KanbanBoard.Designer.cs`.
- **Step 2**: Implement `LoadTasksAsync` method using `TaskService`.
- **Step 3**: Update `MainDashboard.cs` to handle navigation to the Kanban view.
- **Step 4**: Update `TaskCard.cs` with status update logic.

## Verification (Murat)
- [ ] **Verification 1**: Tasks with StatusId 1, 2, and 3 appear in the correct respective columns.
- [ ] **Verification 2**: Clicking "Move to In Progress" on a Pending task immediately updates the API and moves the card (or triggers a refresh).
- [ ] **Verification 3**: The UI remains responsive (no "Not Responding") while fetching 10+ tasks.
- [ ] **Verification 4**: SignalR events trigger a board refresh if a task is updated elsewhere.
