# Independent Project - Local Lookup API

## Description

Allows the viewer to Create, Read, Edit, and Delete things in the database through the MVC, Postman, or the Terminal.
Use with Local Lookup MVC!

## Endpoints    
the GET endpoint gets cities and businesses by ID.
For example:
```
http://localhost:5004/api/Cities/
http://localhost:5004/api/Business/
```
cURL:
```
curl --location --request GET 'http://localhost:5004/api/cities/' \
--header ': ' \
--header 'Content-Type: application/json' \
--data-raw ''
```

the POST endpoint posts cities and businesses by ID.
For example:
```
http://localhost:5004/api/Cities/X
http://localhost:5004/api/Business/X
X = id
```
cURL:
```
curl --location --request POST 'http://localhost:5004/api/cities/' \
--header ': ' \
--header 'Content-Type: application/json' \
--data-raw '
    {
        "businessId": 6,
        "name": "Nothing",
        "cityId": 0,
        "address": "Nothing",
        "phoneNumber": "Nothing",
        "blurb": "Lubert"
    }

```

the PUT endpoint edits existing cities and businesses by ID.
For example:
```
http://localhost:5004/api/Cities/X
http://localhost:5004/api/Business/X
X = id
```
cURL:
```
curl --location --request PUT 'http://localhost:5004/api/cities/1' \
--header ': ' \
--header 'Content-Type: application/json' \
--data-raw '
    {
        "businessId": 1,
        "name": "Nothing",
        "cityId": 0,
        "address": "Nothing",
        "phoneNumber": "Nothing",
        "blurb": "Lubert"
    }
'
```
the DELETE endpoint removes existing cities and businesses by ID.
```
http://localhost:5004/api/Cities/X
http://localhost:5004/api/Business/X
X = id
```
cURL:
```
curl --location --request PUT 'http://localhost:5004/api/cities/1' \
--header ': ' \
--header 'Content-Type: application/json' \
--data-raw ''

```


## Setup/Installation Requirements

* Clone or Download repo to a directory.
* Open Terminal.
* Navigate to main project folder
* Input terminal commands:

```
dotnet ef database update
dotnet run
```

## Known Bugs

_None known_

## Support and contact details

_Robert Smith_

## Technologies Used
```
    ASP.NET
    C#
    Entity Framework
```

## Legal
Copyright (c) 2020 Robert Smith

This software is licensed under Creative Commons 0 license. Use however you want, in fact please do not credit me.
