# Movecoin Challenge App

Welcome to the Movecoin Challenge App! This application allows users to create and join health and wellness challenges while earning movecoins based on their performance.

## Features

- **Challenge Creation**: Users can create challenges by specifying various metrics, stakes, rewards, and duration.
- **Metrics**: Choose from steps, floors, and intensity minutes to track performance.
- **Scoring System**: Calculate scores using a weighted sum of selected metrics, allowing users to customize the importance of each metric.
- **Stakes**: Set fixed or variable stakes for challenges, with options for minimum and maximum values.
- **Rewards Distribution**: Rewards are calculated based on scores and stakes, minus the organizer's profit margin.
- **Flexible Duration**: Create challenges that last for a day, weekend, week, month, or a custom time frame.

## Getting Started

To get started with the Movecoin Challenge App, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/movecoin-challenge-app.git
   cd movecoin-challenge-app
   ```

2. **Install Dependencies**:
   Make sure you have the necessary dependencies installed. You can do this by running:
   ```bash
   dotnet restore
   ```

3. **Run the Application**:
   To run the application, use the following command:
   ```bash
   dotnet run
   ```

## Project Structure

The project is organized into several directories:

- **src**: Contains the main application code, including models, view models, views, and services.
- **Resources**: Contains fonts, images, and styles used in the application.
- **MauiProgram.cs**: The entry point for the MAUI application.
- **MovecoinApp.csproj**: The project file defining dependencies and build settings.

## Contributing

Contributions are welcome! If you would like to contribute to the Movecoin Challenge App, please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.

## Acknowledgments

Thank you for using the Movecoin Challenge App! We hope you enjoy creating and participating in challenges that promote health and wellness.