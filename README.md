# Phase 2- System Modelling and Design Phase
<div style="text-align: justify">

## Content
- [**Introduction**](#introduction)

- [**Table**](#table)

- [**Description of the UML Application**](#describing-the-application-of-uml-to-the-library-system)

- [**Overall Architecture of the System**](#overall-architecture-of-the-system)

- [**Use case Diagram**](#use-case-diagram)

- [**Sequence Diagram**](#sequence-diagram)

- [**Class Diagram**](#class-diagram)

- [**Activity Diagram**](#activity-diagram)

- [**State Chart Diagram**](#state-chart-diagram)

- [**Reference**](#references)

- [**Authors**](#authors)

- [**Appendices**](#appendices)

- [**Gantt Chart**](#gantt-chart)

## Introduction
In the development of an application of a library system for an educational institution, the System Modelling and Design phase is an essential step. The main goal of this phase is to create computer science diagrams that show the behaviour, structure, and functioning of the system visually. These graphic representations consist of Gantt charts, Use case diagrams, Class diagrams, Activity diagrams, State chart diagrams, and Sequence diagrams. Every diagram has a distinct function that helps comprehend and efficiently build the library system.

Use case diagrams are a tool used to show how a system works from the viewpoint of its users. Sequence diagrams show the order of interactions between items or components, focusing on the dynamic behaviour of the system. Class diagrams are crucial for illustrating the system's static structure. Activity flow diagrams are used to simulate how processes or activities move through a system. The goal of State chart diagrams is to represent the various states and transitions of a system or entity. The timetable and schedule for the project are shown using Gantt charts.

The main goal of the phase is to examine the requirements that were acquired in the previous stage and convert them into a thorough system design. The system's parts, interactions, and information flow can be visualised by applying a variety of modelling tools, which helps to uncover possible problems and make wise design choices.


## Table

| Team Member | Student ID | University Email | GitHub Username | Allocated Tasks |
|----------|----------|----------|----------|----------|
| **Pelit**, Zeynep | 001221738 | zp9906d@gre.ac.uk | [turko06](https://github.com/turko06) | Table , Activity Diagram [](#) |
| **Patel**, Saumya | 001257508 | sp0675d@gre.ac.uk | [SamEng001](https://github.com/SamEng001) |  [](#) Use Case Diagram, Content Table, Overall Architecture of the System [](#) |
| **Rusnac**, Nicoleta | 001143379 | nr1227e@gre.ac.uk | [nicoletarusnac](https://github.com/nicoletarusnac) | Sequence Diagram |, | Conculusion [](#) |
| **Fashola**, Oba | 001272516 | of1104h@gre.ac.uk | [GeneralDavid9797](https://github.com/GeneralDavid9797) | Introduction, State Chart Diagram, Overall Architecture of the System |, | State Chart Diagram [](#)
| **Abdullah**, Ali | 001258128 | aa4759n@gre.ac.uk | [Ali-Abdullah786](https://github.com/Ali-Abdullah786) | Class Diagram, Gantt Chart |, |  [](#) |

## Describing the application of UML to the Library System:
An essential component of contemporary library operations is the design and implementation of a library management information system (LMIS) using the Unified Modelling Language (UML). Zheng, Feng, and Zhao's (2014) study investigates the value of applying UML to the planning and development of a library management system. According to the authors, UML offers a standardised, visual depiction of the system, facilitating efficient stakeholder collaboration and communication. Use case, class, and sequence diagrams are examples of UML diagrams that aid in illustrating the needs, architecture, and behaviour of a system. [[10]](#10)

An LMIS that is more reliable and effective is the outcome of this thorough approach, which guarantees that every facet of the system is taken into account throughout the design stage. UML also makes it easier to identify possible problems and permits changes prior to implementation, which lowers the chance of errors and saves time and money. Libraries can increase user experience, improve information retrieval, streamline operations, and ultimately offer better services to their customers by implementing UML in the design and implementation of an LMIS.

Software designers can effectively model and create framework architectures with the help of the UML profile for framework architectures, an effective tool. A UML profile, according to Fontoura, Pree, and Rumpe (2002), is an extension mechanism of the Unified Modelling Language (UML) that permits UML to be tailored for particular domains or goals. [[11]](#11) The UML profile offers a collection of established stereotypes, tagged values, and constraints that are useful for representing and analysing the various components of framework designs. This makes it possible for designers to precisely and consistently represent the fundamental behavioural and structural components of a framework. Designers can specify extension points, illustrate the links between framework components, and more by using the UML profile.

The UML profile for framework architectures is a useful tool that helps software designers model and construct framework architectures efficiently. Fontoura, Pree, and Rumpe (2002) define a UML profile as an extension mechanism of the Unified Modelling Language (UML) that enables UML to be customised for specific domains or objectives. The UML profile provides a set of well-known stereotypes, constraints, and tagged values that are helpful in assessing and describing the different parts of framework designs. This enables designers to accurately and consistently depict the essential structural and behavioural elements of a framework. Using the UML profile, designers may define extension points, show how framework components are connected, and do much more.


## Overall Architecture of the System

The overall architecture of the system is designed to cater to both Staff and Student users, providing a seamless and intuitive experience. outlines the architecture, emphasizing the login process and subsequent functionalities for each user type.

The high-level arrangement and structure of the several parts and subsystems that cooperate to enable a library's operations is referred to as the overall system architecture of a library system. It includes all of the networks, databases, hardware, software, and interfaces that the library needs to effectively manage its resources, serve patrons, and make information retrieval easier. Three basic parts usually make up a library system: the database, the server-side, and the user-side.

1.	User-side: This part is what makes up the user interface that users of the library use to communicate with the system. Self-checkout kiosks, mobile applications, the library's website, and other user-facing gadgets are all included. Users can place holds on materials, renew them, browse the library catalogue, access digital resources, and carry out other operations pertaining to library services via the user-side interface. 

2.	Server-side: User requests that come in from the client-side are processed and managed by the server-side component. It consists of web servers, application servers, and additional processing power that carries out the software logic required to manage user interactions. Along with managing user authentication and session management, the server-side component also handles connectivity with external systems like external databases or payment gateways.

3.	Database: This part of the library is in charge of keeping track of and arranging user data, transaction histories, resource collections, and other pertinent information. It usually comprises of a relational database management system (RDBMS), which makes data manipulation, retrieval, and storage efficient. Books, journals, multimedia files, user accounts, borrowing records, and other library-related information are all stored in the database. 

To improve usefulness and efficiency, a library system may include a number of additional subsystems and services in addition to these essential elements:

- Cataloguing and Data Management: This subsystem manages the tasks of assigning data, cataloguing and categorising library resources, and making sure that indexing is precise and reliable. Users can search for resources using several parameters including title, author, subject, or keywords. 

- Circulation and Loan Management: This subsystem oversees the checking out and checking out of library resources, keeps track of due dates, deals with holds and reservations, and implements circulation rules. Features like automatic check-in and check-out, fine computation, and overdue item reminders might be included. 

- Digital Resource Management: Libraries frequently have systems in place to handle electronic books, journals, databases, and other digital content due to the growing prominence of digital resources. This subsystem manages digital resource licencing, access control, authentication, and usage monitoring.

- Resource sharing and interlibrary loan: Libraries frequently work with other organisations to grant access to materials that are not part of their own collection. Interlibrary loan systems make it easier for libraries to lend and borrow resources from one another, enabling users to make requests for books from other libraries and guaranteeing effective resource sharing. 

- Reporting and Analytics: To evaluate their operations, make wise decisions, and enhance services, libraries produce a range of reports and data. Subsystems for reporting and analytics take data from many areas of the library system, process it, and display it in forms that are relevant to the user, including usage statistics, financial reports, or collection analysis.

- Integration with External Systems: Libraries have the option to incorporate their systems with those of other companies or platforms, including learning management systems, digital content suppliers, and online payment gateways. These interfaces provide easy access to outside resources or services, which improves the library's capabilities and streamlines workflows. 

In general, a library system's system architecture aims to efficiently manage the library's resources while offering users a smooth and intuitive experience. To support the essential operations of the library, it combines server-side processing, client-side interfaces, and a strong database with extra subsystems and connectors to expand its capabilities.


**Staff User:**

Upon launching the application, the first screen presents two login options: Staff and Student. If the user selects the Staff option, they are directed to the Staff Login Page. Similarly, selecting the Student option leads to the Student Login Page. After successful login, the user is directed to the main application.

In the Staff interface, a menu is available with options for Student Management, Account Management, and Book Search. Navigating to Student Account Management provides further options, such as View/Update Student Record. Upon selecting this option, a new page, "Select Student," displays all student names. Subsequently, choosing a student leads to a page offering options like Edit, Delete Student Account, Check Balance, Payoff balance and Rent books on behalf of student.

The Check Balance option provides details on the current balance and late fee associated with the student's account.

**Student User:**

For Student users, upon login, the front page opens with options for Balance Management and Renting Books. In the Balance Management section, users can pay late fees and check their account balance.

Choosing the Renting Book option allows students to search for books, rent books, and view a list of borrowed books or journals, check account, check balance, payoff late fee. The architecture ensures a straightforward flow for students, promoting efficient book management.

Overall, the architecture is structured to deliver a user-friendly and organized experience for both Staff and Student users, guiding them through the login process and providing intuitive access to relevant functionalities. The systematic arrangement of screens and options enhances the overall usability and efficiency of the system.

## Use case diagram

In software development, a use case diagram is a graphic representation that shows how system actors interact with the system. By depicting a system's use cases and the roles that interact with them, it encapsulates the dynamic behaviour of the system. [[5]](#5)

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

## Sequence Diagrams

### Sequence Diagram Definition
Sequence diagram is a Behavioral Unified Modeling Language (ULM) that is used to show the interactions of the active objects  of the system in a sequential order of them occuring. [[1]](#1) They show the sequence in which interactions take place by showing specific objects, referred to as lifelines, and the messages that flow between them. These diagrams may be used to map out the timing of interactions at various phases of the development process and are useful forsystem design, testing, and maintenance. [[2]](#2) 

### Constructing Sequence Diagrams
Sequence diagrams are usually created following a few steps:
1.	First is identifying the actors/objects: which are all the entities involved in a system. They are defined in the diagram on top wrapped in a rectangle. They are interacting between them with arrows that show the flow of communication and with messages which are shown on top of the arrows. In case of an online library system the following can be objects: user, library system, book database, account database. 
2.	Second step is stipulating the Use Cases which are the main features of the system such as: book searching, book borrowing, book renewing, paying the fines etc.
3.	Third step is defining the interactions: which are the actions/communication between the objects and use cases. In our case it can be a user requesting a book, library system updating user’s records etc.
4.	Fourth step is drawing separate Use cases diagrams with detailed flow of communication and precise messages. 
5.	Fifth step is combining the Use cases diagrams if possible in a detailed and understandable way. [[3]](#3) [[4]](#4)

### Sequence Diagrams for the Library System
#### Staff User Login and Interactions
<u>Actors/Objects</u>: Staff user, Login Page, Account Management, Database, App menu, Student Management, Search for Book.

<u>Interactions</u>:
1.  Staff User picks "Staff" from the first screen.
2.	The Login Page requests for staff credentials.
3.	Staff User inputs their credentials.
4.	The Login Page validates credentials with Account Management (interacting with Database).
5.	Account Management and Database validates credentials and delivers a confirmation to the Login Page.
6.	The Login Page links to the App Menu.
7.	Staff User chooses options from the App Menu:

* Student management:
    * Selects "View/Update Student Record".
    * The system presents the "Select Student" page, which contains student names retrieving it from the Database.
    * The Staff User selects a student.
    * The system provides tools for editing, deleting, and checking the balance.
    * Staff User selects an option:
        * Check Balance: The system displays the current balance and late penalty retrieving it from the Database.
        * Edit Student Account: The system prompts for new information and saves the changes to the Database, and updates student record.
        * Delete Student Account: The system requests for confirmation and then deletes the account from the Database, and removes the student record.
* Search for book:  Staff User enters search criteria, the system retrieves matching books from the Database and display books that fit those criteria.

General Staff User Login and Interactions and Detailed Student Account Management Sequence Diagrams can be found in Appendix.

#### Student User Login and Interactions
<u>Actors/Objects</u>: Student User, Login Page, Account Management, App Menu, Balance Management,  Payment Getaway, Renting a book, Search for book, Database.

<u>Interactions</u>:
1.	On the first screen, the Student User selects "Student".
2.	The Login Page requests for student credentials.
3.	Student User inputs their credentials.
4.	The Login Page validates credentials with Account Management (interacting with the Database).
5.	Account Management and the Database validates credentials and delivers a confirmation to the Login Page.
6.	Student User picks an option from the App Menu:
    * Balance Management:
        * Selects "Check Balance": the system displays the current balance from the Database.
        * Selects "Pay Late Fee": the system requests for payment details and processes the payment interacting with the Payment Getaway, then updates the balance in the Database, and send a confirmation message to the Student User.
    * Renting Book:
        * Selects “Search for Book”: the system will provide a search interface where students can input criteria, in return the system retrieves matching books from the Database and show the results.
        * Selects “Rent Book”: the system asks for a confirmation from the user and updates the student’s borrowed books list in the Database, labels the book as unavailable, and sends a confirmation message to the user.
        * Selects “View Borrowed Books”: the system retrieves and show a list of borrowed books from the Database.

General Student User Login and Interactions and Detailed Student Search for Book and Rent Sequence Diagrams can be found in Appendix. 

## Class Diagram

## Activity Diagram 

[[7]](#7), [[8]](#8), [[9]](#9) An activity diagram, classified as a UML diagram, serves the purpose of illustrating the sequential flow of activities within a given process. Business analysts leverage activity diagrams for the analysis of changes in business processes, depiction of workflows, and modeling intricate algorithms using UML. Through a meticulous examination of business processes via activity diagrams, it becomes possible to identify and streamline sequential operations that could be executed in parallel. 

Use cases, offering a textual elucidation of the business process, may necessitate support from activity diagrams, particularly when intricate interconnections between flows arise. Consequently, activity diagrams serve as valuable input for systemic design and testing processes. The workflow specified in the activity diagram facilitates the creation of detailed system designs and test scenarios. 

A paramount characteristic distinguishing activity diagrams from flowcharts lies in their support for parallel behavior. When aiming to represent the algorithmic logic of multithreaded applications using UML, employing activity diagrams proves to be apt. 

It is essential to note that the depiction of activities in parallel within activity diagrams does not imply that these activities must be performed simultaneously. Rather, this notation signifies the absence of a predetermined order relationship among the activities. 

### Tabular description of staff account:

| Action | Description |
|-------|-------|
Log in  | Staff members are required to input their respective email addresses and passwords to access their accounts. Upon successful login, they will gain comprehensive access to all system functionalities. 
Delete an account  | Staff will be able to delete student accounts. However, a confirmation pop-up will prompt, ensuring that the staff member is certain about the deletion action. 
Late Penalty |Staff should be able to manage the late penalties for students and pay them off. 
View Balance | Staff are granted the privilege to view the account balances of students, providing a comprehensive overview of financial information. 
Book look ups | Staff members can conduct thorough book searches, obtaining information on the availability of books within the system. This feature allows staff to efficiently manage and monitor the status of each book in the inventory. 

### Tabular description of student account:

| Action | Description |
|-------|-------|
Log in  | Students are required to input their respective email addresses and passwords to access their accounts. Upon successful login, they will gain comprehensive access to all system functionalities. 
Renting book  |  Students will be able to choose a book and rent the book for 3 days, 7 days, and 14 days.  
Renting Journals | Student will be able choose Journals and rent the. Journals for 3 days, 7 days, and 14 days. 
 Borrowed Journals and Book | Students can view their rental history, displaying details such as the books and journals they have borrowed, the rental durations, return status, and any overdue items. This comprehensive view will facilitate a better understanding of their borrowing history. 

## State Chart Diagram
State chart diagrams are useful for showing the various states that items in the library system are capable of changing into. They guarantee that the system performs as planned by giving a clear understanding of how the system behaves in response to different situations or stimuli.
A State chart for a library system is created by a number of steps that aid in illustrating the behaviour and states of the system. A detailed explanation of each step is provided below:

1.	Determine the entities and states of the system: Finding the key players in the university library system is the first step. Books, patrons of libraries, librarians, and the system itself are examples of these entities. Determine the various states that each entity is capable of. For instance, a book may be reserved, loaned, or offered.

2.	Describe the circumstances that lead to state transitions: Determine the circumstances or acts that may result in a state change. These can be internal—like a book being returned—or external—like a member checking out a book. Make a list of all the potential outcomes for each entity.

3.	Establish the starting state: Establish the starting state of every entity during system startup or reset. This state serves as the system's initialization point. For instance, all books might be in the "available" status when the library system first launches.

4.	Describe the transitions and states: For every identified state of an entity, create a state. These states should be represented using UML state symbols. For instance, a state is represented by a rectangle with the state's name printed inside. To illustrate the changes between the states, join them together with arrows. Indicate which transition is caused by on each label.

5.	Add actions and conditions: Actions and conditions can be added to each transition. The conditions outline what must happen for the shift to take place. The activities that take place throughout the transition are represented by actions. When a book is borrowed, for instance, the availability of the book might be the condition, and the action would be to update the book's status and note the borrower's details.

6.	Substates and nested states may be included: If necessary, substates and nested states may be included within a state. This aids in the representation of more intricate behaviour. One way to break down a book's "borrowing" state is into smaller states, such as "book selected" and "book issued."

7.	Examine and improve the State chart: After the State chart has been initially produced, check that it appropriately depicts all states, transitions, circumstances, and actions. As necessary, adjust the chart to make it easier to read and comprehend.

Stakeholders, including developers, designers, and other team members engaged in the system development process, should be informed about the created state chart diagram through appropriate documentation and communication. The system's behaviour can be understood by consulting this documentation, which can also be helpful during the implementation stage.
One may effectively create state chart diagrams to represent a system's behaviour by following these steps. Requirements relevant to the system being modelled and its scope should be taken into consideration when determining the amount of detail and complexity of the diagram.


## Conclusion
Overall, the System Modelling and Design segment is essential to building the application for the library system. To adequately depict the functionality, behaviour, and structure of the system, this phase focuses on producing software development diagrams, such as Use case diagrams, Sequence diagrams, Class diagrams, Activity diagrams, State chart diagrams, and Gantt charts. The purpose of each diagram is defined, enabling a comprehensive understanding of the system's application design. This phase sets the foundation for the subsequent phases of the report, facilitating the successful implementation of the library system.

## References
<a id="1">[1]</a> 
Visual Paradigm. What is sequence diagram? Learn UML Faster, Better and Easier.  Available at:https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-sequence-diagram/ 

<a id="2">[2]</a> Bell, D. (2023) Explore the UML sequence diagram, IBM developer. Available at: https://developer.ibm.com/articles/the-sequence-diagram/

<a id="3">[3]</a> Creately.com. (2022). Sequence Diagram Tutorial – Complete Guide with Examples | Creately. Available at: https://creately.com/guides/sequence-diagram-tutorial/


<a id="4">[4]</a> Lucidchart. (2019). How to Draw a Sequence Diagram in UML Available at: https://www.lucidchart.com/pages/how-to-draw-a-sequence-diagram-in-UML 

<a id="5">[5]</a> PlantUML.com. (n.d.). Use case Diagram syntax and features. [online] Available at: https://plantuml.com/use-case-diagram.

<a id="6">[6]</a> BoardMix. (n.d.). What Is Activity Diagram. [online] Available at: https://boardmix.com/tips/uml-activity-diagram/.

‌<a id="7">[7]</a> Visual Paradigm (2019). What is Activity Diagram? [online] Visual-paradigm.com. Available at: https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-activity-diagram/. 

<a id="8">[8]</a> www.mindmanager.com. (n.d.). What is an Activity Diagram? | MindManager. [online] Available at: https://www.mindmanager.com/en/features/activity-diagram/. 

‌<a id="9">[9]</a> tutorialspoint.com (2019). UML - Activity Diagrams. [online] www.tutorialspoint.com. Available at: https://www.tutorialspoint.com/uml/uml_activity_diagram.htm. 

‌<a id="10">[10]</a> Zheng, J., Feng, Y. and Zhao, Y. (2014) A Unified Modeling Language-Based Design And Application For A Library Management Information System, Sciendo, [online] Available at: https://sciendo.com/article/10.2478/cait-2014-0050.  [Accessed 18 January 2024].

‌<a id="11">[11]</a> Fontoura, M., Pree, W., Rumpe, B. (2022) The UML Profile for Framework Architectures, Google Books, [online] Available at: https://books.google.com/books?hl=en&lr=&id=UVm_HY5EmWcC&oi=fnd&pg=PR10&dq=%22The+Power+and+Purpose+of+UML+Architecture+Diagrams:+Understanding+the+Blueprint+of&ots=4WM51_61hQ&sig=oPRWfEvYNKC7fUE4ijMd59LEItI.  [Accessed 17 January 2024].

## Authors

- [nicoletarusnac](https://github.com/nicoletarusnac)
- [GeneralDavid9797](https://github.com/GeneralDavid9797)
- [turko06](https://github.com/turko06)
- [SamEng001](https://github.com/SamEng001)
- [Ali-Abdullah786](https://github.com/Ali-Abdullah786)
‌ 

## Appendices
<details>
<summary> Use Case Diagrams </summary>

![Student use case diagram](<Student Use Case Daigram.png>)

![Staff use case diagram](<Staff Use Case Diagram.png>)
</details>

<details>
<summary> Sequence Diagrams </summary>

<summary>General Staff User Login and Interactions Sequence Diagram</summary> 

![StaffD](StaffUserDiagram.png)


<summary>  Detailed Student Account Management Sequence  Diagram </summary>

![UpdatD](Upd&Del&CheckDiagram.png)


<summary>  General Student User Login and Interactions Sequence Diagram </summary>  

![StduentD](StudentUserDiagram.png)


<summary> Detailed Student Search for Book and Rent Sequence Diagram </summary>

![SearchD](Search&RentDiagram.png)
</details>

</details>

<details>
<summary> Class Diagram </summary>

</details>

<details>
<summary> Activity Diagram </summary>

### Components and Notations of UML Activity Diagram [[6]](#6)

![Components and Notations of UML Activity Diagram](<Activity Diagram Table.png>)

![Activity Diagram student ](<activity diagram 1.png>)

![Activity Diagram Staff ](<activity diagram 2.png>)

</details>

</details>

<details>
<summary> State Chart Diagram </summary>

</details>

## Gantt Chart 

</div>