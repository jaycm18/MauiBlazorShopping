# Shopping List App

A simple shopping list application built with **.NET MAUI** and **Blazor**. This app allows users to manage their shopping lists by adding, marking items as purchased, and deleting items.

## Features

- Add items to the shopping list with a name and quantity.
- Mark items as purchased with a checkbox or by clicking the item name.
- Delete items from the shopping list.
- Responsive UI built with Blazor and styled for usability.


## Technologies Used

- **.NET MAUI**: Cross-platform framework for building native apps.
- **Blazor**: For building the interactive UI.
- **C#**: Backend logic and data handling.

## Installation

1. Clone the repository:
   git clone https://github.com/yourusername/shopping-list-app.git cd shopping-list-app

2. Open the project in Visual Studio.

3. Restore NuGet packages:
   dotnet restore

4. Run the application:
   - Select the target platform (Android, iOS, Windows, etc.).
   - Press `F5` or click the "Run" button in Visual Studio.

## Usage

1. **Add Items**: Enter the item name and quantity, then click the green "+" button.
2. **Mark as Purchased**: Click the checkbox or the item name to mark it as purchased. Purchased items will have a strikethrough and gray color.
3. **Delete Items**: Click the red "X" button to remove an item from the list.

## Project Structure

- **Components/Pages/Home.razor**: Main shopping list page.
- **Models/Shoplist.cs**: Data model for shopping list items.
- **Services/ShoplistService.cs**: Service for managing shopping list data.
- **MauiProgram.cs**: Configures the app and services.

## Data Model

The `Shoplist` model represents a shopping list item:
public class Shoplist { public int Id { get; set; } public string Item { get; set; } public int Amount { get; set; } public bool Purchased { get; set; } }

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

## License

This project is licensed under the [MIT License](LICENSE).

---

### Author

Created by Joonas (https://github.com/jaycm18).
