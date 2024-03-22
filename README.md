# WGUC968 - Software I - C# - Inventory Management System

## Overview

This Inventory Management System is a C# application designed to manage parts and products for an imaginary manufacturing company. Based on specific requirements and guided by a GUI Mock-Up and a UML Class Diagram, this application features a comprehensive user interface and a backend structure to facilitate inventory management tasks efficiently.

### User Interface

The application includes several forms with various controls to interact with the inventory data:

#### Main Form

- **Controls**: Add, Modify, Delete, and Search buttons for parts and products; Exit button; lists for displaying parts and products; text boxes for searching; title labels.
- **Functions**: Navigate to part/product forms, delete selected parts/products, search and display results, exit the application.

#### Add Part Form

- **Controls**: Radio buttons for selecting "In-House" or "Outsourced" parts; Save and Cancel buttons; text boxes and labels for part details including ID, name, inventory level, price, max and min values, and company name or machine ID for outsourced parts.
- **Functions**: Input and save new part details, or cancel the operation.

#### Modify Part Form

- **Similar to the Add Part Form** but pre-populates fields with the selected part's data for editing.

#### Add Product Form

- **Controls**: Save, Cancel, Add part, and Delete part buttons; text boxes for product details; labels; two grid views (one for all parts and another for parts associated with the product); Search button and text field.
- **Functions**: Input and save new product details, associate parts with the product, disassociate parts, or cancel the operation.

#### Modify Product Form

- **Similar to the Add Product Form** but pre-populates fields with the selected product's data for editing.

### Classes and Behavior

Implements classes, methods, and properties as per the attached "UML Class Diagram" to manage parts and products. It includes functionality for adding, modifying, deleting, and searching parts and products, along with input validation to ensure data integrity.

### Input Validation

Ensures user input is valid and logical, preventing errors such as non-numeric values in numeric fields, minimum values being greater than maximum, inventory levels outside min/max bounds, and unauthorized deletion of parts/products.

## Getting Started

To use the Inventory Management System:

1. **Clone the repository** to your local machine.
2. **Open the solution** in Visual Studio.
3. **Build the application** to resolve any dependencies.
4. **Run the application** from Visual Studio to launch the main form.

### License

This project is licensed under the MIT License - see the LICENSE file for details.
