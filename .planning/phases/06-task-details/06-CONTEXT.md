# Phase 6 Context: Task Details & Interactions

## Implementation Decisions
- **Current Task State**: The `TaskDetailsView` will be passed a `TaskDto` object on construction to avoid an immediate redundant API call for basic info.
- **Comments Fetch**: Only the comments will be fetched asynchronously on `Load`.
- **Comment Input**: Includes `CommentText` (string), `HoursWorked` (int), and `MinutesWorked` (int).
- **Meeting Request**: Requires `MeetingTitle` (string), `MeetingDateTime` (DateTime), `Description` (string), and optional time logging.
- **Refresh**: The comments list will be cleared and re-populated after every successful post.

## Navigation Flow
1. User clicks `TaskCard` in `KanbanBoard`.
2. `KanbanBoard` fires `OnTaskSelected`.
3. `MainDashboard` creates `TaskDetailsView` and swaps it in.
4. `TaskDetailsView` fires `OnBack` when user clicks back button.
5. `MainDashboard` swaps back to `KanbanBoard`.
