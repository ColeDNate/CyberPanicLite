using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberPanicLite.Classes;
using static CyberPanicLite.Classes.Enumerated;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace CyberPanicLite.Data
{
    internal class MySQLConnection
    {
        
        private string connectionString = "server=cyber-panic-database.mysql.database.azure.com;username=CyberDev;password=!PanicPass;";
        //127.0.0.1
        private string query;

        public MySQLConnection()
        {


        }

        public bool ExecuteSql(string query, List<MySqlParameter> parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                    return rowsAffected > 0;
                }
            }
        }


        /*** ACTIONS ***/
        public bool SaveAction(int actionID, string actionName, string actionDescription, bool enemyIsTarget, int effectType, int value, int cooldown)
        {
            string query;
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            Console.WriteLine("Attempting to write action: " + actionName + " " + actionDescription);

            if (actionID == 0)
            {
                // Insert a new action
                query = "INSERT INTO game.action (action_name, action_description, enemy_is_target, effect_type, value, cooldown) VALUES (@actionName, @actionDescription, @enemyIsTarget, @effectType, @value, @cooldown)";
            }
            else
            {
                // Update an existing action
                query = "UPDATE game.action SET action_name = @actionName, action_description = @actionDescription, enemy_is_target = @enemyIsTarget, effect_type = @effectType, value = @value, cooldown = @cooldown WHERE action_id = @actionID";
                parameters.Add(new MySqlParameter("@actionID", actionID));
            }

            parameters.AddRange(new List<MySqlParameter>
            {
                new MySqlParameter("@actionName", actionName),
                new MySqlParameter("@actionDescription", actionDescription),
                new MySqlParameter("@enemyIsTarget", enemyIsTarget),
                new MySqlParameter("@effectType", effectType),
                new MySqlParameter("@value", value),
                new MySqlParameter("@cooldown", cooldown)
            });

            return ExecuteSql(query, parameters);
        }
        public bool InsertAction(string actionName, string actionDescription, bool enemyIsTarget, int effectType, int value, int cooldown)
        {
            string query = "INSERT INTO game.action (action_name, action_description, enemy_is_target, effect_type, value, cooldown) VALUES (@actionName, @actionDescription, @enemyIsTarget, @effectType, @value, @cooldown)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@actionName", actionName),
                new MySqlParameter("@actionDescription", actionDescription),
                new MySqlParameter("@enemyIsTarget", enemyIsTarget),
                new MySqlParameter("@effectType", effectType),
                new MySqlParameter("@value", value),
                new MySqlParameter("@cooldown", cooldown)
            };

            return ExecuteSql(query, parameters);
        }

        public bool EditAction(int actionID, string actionName, string actionDescription, bool enemyIsTarget, int effectType, int value, int cooldown)
        {
            string query = "UPDATE game.action SET action_name = @actionName, action_description = @actionDescription, enemy_is_target = @enemyIsTarget, effect_type = @effectType, value = @value, cooldown = @cooldown WHERE action_id = @actionID";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@actionID", actionID),
                new MySqlParameter("@actionName", actionName),
                new MySqlParameter("@actionDescription", actionDescription),
                new MySqlParameter("@enemyIsTarget", enemyIsTarget),
                new MySqlParameter("@effectType", effectType),
                new MySqlParameter("@value", value),
                new MySqlParameter("@cooldown", cooldown)
            };

            return ExecuteSql(query, parameters);
        }


        public List<PlayAction> FetchActions()
        {
            List<PlayAction> actions = new List<PlayAction>();

            query = "SELECT * FROM game.action";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Map database columns to ActionData properties
                            PlayAction action = new PlayAction
                            {
                                /*PlayAction(int actionID, string actionName, bool enemyIsTarget, Enumerated.EffectType effectType, int value, int coolDown)*/
                                 
                                actionID = reader.GetInt32("action_id"),
                                actionName = reader.GetString("action_name"),
                                actionDescription = reader.GetString("action_description"),
                                enemyIsTarget = reader.GetBoolean("enemy_is_target"),
                                effectType = (Enumerated.EffectType)reader.GetInt32("effect_type"),
                                value = reader.GetInt32("value"),
                                coolDown = reader.GetInt32("cooldown")
                            };

                            actions.Add(action);
                        }
                    }
                }
                connection.Close();
            }

            return actions;
        }

        //to be used with the fetch cards
        public PlayAction FetchSingleAction(int actionID)
        {
            PlayAction action = null;
            query = "SELECT * FROM game.action WHERE action_id = @actionID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@actionID", actionID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map database columns to ActionData properties
                            action = new PlayAction
                            {
                                actionID = reader.GetInt32("action_id"),
                                actionName = reader.GetString("action_name"),
                                actionDescription = reader.GetString("action_description"),
                                enemyIsTarget = reader.GetBoolean("enemy_is_target"),
                                effectType = (Enumerated.EffectType)reader.GetInt32("effect_type"),
                                value = reader.GetInt32("value"),
                                coolDown = reader.GetInt32("cooldown")
                            };
                        }
                    }
                }
                connection.Close();
            }

            return action;
        }

        public bool DeleteAction(int actionID)
        {
            string query = "DELETE FROM game.action WHERE action_id = @actionID";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@actionID", actionID)
            };

            return ExecuteSql(query, parameters);
        }


        /*** CARD ACTIONS ***/

        public bool InsertCard(string cardName, string cardDescription, int cardType, int actionID1, int actionID2)
        {
            string query = "INSERT INTO game.card (card_name, card_description, card_type, action_id_1, action_id_2) VALUES (@cardName, @cardDescription, @cardType, @actionID1, @actionID2)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@cardName", cardName),
                new MySqlParameter("@cardDescription", cardDescription),
                new MySqlParameter("@cardType", cardType),
                new MySqlParameter("@actionID1", actionID1),
                new MySqlParameter("@actionID2", actionID2),
            };

            return ExecuteSql(query, parameters);
        }

        public bool EditCard(int cardID, string cardName, string cardDescription, int cardType, int actionID1, int actionID2)
        {
            string query = "UPDATE game.card SET card_name = @cardName, card_description = @cardDescription, card_type = @cardType, action_id_1 = @actionID1 , action_id_2 = @actionID2 WHERE card_id = @cardID";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@cardID", cardID),
                new MySqlParameter("@cardName", cardName),
                new MySqlParameter("@cardDescription", cardDescription),
                new MySqlParameter("@cardType", cardType),
                new MySqlParameter("@actionID1", actionID1),
                new MySqlParameter("@actionID2", actionID2),
            };

            return ExecuteSql(query, parameters);
        }


        public List<Card> FetchCards()
        {
            List<Card> cards = new List<Card>();

            query = "SELECT * FROM game.card";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //fetch the actions singularly to create the card
                            PlayAction fetchedAction1 = null;
                            PlayAction fetchedAction2 = null;

                            //initialize the id to the action_id from the database
                            //will use this id to find the cooresponding item to join with the card
                            int actionID1 = reader.GetInt32("action_id_1");
                            int actionID2 = reader.GetInt32("action_id_2");

                            //if the value is greater than 0 then we will be able to fetch the actions from the database
                            if (actionID1 > 0)
                            {
                                //using a singular action pull specifically for the cards. 
                                fetchedAction1 = new PlayAction(FetchSingleAction(actionID1));
                            }
                            if (actionID2 > 0)
                            {
                                fetchedAction2 = new PlayAction(FetchSingleAction(actionID2));
                            }
                            // Map database columns to Card Data properties
                            Card card = new Card
                            {
                                //when adding the cards to the database
                                cardID = reader.GetInt32("card_id"),
                                name = reader.GetString("card_name"),
                                cardType = (Enumerated.CardType)reader.GetInt32("card_type"),
                                description = reader.GetString("card_description"),
                                action1 = fetchedAction1,
                                action2 = fetchedAction2
                            };

                            cards.Add(card);
                        }
                    }
                }

                connection.Close();
            }

            return cards;
        }
        public Card FetchSingleCard(int cardID)
        {
            Card card = new Card();

            query = "SELECT * FROM game.card WHERE card_id = @cardID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Define the @cardID parameter and set its value
                    command.Parameters.AddWithValue("@cardID", cardID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        //fetch the actions singularly to create the card
                        PlayAction fetchedAction1 = null;
                        PlayAction fetchedAction2 = null;

                        if (reader.Read())
                        {
                            //initialize the id to the action_id from the database
                            //will use this id to find the cooresponding item to join with the card
                            int actionID1 = reader.GetInt32("action_id_1");
                            int actionID2 = reader.GetInt32("action_id_2");

                            //if the value is greater than 0 then we will be able to fetch the actions from the database
                            if (actionID1 > 0)
                            {
                                //using a singular action pull specifically for the cards. 
                                fetchedAction1 = new PlayAction(FetchSingleAction(actionID1));
                            }
                            if (actionID2 > 0)
                            {
                                fetchedAction2 = new PlayAction(FetchSingleAction(actionID2));
                            }
                        
                            // Map database columns to Card Data properties
                            card = new Card
                            {
                                //when adding the cards to the database
                                cardID = reader.GetInt32("card_id"),
                                name = reader.GetString("card_name"),
                                cardType = (Enumerated.CardType)reader.GetInt32("card_type"),
                                description = reader.GetString("card_description"),
                                action1 = fetchedAction1,
                                action2 = fetchedAction2
                            };

                        }
                    }
                }
                connection.Close();
            }

            return card;
        }
        public bool DeleteCard(int cardID)
        {
            string query = "DELETE FROM game.card WHERE card_id = @cardID";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@cardID", cardID)
            };

            return ExecuteSql(query, parameters);
        }




        /*** Deck ACTIONS ***/

        public bool InsertDeck(string deckName, int hpMax, int card1ID, int card2ID, int card3ID, int card4ID, int card5ID)
        {
            string query = "INSERT INTO game.deck (deck_name, health_max, card_id_1, card_id_2, card_id_3, card_id_4, card_id_5) VALUES (@deckName, @hpMax, @card1ID, @card2ID, @card3ID, @card4ID, @card5ID)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@deckName", deckName),
                new MySqlParameter("@hpMax", hpMax),
                new MySqlParameter("@card1ID", card1ID),
                new MySqlParameter("@card2ID", card2ID),
                new MySqlParameter("@card3ID", card3ID),
                new MySqlParameter("@card4ID", card4ID),
                new MySqlParameter("@card5ID", card5ID),
            };

            return ExecuteSql(query, parameters);
        }

        public bool EditDeck(int deckID, string deckName, int hpMax, int card1ID, int card2ID, int card3ID, int card4ID, int card5ID)
        {
            string query = "UPDATE game.deck SET deck_name = @deckName, health_max = @hpMax, card_id_1 = @card1ID, card_id_2 = @card2ID , card_id_3 = @card3ID, card_id_4 = @card4ID, card_id_5 = @card5ID WHERE deck_id = @deckID";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@deckID", deckID),
                new MySqlParameter("@deckName", deckName),
                new MySqlParameter("@hpMax", hpMax),
                new MySqlParameter("@card1ID", card1ID),
                new MySqlParameter("@card2ID", card2ID),
                new MySqlParameter("@card3ID", card3ID),
                new MySqlParameter("@card4ID", card4ID),
                new MySqlParameter("@card5ID", card5ID),
            };

            return ExecuteSql(query, parameters);
        }


        public List<Deck> FetchDecks()
        {
            List<Deck> decks = new List<Deck>();

            query = "SELECT * FROM game.deck";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<Card> fetchedCards = new List<Card>();

                            for (int i = 1; i <= 5; i++)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal($"card_id_{i}")))
                                {
                                    int cardID = reader.GetInt32($"card_id_{i}");
                                    fetchedCards.Add(new Card(FetchSingleCard(cardID)));
                                }
                                else
                                {
                                    // If card_id_i is NULL, add an empty card to the list
                                    fetchedCards.Add(null);
                                }
                            }

                            Deck deck = new Deck
                            {
                                deckID = reader.GetInt32("deck_id"),
                                name = reader.GetString("deck_name"),
                                healthMax = reader.GetInt32("health_max"),
                                hand = new List<Card> (fetchedCards)
                            };

                            decks.Add(deck);
                        }
                    }
                }
                connection.Close();
            }
            return decks;
        }

        public bool DeleteDeck(int deckID)
        {
            string query = "DELETE FROM game.deck WHERE deck_id = @deckID";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@deckID", deckID)
            };

            return ExecuteSql(query, parameters);
        }

    }
}
