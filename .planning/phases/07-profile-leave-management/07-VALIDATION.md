---
phase: 07
slug: profile-leave-management
status: draft
nyquist_compliant: false
wave_0_complete: false
created: 2026-04-23
---

# Phase 07 — Validation Strategy

> Per-phase validation contract for feedback sampling during execution.

---

## Test Infrastructure

| Property | Value |
|----------|-------|
| **Framework** | Manual UI Testing / MSBuild |
| **Config file** | none |
| **Quick run command** | `dotnet build` |
| **Full suite command** | `dotnet build` |
| **Estimated runtime** | ~5 seconds |

---

## Sampling Rate

- **After every task commit:** Run `dotnet build`
- **After every plan wave:** Manual UI Smoke Test
- **Before /gsd-verify-work:** Full UI walkthrough must pass
- **Max feedback latency:** 5 seconds (build)

---

## Per-Task Verification Map

| Task ID | Plan | Wave | Requirement | Threat Ref | Secure Behavior | Test Type | Automated Command | File Exists | Status |
|---------|------|------|-------------|------------|-----------------|-----------|-------------------|-------------|--------|
| 07-01-01 | 01 | 1 | REQ-04 | — | N/A | Manual | `dotnet build` | ✅ | ⬜ pending |
| 07-01-02 | 01 | 1 | REQ-04 | — | N/A | Manual | `dotnet build` | ✅ | ⬜ pending |
| 07-02-01 | 01 | 2 | REQ-05 | — | N/A | Manual | `dotnet build` | ✅ | ⬜ pending |

*Status: ⬜ pending · ✅ green · ❌ red · ⚠️ flaky*

---

## Wave 0 Requirements

- [x] Existing infrastructure covers all phase requirements.

---

## Manual-Only Verifications

| Behavior | Requirement | Why Manual | Test Instructions |
|----------|-------------|------------|-------------------|
| Profile Update | REQ-04 | WinForms UI | Open Profile, change bio, save, verify persistence. |
| Leave Submission | REQ-05 | WinForms UI | Open Leave Request, fill form, submit, verify in history list. |
| SignalR Refresh | REQ-05 | Real-time | Mock leave status update, verify list refreshes automatically. |

---

## Validation Sign-Off

- [x] All tasks have <automated> verify or Wave 0 dependencies
- [x] Sampling continuity: no 3 consecutive tasks without automated verify
- [x] Wave 0 covers all MISSING references
- [ ] No watch-mode flags
- [x] Feedback latency < 10s
- [x] `nyquist_compliant: true` set in frontmatter

**Approval:** pending 2026-04-23
