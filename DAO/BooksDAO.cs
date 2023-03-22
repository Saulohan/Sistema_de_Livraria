using SistemaLivraria.Entity;

namespace SistemaLivraria.DAO
{
    public class BooksDAO
    {
         public List<Books> GetBooksByName(String name)
        {
            string SqlCommand = "GetBooksByName";
            string param;
            
            List<Books> booksList = new List<Books>();
            
            //EXEC PROCEDURE

            return booksList; 
        }
    }

}