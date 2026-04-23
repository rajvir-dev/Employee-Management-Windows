# Phase 07: Profile & Leave Management - Research

## Technical Assessment

### Existing Components
- **ProfileView.cs**: Mostly functional. Handles loading profile data and updating basic info.
- **LeaveHistoryView.cs**: Scaffolded. Loads leave history but needs polish.
- **LeaveRequestForm.cs**: Basic form for requesting leaves. Needs `LeaveType` integration.
- **LeaveItem.cs**: UI component for leave history rows.

### Gap Analysis
1. **LeaveType Property**: 
   - `07-CONTEXT.md` specifies `LeaveType` (0=Vacation, 1=Sick, 2=Other).
   - Current `LeaveDto` and `LeaveRequestDto` do NOT have this property.
   - Action: Update models and UI to include a dropdown for Leave Type.
2. **Theme Consistency**:
   - `ThemeColors.cs` currently uses a Light theme ("Modern SaaS Purple").
   - Requirement: "Premium Dark Mode (Catppuccin Mocha)".
   - Action: Revert or update `ThemeColors.cs` to dark mode values.
3. **SignalR Integration**:
   - `SignalRService.cs` lacks a specific `OnLeaveStatusUpdated` event.
   - Current implementation in `LeaveHistoryView.cs` uses a substring check on notification titles.
   - Action: Keep substring check for now or add explicit event if server supports it.

## Implementation Patterns

### Data Flow
- Profile: `EmployeeService.GetProfileAsync` -> `ProfileView`
- Leave List: `LeaveService.GetMyLeavesAsync` -> `LeaveHistoryView` -> `LeaveItem`
- Leave Request: `LeaveRequestForm` -> `LeaveService.RequestLeaveAsync`

### UI Updates
- Use `InvokeRequired` pattern for SignalR callbacks as per `project-context.md`.

## Validation Architecture

### Verification Strategy
- **Manual UI Testing**: Primary method for verifying WinForms components.
- **API Response Check**: Verify that `Success` flag is handled for all submissions.
- **State Consistency**: Profile header in Dashboard must update after `ProfileView` saves changes.

### Automated Checks (Mock)
- Check for file existence of new/updated components.
- Verify `ThemeColors` constants match dark mode palette.

## RESEARCH COMPLETE
