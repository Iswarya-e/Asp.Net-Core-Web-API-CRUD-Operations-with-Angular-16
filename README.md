Project Overview

This project demonstrates DevOps, containerization, and runtime architecture concepts using a simple Payment API as the application layer.

The business logic is intentionally kept minimal. The primary goal of this repository is to showcase:

- Docker & Docker Compose
- Service-to-service networking
- Environment-based configuration


Architecture Overview

High-level flow:

-Client → API Container → Database Container

Components:

-Payment API – ASP.NET Core Web API

-Database – SQL Server (containerized)

-Docker Network – Internal bridge network for service communication

Key design principles:

-Stateless API service
-Container-to-container communication via service names
-Externalized configuration via environment variables



🐳 Docker & Containerization
Dockerfile

-Multi-stage build for optimized image size
-Separation of build and runtime layers
-Uses official .NET SDK and runtime images

Docker Compose
-Orchestrates API and database containers
-Defines isolated Docker network
-Uses named volumes for database persistence
-Environment variables injected at runtime

This setup mimics local production-like behavior rather than simple development execution.

🚀 How to Run Locally
Prerequisites

-Docker
-Docker Compose

Steps
docker compose up --build

API will be available at:

http://localhost:<exposed-port>
🧪 DevOps Focus Areas Demonstrated

Docker image optimization
Containerisation of applications
Container networking



