## Software Process Model 
## Content 

* [Introduction](#introduction)
* [Software Process Model](#software-process-model)
  * [Waterfall](#waterfall)
* [User requirements](#user-requriments)
* [System requirements specification](#system-requriemtns-specification)
* [Risk planning](#risk-planning)
* [Appendix](#appendix)
* [Glossary](#glossary)
* [References](#referencing)
* [Developers](#developers)

## Introduction 

This project involves the development of an application for the setup of a library system for an educational institution, such as a university. The purpose of the system is to serve as a means for students and staff members to access various academic services such as resource accessibility, learning support, assistance for teaching staff, and community collaboration.

To ensure the application for the library system is as optimal as possible, it should be designed in a way that allows certain categories of users to access specific and exclusive features such as students having access to rent resources, being able to manage their accounts, viewing their balance, and staff having access to all application functions. The application features may also include a full description of resources in the library, fines for late transactions, encrypted payment information, unique login info for users, and other essential functions.

In summary, the development of the application for the library system will ensure that the system is dynamic enough to adjust to the needs of the users. The team aims to enhance the interaction between the community and the library system as well as boost the overall library experience via the provision of a convenient and user-friendly interface. The team will ensure that this report includes the provision of detailed descriptions involved in the construction of the application for the library system, as well as observations and valid recommendations that may help in kick-starting the successful execution of this progressive project.

## User Requriments 
## Software Requirements Specification (SRS) Report 

 

### 1. Introduction 

#### 1.1 Purpose 

This Software Requirements Specification (SRS) document outlines the specifications for the development of a comprehensive system that encompasses student and staff account management, payment processing, book rental, journal management, and account deletion functionality. 

##### 1.2 Scope 

The system aims to provide a secure and user-friendly platform for students and staff to manage accounts, facilitate payments, rent books, and manage journals. It also ensures adherence to industry standards for payment security and offers a dynamic approach for handling different card types. 

### 2. System Requirements 

#### 2.1 Student Account Requirements 

- Students can access and edit their accounts. 
- Students can view their account balance and update it. 
- Students cannot rent a book if they are in debt until they return the overdue books. 
- Students can reset their passwords securely through a multi-step verification process. 
- Account history and activity logs for students, allowing them to track changes and transactions. 
- Notifications for students when their account balance is low or when a book rental is approaching its due date. 
- Two-factor authentication for enhanced security in student accounts. 

 

#### 2.2 Staff Account Requirements 

- Staff accounts have different levels of access based on roles, such as administrative, financial, and support roles. 
- Staff accounts can generate reports on account balances, transaction histories, and overdue books. 
- Logging and auditing functionalities for staff actions within the system to maintain accountability. 

 

#### 2.3 Payment Requirements 

- Implement a sophisticated card recognition mechanism capable of discerning card types (Visa, debit, Amex) based on the card number. 
- Dynamic system logic tailored to card categories. 
- For Visa and debit cards, prompt users for a three-digit Card Verification Value (CVV) code. 
- For Amex cards, prompt users for a four-digit CVV code. 
- Ensure adherence to standard security practices. 

#### 2.4 Book Requirements 

- Maintain a catalog of 20 books in the system. 
- Include book details: picture, title, author, ISBN, and synopsis. 
- Allow book rentals for 3, 7, and 14 days. 
- System prevents renting if the user is in debt until overdue books are returned. 
- Students can request an extension of the rental period, subject to approval by authorized staff. 

An example of how it needs look in application 

![picture example of how it supposed to look](image.png)

[refference link 1 ]

#### 2.5 Journal Requirements 

- Include 10 journals in the system. 
- Capture journal details: title and volume. 

#### 2.6 Deleting Account Requirements 

- Only authorized personnel can delete an account. 
- Display a pop-up confirmation: "Are you sure you want to delete this account?" 

### 3. Functional Requirements 

#### 3.1 Student Account Functionality 

- Login and authentication for students. 
- Edit account details. 
- View account balance. 
- Rent books. 

##### 3.2 Staff Account Functionality 

- Login and authentication for staff. 
- Access all accounts. 
- Update account balances. 

##### 3.3 Payment Functionality 

- Card recognition and categorization. 
- Dynamic CVV prompts based on card type. 

#### 3.4 Book Functionality 

- Book catalog management. 
- Rental functionality. 
- Overdue book handling. 
- Extension request and approval. 

#### 3.5 Journal Functionality 

- Journal catalog management. 

#### 3.6 Account Deletion Functionality 

- Authorization for account deletion. 
- Confirmation pop-up for account deletion. 

### 4. Non-Functional Requirements 

#### 4.1 Performance 

- System response time: < 2 seconds for standard operations. 

#### 4.2 Dependability 

- System availability: 99.9%. 

#### 4.3 Usability 

- Intuitive user interfaces for both students and staff. 

#### 4.4 Scalability 

- Ability to handle a user base of at least 1000 students and 100 staff members. 

#### 4.5 Security 

- Encryption of sensitive data. 
- Regular security audits. 

### 5. Conclusion 

- This Software Requirements Specification provides a comprehensive overview of the functionalities and specifications required for the development of the proposed system. Adherence to these requirements will ensure a robust, secure, and user-friendly platform for account management, payment processing, book rental, journal management, and account deletion. 


## Risk Planning 

## Appendix 

## Glossary  

## Referencing 


- [nicoletarusnac](https://github.com/nicoletarusnac)
- [GeneralDavid9797](https://github.com/GeneralDavid9797)
- [GeneralDavid9797](https://github.com/GeneralDavid9797)