# Migration Tasks: Newtonsoft.Json to System.Text.Json

**Scenario**: Migrate from Newtonsoft.Json to System.Text.Json in .NET 9 projects
**Solution**: C:\SRC\Library\Wibci.CountryReverseGeocode\CountryReverseGeocode.sln
**Target Project**: UnlockedData.CountryReverseGeocode.DataConversion
**Start Branch**: Update-project-to-.NET10

---

**Progress**: 4/8 tasks complete (50%) ![50%](https://progress-bar.xyz/50)

| Task | Status | Verified | Notes |
|------|--------|----------|-------|
| TASK-001 | [?] | - | Analyze Newtonsoft.Json usage |
| TASK-002 | [?] | - | Remove Newtonsoft.Json dependency |
| TASK-003 | [ ] | - | Add System.Text.Json using statements |
| TASK-004 | [?] | - | Migrate JsonConvert API calls |
| TASK-005 | [?] | - | Update JSON attributes |
| TASK-006 | [?] | - | Fix serialization issues |
| TASK-007 | [ ] | - | Test and validate |
| TASK-008 | [ ] | - | Commit migration changes |

---

## Detailed Tasks

### [?] TASK-001: Analyze Newtonsoft.Json Usage *(Completed: 2026-01-15 14:10)*

**Objective**: Identify all Newtonsoft.Json references and usage patterns

**Actions:**
- [?] (1) Search for "using Newtonsoft.Json" statements across all files
- [?] (2) Identify JsonConvert.SerializeObject() calls
- [?] (3) Identify JsonConvert.DeserializeObject<T>() calls
- [?] (4) Document JSON attributes used ([JsonProperty], [JsonIgnore], etc.)
- [?] (5) Create usage report

**Verification:**
- All Newtonsoft.Json usages documented
- Report includes file locations and line numbers

---

### [?] TASK-002: Remove Newtonsoft.Json Dependency

**Objective**: Remove Newtonsoft.Json NuGet package from affected projects

**Actions:**
- [ ] (1) Open UnlockedData.CountryReverseGeocode.DataConversion.csproj
- [ ] (2) Remove Newtonsoft.Json package reference (if present)
- [ ] (3) Save project file
- [ ] (4) Run dotnet restore to verify no Newtonsoft.Json references remain

**Verification:**
- Project file saved without Newtonsoft.Json references
- No restore errors reported
- Build succeeds without Newtonsoft.Json

---

### [ ] TASK-003: Add System.Text.Json Using Statements

**Objective**: Add necessary System.Text.Json imports to files using JSON serialization

**Actions:**
- [ ] (1) Add "using System.Text.Json" where needed
- [ ] (2) Add "using System.Text.Json.Serialization" where JSON attributes are used
- [ ] (3) Identify and document all files requiring these imports
- [ ] (4) Update imports in all affected code files

**Verification:**
- All files using JSON functionality have correct imports
- No compilation errors from missing using statements

---

### [?] TASK-004: Migrate JsonConvert API Calls *(Completed: 2026-01-15 14:17)*

**Objective**: Replace Newtonsoft.Json API calls with System.Text.Json equivalents

**Actions:**
- [?] (1) Replace JsonConvert.SerializeObject(obj) with JsonSerializer.Serialize(obj)
- [?] (2) Replace JsonConvert.DeserializeObject<T>(json) with JsonSerializer.Deserialize<T>(json)
- [?] (3) Handle JsonSerializerSettings ? JsonSerializerOptions conversion
- [?] (4) Update any custom resolver or converter logic
- [?] (5) Verify all transformations applied correctly

**Verification:**
- All JsonConvert calls replaced
- Project compiles with no JsonConvert errors
- Serialization/deserialization still works as expected

---

### [?] TASK-005: Update JSON Attributes *(Completed: 2026-01-15 14:19)*

**Objective**: Replace Newtonsoft.Json attributes with System.Text.Json equivalents

**Actions:**
- [?] (1) Replace [JsonProperty(Name = "...")] with [JsonPropertyName("...")]
- [?] (2) Replace [JsonIgnore] attributes (same in both libraries)
- [?] (3) Update [JsonConverter(...)] attributes if present
- [?] (4) Handle any PropertyNamingPolicy differences
- [?] (5) Update model classes with corrected attributes

**Verification:**
- All JSON attributes updated
- Models compile without attribute errors
- Property naming conventions preserved

---

### [?] TASK-006: Fix Serialization Issues *(Completed: 2026-01-15 14:21)*

**Objective**: Address behavioral differences between Newtonsoft.Json and System.Text.Json

**Actions:**
- [?] (1) Review null handling behavior (Newtonsoft.Json ignores nulls by default)
- [?] (2) Update PropertyNameCaseInsensitive if needed (JsonSerializerOptions)
- [?] (3) Fix case sensitivity in property matching
- [?] (4) Handle date/time serialization differences
- [?] (5) Test edge cases (empty objects, null values, special characters)

**Verification:**
- Serialized JSON output matches expected format
- Deserialization correctly maps all properties
- No data loss in conversion

---

### [?] TASK-007: Test and Validate

**Objective**: Ensure all JSON operations work correctly after migration

**Actions:**
- [?] (1) Run unit tests (XUnitTests project)
- [ ] (2) Run integration tests if available
- [ ] (3) Test data conversion pipeline
- [ ] (4) Verify file I/O with JSON data
- [ ] (5) Performance testing (optional)
- [ ] (6) Document any test result issues

**Verification:**
- All unit tests pass (0 failures)
- All integration tests pass (if applicable)
- No regression in functionality

---

### [ ] TASK-008: Commit Migration Changes

**Objective**: Commit all migration changes to the repository

**Actions:**
- [ ] (1) Stage all modified files
- [ ] (2) Commit with message: "TASK-008: Migrate from Newtonsoft.Json to System.Text.Json"
- [ ] (3) Verify commit succeeded
- [ ] (4) Push to origin/Update-project-to-.NET10

**Verification:**
- Commit hash recorded
- Changes pushed to remote branch
- All migration tasks completed successfully

---

## Execution Log

### Session Start
- **Timestamp**: [To be filled during execution]
- **Branch**: Update-project-to-.NET10
- **Status**: Ready for execution

### Progress
- [Progress entries will be added during execution]

### Completion
- **Status**: [To be filled after all tasks complete]
- **Total Tasks**: 8
- **Tasks Completed**: 0/8
- **Commits**: 0
