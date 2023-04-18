Feature: ProfileFeature

As a New user
I would like to join to the Mars
So that I can add my profile and share my skill
Then when the people seeking for some skills can look into my details

@tag1
Scenario Outline: 01) Register Mars with vaild details
Given I navigated to the Mars website successfully
And I clicked the Join button
And I enter valid '<FirstName>', '<LastName>', '<EmailAddress>', '<Password>', '<ConfirmPassword>'
Then The account should be created successfully

Examples: 
| FirstName | LastName | EmailAddress          | Password  | ConfirmPassword |
| Eddie	    | He       | eddie0309@gmail.com    | Eddie123 | Eddie123        |


Scenario Outline: 02) Sign in Mars with valid details and fill up user profile
Given I navigated to the Mars website successfully
And I clicked the signin button
And I enter valid '<EmailAddress>', '<Password>'
Then Should be in the user page '<Fullname>'
Then I write user description
And I add new langauge '<Language>'
And I add new skills '<Skill>'
And I add new education '<CollegeName>' '<Degree>'
And I add new certifications '<Certificate>', '<CertifiedFrom>'

Examples: 
| Fullname | EmailAddress         | Password | Language | Skill | CollegeName | Degree | Certificate    | CertifiedFrom |
| Eddie He | eddie0309@gmail.com  | Eddie123 | English  | Jazz  | USQ         | Master | Master of Jazz | Guess         |

Scenario Outline: 03) Edit the Skills
Given I navigated to the Mars website successfully
And I clicked the signin button
And I enter valid '<EmailAddress>', '<Password>'
Then I click on the Skills tag and click the pen icon to edit the skill detail '<NewSkill>'

Examples: 
| EmailAddress		  | Password      | NewSkill   |
| eddie0309@gmail.com | Eddie123      |   IT       |

Scenario Outline: 04) Delete the Skills
Given I navigated to the Mars website successfully
And I clicked the signin button
And I enter valid '<EmailAddress>', '<Password>'
Then I click on the Skills tag and delete the first skill

Examples: 
| EmailAddress		  | Password      |
| eddie0309@gmail.com | Eddie123      |


Scenario Outline: 05) Complated the Share skill form and save it
Given I navigated to the Mars website successfully
And I clicked the signin button
And I enter valid '<EmailAddress>', '<Password>'
Then I click the Share skill button
And I completed the Share skill form '<Title>', '<Description>', '<Tags>', '<Skill-Exchange>'
Then My form should be searchable

Examples: 
| EmailAddress         | Password | Title     | Description																		    | Tags | Skill-Exchange |
| eddie0309@gmail.com  | Eddie123 | Jazz Club | We are true Jazz lover, If you are intrested in Jazz please feel free to join us!!  | JAZZ | Photo Skill    |
