---
wave: 1
depends_on: []
files_modified:
  - Models/LeaveDto.cs
  - Models/LeaveRequestDto.cs
  - Helpers/ThemeColors.cs
autonomous: true
---

# Phase 07 Plan: Profile & Leave Management (Wave 1)

<tasks>
<task id="07-01-01">
<read_first>
- Models/LeaveDto.cs
- Models/LeaveRequestDto.cs
</read_first>
<action>
Add the `LeaveType` property (int) to both `LeaveDto` and `LeaveRequestDto`.
In `LeaveDto`, add a `LeaveTypeName` helper property that returns "Vacation", "Sick", or "Other" based on the integer value.
</action>
<acceptance_criteria>
- `LeaveDto.cs` contains `public int LeaveType { get; set; }`
- `LeaveRequestDto.cs` contains `public int LeaveType { get; set; }`
- `LeaveDto.cs` contains `LeaveTypeName` property.
</acceptance_criteria>
</task>

<task id="07-01-02">
<read_first>
- Helpers/ThemeColors.cs
</read_first>
<action>
Update `ThemeColors.cs` to implement the "Catppuccin Mocha" Dark Mode palette defined in UI-SPEC.md.
Set `Background` to `#1e1e2e`, `Surface` to `#313244`, `TextPrimary` to `#cdd6f4`, `Primary` (Mauve) to `#cba6f7`, and `Danger` (Red) to `#f38ba8`.
Update the backward compatibility aliases (Base, Mantle, etc.) to match these new values.
</action>
<acceptance_criteria>
- `ThemeColors.cs` contains `Background = ColorTranslator.FromHtml("#1e1e2e")`
- `ThemeColors.cs` contains `Primary = ColorTranslator.FromHtml("#cba6f7")`
- Build passes.
</acceptance_criteria>
</task>
</tasks>

<must_haves>
- Models reflect the required `LeaveType` field.
- Visual theme matches the "Premium Dark Mode" requirement.
</must_haves>

---

---
wave: 2
depends_on: [07-01-01, 07-01-02]
files_modified:
  - Views/ProfileView.cs
  - Views/ProfileView.Designer.cs
  - Forms/LeaveRequestForm.cs
  - Forms/LeaveRequestForm.Designer.cs
autonomous: true
---

# Phase 07 Plan: Profile & Leave Management (Wave 2)

<tasks>
<task id="07-02-01">
<read_first>
- Views/ProfileView.cs
- Views/ProfileView.Designer.cs
</read_first>
<action>
Update `ProfileView` to match the Dark Mode theme. 
Ensure the "Save" button uses `ThemeColors.Primary`.
Verify all labels use `ThemeColors.TextPrimary` and multiline text boxes use `ThemeColors.Surface`.
</action>
<acceptance_criteria>
- `ProfileView` designer reflects dark theme colors.
- Bio section is editable and saves correctly.
</acceptance_criteria>
</task>

<task id="07-02-02">
<read_first>
- Forms/LeaveRequestForm.cs
- Forms/LeaveRequestForm.Designer.cs
</read_first>
<action>
Add a ComboBox for "Leave Type" to the `LeaveRequestForm`.
Populate it with "Vacation", "Sick", and "Other".
In `PopulateData()`, set the ComboBox index based on the `_existingLeave.LeaveType`.
Update `btnSubmit_Click` to include the selected `LeaveType` in the `LeaveRequestDto`.
Apply Dark Mode styles to the form components.
</action>
<acceptance_criteria>
- `LeaveRequestForm` contains a `cmbLeaveType` ComboBox.
- Selected `LeaveType` (0, 1, or 2) is sent to the API.
- Form background is `#1e1e2e`.
</acceptance_criteria>
</task>
</tasks>

<must_haves>
- Users can request leaves with a specific type.
- Profile view is aesthetically consistent with the dark theme.
</must_haves>

---

---
wave: 3
depends_on: [07-02-02]
files_modified:
  - Views/LeaveHistoryView.cs
  - Components/LeaveItem.cs
  - Components/LeaveItem.Designer.cs
autonomous: true
---

# Phase 07 Plan: Profile & Leave Management (Wave 3)

<tasks>
<task id="07-03-01">
<read_first>
- Components/LeaveItem.cs
- Components/LeaveItem.Designer.cs
</read_first>
<action>
Update `LeaveItem` to display the `LeaveTypeName`.
Apply the color-coded status badges as per UI-SPEC (Yellow=Pending, Green=Approved, Red=Rejected).
Update layout to match the "horizontal row" specification.
</action>
<acceptance_criteria>
- `LeaveItem` displays the leave type (e.g., "Vacation").
- Status badge colors match `ThemeColors.Warning/Success/Danger`.
</acceptance_criteria>
</task>

<task id="07-03-02">
<read_first>
- Views/LeaveHistoryView.cs
</read_first>
<action>
Update `LeaveHistoryView` styles for Dark Mode.
Ensure the `SignalR` callback for notifications triggers a thread-safe refresh of the leave history.
</action>
<acceptance_criteria>
- `LeaveHistoryView` background is `#1e1e2e`.
- Real-time refresh works without cross-thread exceptions.
</acceptance_criteria>
</task>
</tasks>

<must_haves>
- Leave history list displays all relevant request details.
- Real-time status updates are reflected visually.
</must_haves>
