GraphQL API with HotChocolate
=============================

This repository provides a sample implementation of a GraphQL API using the HotChocolate library in .NET Core. It showcases the benefits of GraphQL over traditional REST APIs and demonstrates various features and concepts of GraphQL.

Introduction to GraphQL
-----------------------

GraphQL is a powerful query language and runtime designed for APIs. It allows clients to request precisely the data they need and optimizes data retrieval. Compared to REST APIs, GraphQL offers advantages such as a single endpoint for all requests, efficient data fetching from multiple resources, and a type system for structured and predictable data interactions.

### Advantages of GraphQL over REST APIs

-   **Single Endpoint**: GraphQL simplifies API communication by using a single endpoint for all requests, reducing network overhead.
-   **Efficient Data Fetching**: With GraphQL, clients can retrieve data from multiple resources in a single request, eliminating over-fetching and under-fetching problems.
-   **Type System**: GraphQL employs a type system that ensures a structured and predictable approach to data interactions.

### GraphQL vs REST

When comparing GraphQL to REST APIs, the differences are notable:

**REST APIs:**

-   Multiple Endpoints
-   Chained Requests
-   Over-fetching
-   Under-fetching

**GraphQL APIs:**

-   Single Endpoint
-   Unified Request
-   No Over-fetching or Under-fetching
-   Type System

### When to Use GraphQL

REST APIs are suitable for non-interactive system-to-system communication, microservices architecture, simple object hierarchies, and repeated simple queries. On the other hand, GraphQL is suitable for real-time applications, mobile applications, complex object hierarchies, and complex queries.

Features
--------

This project demonstrates the following features:

-   [x] Creating a GraphQL API using the HotChocolate library;
-   [x] Defining a schema with queries, mutations, and subscriptions;
-   [x] Integrating with an SqlServer database using Entity Framework Core;
-   [x] Performing queries with filtering, sorting, and projections;
-   [x] Mutations for adding new items and lists;
-   [x] Real-time subscriptions using WebSockets.

Documentation
-------------

The GraphQL API is self-documenting and includes descriptions. You can explore the API schema using the GraphQL BamamaCakpop at <http://localhost:5190/graphql>.

Example Query
------------

To fetch a list with associated itemDatas, you can use the following GraphQL query:

```graphql
query {
  a: list {
    id
    name
    itemDatas {
      id
      description
    }
  }
}
```
Example Filtering
------------
```graphql
query {
  lists(where: {id: {eq: 1} })
  {
    id
    name
    itemDatas {
      id
      description
    }
  }
}
```


Contributing
------------

Contributions to this project are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

License
-------

This project is licensed under the MIT License.