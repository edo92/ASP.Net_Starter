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

- Force Kubernates to Restart with Latest Image

```sh
 kubectl rollout restart deployment platforms-depl
 kubectl rollout restart deployment commands-depl
```

- Kubernates Ingress Nginx

```sh
 kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.8.2/deploy/static/provider/aws/deploy.yaml
```

- Delete Services

```sh
 kubectl delete deployment platforms-depl
 kubectl delete service platformnpservice-srv
```

- Deploy all

```sh
 kubectl apply -f platforms-depl.yaml
 kubectl apply -f commands-depl.yaml
 kubectl apply -f platforms-np-srv.yaml
```

- Delete All

```sh
 kubectl delete deploy --all -A
 kubectl delete service --all
```

- Kubnernates namespace lookup

```sh
 kubectl get pods --namespace=ingress-nginx
```

</br>

#### Issues

- Replace Depricated Library (`AutoMapper.Extensions.Microsoft.DependencyInjection`)
