# Models used to create return objects from API controllers

Each object type has a corresponding controller, and this folder contains 
the return object models used in the REST API responses.

## Example REST (HATEOAS) Response

[HATEOAS](https://en.wikipedia.org/wiki/HATEOAS) - Acronym for "Hypermedia As The Engine Of Application State"


Example Source: [API Design Best Practices](https://github.com/mspnp/architecture-center/blob/master/docs/best-practices/api-design.md)


```HTTP/1.1 200 OK
...
Content-Type: application/json; charset=utf-8
...
Content-Length: ...
{"CustomerID":2,"CustomerName":"Bert","Links":[
    {"rel":"self",
    "href":"http://adventure-works.com/customers/2",
    "action":"GET",
    "types":["text/xml","application/json"]},
    {"rel":"self",
    "href":"http://adventure-works.com/customers/2",
    "action":"PUT",
    "types":["application/x-www-form-urlencoded"]},
    {"rel":"self",
    "href":"http://adventure-works.com/customers/2",
    "action":"DELETE",
    "types":[]},
    {"rel":"orders",
    "href":"http://adventure-works.com/customers/2/orders",
    "action":"GET",
    "types":["text/xml","application/json"]},
    {"rel":"orders",
    "href":"http://adventure-works.com/customers/2/orders",
    "action":"POST",
    "types":["application/x-www-form-urlencoded"]}
]}