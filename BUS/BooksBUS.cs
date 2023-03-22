using SistemaLivraria.Entity;
using SistemaLivraria.DAO;

namespace SistemaLivraria.BUS
{
    public class BooksBUS 
    {
        private BooksDAO BooksDAO { get; set; }

        public BooksBUS()
        {
            this.BooksDAO = new BooksDAO();
        }

        public List<Books> GetBooksByName(string name)
        {
            try
            {
                return this.BooksDAO.GetBooksByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}