using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFunctions" in both code and config file together.
    [ServiceContract]
    public interface IFunctions
    {
       
        [OperationContract]
        bool checkUser(string email);
        [OperationContract]
        int getUserID(string email);
        [OperationContract]
        string loginUser(string email, string password);
        [OperationContract]
        bool addNewFurninture(classFurninture f);
        [OperationContract]
        bool addNewInterior(classInterior i);
        [OperationContract]
        classInterior getInterior(string cat);
        [OperationContract]
        classUser getCustomer(int id);
        [OperationContract]
        List<InteriorTable> liestDesigns(string category,string room);
        [OperationContract]  
        List<InteriorTable> getAboutInterior(int id);
        [OperationContract]
        List<FurnitureTable> listFuniture(int interiorID);

        [OperationContract]
        bool addToCart(classCart c);

        [OperationContract]
        List<cartTable> listCart(int useID);
        [OperationContract]
        List<FurnitureTable> listCartFuniture(int furInt);
        [OperationContract]
        List<UserTable> listUser(string emails);
        [OperationContract]
        bool deleteAll();
        [OperationContract]
        int SearchCart(int furnID ,int userid);
        [OperationContract]
        int SearchTempCart(int furnID, int userid);
        [OperationContract]
        int editCart(int useId, int furID, int num);
        [OperationContract]
        int editRegOder(int useId,int Odernum);
        [OperationContract]
        int editTempCart(int useId, int furID, int num);
        [OperationContract]
        int editDelete(int useId, int furID, int num);
        [OperationContract]
        int editTempDelete(int useId, int furID, int num);
        [OperationContract]
        bool deleteCartFurniture(int useId, int furID);
        [OperationContract]
        bool deleteTempCartFurniture(int useId, int furID);
        [OperationContract]
        bool deleteFurniture(int furID,int num);
        [OperationContract]
        List<FurnitureTable> getAboutFurniture(int id);
        [OperationContract]
        bool editQuantity(int userId, int furID, int num);

        [OperationContract]
        bool editUserMoney(int userId,int num);
        [OperationContract]
        bool DeleteInterior(int id,int num);
        [OperationContract]
        bool editUserPoint(int userId, int num);
        [OperationContract]
        bool editTempQuantity(int userId, int furID, int num);
        [OperationContract]
        bool userRegister(classUser u);
        [OperationContract]
        bool userTempRegister(classUser u);

        [OperationContract]
        bool DeleleUserPoint(int userId);
        [OperationContract]
        int getPoints(int id);

        [OperationContract]
        bool addOder(clsOders or);
        // Addint to temp cart
        [OperationContract]
        bool addTempcart(classSession s);
        [OperationContract]
        List<InteriorTable> listDesigns(string category, string roomtype);
        [OperationContract]
        List<SessionCart> listTempCart(int userID);
        [OperationContract]
        int addSessionUser();
        [OperationContract]
        bool addTempOder(clsOders or);
        [OperationContract]
        int GenerateReference(int userId);

        //________________________________ Reports____________________________________ 
        //____________________________________________________________________________
        //____________________________________________________________________________
        [OperationContract]
        List<UserTable> listRegisteredUsers(string date);
        [OperationContract]
        List<SessionUser> listRegisteredTempUsers();
        [OperationContract]
        List<UserTable> getAbautUsers(int id);

        [OperationContract]
        List<UserTable> getRecCustomers(string dates);
        [OperationContract]
        int SearchUser(int userid);
        [OperationContract]
        List<Oder> SearchOders(int userid);
        [OperationContract]
        List<Oder> listAllOders(string condtion);
        [OperationContract]
        List<OdersByTempUser> listAllTempOders(string condtion);
        [OperationContract]
        List<InvoiceTable> listAllInvoice(string condtion ,int usrID);
        [OperationContract]
        List<InvoiceItme> listIvoiceItems(int condtion);
        [OperationContract]
        List<FurnitureTable> listAllFunitures(string cat,string room);

        [OperationContract]
        bool addnewInvoice(classInvoice c);

        [OperationContract]
        bool addnewInvoiceItems(clsOders c);  

    }
}
