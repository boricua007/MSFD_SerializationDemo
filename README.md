# MSFD Serialization Demo

A comprehensive C# console application demonstrating multiple serialization techniques in .NET 9.0, showcasing Binary, XML, and JSON serialization methods for educational and professional development purposes.

## 🌐 Live Demo

**Console Application** - Run locally to see serialization outputs →

## Documentation

• [Project Overview](#project-overview) - Core functionality and serialization techniques  
• [Technology Stack](#technology-stack) - Frameworks and tools used  
• [Key Features](#features) - Serialization methods and outputs  
• [Code Structure](#code-structure) - Architecture and file organization  

## Project Overview

This project showcases fundamental serialization techniques in C#/.NET development, featuring:

• **Binary Serialization**: Custom binary data writing using `BinaryWriter` for compact file storage  
• **XML Serialization**: Standard XML serialization using `XmlSerializer` for structured, human-readable data  
• **JSON Serialization**: Modern JSON serialization using `System.Text.Json` for web-friendly data exchange  
• **Person Model**: Simple data model demonstrating different serialization approaches  
• **File Output Generation**: Creates multiple file formats from the same data source  
• **Cross-Platform Compatibility**: Built on .NET 9.0 for modern development environments  

## Features

✅ **Binary Serialization**: Custom binary file creation with `BinaryWriter` for efficient data storage  
✅ **XML Serialization**: Standards-compliant XML output with proper schema and formatting  
✅ **JSON Serialization**: Clean JSON output compatible with web APIs and modern applications  
✅ **Person Data Model**: Simple class structure with UserName and UserAge properties  
✅ **File Generation**: Automatic creation of three different serialized file formats  
✅ **Console Logging**: Real-time feedback showing serialization completion status  
✅ **Cross-Format Comparison**: Side-by-side demonstration of serialization output differences  
✅ **Educational Structure**: Clear, commented code perfect for learning serialization concepts  

## Technology Stack

• **Framework**: .NET 9.0 Console Application  
• **Language**: C# with modern language features  
• **Serialization Libraries**: 
  - `System.IO.BinaryWriter` for binary serialization
  - `System.Xml.Serialization.XmlSerializer` for XML serialization
  - `System.Text.Json.JsonSerializer` for JSON serialization
• **File I/O**: Native .NET file handling with `FileStream` and `StreamWriter`  

## Code Structure

### Models

• **Person Class**: Core data model with UserName (string) and UserAge (int) properties  
• **Sample Data**: Predefined test data (Alice, age 30) for consistent demonstration  

### Serialization Methods

• **Binary Serialization**: Manual binary writing with `BinaryWriter` for compact storage  
• **XML Serialization**: Automated XML generation with proper schema compliance  
• **JSON Serialization**: Modern JSON output using `System.Text.Json` for web compatibility  

### Output Files

• **person.dat**: Binary serialized data file (compact, not human-readable)  
• **person.xml**: XML formatted data with proper schema and structure  
• **person.json**: Clean JSON format perfect for API integration  

## Educational Value

This project serves as a comprehensive example for developers learning:

• **Serialization Fundamentals**: Understanding different data serialization approaches  
• **File I/O Operations**: Working with various file streams and writers in .NET  
• **Data Format Comparison**: Analyzing trade-offs between Binary, XML, and JSON formats  
• **Console Application Development**: Building simple but effective command-line tools  
• **.NET 9.0 Features**: Modern C# development practices and library usage  
• **Cross-Platform Development**: Building applications that work across different operating systems  

## Architecture Highlights

### File Organization
```
MSFD_SerializationDemo/
├── Program.cs                    # Main application logic with all serialization methods
├── MSFD_SerializationDemo.csproj # .NET 9.0 project configuration
├── person.dat                   # Generated binary output
├── person.xml                   # Generated XML output
├── person.json                  # Generated JSON output
└── README.md                    # Project documentation
```

### Performance Characteristics

• **Binary**: Smallest file size, fastest write/read operations  
• **XML**: Human-readable, schema validation, larger file size  
• **JSON**: Web-friendly, moderate size, excellent interoperability  

## Microsoft Full Stack Developer Certification

This project demonstrates key competencies required for the Microsoft Full Stack Developer certification:

• ✅ **C# Programming**: Object-oriented programming with modern C# syntax  
• ✅ **.NET Framework Mastery**: Utilizing .NET 9.0 libraries and features  
• ✅ **File I/O Operations**: Working with different file streams and serialization methods  
• ✅ **Data Serialization**: Understanding multiple serialization techniques and their applications  
• ✅ **Console Application Development**: Building efficient command-line applications  
• ✅ **Cross-Platform Development**: Creating applications that work across different environments  
• ✅ **Error Handling**: Implementing proper resource management with `using` statements  
• ✅ **Code Organization**: Structuring applications with clear separation of concerns  

## Learning Objectives

This application demonstrates:

• **Serialization Fundamentals**: Understanding when and how to use different serialization methods  
• **Performance Considerations**: Analyzing file size and speed trade-offs between serialization formats  
• **File I/O Best Practices**: Proper resource management and file handling techniques  
• **Data Model Design**: Creating simple but effective data structures for serialization  
• **Cross-Format Compatibility**: Understanding how data translates between different formats  
• **Modern .NET Development**: Leveraging .NET 9.0 features and best practices  

## How to Run

1. **Clone the repository**:
   ```powershell
   git clone https://github.com/boricua007/MSFD_SerializationDemo.git
   cd MSFD_SerializationDemo
   ```

2. **Build and run the application**:
   ```powershell
   dotnet run
   ```

3. **View generated files**:
   - Check `person.dat` for binary output
   - Open `person.xml` for XML formatted data
   - View `person.json` for JSON formatted data

## Sample Output Files

### person.json
```json
{"UserName":"Alice","UserAge":30}
```

### person.xml
```xml
<?xml version="1.0" encoding="utf-8"?>
<Person xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <UserName>Alice</UserName>
  <UserAge>30</UserAge>
</Person>
```

### person.dat
Binary file containing compressed data (not human-readable)

This SerializationDemo application showcases essential .NET serialization techniques with emphasis on practical implementation and educational value - fundamental skills for full-stack software developers.

## About

**.NET 9.0 C# Console Application** built for the Microsoft Full Stack Developer course as part of the certification track. This app demonstrates fundamental serialization techniques essential for modern application development.