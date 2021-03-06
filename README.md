# Independent Project - Local Lookup API

## Description

Allows the viewer to Create, Read, Edit, and Delete things in the database through the MVC, Postman, or the Terminal.

Use with Local Lookup MVC!

## Setup/Installation Requirements

* Clone or Download repo to a directory.
* Open Terminal.
* Navigate to main project folder
* Input terminal commands:

```
dotnet ef database update
dotnet run
```
* Get and follow instructions for [LocalLookupMVC](https://github.com/Riverface/LocalLookupMVC)

# Endpoints    

## Businesses
>`/api/Businesses`.
>GET `api/Businesses`: Returns all entries
>
>POST `api/Businesses`: Adds a valid JSON object into the database as a Business
>
>GET `api/Businesses/id`: Returns the entry whose BusinessId matches id
>
>PUT `api/Businesses/id`: Replaces an entry whose BusinessId matches id in favor of a valid JSON object
>
>DELETE `api/Businesses/id`: Removes an entry whose BusinessId matches id

* Parameter: `name` (string): Returns all entries whose Name matches `name` =

## Cities
>`/api/Cities`
>
>POST `api/Cities`: Adds a valid JSON object into the database as a `City`
>
>GET `api/Cities/id`: Returns the entry whose `CityId` matches id
>
>PUT `api/Cities/id`: Replaces an entry whose `CityId` matches id in favor of a valid JSON object
>
>DELETE `api/Cities/id`: Removes an entry whose `CityId` matches id

### Properties
>#### Business:
>
>>* `businessId` int
>>* `name` string
>>* ``cityId`` int
>>* `address` string
>>* `phoneNumber` string
>>* `blurb` string
>
>#### City:
>
>> * `name` string
>> * `zipcode` int
>

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
---
## Legal
Copyright (c) 2020 Robert Smith

This software is licensed under Creative Commons 0 license. Use however you want, in fact please do not credit me.
