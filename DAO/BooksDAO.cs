using SistemaLivraria.Entity;

namespace SistemaLivraria.DAO
{
    public class BooksDAO
    {
         public List<Books> GetBooksByName(String name)
        {
           
           using(sqlConnection conn = new sqlConnection("Server=(local);DataBase=Nortwind;Integrated Security=SSPI"))
           {
                conn.Open();

                sqlCommand cmd = new sqlCommand("CustOrderHist",conn);
                cmd.CommandType = CommandType.StoredProcedure;
           }
            return cmd; 
        }
    }

}