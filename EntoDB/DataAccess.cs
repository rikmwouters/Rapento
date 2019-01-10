using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Rapento
{
    public class DataAccess
    {

        public void AddIndividual(string genus, string species, string collection)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                List<Individual> individual = new List<Individual>();
                individual.Add(new Individual { GivenGenusName = genus, GivenSpeciesName = species, GivenCollectionName = collection });
                connection.Execute("dbo.AddIndividual @GivenGenusName = @GivenGenusName, @GivenSpeciesName = @GivenSpeciesName, @GivenCollectionName = @GivenCollectionName", individual);
            }
        }

        public void AddIndividual(Individual individual)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                List<Individual> individualList = new List<Individual>();
                individualList.Add(individual);
                connection.Execute("dbo.AddIndividual @GivenGenusName = @GivenGenusName, @GivenSpeciesName = @GivenSpeciesName, @GivenCollectionName = @GivenCollectionName", individual);
            }
        }

        public int FindTaxonID(string taxonname)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                var output = connection.Query<int>("dbo.FindTaxonID @GivenTaxonName", new { GivenTaxonName = taxonname }).ToList();
                return output.First<int>();
            }
        }
    }
}
