### FourTwenty.Core.Data
Base classes for cross-platform database management

### Build 
[![Build status](https://dev.azure.com/420-solutions/FourTwenty.Core.Data/_apis/build/status/FourTwenty.Core.Data-CI)](https://dev.azure.com/420-solutions/FourTwenty.Core.Data/_build/latest?definitionId=9)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/464e0a87c236417f981c590b9587c31f)](https://www.codacy.com/gh/4TwentySolutions/FourTwenty.Core.Data?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=4TwentySolutions/FourTwenty.Core.Data&amp;utm_campaign=Badge_Grade)
![Nuget](https://img.shields.io/nuget/v/FourTwenty.Core.Data?label=4Twenty%20Solutions)
### Features

 - [Extensions](#extensions)
 - [Models](#models)
 - [Repositories](#repositories)
 - [Specifications](#specifications)


### Extensions

 - `DbExtensions`

### Models

 - `BaseEntity`

### Repositories

 - `IRepository`
 - `IAsyncRepository`
 - `EfRepository<T>`
 - `EfRepository<T, TKey>`

### Specifications

 - `SpecificationEvaluator`
 - `BaseSpecification<T>`
 - `IdentitySpecification<T>`
 - `AndSpecification<T>`
 - `OrSpecification<T>`
 - `NotSpecification<T>`
