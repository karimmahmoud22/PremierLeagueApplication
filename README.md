Type ➔ Desktop Application <br> Problem Definition (Main Idea):<br> we think to create this application (with its database) to provide information and statistics about the players and managers of the premier league teams to make it easy for Supervisors of the premier league to manage it easily by employing coaches of teams and some other responsibilities that will be explained later. Each coach will have responsibilities will be explained later. Also, we will help people who love football to know about their lovely teams and players.
-------------------------------------------------------------------------------------------------------------
Users:<br>
Supervisors: add / remove / employ Supervisor Assistant && add / remove teams (if that team is relegated from the premier league to English second division).<br>
Supervisor Assistant: add / remove teams (if that team is relegated from the premier league to English second division).<br>
Coaches: add / remove / employ doctors && add / remove / employ statistician.<br>
Team Manager (Statistician): add / remove / transfer players & & update the statistics of each player (goals, assists, yellow cards, red cards).<br>
Doctor: determine whether the player is injured or not && specify the injured duration && write short report about the injury.<br>
Fitness Trainer: determine Shoot Power && dribbling && Pass Power && Salary for each player in the team.<br>
------------------------------------------------------------------------------------------------------------
Entities:<br>
1. Teams: include all teams of premier league.
2. Players: include all players in the league.
3. Coaches: include all coaches in the league.
4. Doctors: include all doctors who will treat players.
5. Team Managers (Statisticians): include all team managers who will responsible for updating each player information.
6. Supervisors: who will manage the league.
7. Supervisor Assistant: who will help supervisor to manage the league.
8. Fitness Trainer: who will responsible for each player fitness in the team he will work for.
-----------------------------------------------------------------------------------------
Relationships:<br>
Plays for: each player will play in a team or will be free that means (0,1) and each team will have minimum 14 players and maximum 30 players that means (14,30).<br>
Works for(coach): each coach will work for only one team or will be free (0,1) and each team must have only one coach (1,1).<br>
Works for (Statistician): each Statistician will work for only one team or will be free (0,1) and each team must have only one Statistician (1,1).<br>
Works for (Doctor): each Doctor will work for only one team or will be free (0,1) and each team must have only one Doctor (1,1).<br>
Works for (Fitness Trainer): each Fitness Trainer will work for only one team or will be free (0,1) and each team must have one Fitness Trainer and can increase up to 4 (1,4).<br>
Physical Training: each Fitness Trainer will trainee the players of the team he works for or will be free (0, n) and each player will trainee by only one fitness trainer or not (In case of being free) (0,1).<br>
Supervises: league supervisor will supervise his assistants (0, n) and each assistant will be supervised by only one supervisor or not (in case of being started his job) (0,1).<br>
Treats: each doctor will treat the players of the team he works for or will be free (0,30) and each player will be treated by only one doctor or not (In case of being free) (0,1).<br>
Trainee: each coach will train the players of the team or not (In case of being free) (0, n) and each player will be trained by only one coach or not (In case of being free) (0,1).<br>
-----------------------------------------------------------------------------------------------------
