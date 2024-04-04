
## Phase 3 Implementation and Testing

## Content

[**Introduction**](#1-introduction)

[**Table**](#2-table)

[**Implementation**](#3-implementation)

 * [Login Page](##31-login-page)

 * [Student and Staff Homepage](##32-student-and-staff-home-page)

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
| **Abdullah**, Ali | 001258128 | aa4759n@gre.ac.uk | [Ali-Abdullah786](https://github.com/Ali-Abdullah786) | Staff Homepage|, |  [](#) |

## 3. Implementation 

### 3.1 Login Page

![alt text](1.jpg)
    
When people first log in to the app this page going to welcome them asking if they are student or staff once they choose one it will take them to the Login page where they can enter their login details. 

 ![alt text](2.jpg)

### 3.2 Student and Staff Homepage 

#### Student Homepage
The StudentWindow.xaml is a critical document for developing the WPF library management system (LMS) app. It is the GUI working from the student’s homepage system of which the application is based. This file displays the interface design, navigation, and implementation of the system, which the users can exploit to accomplish their tasks associated with the features related to managing the account and utilizing the library resources. The main composing elements of this interface is visual including images, labels, buttons, and rectangles allocated to the grid structure to create the front-end in a more user-friendly and visually pleasing manner. This tab includes a search space with a search bar for students to search their chosen books from the library's system. The interface consists of buttons which defining the key options like user's accounts management and books renting. These buttons will always cause needed functions to be executed when clicked on since these corresponding functions are what the event handlers will perform. These, in turn, will facilitate seamless interaction with the system. The navigation elements, which are given the shape of a house, a book and an icon representing the user, respectively, allow the users to easily move around different areas of the app, including those with essential features and functionalities.


To conclude, we might consider our project to be a successful example of modern development practices in application development, a collection of all WPF framework and C# language capabilities, empowering us to create a contemporary and visually appealing library management system with a great user experience.


### 3.3 Balance management and payment page 

#### Student Balance Management

##### BalanceManagement Window

Main Student Balance has the following functionalities:

- Student Data: It keeps track of data regarding students, including name, ID, and unpaid fees. In this case, the student ID is put by default to 3 (for the sake of simulation).

- Database Connection: It connects to an Access database through OleDb. The database file is saved to a specific path in OneDrive.


- Display Outstanding Fee: Upon initialization, it retrieves and shows the outstanding fee for the logged-in student from the database.

- Display Student's Name: It also retrieves and shows the name of the logged-in student from the database.

- Update Balance: It has a function that updates the logged-in student's database balances.

- Pay fee: The student can pay their fee by clicking on a button. It asks the user to input the amount they want to pay when they click., then it redirects to Payment Window. The student's balance is updated in the database and displayed if the payment is successful.

The BalanceManagement Window's layout has buttons to pay the fee and labels to show the name, student ID, and amount owed. The layout is straightforward and easy to use. For a unified look and feel, the background and foreground colours are set to values. The window has the title "BalanceManagement" and is 640 pixels tall by 360 pixels wide.

#### Payment Window

Payment page has the following functionalities:

- Enter Card Information: Users can enter card information on this page, such as name, number, expiration date, and CVV.

- Payment Confirmation: The card information is verified when you click the "Confirm Payment" button. A success message appears, and the dialog result is set to true if the details are valid. An error warning appears, and the dialog result is set to false if the details are deemed invalid. 

- Validation of Card Details: A basic simulation is used to validate the card details. The name cannot be empty, the card number must contain at least 13 characters, the CVV must contain at least 3 characters, and the expiration date must be current. 

The Payment Window layout has two sections for input forms (one on the left and one on the right), a confirmation button at the bottom, and a central instruction text. Card number, name, expiration date, and CVV are among the input fields. The layout is straightforward and easy to use, making it quick to enter payment information.

#### Staff Check Student Balance

CheckStudentBalance Window is meant to assist staff in checking a student's balance by getting the amount from a database. 

Functionalities:

- Student ID Input:  Student IDs can be entered into this page by staff members. 
- Verification of Balance: When a staff member clicks the "Verify Student Balance" button, their ID is checked and used to get the balance they owe from a database. A new ViewStudentBalance window opens to show the balance if the student is located, and the balance is accessible. An error notice is shown if the student cannot be located, or the balance is not available. 

The layout of the CheckStudentBalance page consists of a title positioned at the top, a section where the student's ID can be entered, and a button that allows for the verification of the balance. Everything is conveniently aligned in the centre for effortless navigation and usability.

The ViewStudentBalance Window provides staff with the ability to easily access and handle student fees.

Functionalities:

- Retrieve Student Data: Retrieves the outstanding fee and name of a student from a database by using the student's ID. 
	
- Student Data Display: Shows the student's ID, name, and outstanding fee on the page. 

- Payment Input: Enables staff to input an amount for payment towards the student's fee, and redirects to the Payment Window described above.

- Payment Confirmation: Verifies the payment and reflects the student's fee in the database. 

- Balance Update: Displays the new balance following a successful payment.

The layout of the ViewStudentBalance page consists of a title positioned at the top. It also includes a section where the student's ID, name, and outstanding fee are displayed. Additionally, there is a button provided for conveniently paying the student's fee. 


### 3.4 Renting the books and journals 

## 4. Testing 

### 5. Conclusion 

