# Customer Information Manager

## Description

**Customer Information Manager** is a simple Windows Forms application that allows users to input customer details, including their name, address, telephone number, and customer number. The application also tracks whether the customer is on a mailing list. Once the user enters the information, the app displays the details for review. The application uses object-oriented programming concepts, such as classes and inheritance, to organize customer and person data.

## Features

- **Input Customer Information**: Allows users to input customer details, such as name, address, telephone number, and customer number.
- **Mailing List Preference**: Lets users check if the customer should be included in the mailing list.
- **Display Information**: Displays the entered customer details in a readable format.
- **Clear Fields**: Clears all input fields and the displayed information.
- **Exit Application**: Closes the application.

## How It Works

1. **Enter Customer Details**:  
   Users can input customer information (name, address, phone number, and customer number). There's also a checkbox to indicate whether the customer should be on the mailing list.

2. **Display Customer Information**:  
   Once all fields are filled, click the **Display** button to view the customer details, including whether they are on the mailing list.

3. **Clear Form**:  
   Click **Clear** to reset all input fields and clear the displayed customer information.

4. **Exit**:  
   Click **Exit** to close the application.

## Classes and Inheritance

- **Person Class**: Contains basic personal information such as `Name`, `Address`, and `TelephoneNumber`.
- **Customer Class**: Inherits from the `Person` class, adding additional customer-related properties such as `CustomerNumber` and `OnMailingList`.

## Installation

1. **Clone or Download the Repository**  
   Clone this repository or download the project files to your local machine.

2. **Open the Project in Visual Studio**  
   Open the project in Visual Studio and build it using **Build** > **Build Solution**.

3. **Run the Application**  
   After building the project, run the application by selecting **Start** in Visual Studio or directly executing the compiled `.exe` file.

## Usage

1. Enter the customer's **Name**, **Address**, **Phone Number**, and **Customer Number**.
2. Check the **Mailing List** checkbox if the customer should be on the mailing list.
3. Click **Display** to view the entered customer information.
4. Click **Clear** to reset all fields and labels.
5. Click **Exit** to close the application.

## Example

**Input**:  
- Name: John Doe  
- Address: 123 Main St, Springfield  
- Phone: 555-1234  
- Customer Number: 4567  
- Mailing List: Checked

**Output**:
Name: John Doe Address: 123 Main St, Springfield Telephone: 555-1234 Customer Number: 4567 On Mailing List: True

