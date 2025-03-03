# Code Quality Guidelines

## Important guideline
- Do not push secrets to any branch especially client secret

## API Components
- Ensure that you are registering all the components that are being created in `autofacmodule`
  - E.g. Controller, Services, MappingProfiles
- When creating Service Project, add `autofacmodule` as `serivceautofacmodule.cs` for it.
- When creating a new controller, inherit from `BaseController`.
- Add `Signet.RequestMiddleware` package from Nuget package which will handle the exceptions. Add below in `Program.cs`
  ```csharp
  builder.Services.AddRequestMiddleware();
  app.UseRequestMiddleware();
