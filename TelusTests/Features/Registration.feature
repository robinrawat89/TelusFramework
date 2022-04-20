Feature: Registration
	Check if the Registration functionality is working
	as expected with different permutations and 
	combinations of data

Scenario Outline: Check user is able to register with valid data
	Given User Navigated to the Registration Page
	And User entered the name <FirstName> and <LastName>
	And User entered the email address <Email> 
	And User select the gender <Gender> 
	And User entered the mobile number <Mobile> 
	And User typed the date of birth
	And User entered the  <Subjects> 
	And User selected the <Hobbies> 
	And User upload the picture 
	And  User provide the <Address> 
	And  User entered the state and city
	When User Click the Submit button
	Then registration is complete

Examples: 

| FirstName | LastName | Email             | Gender | Mobile     | Subjects         | Hobbies | Address                         |
| Rahul     | Rana     | rahul89@gmail.com | Male   | 9888894532 | Hindi, English   | Sports  | 116 Redcliff Ave London Onatrio |
| Mak       | Test     | Mak89@gmail.com   | Male   | 9888994532 | Hindi, Math      | Reading | 118 Redcliff Ave London Onatrio |
| Tina      | May      | Tmay90@gmail.com  | Female | 9880994532 | History, English | Music   | 120 Redcliff Ave London Onatrio |