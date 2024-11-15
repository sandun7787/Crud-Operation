CRUD Operations in ASP.NET Core MVC with Entity Framework Core and SQL Server
This project demonstrates how to perform CRUD operations (Create, Read, Update, Delete) using ASP.NET Core MVC and Entity Framework Core with SQL Server. Additionally, it includes functionality to upload and manage images.

Features
ASP.NET Core MVC framework with a clean Model-View-Controller structure.
Database interaction using Entity Framework Core.
SQL Server database integration.
Image upload and storage in the wwwroot folder.
Fully functional CRUD operations.
Prerequisites
Visual Studio 2022 or later (with ASP.NET and web development workload installed).
SQL Server (any edition) installed locally or hosted.
.NET Core SDK 6.0 or higher.
Basic knowledge of ASP.NET Core and Entity Framework Core.
Getting Started
1. Clone the Repository
bash
Copy code
git clone https://github.com/yourusername/your-repo-name.git
cd your-repo-name
2. Configure the Database Connection
Open the appsettings.json file and modify the connection string to point to your SQL Server instance:
json
Copy code
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Replace YOUR_SERVER_NAME with your SQL Server instance name.
Replace YOUR_DATABASE_NAME with the desired database name.
3. Set Up the Database
Open the Package Manager Console in Visual Studio.
Run the following commands to apply migrations and create the database:
bash
Copy code
Add-Migration InitialCreate
Update-Database
4. Build and Run the Project
Run the application using Visual Studio or the .NET CLI:
bash
Copy code
dotnet run
Open your browser and navigate to https://localhost:5001 (or the URL provided by the application).
Application Structure
Models
Product: Represents a product with properties like Id, Name, Description, Price, and ImagePath.
Controllers
ProductController: Handles CRUD operations and image uploads.
Views
Razor views (.cshtml) for Create, Read, Update, and Delete operations.
CRUD Operations
1. Create
Add a new product and upload an image.
Navigate to /Product/Create.
2. Read
View a list of all products.
Navigate to /Product.
3. Update
Edit product details and replace the image.
Navigate to /Product/Edit/{id}.
4. Delete
Remove a product from the database.
Navigate to /Product/Delete/{id}.
Image Upload
Uploaded images are stored in the wwwroot/products folder. Each image is renamed with a timestamp to ensure unique filenames.

Code for Image Upload
csharp
Copy code
string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(productDto.ImageFile.FileName);
string imageFullPath = Path.Combine(_environment.WebRootPath, "products", newFileName);

using (var stream = new FileStream(imageFullPath, FileMode.Create))
{
    productDto.ImageFile.CopyTo(stream);
}

product.ImagePath = $"/products/{newFileName}";
Technologies Used
ASP.NET Core MVC
Entity Framework Core
SQL Server
Bootstrap (for UI styling)
C#
Screenshots
Include screenshots of the application, such as:

Product list page
Create/Edit product forms
Image upload functionality
License
This project is licensed under the MIT License. See the LICENSE file for details.

Contributing
Feel free to submit issues or pull requests. Contributions are welcome!

Contact
For any questions or feedback, contact me at sandunwarnasooreya345@gmail.com or open an issue in this repository.
