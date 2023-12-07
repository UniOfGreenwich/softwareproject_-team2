# Phase 1 - Requirements Engineering

## Content 
- [Software Process Model](#software-process-model)
- [Content](#content)
- [Introduction](#introduction)
- [User Requriments](#user-requriments)
- [System Requriemtns Specification](#system-requriemtns-specification)
  - [**What is system requriments?**](#what-is-system-requriments)
  - [**What is functional rquriments ?**](#what-is-functional-rquriments-)
  - [**What is non-functional requiremnts?**](#what-is-non-functional-requiremnts)
- [Risk Planning](#risk-planning)
- [Appendix](#appendix)
- [Glossary](#glossary)
- [Referencing](#referencing)
- [Authors](#authors)
* [Introduction](#introduction)
* [Software Process Model](#software-process-model)
  * [Waterfall](#waterfall)
* [System requirements specification](#system-requriemtns-specification)
  * [Introduction](#1-introduction)
  * [System requirements](#2-system-requirements)
  * [Functional requirements](#3-functional-requirements)
  * [Non functional requirements](#4-non-functional-requirements)
  * [Conclusion](#5-conclusion)
* [User requirements](#user-requriments)
* [Risk planning](#risk-planning)
* [Appendix](#appendix)
* [Glossary](#glossary)
* [References](#referencing)
* [Developers](#developers)

## Introduction 

This project involves the development of an application for the setup of a library system for an educational institution, such as a university. The purpose of the system is to serve as a means for students and staff members to access various academic services such as library resources and the ability to manage their activity on the application while being dynamic enough to adjust to the needs of the consumers via a user-friendly interface.

To ensure the application for the library system is as optimal as possible, it should be designed in a way that allows users to access specific and exclusive features such as resource accessibility, learning support, assistance for teaching staff, and community collaboration. The software process model to be applied for this project will be the **Waterfall methodology**.  The user and system requirements for this project will be described in this report, and possible risks will be indicated as well as how they can be managed and planned for. The project management plan will also be laid out via a Gantt chart.

The team will ensure that this report includes the provision of detailed descriptions involved in the construction of the application for the library system, as well as observations and valid recommendations that may help in kick-starting the successful execution of this progressive project.

## Task Table 

| Username | Tasks | 
--- | --- 
[Sam](https://github.com/SamEng001) | [Software Process Model](#software-process-model), [Content](#content), [Table](#table)
[Zeynep]() | [Software requirements](#system-requriemtns-specification)
[Nicoleta](https://github.com/nicoletarusnac) | [User requirements](#user-requriments)
[Oba](https://github.com/GeneralDavid9797) | [Introduction](#introduction), [Risk planning](#risk-planning)

## Software Process Model 
A software model process is an arrangement of processes meant to develop software, and it is an abstract representation of the process. Activities like planning, requirement analysis, designing, implementing, testing, and development are processes for developing software.

Different criteria can be met by using a variety of process models. These are what we call Software Development Life Cycle models, or SDLC models. The following are the key and most widely used SDLC models:

Agile model, Waterfall model, Incremental model, V model

### Waterfall
-------------

In a waterfall model, there is no phase overlap and each step must be finished before the next can start. The entire software development process is split up into distinct phases as per "The Waterfall" methodology. Usually, in this Waterfall model, the result of one phase serves as the sequential input for the following phase.

As with other development methodologies, waterfall does not include a project's end user. Client feedback is incorporated after gathering and defining initial requirements with users. Using the waterfall process eliminates the client from the main part of the process, which speeds up development.

**Advantages**

- As a rigid model, it's easy to manage - every phase has specific deliverables and a review process.
- One phase at a time is processed and completed in this model. There are no overlaps between phases.
- As hardware isn't flexible, you need to be clear about the requirements before implementing.

**Disadvantages** 

- Changing something that was not well thought out at the concept stage is very difficult after the application is in the testing stage.
- Uncertainty and high risk.
- Object-oriented and complex projects are not well suited to this model.
- Projects that take a long time to complete are poorly suited to this model.

Waterfall model consists of the following phases:

![Waterfall model phases!](software-process-model.png)

### 1. Requirement phase
In a formal requirements document, also called a functional specification, all the requirements, deadlines, and guidelines for the project are analysed.

There are also different types of requirements, including:

**User requirements:**

User requirements provide a description of what users want from the system. It also ensures that functionalities, usability, and high-level expectations are met, developer can do so by answering this question, "What should the system do for users?"

**System Requirements:**

In this section, we discuss how we will satisfy the user's requirements with our system by using specified technical details, functions, services and constraints.

**Constraints:**

Constraints describe the limitations and functionality of the system. It also considers budget, technological choices, and legal requirements when developing a system.

In our Library system, requirements like staff access control, student payment capability, rental facilities, payment verification, card verification are important. 

### 2. Design phase 
Design specifications detail technical design requirements, such as programming languages, hardware, information sources, architectures, and services.

High level design phase:

This phase involves listing and understanding the modules involved, along with determining their correlations, generating architecture diagrams, and establishing database tables.

Low level design phase: 

Low-level Design documents contain pseudocode for each module, which helps the programmer write code directly from them. Furthermore, it provides information about interfaces, error messages, dependency issues, and inputs and outputs.

### 3. Implementation phase 
This phase involves writing the source code in accordance with the requirements. A working code is created based on the physical design specifications. In order to develop a system, small programs called units are written, and then these units are integrated.

### 4. Testing phase
 By running test cases either manually or automatically, testers check the program for all possible defects. In order to ensure that all requirements are met, the client is also involved in the testing phase. Quality Assurance ensures that all bugs and flaws are repaired during this phase.

### 5. Deployment phase 
Software is deployed into a live environment so that its performance can be tested. Users can access the software as soon as it has been deployed. In some cases, real-time users are also trained during this phase in order to communicate the benefits of the system.

### 6. Maintenance phase 
It is team's job to ensure that the software that they have developed runs smoothly without any bugs or downtime. So for that, regular maintenance is necessary in order to enhance, improve and update the software.

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

 
## System Requriemtns Specification 
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

![picture example of how it supposed to look](Example-image-of-user-interface.png)


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

## User requirements 

In order to get the library system as user-friendly as possible there are some basic user requirements that should be met. These are usually divided in functional and non-functional. 

### Functional requirements

Functional requirements are the key features that the system should be able to provide for all the users, they are user-focused and task-oriented.

* User Registration and Login 

Users should be able to create their account by providing personal information such as e-mail, password, date of birth, phone number, and student ID.

* Search and browse

Users should be able to search online for the books, authors, topics, journals. Clicking on a book or journal should display its details such as title, author, summary, and availability status (should display if it's  available online or on-site). 

* Rental information 

The available books or journals should be able to rent for 3days, 7days, 14 days. This information should be displayed in the details of available books and journals. 

* Renewal system

Users should be able the renew the rental period for a current book they holding direclty online in their account.

* Late fee information and payment

Users should be notified about the library's late fee policy and the charges applied with it. Each late day is 10p with maximum fine being the value of the book. It should calculate the fine and inform the account user and should be available to pay it straight away online in the app with a payment validation check.

* Account Management

Users should be able to view and edit their profile, borrowing history and the due dates in their account management section.


### Non-functional requirements

Non-functional requirements are usually a bit more technical and are responsible for the quality, performance and security part of the user-system experience.

* Usability 

The system should be easy and straitforward to use, efficient and fast enough.

* Security 

Users should be protected against the data leaking, unauthorized access, and malicious software.

* Portability and compatibility

The system should be able to run on different operating systems and should be compatible with the lastest versions of the most known and used operating system and online environments.

## Risk Planning 

## Appendix 

## Glossary  
User requirements - is a set/list of instructions/functionalities that a system needs to meet in order to be user friendly and efficient.

Account management- reffers to user's profile section where they can view/change/delete their personal information and other relevant activies to their acccount.

## Referencing 
Scribd. (n.d.). What Are The Functional and Non Functional Requirements of A Library Management System | PDF | Librarian | Databases. [online] Available at: https://www.scribd.com/document/177041340/What-Are-the-Functional-and-Non-Functional-Requirements-of-a-Library-Management-System.

‌
Lily Wulandari, L. (2017) User Requirements Analysis for digital library application ... - iopscience, IOPScience. Available at: https://iopscience.iop.org/article/10.1088/1742-6596/818/1/012004. 

Altexsoft (2021). Functional and Non-functional Requirements: Specification an. [online] AltexSoft. Available at: https://www.altexsoft.com/blog/functional-and-non-functional-requirements-specification-and-types/.

‌


- [nicoletarusnac](https://github.com/nicoletarusnac)
- [GeneralDavid9797](https://github.com/GeneralDavid9797)
- [turko06](https://github.com/turko06)
- [SamEng001](https://github.com/SamEng001)

