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
  Ensure that you are registering all the components that are being created in autofacmodule 

E.g. Controller, Services, MappingProfiles 

When creating Service Project add autofacmodule as serivceautofacmodule.cs  for the it  

When new creating new controller inherit from BaseController 

Add Signet.RequestMiddleware package from Nuget package which will handle the exceptions. Add below in Program.cs 

builder.Services.AddRequestMiddleware(); 

app.UseRequestMiddleware(); 

When adding Base Controller ensure that you add to the BaseController 

[ApiController] 
[Authorize] 

ApiAutofacModule – Do not delete existing code 

Add GET or POST verbs as per the confluence. 

Only keep configurations that are same across environments in appsettings.json. If they differ then keep it in the environment specific appSettings(dev/test).json files 

Remove commented codes 

Development team could’ve asked on which http codes to return back to FE in the scenario based on US and get confirmed with the architect before raising PR 

ILogger class should declared be private and readonly. Ex- private readonly ILogger – Check with Anup 

Development team should go thru the US and return the instructed HTTP codes to the FE. If any doubt get confirmed with the architect before raising PR 

Ensure that any service implementation should be part of the Services project and any database implementation should be part of Services project inside Data folder. 

Dont have try catch block in code. RequestMiddleware is doing the exception handling 

Any environment specific configurations must be changed in the appsettings.<environment>.json. Only configurations that will same for all environments should be part of appsettings.json 

When creating a new Api add ProducerResponseTypes like below for statuses whichever applicable: 
[ProducesResponseType(typeof(ResponseObject), StatusCodes.Status200OK)] 
[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] 
[ProducesResponseType(StatusCodes.Status204NoContent)] 

Please follow alphabetical order for models, method names. 

Keep a line gap between 2 attributes  

Remove any extra lines after end of file 

Don’t have any comments on the code 

If you are using a list then name the attribute name as plural 

Remove unused usings and sort for every file that is changed 

Check nullable criteria for the attribute and set accordingly 

Have a line space between namespace and class 

Local variables should have camel case and not have “_” 

Remove braces namespace and class and end of document and put a semi colon after namespace 

If adding a list then it should not be nullable and should have new() instead of default! 

For objects we should use default! 

When adding a new controller follow the below format 

[ApiVersion("1")] 
 [Route("v{version:apiversion}/intake/[controller]")] 

(OR) 

[ApiVersion("1")] 
 [Route("v{version:apiversion}/common/[controller]")] 

 (OR) 

[ApiVersion("1")] 
 [Route("v{version:apiversion}/fulfillment/[controller]")] 

 

When adding components to constructor ensure adding the extension “.ValidateParameter()” 

Wherever type is mentioned, use var instead. 

Deserialize interface/internal api responses to response objects rather than creating a new object and assigning values to the object. 

Please go through the PR file changes once you raise a PR.?? 

Use HasValue for these IsNullOrEmpty calls 

PromiseDate should be DateOnly type 

Use .IsNullOrWhitespace() instead of .Trim() on the properties 

Should have validation rules on required properties in request class 

Constant name should not be “gsiSortKey” and should be “Sk”. These are moved to data-nuget constants 

String literals should not be used inside method. Declare as const and use it in the method. 

DynamoConstant has been created and refer for Dynamo db constants 

Refer Job status constants for comparing or assigning job status. Dont harcode. 
 
