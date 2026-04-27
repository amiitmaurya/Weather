# 🌤 Weather App (React + .NET)

A modern **Weather Application** built using **React (Vite)** for the frontend and **ASP.NET Core Web API (.NET)** for the backend.
It provides **current weather data** and a **5-day forecast** with a clean and responsive UI.

---

## 🚀 Features

* 🔍 Search weather by city name
* 🌡 Display current temperature
* ☁ Show weather condition (haze, rain, etc.)
* 📅 5-day forecast (daily view)
* 🎨 Modern glassmorphism UI
* ⚡ Auto-search with debounce (smooth typing experience)
* 🌍 Timezone-correct date display

---

## 🧩 Tech Stack

### Frontend

* React (Vite)
* CSS (Glass UI)

### Backend

* ASP.NET Core Web API (.NET)
* HttpClient

### API

* OpenWeatherMap API

---

## 📁 Project Structure

```
Weather/
│
├── weather.client/        # React Frontend
│   ├── src/
│   │   ├── App.jsx
│   │   ├── App.css
│   │   └── main.jsx
│
├── Weather.Server/        # .NET Backend
│   ├── Controllers/
│   │   └── WeatherController.cs
│   ├── Program.cs
│
└── README.md
```

---

## ⚙️ Setup Instructions

### 🔹 1. Clone the repository

```bash
git clone https://github.com/your-username/weather-app.git
cd weather-app
```

---

### 🔹 2. Backend Setup (.NET)

```bash
cd Weather.Server
dotnet restore
dotnet run
```

---

### 🔹 3. Frontend Setup (React)

```bash
cd weather.client
npm install
npm run dev
```

---

## 🔑 API Key Setup

Get your API key from
👉 https://openweathermap.org/

Update in:

📁 `WeatherController.cs`

```csharp
private readonly string apiKey = "YOUR_API_KEY";
```

---

## 🔗 API Endpoints

| Endpoint                       | Description         |
| ------------------------------ | ------------------- |
| `/api/weather/{city}`          | Get current weather |
| `/api/weather/forecast/{city}` | Get 5-day forecast  |

---

## 🎯 UI Preview

* 🌈 Gradient background
* 🧊 Glass card design
* 📊 Forecast cards (no scroll, clean layout)

---

## 🧠 Key Concepts Used

* React Hooks (`useState`, `useEffect`)
* Debouncing API calls
* REST API integration
* JSON parsing & DTO mapping
* CSS Grid & Flexbox

---

## 💡 Future Improvements

* 📍 Auto location detection
* 🌙 Dark / Light mode
* 📊 Temperature charts
* 🔍 Search suggestions dropdown
* 🌐 Deploy to cloud

---

## 🙌 Acknowledgements

* OpenWeatherMap API
* React & .NET community

---

## 📌 Author

**Your Name**

* GitHub: https://github.com/your-username

---

## ⭐ If you like this project

Give it a ⭐ on GitHub!

---
