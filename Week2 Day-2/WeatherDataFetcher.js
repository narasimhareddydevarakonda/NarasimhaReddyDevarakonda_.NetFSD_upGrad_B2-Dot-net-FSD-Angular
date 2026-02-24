const latitude = 40.7128;
const longitude = -74.0060;

const formatWeatherReport = (data) => `
------ Weather Report -----

Temperature: ${data.current_weather.temperature}°C
Wind Speed: ${data.current_weather.windspeed} km/h
Wind Direction: ${data.current_weather.winddirection}°
Weather Code: ${data.current_weather.weathercode}

----------------------------
`;

const fetchWeatherWithPromises = () => {
  fetch(
    `https://api.open-meteo.com/v1/forecast?latitude=${latitude}&longitude=${longitude}&current_weather=true`
  )
    .then(response => {
      if (!response.ok) {
        throw new Error("Failed to fetch weather data");
      }
      return response.json();
    })
    .then(data => {
      console.log("Using Promises:");
      console.log(formatWeatherReport(data));
    })
    .catch(error => {
      console.error(`Error: ${error.message}`);
    });
};

const fetchWeatherWithAsync = async () => {
  try {
    const response = await fetch(
      `https://api.open-meteo.com/v1/forecast?latitude=${latitude}&longitude=${longitude}&current_weather=true`
    );

    if (!response.ok) {
      throw new Error("Failed to fetch weather data");
    }

    const data = await response.json();

    console.log("Using Async/Await:");
    console.log(formatWeatherReport(data));
  } catch (error) {
    console.error(`Error: ${error.message}`);
  }
};

fetchWeatherWithPromises();
fetchWeatherWithAsync();