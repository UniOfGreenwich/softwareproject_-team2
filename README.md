## Content
- **Introduction**

- **Table**

- **Overall Architecture of the System**

- **Use case Diagram**

- **Sequence Diagram**

- **Class Diagram**

- **Activity Diagram**

- **State Chart Diagram**

- **Reference**

- **Gantt Chart**

- **Appendix**

## Introduction

## Table

## Overall Architecture of the System

## Use case diagram

In software development, a use case diagram is a graphic representation that shows how system actors interact with the system. By depicting a system's use cases and the roles that interact with them, it encapsulates the dynamic behaviour of the system.

### Tabular description:

| Actor | Student |
|-------|---------|
Description | Student can login in their account, Student can check account, Student can check balance, Student can payoff late fee, Student can search books, Student can rent books. 
Data | Login details of student (username and password), Search history, Rented books history, Late fee days + 10p each day. 
Stimulus | Entering invalid login credentials, Attempting to pay off late fees without any late fees being accrued, Trying to rent a book that is not available Attempting to access restricted account information.
Response | Displaying appropriate error messages for invalid login attempts, Providing feedback when attempting to pay off non-existing late fees, Notifying if a requested book is unavailable for rent, Implementing access controls to restrict unauthorized access.
Comments | Include password recovery or reset functionality for forgotten passwords, Consider implementing a session timeout for security, Validate and sanitize user inputs to prevent potential security vulnerabilities, Implement logging for login attempts and critical actions for auditing purposes.
----
| Actor | Staff |
|-------|-------|
Description | Staff can login in their account, Staff can check their account as well as any students account, Staff can check their balance as well as student’s balance,Student can search books, Staff can rent books for student, Staff can payoff late fee, delete any student’s account. 
Data | Login details of staff (username and password), Search history, Rented books list of any student, Late fee days + 10p each day of all students, Financial log, Inventory (Id. number of for each book, Title of books, ISBN no., Author, Synopsis, Picture of book, Journal title, paper title, volume number, date)
Stimulus | Attempting to rent a book for a student with insufficient balance, Trying to delete a student account with outstanding late fees, Accessing restricted functionalities based on staff roles, Inputting incorrect ISBN or book details during the rental process.
Response | Displaying a notification for insufficient balance during book rental, Preventing the deletion of a student account with outstanding late fees, Restricting access to functionalities based on staff roles, Validating book details to avoid errors during the rental process.
Comments | Implement a robust authentication and authorization system, Ensure proper handling of financial transactions for balance updates, Consider implementing a confirmation step for critical actions like account deletion, Provide a comprehensive error-handling mechanism to guide users in case of issues.

## Sequence Diagram

## Class Diagram

## Activity Diagram 

## State Chart Diagram

## Reference 
PlantUML.com. (n.d.). Use case Diagram syntax and features. [online] Available at: https://plantuml.com/use-case-diagram.

‌

## Gantt Chart

## Appendix