### FourTwenty.Core.Data
Base classes for cross-platform database management

### Build 
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/c9b24e7be0104de6bf82a154ed87e5bf)](https://app.codacy.com/gh/4TwentySolutions/FourTwenty.Core.Data?utm_source=github.com&utm_medium=referral&utm_content=4TwentySolutions/FourTwenty.Core.Data&utm_campaign=Badge_Grade_Dashboard)
[![Build status](https://dev.azure.com/420-solutions/FourTwenty.Core.Data/_apis/build/status/FourTwenty.Core.Data-CI)](https://dev.azure.com/420-solutions/FourTwenty.Core.Data/_build/latest?definitionId=9)


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
