# Lab05-c-kku-2026-Phat
<<abstract>>
Person
------------------------------------------------
- FirstName : string
- LastName  : string
- Phone     : string
- Email     : string
------------------------------------------------
+ Register() : void
+ ShowInfo() : void


<<interface>>
ISpeaker
------------------------------------------------
+ Train() : void
+ Approve(p : Person) : void


Student ----------------------|> Person
------------------------------------------------
- Major : string
- StudentID : string
------------------------------------------------
+ ShowInfo() : void


Teacher ----------------------|> Person
Teacher ----------------------|> ISpeaker
------------------------------------------------
- Major : string
- AcademicRank : string
------------------------------------------------
+ ShowInfo() : void
+ Train() : void
+ Approve(p : Person) : void


GeneralPerson ---------------|> Person
GeneralPerson ---------------|> ISpeaker
------------------------------------------------
- Workplace : string
- Position  : string
------------------------------------------------
+ ShowInfo() : void
+ Train() : void
+ Approve(p : Person) : void
