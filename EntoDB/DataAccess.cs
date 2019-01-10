using Dapper;
using Rapento.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Rapento
{
    public class DataAccess
    {

        public void AddIndividual(Individual individual)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                List<Individual> individualList = new List<Individual>();
                individualList.Add(individual);
                connection.Execute("dbo.AddIndividual @GivenGenusName = @GivenGenusName, @GivenSpeciesName = @GivenSpeciesName, @GivenCollectionName = @GivenCollectionName", individualList);
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

        public void DeleteIndividual(int individualID)
        {
            using (IDbConnection connection = new SqlConnection(connectionString: Helper.CnnVal("Rapento.Properties.Settings.Database1ConnectionString")))
            {
                List<Individual> individualList = new List<Individual>();
                individualList.Add(new Individual { GivenIndividualID = individualID});
                connection.Execute("dbo.DeleteIndividual @GivenIndividualID", individualList);
            }
        }
    }
}
