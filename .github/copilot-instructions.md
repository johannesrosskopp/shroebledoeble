# Copilot Instructions for shroebledoeble Repository

## .NET Version Management
- **ALWAYS maintain .NET version consistency**: The project uses `net9.0` as the target framework
- Never upgrade or downgrade the .NET version without explicit approval
- When creating new projects, use the same target framework (`net9.0`) as existing projects
- Preserve existing `PropertyGroup` settings in .csproj files

## Dependency Management
- **Only change dependencies when absolutely necessary**: Avoid adding new packages unless explicitly required
- Use existing package versions when possible - prefer updating existing packages over adding new ones
- When adding packages, use version ranges (e.g., `9.0.*`) that match the existing pattern
- Do not upgrade major versions of existing packages without explicit requirement

## Code Structure and Patterns
- **Preserve existing codebase structure**: Do not refactor unless explicitly requested
- Follow the established patterns in the codebase:
  - Use minimal APIs pattern as shown in BackEnd/Program.cs
  - Maintain Blazor Server-side patterns in FrontEnd
  - Keep the existing project separation (BackEnd/FrontEnd)
- Respect existing file organization and naming conventions
- Do not restructure directories or move files unnecessarily

## Code Style Guidelines
- **No unnecessary comments**: Only add comments when they provide essential context or explain complex logic
- Follow existing code formatting and style patterns
- Use implicit usings as configured in the projects
- Maintain nullable reference types settings (`<Nullable>enable</Nullable>`)
- Preserve existing using statements organization

## Minimal Changes Principle
- Make the smallest possible changes to achieve the requested functionality
- Do not modify working code unless it's directly related to the task
- Avoid "improvements" that weren't specifically requested
- When fixing bugs, focus only on the specific issue without broader refactoring

## Best Practices for This Codebase
### ASP.NET Core (BackEnd)
- Follow the minimal API pattern established in Program.cs
- Use dependency injection appropriately
- Maintain the existing OpenAPI/Scalar configuration
- Preserve environment-specific configurations

### Blazor Server (FrontEnd) 
- Follow existing Blazor component patterns
- Maintain server-side rendering approach
- Use the established CSS organization (scoped styles, bootstrap integration)
- Preserve existing static file handling

### General Development
- Maintain separation of concerns between projects
- Use appropriate async/await patterns where established
- Follow existing error handling patterns
- Preserve configuration management approach (appsettings files)

## Build and Deployment
- Ensure changes work with the existing build pipeline (.github/workflows/build.yml)
- Test both Debug and Release configurations
- Verify that both projects build successfully together
- Do not modify build scripts unless specifically required

## Testing Approach  
- Follow existing testing patterns if tests are present
- Write minimal, focused tests that validate specific functionality
- Do not create extensive test suites unless explicitly requested

## Documentation
- Update documentation only when directly related to code changes
- Keep documentation concise and focused
- Maintain existing markdown formatting styles in README files

## What NOT to Do
- Do not add extensive logging unless requested
- Avoid adding complex abstractions or design patterns not already present
- Do not change existing configuration files unless necessary
- Avoid adding development tools or utilities not specifically requested
- Do not modify package.json, global.json, or other configuration files without explicit need