using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DBapplication;

namespace WindowsFormsApp1
{
    public class DB_Controller
    {
        DBManager DB_Man;

        public DB_Controller()
        {
            DB_Man = new DBManager();
        }

        public int employAssistant(string email, string super_id)
        {
            string query = "UPDATE supervisor_assistant SET supervisor_id = " + super_id + " where email = '" + email + "';";
            return DB_Man.ExecuteNonQuery(query);
        }

        //********************************************* ALL QUERIES FOR INSERTION ********************************************* 

        /* INSERT NEW PLAYER */
        //KARIM ======> NOTE : we will senf injured as a boolean or int ( data base ) ?
        //the 3 zeros for yellow_cards , red_cards and goals
        public int Insert_New_Player( string firstName , string lastName , string minit , string nationality , string birthDate ,
                                      int salary , int pass_power , int shoot_power , int Tshirt_number , int dribbling , string injured ,
                                      string height , string weight , int price , string position , int team_id , int coach_id )
        {
            string query ="INSERT INTO player " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + nationality + "', '" + birthDate
                          + "', '" + salary + "', '" + pass_power + "', '" + shoot_power + "', '" + Tshirt_number + "', '" + dribbling 
                          + "', '" + injured + "', '" + height + "', '" + weight + "', '" + 0 + "', '" + 0 + "','" + 0 + "', '" + 0 + "', '" + price
                          + "', '" + position + "', '" + team_id + "', '" + coach_id + "' );";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW COACH */
        public int Insert_New_Coach( string firstName, string lastName, string minit, string email, string password, string nationality,
                                     string birthDate , string salary, string city , string team)
        {
            string query = "INSERT INTO coach " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + email + "', '" + password
                          + "'," + "  '" + nationality + "', '" + birthDate + "', '" + salary + "', '" + city + "', '" + team + "');";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW DOCTOR */
        public int Insert_New_Doctor( string firstName, string minit, string lastName, string email, string password, string nationality,
                                      string birthDate, string salary)
        {
            string query = "INSERT INTO doctor " +
                          "Values('" + firstName + "','" + minit + "','" + lastName + "' , '" + email + "', '" + password
                          + "'," + "  '" + nationality + "', '" + birthDate + "', '" + salary + "', '" + "NULL" + "');";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW FITNESS_TRAINER */
        public int Insert_New_fitness_trainer( string firstName, string lastName, string minit, string email, string password, string nationality,
                                               string birthDate, string salary , string team_id)
        {
            string query = "INSERT INTO fitness_trainer " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + email + "', '" + password
                          + "'," + "  '" + nationality + "', '" + birthDate + "', '" + salary + "', '" + team_id + "' );";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW SUPERVISOR */
        public int Insert_New_supervisor( string firstName, string lastName, string minit, string email, string password, string nationality,
                                          string birthDate, string salary,string phoneNumber)
        {   
            string query = "INSERT INTO supervisor " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + email + "', '" + password
                          + "'," + "  '" + nationality + "', '" + birthDate + "', '" + salary + "','" + phoneNumber + "');";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW SUPERVISOR ASSISTANT */
        public int Insert_New_supervisor_assistant( string firstName, string lastName, string minit, string email, string password, string nationality,
                                  string birthDate, string salary,string supervisor_idd)
        {
            string query = "INSERT INTO supervisor_assistant " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + email + "', '" + password
                          + "'," + " '" + nationality + "', '" + birthDate + "', '" + salary + "', '" + supervisor_idd + "');";
            return DB_Man.ExecuteNonQuery(query);
        }

        /* INSERT NEW TEAM MANAGER */
        public int Insert_New_Manager( string firstName, string lastName, string minit, string email, string password, string nationality,
                          string birthDate, string salary, string address , string team)
        {
            string query = "INSERT INTO Manager " +
                          "Values('" + firstName + "','" + lastName + "','" + minit + "' , '" + email + "', '" + password
                          + "'," + "  '" + nationality + "', '" + birthDate + "', '" + salary + "', '" + address + "', '" + team + "');";
            return DB_Man.ExecuteNonQuery(query);
        }

        // INSERT NEW TEAM
        public int InsertTeam(string name,int playersCount, decimal budget, int points, int scoredGoals)
        {
            string query = "EXEC insertTeam @teamName = " + name
                           + ", @playersCount = " + playersCount
                           + ", @budget = " + budget
                           + ", @points = " + points
                           + ", @scoredGoals= " + scoredGoals; 
                           //+", @doctorId = "                + "null" 
                           //+", @coachId = "                 + "null"
                           //+", @managerId = "               + "null";

            return DB_Man.ExecuteNonQuery(query);
        }

        //********************************************* ALL QUERIES FOR UPDATES ********************************************* 

        // update player
        public int updatePlayer(int team_id, string goals, string assists, string  y_cards, string r_cards, string tShirtNumber)
        {
            string query = "EXEC updatePlayer @goals = " + goals
                           + ", @Assists = " + assists
                           + ", @yCards = " + y_cards
                           + ", @rCards = " + r_cards
                           + ",@teamId = " + team_id
                           + ",@t_num= "  + tShirtNumber
                           ;
            return (int)DB_Man.ExecuteNonQuery(query);
        }


        //FOR EMPLOYE DOCTOR ( SET DOCTOR_ID IN THE TABLE OF THE TEAM HE WILL WORK FOR )
        public int Update_Doctor_ID_IN_TEAMTABLE(int doctor_id)
        {
            string query = "UPDATE team SET doctor_id='" + doctor_id + "';";
            return DB_Man.ExecuteNonQuery(query);
        }

        // update goals of the team
        public int updateGoals(int team_id, int goals)
        {
            string query = "UPDATE team SET scored_goals='" + goals + "' where team.id = " + team_id;
            return DB_Man.ExecuteNonQuery(query);
        }
        // get goals of the team
        public int getGoals(int team_id)
        {
            string query = "select scored_goals from team where id='" + team_id + "';";
            return (int)DB_Man.ExecuteScalar(query);
        }

        public int Update_TEAM_ID_IN_DOCTORTABLE(int team_id)
        {
            string query = "UPDATE doctor SET team_id='" + team_id + "';";
            return DB_Man.ExecuteNonQuery(query);
        }

      /*  public int Update_TEAM_ID_IN_TRANSFER(int team_id)
        {
            string query = "UPDATE player SET team_id='" + team_id + "';";
            return DB_Man.ExecuteNonQuery(query);
        }*/

        public int Update_TEAM_ID_IN_Stat(int team_id, string email)
        {
            string query = "UPDATE Manager SET team_id='" + team_id + "' WHERE email = '" + email +"';";
            return DB_Man.ExecuteNonQuery(query);
        }


        //********************************************* ALL QUERIES FOR DELETION ********************************************* 


        public int removeFromAnyTableByUniqueAttribute(string attributeName, string attributeValue, string tableName)
        {
            string query = "DELETE FROM " + tableName + " WHERE " + attributeName + " = '" + attributeValue + "';";
            return DB_Man.ExecuteNonQuery(query);
        }


        public int DeleteDoctor(string email)
        {
            string query = "DELETE FROM doctor WHERE email='" + email + "';";
            return (int)DB_Man.ExecuteNonQuery(query);
        }

        public int DeletePlayer(string Tshirt_number)
        {
            string query = "DELETE FROM player WHERE Tshirt_number='" + Tshirt_number + "';";
            return (int)DB_Man.ExecuteNonQuery(query);
        }


        public int DeleteStatistician(string email)
        {
            string query = "DELETE FROM Manager WHERE email='" + email + "';";
            return (int)DB_Man.ExecuteNonQuery(query);
        }

        //********************************************* ALL QUERIES FOR GETTING *********************************************


        public DataTable get_All_mails_of_Players_in_a_team()
        {
            string query = "SELECT Tshirt_number FROM player WHERE ;";
            return DB_Man.ExecuteReader(query);
        }


        public DataTable get_All_mails_of_Doctors_who_donnot_work()
        {
            string query = "SELECT doctor.email FROM doctor WHERE NOT EXISTS( SELECT id FROM team WHERE team.id=doctor.team_id);";
            return DB_Man.ExecuteReader(query);
        }


        public DataTable get_All_mails_of_Doctors()
        {
            string query = "SELECT email FROM doctor;";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_All_mails_of_Statistician()
        {
            string query = "SELECT email FROM Manager WHERE NOT EXISTS( SELECT id FROM team WHERE team.id=Manager.team_id);";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_All_mails_of_Statistician_to_delete(string mail)
        {
            string query = "SELECT email FROM Manager WHERE Manager.team_id  IN ( SELECT team_id FROM coach WHERE coach.email='" + mail + "')";
            return DB_Man.ExecuteReader(query);
        }


        public DataTable get_All_IDS_of_Teams_to_transfer_from()
        {
            string query = "SELECT id FROM team;";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_All_NamesS_of_Teams()
        {
            string query = "SELECT Name FROM team;";
            return DB_Man.ExecuteReader(query);
        }
        public DataTable get_name_team_for_player(string mail)
        {
            string query = "SELECT Name FROM Manager,team WHERE team_id=team.id AND email='" + mail + "';";
            return DB_Man.ExecuteReader(query);
        }

        

        public DataTable get_All_IDS_of_Teams_null_coach()
        {
            string query = "SELECT team.id FROM team WHERE team.id NOT IN ( SELECT coach.team_id FROM coach where team_id Is Not NULL );";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_All_IDS_of_Teams_null_manager()
        {
            string query = "SELECT team.id FROM team WHERE team.id NOT IN ( SELECT Manager.team_id FROM Manager where team_id Is Not Null );";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_All_IDS_of_supervisors()
        {
            string query = "SELECT id FROM supervisor;";
            return DB_Man.ExecuteReader(query);
        }


        public int get_team_id_for_player(string mail)
        {
            string query = "SELECT team_id FROM Manager WHERE email='" + mail + "';";
            return (int)DB_Man.ExecuteScalar(query);
        }

        public DataTable get_team_id_for_playerr(string mail)
        {
            string query = "SELECT team_id FROM Manager WHERE email='" + mail + "';";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable get_team_ids_for_transfer(int idd)
        {
            string query = "SELECT id FROM team WHERE id!='" + idd + "';";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable Get_Plyers_of_a_team(int team_id)
        {
            string query = "SELECT Tshirt_number FROM player WHERE team_id=" + team_id + ";";
            return DB_Man.ExecuteReader(query);
        }


        /* GET TEAM_ID THAT TEAM MANAGER WORKS FOR */
        public int Get_Team_Id(int manager_id)
        {
            string query = "SELECT id FROM team WHERE manager_id=" + manager_id + ";";
            return (int)DB_Man.ExecuteScalar(query);
        }


        public int Get_Team_Id_from_manager_mail(string manager_mail) /////////coach
        {
            string query = "SELECT team_id FROM coach WHERE email='" + manager_mail + "';";
            return (int)DB_Man.ExecuteScalar(query);
        }

        public int Get_Team_Id_from_manager_stat_mail(string manager_mail) 
        {
            string query = "SELECT team_id FROM Manager WHERE email='" + manager_mail + "';";
            return (int)DB_Man.ExecuteScalar(query);
        }


        /* GET DOCTOR_ID THAT WORKS FOR A SPECIFIC TEAM */
        public int Get_Doctor_Id(int team_id)
        {
            string query = "SELECT doctor_id FROM team WHERE id=" + team_id + ";";
            return (int)DB_Man.ExecuteScalar(query);
        }

        public int Get_Stat_Id_from_Stat_email(string mail)
        {
            string query = "SELECT id FROM Manager WHERE email='" + mail + "';";
            return (int)DB_Man.ExecuteScalar(query);
        }

        /* GET FITNESS TRAINER _ID THAT WORKS FOR A SPECIFIC TEAM */
        public int Get_Fitness_Trainer_Id(int team_id)
        {
            string query = "SELECT id FROM fitness_trainer WHERE team_id=" + team_id + ";";
            return (int)DB_Man.ExecuteScalar(query);
        }

        /* GET COACH_ID THAT WORKS FOR A SPECIFIC TEAM */
        public int Get_Coach_Id(int team_id)
        {
            string query = "SELECT id FROM coach WHERE team_id=" + team_id + ";";
            return (int)DB_Man.ExecuteScalar(query);
        }

        // select all teams
        public DataTable getAllTeams()
        {
            string query = "EXEC selectAllTeams";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable getTeamsWithoutCoaches()
        {
            string query = "SELECT id,Name, player_count, budget, points, scored_goals from team where team.id NOT IN ( SELECT coach.team_id FROM coach where coach.team_id is not null )";
            return DB_Man.ExecuteReader(query);
        }

        public DataTable getAllCoaches()
        {
            string query = "EXEC selectAllCoached";
            return DB_Man.ExecuteReader(query);
        }

        // select all players of a certain team
        public DataTable getTeamPlayers(string teamName)
        {
            string query = "EXEC selectPlayersOfTeam " + teamName;
            return DB_Man.ExecuteReader(query);
        }

        public bool checkEmail_passowrd(string email, string pass, string table)
        {
            //EDITED BY KARIM
           string query = "SELECT count(email) as counter FROM " +  table + " where email = '" + email + "' AND password ='" + pass + "';";
            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return true;
            else return false;
        }

        public bool check_TshirtNumber(int team_id, string t_number)
        {
            //EDITED BY KARIM
            string query = "SELECT count(player.firstName) as counter FROM player where player.team_id = " + team_id+ " and player.Tshirt_number = " + t_number;
            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return false;
            else return true;
        }

        public bool checkAssistant(string email)
        {
            //EDITED BY KARIM
            string query = "SELECT count(supervisor_assistant.firstName) from supervisor_assistant where email = '" + email + "' and supervisor_assistant.supervisor_id IS NULL; ";
            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return true;
            else return false;
        }

        public bool check_user_is_already_employed(string tableName, string checker_attribute, string email)
        {
            //EDITED BY KARIM
            string query = "SELECT count(*) from " + tableName + " where " + checker_attribute + " is not null and email = '" +  email + "'"; 

            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return true;
            else return false;
        }


        public bool checkEmail(string email, string table)
        {
            string query = "SELECT count(email) as counter FROM " + table + " where email = '" + email +"';";
            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return true;
            else return false;
        }
        public bool checkTeamNameUniqueness(string teamName)
        {
            string query = "SELECT count(Name) as counter FROM team where Name = '" + teamName + "';";
            int count = (int)DB_Man.ExecuteScalar(query);

            if (count == 1)
                return false;
            else return true;
        }

        public int updatePassword(string email,string table, string newPassword)
        {
            string query = "UPDATE " + table + " SET password = '" + newPassword + "' where email = '" + email + "';";
            return DB_Man.ExecuteNonQuery(query);
        }

        public int transferPlayer(string player_tshirtNum, int coachId_new, string team_id_new)
        {
            string query = "update player SET player.team_id = " + team_id_new + ", player.coach_id = " + coachId_new + " WHERE Tshirt_number = " + player_tshirtNum;
            return DB_Man.ExecuteNonQuery(query);
        }

        public DataTable getSuperVisorAssistantsData()
        {
            string query = "EXEC getAllAssistants ";
            return DB_Man.ExecuteReader(query);
        }
        public DataTable getNotEmplyedCoaches()
        {
            string query = "EXEC getNotEmployedCoaches";
            return DB_Man.ExecuteReader(query);
        }

        public int updateStartDate(int id, string tableName, DateTime date)
        {
            string query = "UPDATE " + tableName + " SET start_data = '" + date + "' WHERE id=" + id;
            return DB_Man.ExecuteNonQuery(query);
        }
        public DataTable statistics(string team_id)
        {
            string query = "select CONCAT(player.firstName, ' ', player.lastName) as 'name', player.goals as 'goals' from player where team_id = " + team_id;
            return DB_Man.ExecuteReader(query);
        }

        // update coachId in the team
        public int updateTeamCoach(int coachId, int teamId)
        {
            string query = "EXEC setCoachId " + coachId + ',' + teamId;

            update_team_id_for_coach(teamId, coachId);

            return (int)DB_Man.ExecuteNonQuery(query);
        }

        public int update_team_id_for_coach(int team_id_valud, int id)
        {
            string query = "UPDATE coach SET team_id=" + team_id_valud + " where id=" + id;

            return (int)DB_Man.ExecuteNonQuery(query);
        }


        public void TerminateConnection()
        {
            DB_Man.CloseConnection();
        }
    }
}
