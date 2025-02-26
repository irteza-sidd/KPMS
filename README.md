# KPMS (Parking Management System)

## Acknowledgments
In this project, we have utilized a 3-Tier Architecture to separate concerns in the software. The Data Access Layer and Business Logic Layer are abstracted to ensure better manageability and scalability. By using an SQL database, we efficiently store and manage vehicle-related records. This project has provided us with the ability to design and implement systems that are user-friendly and reduce manual efforts, making it easier for organizations to manage vehicles.

## Abstract
The project focuses on storing vehicle records in an efficient and structured manner. It is designed to be user-friendly, reducing the time and human effort needed to manage vehicles. The main goal is to replace manual records with digital storage, making vehicle management systems smarter and faster.

## Table of Contents
1. [3-Tier Architecture](#3-tier-architecture)
2. [Introduction](#introduction)
3. [Problem and Solution](#problem-and-solution)
4. [Project Representation Diagram](#project-representation-diagram)
5. [Screenshots](#screenshots)
6. [Conclusion](#conclusion)

## 3-Tier Architecture

### Overview
The system follows a Three-Tier Architecture that divides the application into three layers:
1. **Presentation Layer (UI)**: This is the user interface where users interact with the system.
2. **Application Layer (Business Logic)**: This layer handles the application's core functionality.
3. **Data Layer (Database)**: This layer stores all the data related to vehicles.

This architecture provides the advantage of separating concerns, making the application easier to maintain and scale.

## Introduction

### Importance
In the past, vehicle management was done manually, requiring paper records. This project digitizes the process, making vehicle management faster, more efficient, and less prone to errors.

### Applications
The system can be implemented in various management systems, including parking management systems, vehicle fleet management, and more.

### What You Will Do
The project aims to improve and sell the system to different companies and organizations or create customized versions for specific management needs.

## Problem and Solution

### Problem
A major challenge was connecting the database and creating relevant tables. Storing vehicle data (cars, buses, scooters) in the appropriate tables was also a challenge.

### Solution
We overcame these challenges through our own efforts, research, and by referring to lab manuals. We successfully implemented the database connections and the proper storage of data in respective tables.

### Workflow
Our workflow was stable, with minor delays during the UI design phase. The entire project was completed within 14 days.

## Project Representation Diagram
The system starts with the login page where the admin enters credentials. Upon successful login, the user is directed to the home page where vehicle types (Car, Bus, Scooter) can be selected. The user can then choose between inserting or deleting records related to vehicle arrivals and departures.

## Screenshots

### Login Form
The login form checks the username and password against the Admin table in the database. If they match, the user is directed to the main menu.

### Home Page
The home page presents the user with options to select the vehicle type (Car, Bus, Scooter). Each selection leads to the respective vehicle management form.

### Vehicle Arrival Form
Upon selecting "Arrival" for a vehicle, a form appears where information is entered into the system. This data is stored in the respective table (e.g., `Carinfo`, `Businfo`, `Scooterinfo`).

### View Records
The "View Records" button fetches data from the database and displays it in a grid view, allowing the user to search for records using various criteria like plate number or owner’s name.

### Vehicle Departure
When a vehicle departs, its information is matched with the database, deleted, and an invoice is automatically generated.

## Conclusion
This project has demonstrated how to build a robust, scalable, and efficient system for managing vehicle records using 3-Tier Architecture, SQL databases, and a user-friendly Windows Forms interface. The system is adaptable and can be expanded for other management purposes.

## Technologies Used
- **C#**
- **SQL Server**
- **Windows Forms**
- **3-Tier Architecture**
- **Advanced Reporting Features**
