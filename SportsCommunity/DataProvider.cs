using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsCommunity.DomainModel;
using Neo4jClient.Cypher;

namespace SportsCommunity
{
    public class DataProvider
    {

        private Uri uri;
        private GraphClient graphClient;


        public DataProvider()
        {
            uri = new Uri("http://localhost:7474/db/data");
            graphClient= new GraphClient(uri, "neo4j", "nikola1997");
            graphClient.Connect();
        }

        
        
        
        
        #region Client related functions

            public Client CreateClient(String name,String username,String password)
            {
            
                //query koj izvrsavamo u bazi
                String queryText= "create (c:Client{name:'"+
                                        name+"', username:'"+
                                        username+"', password:'"+
                                        password+"'}) with(c) set c.id = id(c) return c";


                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

            
                //rezultat izvrsenja bi trebalo da bude 1 klijent kojeg smo sad stvorili
                List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                                .ToList();


                return clients[0];


            }


            //ispituje da li username za tog korisnika vec postoji true=vec postoji false=ne postoji
            public bool doesUsernameExist(String username)
            {
                String queryText = "match (n:Client) where n.username='" + username + "' return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                                .ToList();

                if (clients.Count == 0) return false;
                else return true;

            }


            public Client getClientByUsername(String username)
            {
                String queryText = "match (n:Client) where n.username='" + username + "' return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                                .ToList();
           

                if (clients.Count == 0)
                {
                    Console.WriteLine("Query faild");
                    return null;
                }
                else
                {
                    Client client = clients[0];
                    client.friend_list = getClientFriends(client.id);
                    client.event_list = getClientEvents(client.id);

                    return client;
                }

            }

            public List<Client> getClientFriends(int id)
            {
                String queryText = "match (n:Client)-[:Friend]->(b:Client) where n.id="+id+" return b";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Client> friends = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                                .ToList();

                return friends;
            }


            public List<Event> getClientEvents(int id)
            {
                String queryText = "match (n:Client)-[:At_Event]->(b:Event) where n.id=" + id + " return b";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Event> events = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Event>(query)
                                                                .ToList();

                foreach (Event e in events)
                {
                  e.location = GetLocationForEvent(e.id);
                  e.eventType = GetEventTypeForEvent(e.id);
                }

                return events;
            }


        public List<Client> GetAllClients()
        {
            String queryText = "match (n:Client) return n";
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                            .ToList();

            return clients;
        }

        public List<Client> GetClientLike(String like)
        {
            String queryText = "match (n:Client) where n.name =~'(?i).*"+like+".*' return n";
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
                                                            .ToList();

            return clients;
        }


        #endregion





        #region Event functions
        
        
            public Event CreateEvent(String name, DateTime dateTime, EventType type, Location location)
            {

                //query koj izvrsavamo u bazi
                String queryText = "create (c:Event{name:'" +
                                        name + "', dateTime:'" +
                                        dateTime + "'}) with(c) set c.id = id(c) return c";


                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);


                //rezultat izvrsenja bi trebalo da bude 1 klijent kojeg smo sad stvorili
                List<Event> events = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Event>(query)
                                                                .ToList();

                this.SetEventTypeToEvent(events[0], type);

                 this.SetLocationToEvent(events[0],location);


                return events[0];
            }

            public Event GetEvent(int id)
            {
               
                String queryText = "match (n:Event) where n.id=" + id + " return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                
                List<Event> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Event>(query)
                                                                .ToList();


                return e[0];
            }

        public List<Event> GetAllEvents()
        {
            String queryText = "match (n:Event) return n";
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Event> events = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Event>(query)
                                                            .ToList();

            foreach (Event e in events)
            {
                e.location = GetLocationForEvent(e.id);
                e.eventType = GetEventTypeForEvent(e.id);
            }

            return events;
        }

        #endregion





        #region Location finctions
        
            public Location CreateLocation(String address, String city)
            {

                

                String queryText = "create (c:Location{address:'" + address+"'}) with(c) set c.id = id(c) return c";


                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);



                List<Location> locations = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Location>(query)
                                                                .ToList();


                City grad = this.GetCity(city);
                this.SetCityToLocation(locations[0],grad);
                


                return locations[0];
            }

            public Location GetLocationForEvent(int id)
            {
                String queryText = "match (a:Event)-[:At_Location]->(n:Location) where a.id=" + id + " return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Location> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Location>(query)
                                                                .ToList();

                e[0].city = GetCityForLocation(e[0].id);
                
                return e[0];
            }

            public List<Location> GetAllLocations()
            {
                String queryText = "match (n:Location) return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<Location> locations = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Location>(query)
                                                                .ToList();

                foreach (Location l in locations)
                {
                    l.city = GetCityForLocation(l.id);
                }

            

                return locations;
            }

        #endregion





        #region City functions
            public City GetCity(string name)
            {
                String queryText = "match (n:City) where n.name='" + name + "' return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<City> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<City>(query)
                                                                .ToList();


                return e[0];
            }

            public List<City> GetAllCitys()
            {
                String queryText = "match (n:City) return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<City> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<City>(query)
                                                                .ToList();


                return e;
            }

            public City GetCityForLocation(int locationId)
            {
                String queryText = "match (a:Location)-[:In_City]->(n:City) where a.id=" + locationId + " return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                List<City> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<City>(query)
                                                                .ToList();


                return e[0];
            }

        public void CreateCity(String name)
        {
            String queryText = "merge (c:City{name:'"+name+"'}) with(c) set c.id = id(c)";


            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);
        }

        #endregion





        #region EventType

            public EventType CreateEventType( string name, String context)
            {

                String queryText = "create (c:EventType{name:'" +
                                    name + "', context:'" +
                                    context + "'}) with(c) set c.id = id(c) return c";


                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

                 List<EventType> eventTypes = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<EventType>(query)
                                                            .ToList();


                 return eventTypes[0];

            }

            public EventType GetEventTypeForEvent(int id)
            {
               
                String queryText = "match (a:Event)-[:Event_Type]->(n:EventType) where a.id=" + id + " return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
                
                List<EventType> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<EventType>(query)
                                                                .ToList();


                return e[0];
            }

            public List<EventType> GetAllEventTypes()
            {
                String queryText = "match (n:EventType) return n";
                var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

                List<EventType> e = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<EventType>(query)
                                                                .ToList();


                return e;
            }

        #endregion






        #region Realtionship functions

        public void makeFriends(Client a, Client b)
        {
            
            
            String queryText = " match(a: Client),(b: Client)" +
                               " where a.id = " + a.id + " and b.id = " + b.id +
                               " merge (a)-[:Friend]->(b)" +
                               " merge (b)-[:Friend]->(a)";
            
            
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);

            
            
            if (a.friend_list == null) a.friend_list = new List<Client>();
            if (b.friend_list == null) b.friend_list = new List<Client>();
            a.friend_list.Add(b);
            b.friend_list.Add(a);

        }
    
        public void AddClientToEvent(Client a, Event e)
        {
          
            String queryText = " match (a: Client),(b: Event)" +
                             " where a.id = " + a.id + " and b.id=" + e.id +
                             " merge (a)-[:At_Event]->(b)";
           
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);

            
            if (a.event_list == null) a.event_list = new List<Event>();
            a.event_list.Add(e);
        }

        public void SetCityToLocation(Location l, City c)
        {
           
            String queryText = " match(a: Location),(b: City)" +
                              " where a.id = " + l.id + " and b.id = " + c.id +
                              " merge (a)-[:In_City]->(b)";
            
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);

            l.city = c;
        }

        public void SetEventTypeToEvent(Event e, EventType et)
        {
           
            String queryText = " match(a: Event),(b: EventType)" +
                              " where a.id = " + e.id + " and b.id = " + et.id +
                              " merge (a)-[:Event_Type]->(b)";
            
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);

            e.eventType = et;

        }

        public void SetLocationToEvent(Event e, Location l)
        {
            
            String queryText = " match(a: Event),(b: Location)" +
                              " where a.id = " + e.id + " and b.id = " + l.id +
                              " merge (a)-[:At_Location]->(b)";
           
            var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)graphClient).ExecuteCypher(query);

            e.location = l;

        }

        #endregion








    }
}
