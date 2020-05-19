# Event Registration Application
In this project, we are designing a web application for making reservations for the events, and to register to the events that are happening in University of Bridgeport. This gives the complete flexibility to the organizers and other Admins, Users associated with the events to access the Events related database.
 
Project Requirements:
●	To implement RDBMS, we are using MySQL on Google Cloud Platform (GCP).
●	We are adopting 3-Tier Architecture, which we are using Visual Studio IDE and C# programming language

<h2> Problem Statement</h2>

The Application has a login page where you have options to sign in or sign up. 
First time user must create an account by Sign-Up, where he provides the information required.
♦	 Admin users can sign in directly.
♦	Once they Sign-up they can Sign-In with their username and password. 
♦	After signing in, a page with the available present and future events will open. To the left of the page you can find two tabs - My Account, My Events where My Account tab takes you to Account details page and My Events tab takes you to the page where you can view your present, past and future details. 
♦	In the above, Admin has privileges to check entire registrations and other details of the attendees. And, can update, edit and can delete the event. 
♦	 Whereas regular user will be able to register for the event as a participant or as a volunteer and can update his Account information. He doesn’t have visibility of others.
♦	Participant or volunteer can check the availability of lodging, food and shuttle services to the event and he can even make an advance booking for accommodation. 
♦	There is a FAQ page available for each event, the registered participants can go view the page. 
♦	We generate e-mail reminders. 
♦	People who are not sure about the registering to the event can follow the event so that they get all the updates made to the Event posting.
♦	All the participants and volunteers attending would be receiving a certificate.  
♦	Admins can post photos of the previous events or pictures that are related to the events in the photo gallery.
♦	Any user can always have access to the Campus Map. 
♦	Feedback of the Web Application is collected for the betterment. 
♦	Users can message Admins in case of any issue.
♦	Admins can receive mails from the users and volunteers.

<h2> Queries on the Database (In English)</h2>

1.	To get the Eventid of the events for which the number of people attending is greater than the capacity.
2.	To know about the Things to improve provided by users incase the rating is low.
3.	To get the email and phone number of the people who have booked the lodging.
4.	To get the user name, Role in the event, Event name for providing the attended candidates a certificate.
5.	To obtain the email id of the users who have an event the next day so that we can send reminder mails.
6.	To get the email id of the users who are following our site so that they can get  mails regarding upcoming events.
7.	Admins can check if the volunteers of their event who  have booked lodging.  
8.	Admins can get the details of users who have registered for more than 2 events.
9.	Users can check the facilities available for that event.
10.	Admin can view the number of people participating in an event.
11.	Admins can know the events happening in all the halls on a particular date.
12.	Volunteers can check whom to report for their registered events.
13.	Users can get the contact details of Admins to connect with them in case of emergency.
14.	Admins can check the availability of Hall based on the capacity.
15.	Admins can view Audience attending the event.

<h2> Entities being used and their attributes </h2>

1.	USER is an entity with the attributes- UserID, Email, Password, Name, DOB, Phone, Address which has Street,City, State, ZIPCode.
2.	USER has ADMINS with UBID and Role as ADMINs and OTHERS with University, Role as Non ADMIN’s.
3.	FEEDBACK entity with attributes- Rating, Sign-up, Booking Experience, Signup experience, Things to improve.
4.	REGISTRATION with attributes- RegID, Shuttle, Accommodation,Food, Following, Type-Volunteer, Participant.
5.	EVENT REGISTER with attributes-  Event ID,Event Name, Date & Time, Location, Description, Created date.
6.	HALL REGISTER with attributes- HallID,Capacity,Hall Number, Location,Available dates Status.
7.	FAQS with attributes-  Things to bring, Facilities Available, Prerequisites, Dress Code.
8.	VOLUNTEERS with attributes- Report Date & Time, Place of Reporting, Report to, Things to bring, Dress code.
9.	LODGING- RoomID, Location, Available dates, Status.
10.	AUDIENCE- Name, Phone, IDProof.

<h2> Relationships </h2>

1.	USERS give FEEDBACK(1:1).
2.	ADMINS organize EVENTREGISTER(Events) (1:M).
3.	ADMINS reserve Halls for the Event through HALL REGISTER(1:1) One hall for One event.
4.	ADMINS answer FAQ’s(1:1).
5.	ADMINS manage VOLUNTEERS(1:M).
6.	OTHER users can register for events through REGISTRATION(1:M).
7.	REGISTRATION are made for EVENT REGISTER(M:N ).
8.	Events organized in EVENT REGISTER happen in Halls reserved in HALL REGISTER(1:1)
9.	Registered people through REGISTRATION can view the FAQ’s of that event(M:1).
10.	Registered people through REGISTRATION can participate as VOLUNTEERS for  that event(1:1).
11.	Registered people through REGISTRATION can bring interested AUDIENCE(1:M).

Weak Entity: In our database we consider the AUDIENCE  as the weak entity.

<h2> Generalisation and Specialization </h2>
The Users are classified into Admin and other Users based on their role Admin or Non Admin. Admins can organize events, they can reserve Halls for the events occuring and have different privileges when compared to other users.

<h2> Extended Entity Relationship Model </h2>

![Image 1](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/1.png)
Relations:

1.	For USERS, UserID is the primary key.
2.	In ADDRESS, ADMIN, OTHERS; UserID is the foreign key from USERS.
3.	For FEEDBACK, UserID is the foreign Key from USERS.
4.	In ADMIN, UBID  is a candidate key.
5.	For EVENT REGISTER, EventID is the primary key, UserID is the foreign Key from ADMINS.
6.	For HALL REGISTER, HallID is the primary key and  UserID , EventID are  the foreign Keys from ADMINS and EVENTREGISTER respectively.
7.	For REGISTRATION, RegID is the primary key and UserID, EventID are Foreign keys from OTHERS and EVENTREGISTER respectively.
8.	For FAQS and VOLUNTEERS, UserID and EventID are the composite primary keys where UserID is from ADMINS and EventID is from EVENTREGISTER..
9.	RegID and name together are the Composite primary key for AUDIENCE where RegID is a primary key of REGISTRATION.
10.	RoomID is the primary key for LODGING, RegID is the Foreign key from REGISTRATIONS.

Functional dependency:
1.	User name is functionally dependent on UserID.
2.	Event Name is functionally dependent on Event ID.

<h2> Relational Schema</h2>

![Image 2](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/2.png)
<h2> Relational Alzebra </h2>
1. TotalReg←Π_(Eventid,No of registrations)  (〖_Eventid〗I_(COUNT Regid) (REGISTRATION))
  HallCap ← Π_(Eventid,Capacity) (HALLREGISTER)
  R1← TotalReg ⋈_(T.Eventid=Eventid) HallCap
  Result ←Π_Eventid  (〖_〗I_(No of registrations>Capacity) (R1))

2. 	Result ←Π_(Things to improve)  (〖_〗ρ_(Rating<5) (FEEDBACK))

3.	BookingReg ←Π_Regid (LODGING)
	UserReg← Π_userid (BookingReg  ⋈_(B.Regid=Regid) REGISTRATION)
	Result ←Π_(email,phone,name) (UserReg)

4.	RegDetails ←Π_(Regid,userid,eventid) (REGISTRATION)
	RoleDetails ←Π_(Regid,role) (RegDetails  ⋈_(R.Regid=Regid) ROLES) 
UserDetails← Π_(Regid,name) (RegDetails  ⋈_(R.Userid=Userid) USERS)
UserRoles ← Π_(Regid,name) (RoleDetails  ⋈_(R.Regid=U.Regid) UserDetails)
Edetails ←Π_(Regid,event name) (RegDetails ⋈_(R.Regid=Regid) EVENTREGISTER)
Result ←Π_(Name,Role,,event name) (UserRoles ⋈_(U.Regid=Regid) Edetails)

5.	NextDayEv ←Π_Eventid  (〖_〗ρ_(Eventdate-1=currentdate) (EVENTREGISTER))
	UserEv←Π_userid ( NextDayEv  ⋈_(N.eventid=eventid) REGISTRATION)
	Result ← Π_(emailid,name) ( UserEv  ⋈_(U.userid=userid) USERS)

6.	FollowingUsers ←Π_Userid  (〖_〗ρ_(Following='Yes') (REGISTRATION))
	Result ←Π_emailid (FollowingUsers   ⋈_(U.userid=userid) USERS)

7.	AdEvent ←Π_Eventid  (〖_〗ρ_(〖a_ 〗_userid=XXXX) (EVENTREGISTER))
	AdRegister ← Π_Regid ( AdEvent  ⋈_(A.eventid=eventid) REGISTRATION)	
EventVol ← Π_Regid ( AdRegister ⋈_(A.Regid=Regid) (〖_〗ρ_(Roles='volunteers) (VOLUNTEERS)))
Result ← Π_Regid ( EventVol   ⋈_(E.Regid=Regid) LODGING)

8. Result ← Π_userid (〖_〗ρ_(No of events>2) (〖_Userid〗I_(COUNT Eventid) (REGISTRATION)))

9. RegEve ←Π_Eventid  (〖_〗ρ_(Userid=XXXX) (REGISTRATION))
   Result ← Π_(Facilities available) (RegEve   ⋈_(R.eventid=eventid) FAQS)

10. UserReg ←Π_Regid  (〖_〗ρ_(Eventid=XXXX) (REGISTRATION))
    Total ←UserReg ⋈_(U.Regid=Regid) (〖Π_Regid〗_ (ρ_(Roles='participants') (ROLES)))
   Result  ←Π_(COUNT Regid) (Total)

11. HapEve ←Π_(Eventid,EVENT name)  (〖_〗ρ_(Event date=XX-XX-XX) (EVENTREGISTER))
  Result ←Π_(eventname,hall name) ( HapEve   ⋈_(H.eventid=eventid) HALLREGISTER)

12. HisEve  ←Π_Eventid  (〖_〗ρ_(Regid=XXXX) (REGISTRATION))
 Result ←Π_(Report to) ( HisEve    ⋈_(H.eventid=eventid) VOLUNTEERS)

13. RegEve  ←Π_Eventid  (〖_〗ρ_(Userid=XXXX) (REGISTRATION)) 
  AdminDetail←Π_auserid ( RegEve    ⋈_(R.eventid=eventid) EVENTREGISTER)
 Result ←Π_emailid (  AdminDetail ⋈_(auserid=userid) USERS)

14. Result ←〖_〗ρ_(Capacity>=XXX and date=XX-XX-XX) (HALLREGISTER))

15. RegUsers ←Π_Regid  (〖_〗ρ_(Eventid=XXXX) (REGISTRATION))
   Result ←Π_(COUNT Regid) (  RegUsers ← ⋈_(R.Regid=Regid) AUDIENCE)
   
<h2> Creating Database Server in GCP</h2>

![Image 3](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/3.png)

![Image 4](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/4.png)

![Image 5](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/5.png)

![Image 6](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/6.png)

![Image 7](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/7.png)

![Image 8](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/8.png)

![Image 9](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/9.png)

![Image 10](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/10.png)

![Image 11](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/11.png)

![Image 12](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/12.png)

![Image 13](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/13.png)

![Image 14](https://github.com/DivyaSamragniNadakuditi/EventRegistrationApp/blob/master/images/14.png)




