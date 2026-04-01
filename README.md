# 🚗 Car Explorer

A full-stack web application that allows users to explore vehicle data by selecting a car make and manufacturing year, then viewing available vehicle types and models.

This project was built as part of a technical assignment using **.NET Core**, **Angular**, and **Docker**.

---

##  Features

- Search and select car makes
- Filter by manufacturing year
- Display available vehicle types
- Display models based on selected criteria
- Integrated with external public APIs
- Fully dockerized for easy setup

---

##  Tech Stack

### Backend
- .NET 8 Web API
- RESTful architecture

### Frontend
- Angular
- TypeScript

### DevOps
- Docker
- Docker Compose

---

##  External APIs

- Get All Makes  
  https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json  

- Get Vehicle Types for Make ID  
  https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{makeId}?format=json  

- Get Models by Make ID and Year  
  https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{year}?format=json  

---

##  Running the Application (Docker)

### Prerequisites
- Docker Desktop installed and running

### 1. Clone the repository

```bash
git clone https://github.com/thetala3/CarExplorer.git
cd CarExplorer
```

### 2. Build and run

```bash
docker compose up --build
```

### 3. Access the app

Frontend:  
http://localhost:4200  

Backend (Swagger):  
http://localhost:5000/swagger  

---

## 💻 Running Locally (Without Docker)

### Backend

```bash
cd CarExplorer.API
dotnet run
```

Swagger:
```
http://localhost:5000/swagger
```

---

### Frontend

```bash
cd car-explorer-ui
npm install
npm run build
ng serve
```

Frontend:
```
http://localhost:4200
```

---

##  Project Structure

```
CarExplorer/
│
├── CarExplorer.API/
├── CarExplorer.Application/
├── CarExplorer.Domain/
├── CarExplorer.Infrastructure/
├── car-explorer-ui/
├── docker-compose.yml
```

---

##  AWS Deployment

The application was prepared for deployment on AWS EC2 (free tier).

Due to limited resources on the **t3.micro instance**, Angular build performance was slow and unreliable during container builds.

The application runs successfully locally using Docker.

---

##  Notes

- Make sure Docker is running before executing commands
- Ports used:
  - 4200 → Frontend
  - 5000 → Backend

---

##  Submission Notes

- Application fully functional locally
- Dockerized setup included
- External APIs integrated successfully
- Code pushed incrementally to GitHub
