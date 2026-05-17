<p align="left">
  <img src="./assests/fixup-logo.png" width="200" alt="FixUp Logo">
</p>

## FixUp - Real-Time Service Platform
[![Live Website](https://img.shields.io/badge/Demo-Live_Website-28A745?style=for-the-badge&logo=vercel&logoColor=white)](https://fixup-fullstack1.vercel.app)
[![API Endpoint](https://img.shields.io/badge/API-Render_Backend-000000?style=for-the-badge&logo=render&logoColor=white)](https://fixup-fullstack.onrender.com)
FixUp is a production-like real-time service marketplace platform that connects customers with professional service
providers through smart issue classification, real-time communication, and automated routing.
The system enables users to report problems, attach images, and receive instant assistance from the most relevant professionals.

## 💡 Project Overview
FixUp is a smart service orchestration system designed to reduce the time between problem reporting and resolution.
Users can:
- Report technical or home-related issues
- Upload images for better diagnosis
- Chat in real time with professionals
- Get automatic issue classification
- Request professional visits
- Receive booking confirmations via email

# ✨ Features
## 💬 Real-Time Chat (SignalR)
- Instant messaging between users and professionals
- Live updates without page refresh
- Group-based conversation handling

---

## 📸 Image Upload System
- Upload images directly in chat
- Stored securely via backend API
- Displayed in real-time in conversation

---

## 🧠 Smart Issue Classification System
Custom rule-based multilingual keyword engine:

- Hebrew / English / Russian / Arabic support
- Category detection using predefined keyword dictionaries
- Automatic routing to relevant professionals
> Note: This system is rule-based (not AI), built using custom logic.

---
## 🧑‍🔧 Professional Routing System
- Automatic assignment based on category
- Real-time job notifications via SignalR
- Dedicated groups per category

---
## 📅 Professional Scheduling
- Availability calendar per professional
- Mark as busy / available
- Supports flexible scheduling

---

## 📧 Booking System
- Customers can request professional visits
- Email notifications sent on booking confirmation
- Minimum service duration support

---

## 🔐 Authentication & Authorization
- JWT-based authentication
- Role-based access control (Client / Professional)
- Secure protected routes

---

## 🧾 Chat History System
- Customers: session-based conversations
- Professionals: persistent chat history

## 🧱 Tech Stack

![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![TypeScript](https://img.shields.io/badge/TypeScript-007ACC?style=for-the-badge&logo=typescript&logoColor=white)
![TailwindCSS](https://img.shields.io/badge/TailwindCSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Redux](https://img.shields.io/badge/Redux-593D88?style=for-the-badge&logo=redux&logoColor=white)
![SignalR](https://img.shields.io/badge/SignalR-512BD4?style=for-the-badge&logo=microsoft&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)
![Context API](https://img.shields.io/badge/Context_API-61DAFB?style=for-the-badge&logo=react&logoColor=black)
![Layered Architecture](https://img.shields.io/badge/Layered_Architecture-2E8B57?style=for-the-badge&logo=architecture&logoColor=white)
-
# 👥 Team Contribution
This project was developed collaboratively under a GitHub Organization.

---

###  TehillaZ
<img src="https://github.com/TehillaZ.png" width="50" style="border-radius:50%; float:left; margin-right:10px;" />

* **Real-time communication architecture using SignalR** for instant bi-directional messaging
* Robust message pipeline handling client-server synchronization, validation, and delivery flow
* End-to-end image processing and AI integration pipeline for automated request analysis and categorization
* Intelligent routing system for dynamic assignment of requests to relevant professionals based on classification logic
<br clear="left"/>

---

###  SaraAbaShaul
<img src="https://github.com/SaraAbaShaul.png" width="50" style="border-radius:50%; float:left; margin-right:10px;" />

* **Booking System:** Designed and implemented the end-to-end appointment logic.
* Managed scheduling and professional availability.
* Integrated email service for automated confirmations.
* Ensured seamless backend workflow.
<br clear="left"/>

---

###  hadas0556751108-sudo
<img src="https://github.com/hadas0556751108-sudo.png" width="50" style="border-radius:50%; float:left; margin-right:10px;" />

* **Backend Architecture:** Core system design using .NET Web API.
* Built layered system (Controllers / Services / Repository / Data Layer).
* Responsible for database schema and system organization.
<br clear="left"/>

### UI / Design
Base44 AI-assisted design tool
Implemented in React + Tailwind CSS

# 📸 Screenshots
<p align="center">
  <img src="./assests/fixup-chat.png" width="30%" />
  <img src="./assests/fixup-services.png" width="30%" />
  <img src="./assests/fixup-dashboard.png" width="30%" /> 
</p>

# ⚙️ Environment Configuration

Create a local `appsettings.json` file inside the backend project and configure the required secrets and local settings:

```json
{
  "GeminiApiKey": "YOUR_API_KEY",

  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  },

  "Jwt": {
    "Key": "YOUR_JWT_SECRET",
    "Issuer": "FixUpBackend",
    "Audience": "FixUpFrontend",
    "DurationInMinutes": 120
  },

  "EmailSettings": {
    "Email": "YOUR_EMAIL",
    "Password": "YOUR_EMAIL_PASSWORD",
    "Host": "YOUR_SMTP_HOST",
    "Port": 587
  }
}
```

# 🚀 Running The Project
1️⃣ Clone the repository
```bash
git clone YOUR_REPOSITORY_URL
```
2️⃣ Frontend Setup
```bash
cd client
npm install
npm run dev
```
Frontend runs on:
http://localhost:5173.

3️⃣ Backend Setup
```bash
cd server
dotnet restore
dotnet run
```
Backend runs on:
https://localhost:7230

4️⃣ Database Setup
Make sure SQL Server is running locally and update the connection string inside:
```bash
appsettings.json
```
Apply Entity Framework migrations:
```bash
Update-Database
```
