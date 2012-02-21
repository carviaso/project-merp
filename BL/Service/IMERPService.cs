using System.ServiceModel;
using Views;
using Views.Stammdaten.Product;
using Views.Stammdaten.User;

namespace BL.Service
{
   
    [ServiceContract]
    
    public interface IMERPService : IRootInterface
    {
        /* Zur l�schung vorgemerkt 
       [OperationContract]
       PagedResult<ProductView> GetProducts(int Prdcat, int Anzahl, int Start);

       
       [OperationContract]
       PagedResult<IUserView> GetUserByIdent(string ident, int Anzahl, int Start);

         
       [OperationContract]
       void UpdateUser(IUserView usr);

       
       [OperationContract]
       void AddUser(IUserView usr);
    
        */
        [OperationContract]
        bool TestConnection(bool test);
         
    }
}
