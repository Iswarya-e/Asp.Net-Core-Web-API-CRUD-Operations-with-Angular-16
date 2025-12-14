# Asp.Net Core Web API + Angular 16 — DevOps Focus

This repository is a **fork** of the original CRUD project and has been extended to demonstrate **DevOps, containerization, and runtime architecture concepts**.  
The goal is not feature development, but to practice real-world concerns such as container builds, orchestration, configuration, and deployment readiness. 

---

## 🚀 Project Purpose

This project shows how to:
- Containerize an ASP.NET Core API + Angular app
- Use Docker Compose & link services
- Configure environment variables
- Handle runtime networking
- Persist data using named volumes
- Prepare a reproducible local environment

The focus is on **DevOps readiness**, not application feature complexity.

---

## 📦 Stack

| Component | Technology |
|-----------|------------|
| Backend | ASP.NET Core Web API (.NET) |
| Frontend | Angular 16 |
| DB | SQL Server (containerized) |
| Containerization | Docker + Docker Compose |
| Deployment | Local environment with compose |

---

## 🧠 Architecture

Client → API Container → Database Container

**Key principles:**
- Stateless API
- Docker networking between services
- Environment-based config via env vars

---

## 🐳 Docker Setup

### Dockerfile
- Multi-stage build for optimized image sizes
- Separation of build + runtime layers

### Docker Compose
- Compose defines:
  - API and DB services
  - Docker bridge network
  - Named volumes to persist data
  - Environment variables at runtime

Run:
```
docker compose up --build
```

API will be available at `http://localhost:3000` after containers start.

---

## ⚙️ Configuration

- Environment variables provided in compose

---

## 🛠 What I Improved

- Dockerization of backend & frontend
- Docker network setup
- Proper compose configuration
- `.gitignore` cleanup
- 
---


## 📌 Local Run Instructions

### Prerequisites
- Docker
- Docker Compose

### Steps
```bash
docker compose up --build
```

Access the web app or API at the exposed ports.


## 📎 Attribution

This project is forked from:
https://github.com/CodAffection/Asp.Net-Core-Web-API-CRUD-Operations-with-Angular-16.git
