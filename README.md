# ASP.Net Production Ready Starter Project

</br>

#### Commands Used

- Create/Initialize Project

```sh
 dotnet new webapi -n PlatformService
```

- Add Package to Project

```sh
 dotnet add package <PACKAGE_NAME>
```

</br>

#### Dependencies

- `AutoMapper.Extensions.Microsoft.DependencyInjection` // Repalce:Depricated
- `package Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.InMemory`
- `Microsoft.EntityFrameworkCore.SqlServer`

</br>

#### Kubernates Local Deployment

- Deploy Kubernates

```sh
 kubectl apply -f platforms-depl.yaml
```

- Delete Kubernates

```sh
 kubectl delete deployment platforms-depl
```

</br>

#### Issues

- Replace Depricated Library (`AutoMapper.Extensions.Microsoft.DependencyInjection`)
