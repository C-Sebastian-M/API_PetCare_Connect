# API_PetCare_Connect

.NET 10 ASP.NET Core Web API — veterinary clinic management backend (Spanish domain). EF Core database-first from an existing SQL Server LocalDB instance.

## Quick start

```powershell
dotnet run    # http://localhost:5082
```

Scalar API reference at `/scalar/v1` (Development only).

No test project, no CI, no lint/format tools configured.

## Architecture (early stage — many layers are stubs)

| Layer | Status |
|-------|--------|
| `Controllers/` | 1 stub (`SedeController` — empty) |
| `Data/Models/` | 36 entities + `PetCareConnectContext` scaffolded from DB |
| `Data/DTOs/` | Cliente, Mascota, Consulta groups |
| `Data/Validators/` | Cliente + Mascota validators exist; `Consulta/` is empty |
| `Services/` | empty — placeholder |
| `Repository/` | empty — placeholder |
| `PetCareMapper/` | empty — placeholder |

`Program.cs` uses minimal hosting. **Missing DI registrations:** no `AddDbContext`, no FluentValidation `AddValidatorsFromAssembly`, no service/repo registration.

## Namespace quirks

- Cliente DTOs: `API_PetCare_Connect.Data.DTOs.Cliente`
- Mascota/Consulta DTOs: `API_PetCare_Connect.DTOs.Mascota` / `.Consulta` (missing `Data`)
- Validators live in `Data/Validators/` folders but declare namespace `API_PetCare_Connect.Validators.{Entity}`

## Database

- LocalDB: `(localdb)\MSSQLLocalDB`, database `PetCare_Connect`
- Connection string in `appsettings.Development.json` → `ConnectionStrings:SqlConnection`
- `OnConfiguring` has a hardcoded fallback — replace with DI config when wiring up `AddDbContext`
- All tables, columns, entities in **Spanish** (e.g. `Mascotum`, `Consultum`, `Citum`)

## DTO & Validator conventions

- `{Entity}Dto` — read/summary
- `Crear{Entity}Dto` — create (no identity/audit/status fields)
- `Actualizar{Entity}Dto` — update (includes `Estado{Entity}`)
- `Detalle{Entity}Dto` — detail with expanded navigation property names
- Validation messages in Spanish; `.NotEmpty()` for required fields, `.MaximumLength()` for optional string length, `.GreaterThan(0)` for FK IDs

## EF Core

- DbContext is `partial class` — safe to extend in separate file
- Generated with `dotnet ef dbcontext scaffold` — re-scaffolding will overwrite; hand edits in partial companion files
