using Npgsql;

namespace Expenses
{
    public class VariableExpense
    {
        public int Id{get;set;}
        public int IdVariableExpense{get;set;}
        public string Motif{get;set;}
        public int MontantUnitaire{get;set;}
        public string UniteMesureVariable{get;set;}
        public int Variable{get;set;}

        public int Mois{get;set;}


        public VariableExpense(){}

        public VariableExpense addId(int id)
        {
            Id=id;
            return this;
        }

        public VariableExpense addIdVariableExpense(int idVariableExpense)
        {
            IdVariableExpense=idVariableExpense;
            return this;
        }
        public VariableExpense addMotif(string motif)
        {
            Motif=motif;
            return this;
        }
        public VariableExpense addMontantUnitaire(int montantUnitaire)
        {
            MontantUnitaire=montantUnitaire;
            return this;
        }
        public VariableExpense addUniteMesureVariable(string uniteMesureVariable)
        {
            UniteMesureVariable=uniteMesureVariable;
            return this;
        }
        public VariableExpense addVariable(int variable)
        {
            Variable=variable;
            return this;
        }

        public VariableExpense addMois(int mois)
        {
            Mois=mois;
            return this;
        }
        private static List<VariableExpense> GetVariableExpenses(NpgsqlConnection connection)
        {
            List<VariableExpense> listVariableExpense = new List<VariableExpense>();

            connection.Open();
            using(var command=new NpgsqlCommand("select * from static_expenses",connection))
            {
                using(var reader=command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        VariableExpense variableExpense = new VariableExpense().
                        addId(reader.GetInt32(0)).
                        addMotif(reader.GetString(1)).
                        addMontantUnitaire(reader.GetInt32(2));

                        listVariableExpense.Add(variableExpense);
                    }
                }
            }
            connection.Close();
            return listVariableExpense;
        }
    }
}