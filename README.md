## Sequence Diagram
Sequence diagram is a Behavioral Unified Modeling Language (ULM) that is used to show the interactions of the active objects  of the system in a sequential order of them occuring. [[1]](#1) They show the sequence in which interactions take place by showing specific objects, referred to as lifelines, and the messages that flow between them. These diagrams may be used to map out the timing of interactions at various phases of the development process and are useful forsystem design, testing, and maintenance. [[2]](#2) 
## Creating a Sequence Diagram
Sequence diagrams are usually created following a few steps:
1.	First is identifying the actors/objects: which are all the entities involved in a system. They are defined in the diagram on top wrapped in a rectangle. They are interacting between them with arrows that show the flow of communication and with messages which are shown on top of the arrows. In case of an online library system the following can be objects: user, library system, book database, account database. 
2.	Second step is stipulating the Use Cases which are the main features of the system such as: book searching, book borrowing, book renewing, paying the fines etc.
3.	Third step is defining the interactions: which are the actions/communication between the objects and use cases. In our case it can be a user requesting a book, library system updating user’s records etc.
4.	Fourth step is drawing separate Use cases diagrams with detailed flow of communication and precise messages. 
5.	Fifth step is combining the Use cases diagrams if possible in a detailed and understandable way. [[3]](#3) [[4]](#4)

## Use Cases Diagrams
### Sequence diagram for Searching and Borrowing a book

Objects:
* User 
* Online library System
* Book Database 
* Account Database 

Steps:
1.	The user initiates a borrow request (uses the library system interface to choose a book and press the borrow request).

2.	The library system checks with the book database to see if the book is available for borrowing.

3.	The book database responds to the library system with availability information.

4.	The library system processes the request and if the book is available, the library system contacts the account database to confirm the user's account status and borrowing rights.

5.	The account database verifies the user's account information, including borrowing limits and outstanding fines.

6.	The account database confirms the user's borrowing eligibility with the library system.

7.	If the user meets the eligibility requirements, the library system marks the book as borrowed and sends a confirmation message.

8.	If the user does not meet the eligibility, the library system shows an error message informing the user about the cause.

Diagram available in Appendix.
### Sequence diagram for Renewing a book
Objects:
* User 
* Online library System
* Book Database 
* Account Database 

Steps:
1. User starts a renewal request (picks the book they wish to renew and selects the "Renew" option from the book details or their borrowings list).

2. The library system verifies renewal eligibility:
*	It checks to see if the book is presently borrowed by the user. 
*	Uses the book database to determine whether the book is available for renewal (not reserved, late, etc.).
*	Checks the account database to check that the user has no outstanding penalties or borrowing limits.

3. If the renewal request is valid:
*	The library system will show a confirmation message notifying the user of the new due date.
*	The book database will be updated with the extended due date.

4. If the renewal request is invalid, the library system will show a notice indicating the cause for the refusal (e.g., unavailable, late, penalties), and provides alternatives (returning the book, placing a hold, etc.).

Diagram available in Appendix.
### Sequence diagram for User pays fines
Objects:
* User 
* Online library System
* Book Database 
* Account Database 
* Payment Getaway

Steps:
1.	The user initiates the payment procedure (logs into their account, picks the "Pay Fines" option, or examines their account balance, which shows overdue penalties).

2.	The library system accesses the account database to determine the total amount of overdue fines for the user's account.

3.	The library system offers payment choices, including credit and debit cards. User chooses their desired payment method and fills in the details.

4.	Payment Gateway handles payments by authenticating and verifying user information, and then securely executes the payment and deducts the fine amount from the user's designated account.

5.	Payment Gateway provides confirmation message to library system, indicating transaction success or failure.

6.	If payment is successful, the library system will update the account database to reflect the cleared penalties for the user.

7.	The library system provides a confirmation message to the user indicating successful fine payment and updated account balance.


8.	If payment fails, the library system shows an error message informing users of payment failure and suggesting troubleshooting steps or other payment options and changes the account database accordingly (for example, recording an unsuccessful payment attempt). 

Diagram available in Appendix.
## References
<a id="1">[1]</a> 
Visual Paradigm. What is sequence diagram? Learn UML Faster, Better and Easier.  Available at:https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-sequence-diagram/ 

<a id="2">[2]</a> Bell, D. (2023) Explore the UML sequence diagram, IBM developer. Available at: https://developer.ibm.com/articles/the-sequence-diagram/

<a id="3">[3]</a> Creately.com. (2022). Sequence Diagram Tutorial – Complete Guide with Examples | Creately. Available at: https://creately.com/guides/sequence-diagram-tutorial/

<a id="4">[4]</a> Lucidchart. (2019). How to Draw a Sequence Diagram in UML Available at: https://www.lucidchart.com/pages/how-to-draw-a-sequence-diagram-in-UML 
‌