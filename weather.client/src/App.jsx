import React, { useState } from "react";
import "./App.css";

function App() {
    const [city, setCity] = useState("");
    const [weather, setWeather] = useState(null);
    const [forecast, setForecast] = useState([]);

    const getWeather = async () => {
        const res = await fetch(`/api/weather/${city}`);
        const data = await res.json();
        setWeather(data);

        const res2 = await fetch(`/api/weather/forecast/${city}`);
        const data2 = await res2.json();

        const daily = data2.list.filter((item, index) => index % 8 === 0);
        setForecast(daily);
    };

    return (
        <div className="app">
            <div className="card glass">
                <h1>🌤 Weather</h1>

                <div className="search">
                    <input
                        placeholder="Enter city..."
                        onChange={(e) => setCity(e.target.value)}
                    />
                    <button onClick={getWeather}>Search</button>
                </div>

                {weather && (
                    <div className="current">
                        <h2>{weather.name}</h2>
                        <h1>{weather.main?.temp}°C</h1>
                        <p>{weather.weather?.[0]?.description}</p>
                    </div>
                )}

                <div className="forecast">
                    {forecast.map((day, i) => (
                        <div key={i} className="day">
                            <p>
                                {new Date(day.dt * 1000).toLocaleDateString("en-IN", {
                                    weekday: "short",
                                    day: "numeric",
                                    month: "short",
                                    timeZone: "Asia/Kolkata"
                                })}
                            </p>

                            <img
                                src={`https://openweathermap.org/img/wn/${day.weather[0].icon}@2x.png`}
                                alt=""
                            />

                            <p>{day.main.temp}°C</p>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
}

export default App;