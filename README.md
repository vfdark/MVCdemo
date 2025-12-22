# MvcDemo

This is a simple **ASP.NET Core MVC project** that demonstrates managing student data.

## Features

- Student Model with Name and Age
- Create, Read (Index) operations
- Uses an ArrayList/List to store student objects
- Simple MVC structure:
  - Models
  - Views
  - Controllers
 
    ##Diagram shows the flow
              ┌──────────────┐
          │   Browser    │
          │ (HTML/CSS/JS)│
          └─────┬────────┘
                │ HTTP Request
                ▼
       ┌───────────────────┐
       │  Controller (C#)  │
       │ Handles routes,   │
       │ processes data,   │
       │ calls Model        │
       └─────────┬─────────┘
                 │ Access/Update
                 ▼
         ┌───────────────┐
         │   Model (C#)  │
         │  Data structure│
         │  (e.g., Student│
         │   objects/List)│
         └───────┬───────┘
                 │ Pass data
                 ▼
         ┌───────────────┐
         │   View (.cshtml)│
         │ Razor HTML + C#│
         │ Generates final │
         │ HTML for browser│
         └───────┬───────┘
                 │ HTTP Response
                 ▼
          ┌──────────────┐
          │   Browser    │
          │ Renders page │
          └──────────────┘


