# DatingApp





![DatingApp Demo](client/src/assets/gifdemo.gif)

Dating Application
Technical Stack: Angular 12 | .NET 6 WebAPI | Entity Framework Core | SQLite | Azure

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

Azure deployment with HTTPS/TLS encryption

Global error handling (API + SPA)

Third-party integrations:

Alertify.js for notifications

Cloudinary for media management

Key Achievements
Reduced API boilerplate via generic repository pattern

Improved performance through lazy loading and DTO mapping

Enhanced security with role-based access controls

