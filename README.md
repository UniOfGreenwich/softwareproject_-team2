# Phase 2- System Modelling and Design Phase
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
Stimulus | Entering invalid login credentials,  Trying to rent a book that is not available
Response | Displaying appropriate error messages for invalid login attempts, Notifying if a requested book is unavailable for rent, Payment successful, Rented successful 
Comments | Validate and sanitize user inputs to prevent potential security vulnerabilities.
----
| Actor | Staff |
|-------|-------|
Description | Staff can login in their account, check their account as well as students account, check student balance, search books, rent books for student, payoff late fee, delete any student’s account. 
Data | Login details of staff (username and password), Search history, Rented books list of any student, Late fee days + 10p each day of all students, Financial log, Inventory (Id. number of for each book, Title of books, ISBN no., Author, Synopsis, Picture of book, Journal title, paper title, volume number, date)
Stimulus | Entering invalid login credentials,  Trying to rent a book that is not available, Trying to delete a student account with outstanding late fees. 
Response | Preventing the deletion of a student account with outstanding late fees, Disply popup before deleting student account, Validating book details to avoid errors during the rental process, Payment successful, Rented successful. 
Comments | Ensure proper handling of financial transactions for balance updates, Consider implementing a confirmation step for critical actions like account deletion.

## Sequence Diagram

## Class Diagram

## Activity Diagram 

## State Chart Diagram

## Reference 
PlantUML.com. (n.d.). Use case Diagram syntax and features. [online] Available at: https://plantuml.com/use-case-diagram.

‌

## Gantt Chart

## Appendices
<details>
<summary> Use Case Diagrams </summary>

![Student Use Case Daigram](<Student Use Case Daigram.png>)

![Staff Use Case Diagram](<Staff Use Case Diagram.png>)
</details>

<details>
<summary> Sequence Diagram </summary>

</details>

<details>
<summary> Class Diagram </summary>

</details>

<details>
<summary> Activity Diagram </summary>

</details>

<details>
<summary> State Chart Diagram </summary>

</details>

