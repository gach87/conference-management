# Conference Administration System

You are planning a big programming conference and you have received many proposals that have passed the initial review process. Now you are having difficulties to fit in the time slots provided for the day of the event. There are many possibilities! So, you have decided to write a program that will help you.

The conference is divided into several themes. Each subject has a session in the morning and another in the afternoon.

Each session contains multiple talks.

The morning sessions begin at 9 AM and must end at 12 noon for lunch.

The afternoon sessions begin at 1 PM and must end in time for the social event.

The social event can not start before 4:00 or after 5:00.

None of the titles of the talks contain numbers.

The duration of all the talks is given in minutes (not hours). It can also be a short talk of 5 minutes (lightning).

The presenters will be very punctual so there is no need to schedule breaks between sessions.

Keep in mind that depending on how you solve the problem your solution can produce different combinations or orderings of the talks in the themes, this is acceptable. You do not have to duplicate exactly the example result provided below.

Example Input:

Writing Fast Tests Against Enterprise Rails 60min

Overdoing it in Python 45min

Lua for the Masses 30min

Ruby Errors from Mismatched Gem Versions 45min

Common Ruby Errors 45min

Rails for Python Developers lightning

Communicating Over Distance 60min

Accounting-Driven Development 45min

Woah 30min

Sit Down and Write 30min

Pair Programming vs Noise 45min

Rails Magic 60min

Ruby on Rails: Why We Should Move On 60min

Clojure Ate Scala (on my project) 45min

Programming in the Boondocks of Seattle 30min

Ruby vs. Clojure for Back-End Development 30min

Ruby on Rails Legacy App Maintenance 60min

A World Without HackerNews 30min

User Interface CSS in Rails Apps 30min


Example output:

Theme 1:

09:00AM Writing Fast Tests Against Enterprise Rails 60min

10:00AM Overdoing it in Python 45min

10:45AM Lua for the Masses 30min

11:15AM Ruby Errors from Mismatched Gem Versions 45min

12:00PM Lunch

01:00PM Ruby on Rails: Why We Should Move On 60min

02:00PM Common Ruby Errors 45min

02:45PM Pair Programming vs Noise 45min

03:30PM Programming in the Boondocks of Seattle 30min

04:00PM Ruby vs. Clojure for Back-End Development 30min

04:30PM User Interface CSS in Rails Apps 30min

05:00PM Networking Event

Theme 2:

09:00AM Communicating Over Distance 60min

10:00AM Rails Magic 60min

11:00AM Woah 30min

11:30AM Sit Down and Write 30min

12:00PM Lunch

01:00PM Accounting-Driven Development 45min

01:45PM Clojure Ate Scala (on my project) 45min

02:30PM A World Without HackerNews 30min

03:00PM Ruby on Rails Legacy App Maintenance 60min

04:00PM Rails for Python Developers lightning

05:00PM Networking Event