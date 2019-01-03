using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Rapento
{
    class DataAccess
    {
        //Deze methodes zijn gevoelig voor SQL injectie. Oplossing: stored procedures.

        public List<Individual> GetIndividuals()
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                var output = connection.Query<Individual>($"SELECT * FROM dbo.Individuals").ToList();
                return output;
            }
        }

        public void AddIndividual(string genus, string species, string collection) //Collectie wordt niet aangemaakt in db???
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                List<Individual> individual = new List<Individual>();
                individual.Add(new Individual { GivenGenusName = genus, GivenSpeciesName = species, GivenCollectionName = collection });
                connection.Execute("dbo.AddIndividual @GivenGenusName, @GivenSpeciesName, @GivenCollectionName", individual);
            }
        }
    }
}
