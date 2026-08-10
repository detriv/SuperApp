# .NET MAUI SuperApp Project Instructions

This project is a .NET MAUI application.

## Developer Commands

-   **Build:** `dotnet build`
-   **Run:** `dotnet run` (or run directly from Visual Studio/VS Code)
-   **Test:** There is no dedicated test project. `dotnet test` currently performs a build and displays warnings. If unit tests are added, they would be executed using `dotnet test`.

## Architecture Notes

-   **Framework:** .NET MAUI
-   **UI Components:** Utilizes `Syncfusion.Maui` for various UI elements (Buttons, Carousel, Inputs, Picker).
-   **Navigation:** Page navigation is handled using `Navigation.PushAsync()` for forward navigation and `Navigation.PopAsync()` for backward navigation.
-   **XAML:** XAML source generation is enabled (`MauiXamlInflator=SourceGen`).

## Known Quirks / Conventions

-   **Obsolete Warnings:** The project currently has warnings related to `Page.DisplayAlert()` (use `DisplayAlertAsync` instead) and `LayoutOptions.FillAndExpand` (deprecated, use `Grid` instead). Additionally, `Frame` is no longer supported; use `Border` instead.
-   **Entry Points:** The primary user interaction flow starts with `LoginPage.xaml` and `RegisterPage.xaml`. `App.xaml.cs` and `MainPage.xaml.cs` serve as the application's core entry points.

## Important Constraints

-   Follow existing C# coding conventions and XAML styling.
-   Address existing warnings (e.g., obsolete API usage) during related modifications.
