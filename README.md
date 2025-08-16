[한국어 버전 보기](README.ko.md)

# Xamarin.Forms Public IP Info Base Project for Tizen Galaxy Watch

This repository contains a foundational Xamarin.Forms project designed to fetch and display public IP address information and related details using the `ipinfo.io` API. While this project provides the core cross-platform logic, it is specifically intended to serve as a **base project** for developing a Tizen Galaxy Watch application.

## Features

*   **Public IP Information Retrieval:** Fetches the public IP address and comprehensive details such as city, region, country, location (latitude/longitude), organization (ISP), postal code, and time zone from `https://ipinfo.io/json`.
*   **Cross-Platform Core:** Built with Xamarin.Forms (C# .NET), providing a shared codebase for UI and logic that can be extended to various platforms.
*   **Tizen Galaxy Watch Ready:** Designed as a starting point for integrating with and deploying to Tizen-based Galaxy Watch devices.

## Technologies Used

*   **Xamarin.Forms:** A cross-platform UI toolkit for building native UIs with C# and .NET.
*   **C# .NET:** The primary programming language and framework.
*   **HttpClient:** Used for making asynchronous HTTP requests to the `ipinfo.io` API.
*   **Newtonsoft.Json:** A popular high-performance JSON framework for .NET, used for deserializing the API responses.
*   **ipinfo.io API:** The external service providing the public IP information.

## Project Structure

The solution is structured as a typical Xamarin.Forms project:

*   `Cross-platform-App/Cross-platform-App/`: This is the core Xamarin.Forms shared project (PCL/Shared Project) containing the common UI (XAML) and business logic (C#). This is where the IP fetching and display logic resides.
*   `Cross-platform-App/Cross-platform-App.Android/`: The Android-specific project for deploying the application to Android devices.
*   `Cross-platform-App/Cross-platform-App.iOS/`: The iOS-specific project for deploying the application to iOS devices.
*   `Cross-platform-App/Cross-platform-App.UWP/`: The Universal Windows Platform project for deploying the application to Windows devices.

To target Tizen, a new Tizen project would typically be added to this solution.

## Getting Started

### Prerequisites

*   **Visual Studio:** Install Visual Studio (Windows or Mac) with the "Mobile development with .NET" workload.
*   **.NET SDK:** Ensure you have the necessary .NET SDKs installed.
*   **Tizen SDK (for Tizen development):** If you plan to extend this to a Tizen Galaxy Watch app, you will need to install the Tizen SDK and Visual Studio Tools for Tizen.

### Setup and Build

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/freeNanum/Xamarin.Forms-PublicIPinfo-App.git
    cd Xamarin.Forms-PublicIPinfo-App
    ```
2.  **Open the solution:**
    Open the `Cross-platform-App/Cross-platform-App.sln` file in Visual Studio.
3.  **Restore NuGet Packages:**
    Visual Studio should automatically restore the necessary NuGet packages. If not, right-click on the solution in the Solution Explorer and select "Restore NuGet Packages".
4.  **Build the solution:**
    Build the solution to ensure all projects compile correctly.

### Running on Emulators/Devices (Android, iOS, UWP)

*   Set the desired platform project (e.g., `Cross-platform-App.Android`) as the startup project.
*   Select an emulator/simulator or a connected device from the Visual Studio toolbar.
*   Run the application.

### Extending to Tizen Galaxy Watch

This project provides the core logic. To create a Tizen Galaxy Watch application:

1.  **Add a new Tizen project:** In Visual Studio, right-click on your solution, select `Add` > `New Project...`, and choose a "Tizen Wearable App (Xamarin.Forms)" or similar template.
2.  **Reference the shared project:** Ensure the new Tizen project references the `Cross-platform-App` shared project.
3.  **Install Tizen NuGet packages:** Install the `Xamarin.Forms.Platform.Tizen` NuGet package in your Tizen project.
4.  **Initialize Xamarin.Forms:** In your Tizen project's `MainApplication.cs` (or equivalent), initialize Xamarin.Forms and load the `App` from your shared project.
5.  **Deploy to Tizen Device/Emulator:** Use the Tizen SDK tools and Visual Studio's Tizen integration to deploy and debug the application on a Tizen Galaxy Watch emulator or a physical device.

## Usage

Once the application is running on a target device or emulator, simply tap the button (labeled "Get Public IP" or similar in `MainPage.xaml`) to fetch and display your current public IP address and associated information.

## Contributing

Contributions are welcome! Please feel free to fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the terms of the [LICENSE](LICENSE) file.
