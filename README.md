# CloudResume

my own staic hosted resume supported by Azure, following [ACloudGurur project video by GPS.](https://www.youtube.com/watch?v=ieYrBWmkfno&t=1941s)

This is my Cloud Resume Challenge built on Azure. It's a static website hosted on Azure Storage, with a visitor counter built on Azure Functions. The website is built with HTML, CSS, and JavaScript. The visitor counter is built with .NET and Azure Functions. 

check out [here](https://www.nikhilkumargupta.in/)

## Pre-requisites

1. Make sure to have AZURE account.
2. make sure to domain ready for your resume website.
3. MOSTLY the extensions and dependencies. They waste the most time not the coding.
4. Or you can avoid most of the headache by using the containers provided graciously by GPS [HERE](https://github.com/madebygps/azure-resume?tab=readme-ov-file)
   


## Frontend 

The front-end is a static site with HTML, CSS, and JavaScript. It's static and has a visitor counter. The visitor counter data fetched via an API call to an Azure Function.

## Backend 

The back-end is an [HTTP triggered Azure Functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook-trigger?tabs=csharp) with Cosmos DB input and output binding. The Function is triggered, it retrieves the CosmosDB item, adds 1 to it, and saves it and returns its value to the caller.



## Testing Resources

- [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/cmdline)
- [Testing Azure Functions.](https://techcommunity.microsoft.com/t5/fasttrack-for-azure/azure-functions-part-2-unit-and-integration-testing/ba-p/3769764)


## CI/CD 

- while creating role for your backend use DOUBLE SLASH after scope.
- This is how you can [deploy an Azure Function to Azure with GitHub Actions.](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-github-actions?tabs=windows%2Cdotnet&pivots=method-template).

## Some Tips
- Use dot net 6
- the command for azure service principle is
   ```
   az ad sp create-for-rbac --name "myApp" --role contributor                             --scopes /subscriptions/<subscription id>/resourceGroups/<rgname>/providers/Microsoft.Storage/storageAccounts/<storageaccountname> \--sdk-auth]
  ```
- for backend deployment template [here](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-github-actions?tabs=windows%2Cdotnet&pivots=method-template)
- Download nuget package process one [here](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-cosmosdb-v2?tabs=in-process%2Cfunctionsv2&pivots=programming-language-csharp)
