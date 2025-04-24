# DatingApp

Azure published - https://dappdemo.azurewebsites.net/ - Register/Login with your information and check the app flow OR you can just login with an existing user lola/password



![DatingApp Demo](DatingApp-SPA/src/assets/DatingApp_Demo.gif)

Dating Application
Technical Stack: Angular 12 | .NET 6 WebAPI | Entity Framework Core | SQL Server | Azure

Core Features & Implementation
Authentication & Authorization

JWT-based authentication for secure API access

Role-based policies for API endpoints (Admin/User)

Angular route guards (CanActivate, CanDeactivate) and custom structural directives for UI protection

Data Layer & Architecture

Repository pattern with generic abstraction over EF Core

Optimized queries with lazy loading for navigation properties

AutoMapper for DTO transformations

Many-to-many relationships (e.g., user likes/interactions)

Client-Side Implementation

Reactive forms with validation

HTTP interceptors for centralized error handling

ngx-loader for request/response progress indicators

Route resolvers for pre-fetching data

Lazy-loaded Angular modules

Advanced Functionality

Real-time private messaging system

User matching with mutual like/dislike functionality

Drag-and-drop photo uploads to Cloudinary

Data pagination, filtering, and sorting

DevOps & Security

Azure deployment with HTTPS/TLS encryption

Global error handling (API + SPA)

Third-party integrations:

Alertify.js for notifications

Cloudinary for media management

Key Achievements
Reduced API boilerplate via generic repository pattern

Improved performance through lazy loading and DTO mapping

Enhanced security with role-based access controls

Scalable cloud architecture with Azure
