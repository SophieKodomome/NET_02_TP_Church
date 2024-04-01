using Npgsql;

namespace Expenses
{
    public class StaticExpense
    { 
        public int Id{get;set;}
        public string Motif{get;set;}
        public int MontantUnitaire{get;set;}


        public StaticExpense(){}

        public StaticExpense addId(int id)
        {
            Id=id;
            return this;
        }
        public StaticExpense addMotif(string motif)
        {
            Motif=motif;
            return this;
        }
        public StaticExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
        private static List<StaticExpense> GetStaticExpenses(NpgsqlConnection connection)
        {
            List<StaticExpense> listStaticExpense = new List<StaticExpense>();

            connection.Open();
            using(var command=new NpgsqlCommand("select * from static_expenses",connection))
            {
                using(var reader=command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        StaticExpense staticExpense = new StaticExpense().
                        addId(reader.GetInt32(0)).
                        addMotif(reader.GetString(1)).
                        addMontantUnitaire(reader.GetInt32(2));

                        listStaticExpense.Add(staticExpense);
                    }
                }
            }
            connection.Close();
            return listStaticExpense;
        }
    }
}