# HotchocolateExample

Simple example of a C# GraphQL api using Chillicream Hotchocolate package

### Features
- Type
- Query
- Directive


## Example
Run this query:

```
query{
  userByEmail(email: "test") {
    id
    name
    email
  }
}
```
