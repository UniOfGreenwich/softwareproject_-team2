
## Phase 3 Implementation and Testing

## Content

[**Introduction**](#1-introduction)

[**Table**](#2-table)

[**Implementation**](#3-implementation)

 * [Login Page](##31-login-page)

 * [Student and Staff Home Page](##32-student-and-staff-home-page)

 * [Balance management and payment](#33-balance-managment-and-payment-page)

 * [Renting the books and journals](#34-renting-the-books-and-journals)
   
[**Testing**](#4-testing)

[**Conclusion**](#5-conculusion)

## 1. Introduction

Phase 3 marks a pivotal stage in our project's development lifecycle, where we transition from design concepts to tangible software solutions. This phase focuses on the meticulous implementation of our system using the C# programming language, coupled with rigorous testing procedures to ensure functionality and reliability.

The adoption of C# as our primary programming language underscores our commitment to leveraging robust tools for software development. Its extensive features and strong typing system provide a solid foundation for translating our design specifications into executable code.

Testing stands as an indispensable aspect of this phase, serving as a critical quality assurance mechanism. Through systematic testing strategies, encompassing unit testing, integration testing, and possibly other methodologies, we aim to validate our software's adherence to specified requirements and its ability to operate seamlessly under diverse conditions.

Central to our workflow is the structured utilization of Git, facilitating collaborative development while maintaining version control integrity. By adhering to branching conventions and merging protocols, we ensure the orderly progression of our development efforts, with all code changes ultimately consolidated into the designated 'phase/3' branch.

To document our progress and facilitate comprehensive understanding, a README.md file will serve as a repository for vital project information. Task assignments, implementation insights, testing methodologies, and outcomes will be systematically documented, providing a clear and informative narrative of our activities during Phase 3

## 2. Table
 
| Team Member | Student ID | University Email | GitHub Username | Allocated Tasks |
|----------|----------|----------|----------|----------|
| **Pelit**, Zeynep | 001221738 | zp9906d@gre.ac.uk | [turko06](https://github.com/turko06) | Table , Login Page, GitHub Flow [](#) |
| **Patel**, Saumya | 001257508 | sp0675d@gre.ac.uk | [SamEng001](https://github.com/SamEng001) |  [](#) Student Page[](#) |
| **Rusnac**, Nicoleta | 001143379 | nr1227e@gre.ac.uk | [nicoletarusnac](https://github.com/nicoletarusnac) | Payment Page, Student and Staff management |, | Conclusion [](#) |
| **Fashola**, Oba | 001272516 | of1104h@gre.ac.uk | [GeneralDavid9797](https://github.com/GeneralDavid9797) | Staff and Student Renting book and journal page, Late Penalty |,  [](#)
| **Abdullah**, Ali | 001258128 | aa4759n@gre.ac.uk | [Ali-Abdullah786](https://github.com/Ali-Abdullah786) | Staff Home Page|, |  [](#) |

## 3. Implementation 

### 3.1 User Page 

User page provides a user interface for selecting between two types of users (staff and student) in a library system. It presents a window with two buttons labeled "Staff" and "Student", respectively. When the user clicks on one of these buttons, the program records the user's selection (whether they are a staff member or a student) and then proceeds to open a login page tailored to the selected user type.

Essentially, this code serves as the entry point for users to access the library system, directing them to the appropriate login page based on their role. By capturing this initial user selection, the program can customize the subsequent interactions and functionalities according to the user's role within the library system. This segregation of user roles is fundamental for managing access permissions, privileges, and functionalities tailored to the specific needs and responsibilities of staff and students within the library environment.

### 3.2 Login Page

#### Authentication: 

The primary goal is to authenticate users based on their provided credentials (username and password).

#### User Distinction: 

The application distinguishes between two types of users: students and staff. The login process is tailored accordingly to verify the credentials provided by each type of user.

#### User Interface Interaction:

The code interacts with the UI elements of the login page, such as text boxes for entering usernames and password boxes for entering passwords. It captures the user input and utilizes it for authentication.

#### Navigation:

Upon successful authentication, the code directs users to their respective homepages - either the student homepage or the staff homepage. This implies that the application has different functionalities or views tailored for each type of user.

#### Feedback on Invalid Credentials:

If the provided credentials do not match any stored credentials, the code provides feedback to the user by displaying a message box indicating that the entered username or password is invalid.

Overall, the aim is to establish a secure and user-friendly login process that allows authorized users (students and staff) to access their designated functionalities within the library system application while maintaining the integrity and security of the system.


### 3.3 Student and Staff Home Page 

### 3.4 Balance management and payment page 

### 3.5 Renting the books and journals 

## 4. Testing 

### 5. Conclusion 

