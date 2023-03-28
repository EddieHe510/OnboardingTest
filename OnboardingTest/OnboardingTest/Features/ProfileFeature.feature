Feature: ProfileFeature

As a New user
I would like to join to the Mars
So that I can add my profile and share my skill
Then when the people seeking for some skills can look into my details

@tag1
Scenario Outline: Register Mars with vaild details
Given I navigated to the Mars website successfully
And I clicked the Join button
And I enter valid '<FirstName>', '<LastName>', '<EmailAddress>', '<Password>', '<ConfirmPassword>'
Then The account should be created successfully

Examples: 
| FirstName | LastName | EmailAddress        | Password | ConfirmPassword |
| Eddie	    | He       | 451075679@qq.com    | Eddie123 | Eddie123        |
| Ben	    | Lee      | 451075645@qq.com    | Ben123   | Ben123          |

Scenario Outline: Sign in Mars with valid details
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
| Fullname | EmailAddress     | Password | Language | Skill | CollegeName | Degree | Certificate    | CertifiedFrom |
| Eddie He | 451075679@qq.com | Eddie123 | English  | Jazz  | USQ         | Master | Master of Jazz | Guess         |
