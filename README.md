# ASP.Net Production Ready Starter Project

- **Based on [Asp.Net Microservices](https://www.youtube.com/watch?v=DgVjEo3OGBI&t=14958s) Tutorial**

</br>

#### Commands Used

- Create/Initialize Platform Service

```sh
 dotnet new webapi -n PlatformService
```

- Create/Initialize Command Service

```sh
 dotnet new webapi -n CommandsService
```

- Add Package to Project

```sh
 dotnet add package <PACKAGE_NAME>
```

</br>

#### Dependencies (Platform Service)

- `AutoMapper.Extensions.Microsoft.DependencyInjection` // Repalce:Depricated
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.InMemory`
- `Microsoft.EntityFrameworkCore.SqlServer`

</br>

#### Dependencies (Commands Service)

- `AutoMapper.Extensions.Microsoft.DependencyInjection` // Repalce:Depricated
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.InMemory`

</br>

#### Kubernates Local Deployment

- Deploy Kubernates

```sh
 kubectl apply -f platforms-depl.yaml
```

- Delete Deployment

```sh
 kubectl delete deployment platforms-depl
```

- Delete Service

```sh
 kubectl delete service platformnpservice-srv
```

</br>

#### Issues

- Replace Depricated Library (`AutoMapper.Extensions.Microsoft.DependencyInjection`)
