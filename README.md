# Phase 1 - Requirements Engineering

<div style="text-align: justify">

## Content 

* [Introduction](#introduction)
* [Table](#table)
* [Software Process Model](#software-process-model)
  * [Waterfall](#waterfall)
  * [Conclusion](#conclusion)
* [System Requirements Specification](#system-requirements-specification-report)
  * [Introduction](#introduction-1)
  * [System Requirements](#system-requirements)
  * [Functional Requirements](#functional-requirements)
  * [Non-functional Requirements](#non-functional-requirements)
  * [Conclusion](#conclusion-1)
* [User Requirements](#user-requirements)
  * [Functional Requirements](#functional-requirements-1)
  * [Non-functional Requirements](#non-functional-requirements-1)
* [Possible Risks & Risk planning](#possible-risks--risk-planning)
* [Kanban](#kanban)
* [Glossary & References](#glossary)
* [Authors](#authors)
* [Appendix](#appendix)


## Introduction 

 This project involves the development of an application for the setup of a library system for an educational institution, such as a university. The purpose of the system is to serve as a means for students and staff members to access various academic services such as library resources and the ability to manage their activity on the application while being dynamic enough to adjust to the needs of the consumers via a user-friendly interface. 

To ensure the application for the library system is as optimal as possible, it should be designed in a way that allows users to access specific and exclusive features such as resource accessibility, learning support, assistance for teaching staff, and community collaboration. The software process model to be applied for this project will be the **Waterfall methodology**.  The user and system requirements for this project will be described in this report, and possible risks will be indicated as well as how they can be managed and planned for. The project management plan will also be laid out via a Gantt chart. 

The team will ensure that this report includes the provision of detailed descriptions involved in the construction of the application for the library system, as well as observations and valid recommendations that may help in kick-starting the successful execution of this progressive project.

## Table 

| Team Member | Student ID | University Email | GitHub Username | Allocated Tasks |
|----------|----------|----------|----------|----------|
| **Pelit**, Zeynep | 001221738 | zp9906d@gre.ac.uk | [turko06](https://github.com/turko06) | [System Requirements Specification](#system-requirements-specification-report), [Kanban](#kanban) |
| **Patel**, Saumya | 001257508 | sp0675@gre.ac.uk | [SamEng001](https://github.com/SamEng001) | [Software Process Model](#software-process-model), [Content](#content), [Table](#table) |
| **Rusnac**, Nicoleta | 001143379 | nr1227e@gre.ac.uk | [nicoletarusnac](https://github.com/nicoletarusnac) | [User Requirements](#user-requriments) |
| **Fashola**, Oba | 001272516 | of1104h@gre.ac.uk | [GeneralDavid9797](https://github.com/GeneralDavid9797) | [Introduction](#introduction), [Risk Planning](#risk-planning), [Table](#table) |
| **Abdullah**, Ali | 001258128 | aa4759@gre.ac.uk | [Ali-Abdullah786](https://github.com/Ali-Abdullah786) | [Gantt chart](#appendix) |

The table above indicates the allocation of tasks to team members. Each member has contributed to the Glossary and References.


## Software Process Model

A software model process is an arrangement of processes meant to develop software, and it is an abstract representation of the process. Activities like planning, requirement analysis, designing, implementing, testing, and development are processes for developing software.

Different criteria can be met by using a variety of process models. These are what we call Software Development Life Cycle models, or [SDLC models](#sdlc-software-development-life-cycle-it-defines-the-process-of-software-development-in-separate-models). The following are the key and most widely used SDLC models:

Agile model, Waterfall model, Incremental model, V model

### Waterfall
In a [waterfall model](#waterfall-model-it-is-universal-model-to-develop-software-in-specific-phases-of-progress), there is no phase overlap and each step must be finished before the next can start. The entire software development process is split up into distinct phases as per "The Waterfall" methodology. Usually, in this Waterfall model, the result of one phase serves as the sequentialinput for the following phase.

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

<details>
<summary> Waterfall model consists of the following phases: </summary>

![Waterfall model phases](software-process-model.png)
</details>

#### 1. Requirement phase

In a formal requirements document, also called a functional specification, all the requirements, deadlines, and guidelines for the project are analysed.

There are also different types of requirements, including:

- **User requirements:**

<ul>User requirements provide a description of what users want from the system. It also ensures that functionalities, usability, and high-level expectations are met, developer can do so by answering this question, "What should the system do for users?" </ul>

- **System Requirements:**

<ul> In this section, we discuss how we will satisfy the user's requirements with our system by using specified technical details, functions, services and constraints.</ul>

- [**Constraints:**](#constraints-it-mentions-all-the-limitations-which-should-be-consider-in-the-development-of-software)

<ul> Constraints describe the limitations and functionality of the system. It also considers budget, technological choices, and legal requirements when developing a system.

In our Library system, requirements like staff access control, student payment capability, rental facilities, payment verification, card verification are important.</ul>

#### 2. Design phase 

Design specifications detail technical design requirements, such as programming languages, hardware, information sources, architectures, and services.

- **High level design phase:**

<ul>This phase involves listing and understanding the modules involved, along with determining their correlations, generating architecture diagrams, and establishing database tables. </ul>

- **Low level design phase:**

<ul> Low-level Design documents contain pseudocode for each module, which helps the programmer write code directly from them. Furthermore, it provides information about interfaces, error messages, dependency issues, and inputs and outputs. </ul>



#### 3. Implementation phase 
This phase involves writing the source code in accordance with the requirements. A working code is created based on the physical design specifications. In order to develop a system, small programs called units are written, and then these units are integrated.

#### 4. Testing phase
 By running test cases either manually or automatically, testers check the program for all possible defects. In order to ensure that all requirements are met, the client is also involved in the testing phase. Quality Assurance ensures that all bugs and flaws are repaired during this phase.

#### 5. Deployment phase 
Software is deployed into a live environment so that its performance can be tested. Users can access the software as soon as it has been deployed. In some cases, real-time users are also trained during this phase in order to communicate the benefits of the system.

#### 6. Maintenance phase 
It is team's job to ensure that the software that they have developed runs smoothly without any bugs or downtime. So for that, regular maintenance is necessary in order to enhance, improve and update the software.

### Conclusion 

As we learned from the above, once the requirements have been identified, it is much easier to develop software in the following phases. Customer interaction is very limited in the waterfall model during the development of the software. Only after the product is ready can it be demonstrated to the end users, enabling the team to work more efficiently without the need for a significant number of changes to the process. 

Due to the pre-structured nature of all these phases, it is easy to predict deadlines and meet the deadline for the deal. As a result of all these factors, it is easy to develop software efficiently.

## System Requirements Specification Report 

### Introduction 

- **Purpose**
<ul> This System Requirements Specification (SRS) document outlines the specifications for the development of a comprehensive system that encompasses student and staff account management, payment processing, book rental, journal management, and account deletion functionality. </ul>

- **Scope** 
<ul> The system aims to provide a secure and user-friendly platform for students and staff to manage accounts, facilitate payments, rent books, and manage journals. It also ensures adherence to industry standards for payment security and offers a dynamic approach for handling different card types. </ul>

 ### Who are Stakeholder and what are their needs?

Stakeholder is any individual or group with a valid interest who is impacted by the system in some way Stakeholder needs are the demands, hopes, and preferences of people or organizations (stakeholders) who are either directly or indirectly associated with a project. To make sure that the stakeholders are satisfied with the finished product, these demands must be recognized, recorded, and taken care of. They are essential to the project's success.  

### What is Non-Functional Requirements?

As the ranges show, non-functional defects are featuring that limit or operate generic software aspects unrelated to continuous operation. It consists of limitations placed by standards, limitations on their time, and limitations on the development process. Non-functional values typically relate to the overall system rather than just specific components. 

### What is Functional Requirements? 

Functional requirements specify the functions of the system that has to be created. It provides an explanation of the system's functionality and how it will be designed to satisfy user needs. They give a detailed explanation of the features, how the system should react to a given order, and what users might anticipate. 

### System Requirements 
---
#### 1. Student Account Requirements

- Students can access and edit their accounts. 
- Students can view their account balance and update it. 
- Students cannot rent a book if they are in debt until they return the overdue books. 
- Students can reset their passwords securely through a multi-step verification process. 
- Account history and activity logs for students, allowing them to track changes and transactions. 
- Notifications for students when their account balance is low or when a book rental is approaching its due date. 
- Two-factor authentication for enhanced security in student accounts. 

 

#### 2. Staff Account Requirements 

- Staff accounts have different levels of access based on roles, such as administrative, financial, and support roles. 
- Staff accounts can generate reports on account balances, transaction histories, and overdue books. 
- Logging and auditing functionalities for staff actions within the system to maintain accountability. 

 
#### 3. Payment Requirements 

- Implement a [sophisticated](#sophisticated-highly-developed-complex-with-sophisticated-taste-or-knowledge) card recognition mechanism capable of discerning card types (Visa, debit, Amex) based on the card number. 
- Dynamic system logic tailored to card categories. 
- For Visa and debit cards, prompt users for a three-digit Card Verification Value (CVV) code. 
- For Amex cards, prompt users for a four-digit CVV code. 
- Ensure [adherence](#adherence-the-act-of-following-or-obeying-a-specific-set-of-laws-regulations-or-directives) to standard security practices. 

#### 4. Book Requirements 

- Maintain a catalog of 20 books in the system. 
- Include book details: picture, title, author, [ISBN](#isbn-the-international-standard-book-number-isbn-is-a-numeric-commercial-book-identifier-that-is-intended-to-be-unique), and [synopsis.](#synopsis-a-short-overview-of-something) 
- Allow book rentals for 3, 7, and 14 days. 
- System prevents renting if the user is in debt until overdue books are returned. 
- Students can request an extension of the rental period, subject to approval by authorized staff. 

An example of how it needs look in application 

<details>
<summary>Picture example of how it suppose to look:</summary>

![picture example of how it supposed to look](Example-image-of-user-interface.png)
</details>

#### 5. Journal Requirements 

- Include 10 journals in the system. 
- Capture journal details: title and volume. 

#### 6. Deleting Account Requirements 

- Only authorized personnel can delete an account. 
- Display a pop-up confirmation: "Are you sure you want to delete this account?" 

### Functional Requirements 
---
#### 1. Student Account Functionality 

- Login and authentication for students. 
- Edit account details. 
- View account balance. 
- Rent books. 

##### 2. Staff Account Functionality 

- Login and authentication for staff. 
- Access all accounts. 
- Update account balances. 

##### 3. Payment Functionality 

- Card recognition and categorization. 
- Dynamic CVV prompts based on card type. 

#### 4. Book Functionality 

- Book catalog management. 
- Rental functionality. 
- Overdue book handling. 
- Extension request and approval. 

#### 5. Journal Functionality 

- Journal catalog management. 

#### 6. Account Deletion Functionality 

- Authorization for account deletion. 
- Confirmation pop-up for account deletion. 

### Non-Functional Requirements 
----
#### 1. Performance 

- System response time: < 2 seconds for standard operations. 

#### 2. Dependability 

- System availability: 99.9%. 

#### 3. Usability 

- Intuitive user interfaces for both students and staff. 
- There should be speacial adjustments for blind people to utilise text-to-speech. 


#### 4. Scalability 

- Ability to handle a user base of at least 1000 students and 100 staff members. 

#### 5. Security 

- Encryption of sensitive data. 
- Regular security audits. 
- The system's protection against cyberattacks 
- Maintaining personal information 
- Protecting the privacy of users 

### Conclusion 

This Software Requirements Specification provides a [comprehensive](#comprehensive-including-every-element-or-almost-every-aspect-wide-ranging) overview of the functionalities and specifications required for the development of the proposed system. Adherence to these requirements will ensure a robust, secure, and user-friendly platform for account management, payment processing, book rental, journal management, and account deletion. 

## User Requirements 


In order to get the library system as user-friendly as possible there are some basic user requirements that should be met. These are usually divided in functional and non-functional. 

### Functional Requirements

Functional requirements are the key features that the system should be able to provide for all the users, they are user-focused and task-oriented.

**1. User Registration and Login:**
Users should be able to create their account by providing personal information such as e-mail, password, date of birth, phone number, and student ID.

**2. Search and browse:**
Users should be able to search online for the books, authors, topics, journals. Clicking on a book or journal should display its details such as title, author, summary, and availability status (should display if it's  available online or on-site). 

**3. Rental information:**
The available books or journals should be able to rent for 3days, 7days, 14 days. This information should be displayed in the details of available books and journals. 

**4. Renewal system:**
Users should be able the renew the rental period for a current book they holding direclty online in their account.

**5. Late fee information and payment:**
Users should be notified about the library's late fee policy and the charges applied with it. Each late day is 10p with maximum fine being the value of the book. It should calculate the fine and inform the account user and should be available to pay it straight away online in the app with a payment validation check.

**6. Account Management:**
Users should be able to view and edit their profile, borrowing history and the due dates in their account management section.

### Non-Functional Requirements

Non-functional requirements are usually a bit more technical and are responsible for the quality, performance and security part of the user-system experience.

**Usability:**
The system should be easy and straitforward to use, efficient and fast enough.

**Security :**
Users should be protected against the data leaking, unauthorized access, and malicious software.

**Portability and compatibility:**
The system should be able to run on different operating systems and should be compatible with the lastest versions of the most known and used operating system and online environments.

**User requirements:** is a set/list of instructions/functionalities that a system needs to meet in order to be user friendly and efficient.

**Account management:** reffers to user's profile section where they can view/change/delete their personal information and other relevant activies to their acccount.

## [Possible Risks & Risk planning](#risks--risk-planning-risks-are-defined-as-uncertainties-which-have-the-ability-to-impact-the-goals-and-objectives-of-a-project-risk-planning-is-the-process-carried-out-in-advance-to-prevent-possible-risks)

Various risks involved with the application development need to be identified and managed effectively. These risks can range from hardware construction to software implementation and user-related issues. Organisations heavily rely on information systems, making them vulnerable to threats that can result in serious consequences. To mitigate these risks, organisations must create strategic plans that include risk identification and assessment (Farahmand et al., 2005).
** Identified Risks**
1. **Technical Risks:** A fundamental risk that may occur in the development of a library system application. The technical risks include compatibility issues, vulnerabilities with data security, software failure, and scalability concerns.

<ul>Risk Management Technique(s) - Before beginning the development process, a comprehensive technical analysis must be carried out to handle these risks. Examining the application's compatibility with various operating systems, databases, and hardware setups should be part of this analysis. Sensitive user data can also be protected by putting strong security measures in place, like encryption and access limits.</ul>

2. **User Acceptance Risks:** The process of comprehending user adoption of digital libraries is intricate and involves several variables, including human diversity, organisational context, and interface characteristics. Any application's ability to be used successfully depends on user acceptance. The programme may not be adopted if end users or library personnel do not find it intuitive or user-friendly.

<ul>According to a study by Goh and Liew (2009), When it comes to improving the usability and accessibility of library resources, users are open to embracing new technologies. The study also found that important criteria influencing user approval included perceived utility, system reliability, and simplicity of use.
</ul>
<ul> Risk Management Technique(s) - It is essential to include end users in the development process through user testing and feedback sessions to reduce the risks associated with user acceptability. The implementation of user-friendly interfaces, thorough training, and support can all contribute to the acceptance and adoption of the library system application by users. Usability studies should also be conducted.</ul>

3. **Project Management Risks:** Inadequate project management can result in budget overruns, delays, and poor quality. To reduce these risks, it is imperative to implement efficient project management procedures. This entails establishing the parameters of the project, creating reasonable deadlines, and assigning resources correctly.

<ul>Risk Management Technique(s) - Employing project management techniques like Agile or Scrum can assist in risk management by encouraging iterative development, ongoing feedback, and flexibility in response to changing needs.</ul>

4.	**Requirements Risks:** Requirements-related risks are a big part of application development. A system that falls short of user expectations or the demands of the library may result in confusion or misunderstandings over requirements.

<ul>Risk Management Technique(s) - It is essential to set up a thorough and transparent requirements-gathering procedure to reduce this danger. Interacting with library employees, learning about their procedures, and recording their unique requirements should all be part of this process. Ensuring that the application complies with stakeholders' needs can be achieved by maintaining regular contact and feedback loops throughout the development process.</ul>

5.	**Data Loss and Backup Risks:** A library system that experiences data loss may face serious repercussions, such as the loss of important data and service interruptions.

<ul>Risk Management Technique(s) - It is crucial to put plans for catastrophe recovery and routine data backups into place to reduce the risk of data loss. This entails putting in place automated backup systems, creating redundant storage systems, and testing data restoration protocols on a regular basis.</ul>

6.	**Integration Risks:** Integration with external systems, such as databases, online publications, or gateways for payment, is a common requirement for library systems. System failures, inconsistent data, and compatibility problems can all lead to integration concerns.

<ul>Risk Management Technique(s) - It is essential to carry out extensive integration testing and make sure the application can interact with external systems without any problems to mitigate these risks. By putting in place suitable error-handling procedures and backup plans, integration risks can be reduced, and reliable system operation can be guaranteed.</ul>

7.	[**Financial and Resource Limitations:**](#financial-and-resource-limitations-the-barriers-that-organisations-and-individuals-encounter-with-their-available-funds-and-resources) Group projects frequently face financial and resource constraints. Risks related to these limitations include not having enough money for the tools or technology that are required, not having enough team members with the right expertise, or having time limits that prevent comprehensive testing and quality control.

<ul>Risk Management Technique(s) - Routine observation, resource allocation, and meticulous planning can all help manage these risks. Based on their possible impact and probability of occurrence, information security threats can be identified and prioritised by organisations with the aid of economic modelling, claims Bojanc and Jerman-Blaič (2008). Organisations can allocate their resources to manage the most severe hazards by measuring these risks and making informed decisions.</ul>
In today's fast-paced technology landscape, Deiss (2004) contends that libraries must actively embrace innovation to satisfy the changing requirements of their patrons. Deiss (2004) goes on to say that to make sure that their resources and services meet the needs and expectations of their patrons, libraries should participate in ongoing evaluation and feedback cycles. 

Libraries can effectively customise their services to match the specific demands of their user community by incorporating user feedback into their decision-making processes. Overall, Deiss's (2004) research emphasises how critical experimentation and strategic planning are to establishing user-centred libraries, and it stimulates library workers to welcome change and take measured chances to provide better services to their consumers.

**Risk Assessment & Planning Strategy**

Any project must include risk planning which may become even more crucial when the project entails developing a group application for a library system. Through the identification of potential risks and the development of mitigation techniques, the project team can guarantee a more seamless and prosperous conclusion. The risk planning that was done during the system's development involves following a sequence of steps which include establishing and categorising the risks, determining the effect and [probability](#probability-the-mathematical-possibility-of-an-event-or-factor-appearing-or-occurring), creating risk response plans, drafting a [risk management](#risk-management-techniques-the-strategy-put-in-place-to-mitigate-risks) plan, monitoring and addressing risks, record acquired knowledge and [iteratively](#iteratively-a-method-or-procedure-that-involves-steadily-repeating-a-series-of-stages-or-actions) improving risk planning. 

The case study by Han et al. (2016) highlights the importance of identifying assets at risk, assessing threats and vulnerabilities, and implementing countermeasures to reduce risks. This research contributes to the field of library and information science by providing a framework to evaluate security risks in digital libraries. It enables librarians and information professionals to make informed decisions about resource allocation and security measures.

## Kanban

## Glossary

#### SDLC (Software development life cycle): It defines the process of software development in separate models. 

#### Waterfall model: It is universal model to develop software in specific phases of progress. 

#### Constraints: It mentions all the limitations which should be consider in the development of software.

#### Sophisticated: Highly developed, complex, with sophisticated taste or knowledge. 

#### Adherence: The act of following or obeying a specific set of laws, regulations, or directives. 

#### ISBN: The International Standard Book Number (ISBN) is a numeric commercial book identifier that is intended to be unique.

#### Synopsis: A short overview of something. 

#### Comprehensive: Including every element or almost every aspect; wide-ranging.

#### Risks & Risk Planning: Risks are defined as uncertainties which have the ability to impact the goals and objectives of a project. Risk planning is the process carried out in advance to prevent possible risks.

#### Risk Management Technique(s): The strategy put in place to mitigate risks.

#### Financial and Resource Limitations: The barriers that organisations and individuals encounter with their available funds and resources.

#### Probability: The mathematical possibility of an event or factor appearing or occurring.

#### Iteratively: A method or procedure that involves steadily repeating a series of stages or actions.

---
<details>
<summary> References </summary>

*SDLC - Waterfall Model* (no date) *Online Tutorials, Courses, and eBooks Library*. Available at: https://www.tutorialspoint.com/sdlc/sdlc_waterfall_model.htm#:~:text=The advantages of waterfall development,model phases one by one (Accessed: 06 December 2023). 

Lutkevich, B. and Lewis, S. (2022) *What is the waterfall model? - definition and guide*, *Software Quality*. Available at: https://www.techtarget.com/searchsoftwarequality/definition/waterfall-model#:~:text=The waterfall model is a,the edge of a cliff (Accessed: 06 December 2023). 

Says, N. *et al.* (no date) *Home*, *Try QA*. Available at: https://tryqa.com/what-is-waterfall-model-advantages-disadvantages-and-when-to-use-it/ (Accessed: 06 December 2023). 

*SDLC Waterfall Model: The 6 phases you need to know about* (no date) *RSS*. Available at: https://www.rezaid.co.uk/post/sdlc-waterfall-model-the-6-phases-you-need-to-know-about#:~:text=System%20Design&text=This%20is%20the%20first%20stage,a%20High-level%20Design%20document (Accessed: 06 December 2023).

Scribd. (n.d.). What Are The Functional and Non Functional Requirements of A Library Management System | PDF | Librarian | Databases. [online] Available at: https://www.scribd.com/document/177041340/What-Are-the-Functional-and-Non-Functional-Requirements-of-a-Library-Management-System.

‌
Lily Wulandari, L. (2017) User Requirements Analysis for digital library application ... - iopscience, IOPScience. Available at: https://iopscience.iop.org/article/10.1088/1742-6596/818/1/012004. 


Altexsoft (2021). Functional and Non-functional Requirements: Specification an. [online] AltexSoft. Available at: https://www.altexsoft.com/blog/functional-and-non-functional-requirements-specification-and-types/.

Singla, C. (2020). Functional vs Non-Functional Requirements. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/functional-vs-non-functional-requirements/. 

Gomez , Jose (2023). What Is SRS in Project Development? [online] Koombea. Available at: https://www.koombea.com/blog/what-is-srs/ [Accessed 7 Dec. 2023]. 

Grant, M. (2021). Scope. [online] Investopedia. Available at: https://www.investopedia.com/terms/s/scope.asp [Accessed 20 Nov. 2013]. 

Landau , P. (2022). What Is a Stakeholder? [online] Project Manager. Available at: https://www.projectmanager.com/blog/what-is-a-stakeholder [Accessed 7 Dec. 2023]. 

Martins, J. (2022). What Is Kanban? A Beginner’s Guide for Agile Teams [2023] • Asana. [online] Asana. Available at: https://asana.com/resources/what-is-kanban [Accessed 1 Dec. 2023]. 

Farahmand, F., Navathe, S. B., Sharp, G. P. and Enslow, P. H. (2005) A Management Perspective on Risk of Security Threats to Information Systems, Information Technology and Management, [online] Available at: https://doi.org/10.1007/s10799-005-5880-5.

Goh, T. and Liew, C. L. (2009) SMS‐based library catalogue system: a preliminary investigation of user acceptance, The Electronic Library, [online] Available at: https://doi.org/10.1108/02640470910966853.

Deiss, K. J. (2004) Innovation and Strategy: Risk and Choice in Shaping User-Centered Libraries, [online] Available at: https://www.ideals.illinois.edu/items/1810.

Bojanc, R. and Jerman-Blaič, B. (2008) An economic modelling approach to information security risk management, International Journal of Information Management, [online] Available at: https://doi.org/10.1016/j.ijinfomgt.2008.02.002. [Accessed 10 December 2023].

Han, Z., Huang, S., Li, H. and Ren, N. (2016) Risk assessment of digital library information security: a case study, The Electronic Library, [online] Available at: https://doi.org/10.1108/el-09-2014-0158. [Accessed 10 December 2023].


</details>

## Authors

- [nicoletarusnac](https://github.com/nicoletarusnac)
- [GeneralDavid9797](https://github.com/GeneralDavid9797)
- [turko06](https://github.com/turko06)
- [SamEng001](https://github.com/SamEng001)
- [Ali-Abdullah786](https://github.com/Ali-Abdullah786)

</div>

## Appendix
<details>
<summary> Gantt Chart </summary>
<img src="https://apaskulin.github.io/waxtechnical/images/pup.jpg" width="600">
</details>

>[Mermaid link](https://mermaid.live/edit#pako:eNqlVUtv2zAM_iuEgGAXO4hfseNb0axFD92GpD2syEWxlUSrLXmS3K4r-t9H2XkoD2CHKhda0UfyIz9R76SQJSM5WVNhzEIALsNNxeDHhmoGAfgwY79brljNhNHwVay5YExxse5Pl9SwG6lqagB-4vLv7_3pdCHsz_6vWWG4RPP7kvY7c0OV6XBwuvKaV0wbKZgH4SiM_CDwg9CDUdlDp1wXrdadv1NoobjxYBo4yDHaW-Rg4GC5Bl43UhkkDUbCq1TPSAioBgqG0XrYg-6EUbJstwQOocouwTsnVIh2sg014_oZmooKYX06MIqOXhA4w8N0ZZiCW7SC8kKx5rT-LONrKQy27DzvaxeQORySHvhAlxU7hYEHD4g7ACc2Emw7KlfmlSoGTV8uqFFUlZtkH3nuVmxsKwawa8-VcHpSbCQvGJgNqgp3sXAaPxggH1QilOyFVbKxirQhC6a17SmipN4LczCgosSjK971wcK1k2cH6vIcwoUGPLE3wZrP9mBfGHW4Q-fobXHCnY_QH6G_8V6589nc0sOELX9awZIVtMXbKZeG9uwaxQquj-LoYwzK3JYAmf9Cjl806LawNRheIP-NF7Jihn6W_qNGjR-ldCbGx8BhHfeX6Cyfq4r_N5WL6aDP5JDOqbBPwP31tEIP90JHB1l_Re2RWzskNVxv7AA7dwC7C37rJpB6EG_xN9gsvbk8-k6m343jwp2Au9ocV6gb1n7Yb_qYyY_wGI52jKryw-gSMHKAkXt4Z6OfCfFIzXDO8xKfi3eLWBBUVM0WJEezpOp5QRbiA8_R1sj5myhIblTLPNI2lvKU07WiNclXtNK4y0pupLrv35_uGfJIQ8WTlPUOiJ8kfyd_SJ4OJ3E2irJJOonjLEhSj7yRPJgEwyCJI9zP4ixNsvjDI387B8Fw1K0oScdhmo2z9OMf4H_nRg)