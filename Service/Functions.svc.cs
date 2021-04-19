using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Functions" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Functions.svc or Functions.svc.cs at the Solution Explorer and start debugging.
    public class Functions : IFunctions
    {
        SDataDataContext db = new SDataDataContext();


        // Delete all in database
        public bool deleteAll()
        {
            return false;
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        //_________________________________   Product Mangagement   ____________________________________________________________________
        public bool addNewFurninture(classFurninture f)
        {
            var newFurniture = new FurnitureTable
            {
                Name = f.name,
                Description = f.description,
                Price = f.price,
                Quantity = f.quantity,
                Image =f.image ,
                Category =f.category ,
                RoomType =f.roomType,
                InteriorID = f.ineteriorid 
            };
            db.FurnitureTables.InsertOnSubmit(newFurniture);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        //_________________________________   User Mangagement   ____________________________________________________________________
        // check if the user alleready exist 

        public bool addNewInterior(classInterior i)
        {
            var newInterior = new InteriorTable
            {
                Name = i.name,
                Description = i.Description,
                DesignerID = 1,
                RoomType = i.roomType,
                Image = i.imge,
                TotalPrice = i.total,
                Available = 1 ,
                Date = DateTime.Now ,
                FurnitureID = 1,
                DesignType  = i.cateory 
                
            };
            db.InteriorTables.InsertOnSubmit(newInterior);
            try
            {
                db.SubmitChanges();
                return true;
            }catch( Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        public bool checkUser(string email)
        {
            var exstingUser = (from i in db.UserTables where i.Email.Equals(email) select i).FirstOrDefault();
            
            if(exstingUser !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        // Getting Interior from the dataBase
        public classInterior getInterior(string cat)
        {
            if( cat == "")
            {
                var interior = (from i in db.InteriorTables orderby i.Date ascending select i).FirstOrDefault();
                classInterior geted = new classInterior
                {
                    name = interior.Name,
                    Description = interior.Description,
                    imge = interior.Image

                };
                return geted;
            }
            else
            {
                var interior = (from i in db.InteriorTables where i.DesignType.Equals(cat) orderby i.Date ascending select i).FirstOrDefault();
                classInterior geted = new classInterior
                {
                    name = interior.Name,
                    Description = interior.Description,
                    imge = interior.Image

                };
                return geted;
            }
           

           
        }

        // getting the user Id 
        public int getUserID(string email)
        {
            int logedId = (from u in db.UserTables where u.Email.Equals(email) select u.Id).FirstOrDefault();
            return logedId;
        }
        // Getting the Customer Information 
        public classUser getCustomer(int id)
        {
            var users= (from i in db.UserTables where i.Id.Equals(id) select i).FirstOrDefault();
            classUser geted = new classUser
            {
                name = users.Name,
                surname = users.Surname,
                email = users.Email,
                farvorite = users.Favorite ,
                address = users.Address ,
            };
            return geted;
        }
        // login 
        public string loginUser(string email, string password)
        {
           dynamic adminLogin = (from u in db.UserTables where u.Email.Equals(email) && u.Password.Equals(password) && u.Active.Equals(1) && u.UserType.Equals("admin") select u).FirstOrDefault();
           dynamic ModrnLogin = (from u in db.UserTables where u.Email.Equals(email) && u.Password.Equals(password) && u.Active.Equals(1) && u.UserType.Equals("customer") && u.Favorite.Equals("Modern") select u).FirstOrDefault();
           dynamic VintageLogin = (from u in db.UserTables where u.Email.Equals(email) && u.Password.Equals(password) && u.Active.Equals(1) && u.UserType.Equals("customer") && u.Favorite.Equals("Vintage") select u).FirstOrDefault();
           dynamic SmartLogin = (from u in db.UserTables where u.Email.Equals(email) && u.Password.Equals(password) && u.Active.Equals(1) && u.UserType.Equals("customer") && u.Favorite.Equals("smart") select u).FirstOrDefault();
           
            if (adminLogin != null)
            {
                return "admin";
            }
            else if (SmartLogin != null)
            {
                return "smart";    
            }
            else if (VintageLogin != null)
            {
                return "vintage";
            }
            else if (ModrnLogin != null)
            {
                return "modern";
            }
            else
            {
                return "access denied";
            }
        }
        // Generating Random numbers
        public int GenerateReference(int userId)
        {
            var newRef = new NumberGenerator
            {
                UserID = userId,
                Date = DateTime.Now ,
            };
            db.NumberGenerators.InsertOnSubmit(newRef);
            try
            {
                db.SubmitChanges();
                return newRef.Id;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return 0;
            }           
        }

        // registering the new user 
        public bool userRegister(classUser u)
        {
            var newUser = new UserTable
            {
                Id = u.id,
                Name = u.name,
                Surname = u.surname,
                Active = 1,
                Password = u.password,
                Address = u.address,
                Email = u.email,
                Favorite = u.farvorite,
                UserType = "customer",
                Date = DateTime.Now.Date,
                TotalMoney = 0 ,
                Points = 0
            };
            db.UserTables.InsertOnSubmit(newUser);
            try
            {
                db.SubmitChanges();
                return true;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool userTempRegister(classUser u)
        {
            var newUser = new TempUserTable
            {
                Id = u.id,
                Name = u.name,
                Surname = u.surname,
                Address = u.address,
                Email = u.email,
            };
            db.TempUserTables.InsertOnSubmit(newUser);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public List<InteriorTable> liestDesigns(string category,string roomtype)
        {
            if( category != "" && roomtype !="")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.DesignType.Equals(category) && p.RoomType.Equals(roomtype) && p.Available.Equals(1) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }else if ( category =="" &&  roomtype =="")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.Available.Equals(1) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }else if( category =="" && roomtype!="" )
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.RoomType.Equals(roomtype) && p.Available.Equals(1) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else if( roomtype =="" && category != "")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.DesignType.Equals(category)&& p.Available.Equals(1) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.Available.Equals(1) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }

             
        }

        public List<InteriorTable> listDesigns(string category, string roomtype)
        {
            if (category != "" && roomtype != "")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.DesignType.Equals(category) && p.RoomType.Equals(roomtype)  orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else if (category == "" && roomtype == "")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables  orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else if (category == "" && roomtype != "")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.RoomType.Equals(roomtype) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else if (roomtype == "" && category != "")
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables where p.DesignType.Equals(category) orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }
            else
            {
                var allDesigns = new List<InteriorTable>();
                dynamic prod = (from p in db.InteriorTables  orderby p.Date ascending select p);
                foreach (InteriorTable p in prod)
                {
                    allDesigns.Add(p);
                }
                return allDesigns;
            }


        }

        public List<InteriorTable> getAboutInterior(int id)
        {

            var allDesigns = new List<InteriorTable>();
            dynamic prod = (from p in db.InteriorTables where p.Id.Equals(id) select p).FirstOrDefault();
            
                allDesigns.Add(prod);
            
            return allDesigns;
        }

        // ___________________Listing the Furniture
        public List<FurnitureTable> listFuniture(int interiorID)
        {
            var allFuniture = new List<FurnitureTable>();
            dynamic furn = (from f in db.FurnitureTables  where f.InteriorID.Equals(interiorID) where f.Quantity >0 select f);
            foreach(FurnitureTable f in furn)
            {
                allFuniture.Add(f);
            }
            return allFuniture;
        }

        
        // Reading Customers Shopping Cart 
        
        public List<cartTable> listCart(int useID)
        {
            var allFurniture = new List<cartTable>();
            dynamic prod = (from c in db.cartTables where c.userID.Equals(useID) select c);
            if( prod != null)
            {
                foreach (cartTable p in prod)
                {
                    allFurniture.Add(p);
                }
                return allFurniture;
            }else
            {
                return null;
            }
            
        }

        // Listing Cart Furniture
        // ___________________Listing the Furniture
        public List<FurnitureTable> listCartFuniture(int furInt)
        {
            var allFuniture = new List<FurnitureTable>();
            dynamic furn = (from f in db.FurnitureTables where f.furnitureID.Equals(furInt) select f);
            foreach (FurnitureTable f in furn)
            {
                allFuniture.Add(f);
            }
            return allFuniture;
        }
        public List<Oder> SearchOders(int userid)
        {
            var ids = new List<Oder>();
            dynamic nums = (from u in db.Oders where u.UserID.Equals(userid) select u);
            foreach (Oder k in nums)
            {
                ids.Add(k);
            }
            return ids ;

        }
        public List<UserTable> listUser(string emails)
        {
            var allAboutUSer = new List<UserTable>();
            dynamic usr = (from f in db.UserTables where f.Email.Equals(emails) select f);
            foreach (UserTable f in usr)
            {
                allAboutUSer.Add(f);
            }
            return allAboutUSer;
        }

        public int SearchCart(int funID ,int userid)
        {
            
            var nums = (from u in db.cartTables where u.userID.Equals(userid) && u.FurnitureID.Equals(funID) select u).FirstOrDefault();
            if ( nums != null)
            {
                int num = Convert.ToInt16(nums.FurnitureNumber);
                if (num == 0)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
            else
            {
                return -1;
            }
            
        }

        public int SearchUser(int userid)
        {

            var nums = (from u in db.UserTables where u.Id.Equals(userid)  select u).FirstOrDefault();
            if (nums != null)
            {
                
                return Convert.ToInt16(nums.Id); ;
            }
            else
            {
                return -1;
            }

        }

       

        public int editCart(int useId, int furID ,int num)
        {
            var quantity = (from f in db.cartTables where f.FurnitureID.Equals(furID) && f.userID.Equals(useId) select f).FirstOrDefault();
            quantity.FurnitureNumber = num + 1;
            try
            {
                db.SubmitChanges();
                return Convert.ToInt16(quantity);
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return 0;
            }
        }
     

        // To be implemeted ************************************
        public int editDelete(int useId, int furID, int num)
        {
            throw new NotImplementedException();
        }
        // Deleting all furniture in the cart Table 
        public bool deleteCartFurniture(int useId, int furID)
        {
            var deletedFurn = (from f in db.cartTables where f.userID.Equals(useId) && f.FurnitureID.Equals(furID) select f).FirstOrDefault();
            db.cartTables.DeleteOnSubmit(deletedFurn);
            if( deletedFurn != null)
            {
                db.SubmitChanges();
                return true;
            }else
            {
                return false;
            }
        }

        // Listing one information about each furniture int the furniture table
        public List<FurnitureTable> getAboutFurniture(int id)
        {

            var allDesigns = new List<FurnitureTable>();
            dynamic prod = (from f in db.FurnitureTables where f.furnitureID.Equals(id) select f).FirstOrDefault();
            allDesigns.Add(prod); 
            return allDesigns;
        }
        // Deleteingfurinitures from  the the table 
        public bool deleteFurniture(int furID,int num)
        {
            var deletedFurn = (from f in db.FurnitureTables where f.furnitureID.Equals(furID) select f).FirstOrDefault();
            deletedFurn.Quantity -= num; 
            if (deletedFurn != null)
            {
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool editUserMoney(int userId, int num)
        {

            var mom = (from f in db.UserTables where f.Id.Equals(userId) select f).FirstOrDefault();
            mom.TotalMoney += num;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        public bool editUserPoint(int userId, int num)
        {
            var mom = (from f in db.UserTables where f.Id.Equals(userId) select f).FirstOrDefault();
            mom.Points +=num;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool DeleleUserPoint(int userId)
        {
            var mom = (from f in db.UserTables where f.Id.Equals(userId) select f).FirstOrDefault();
            mom.Points = 0;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        // Editing Cart Quntity
        public bool editQuantity(int userId, int furID, int num)
        {
            var quantity = (from c in db.cartTables where c.FurnitureID.Equals(furID) && c.userID.Equals(userId) select c).FirstOrDefault();
            quantity.FurnitureNumber = num;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        // Adding products to cart 
        public bool addToCart(classCart c)
        {
            var newItem = new cartTable
            {

                userID = c.userid,
                FurnitureNumber = c.quantiyt,
                FurnitureID = c.furnitureid

            };
            db.cartTables.InsertOnSubmit(newItem);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        // Adding products to oders
        public bool addOder(clsOders c)
        {
            var newItm = new Oder
            {
                UserID = c.id,
                FurID = c.furID,
                Quantity = c.quant,
                Dates = DateTime.Now.Date,
                Status ="Pending",
                ReferenceNumber = c.refNum
              
               
            };
            db.Oders.InsertOnSubmit(newItm);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        public bool addTempOder(clsOders c)
        {
            var newItm = new OdersByTempUser
            {
                UserID = c.id,
                furID= c.furID,
                Quantity = c.quant ,
                Dates =DateTime.Now.Date,
                Status = "Pending",
                
            };
            db.OdersByTempUsers.InsertOnSubmit(newItm);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool addTempcart(classSession s)
        {
            var temp = new SessionCart
            {
                tempUser = s.tempId ,
                furID = s.furId ,
                Quantity = s.quant 
            };
            db.SessionCarts.InsertOnSubmit(temp);
            try
            {
                db.SubmitChanges();
                return true;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
           
        }
        public List<SessionCart> listTempCart(int userID)
        {
            var allTemp = new List<SessionCart>();
            dynamic usr = (from f in db.SessionCarts where f.tempUser.Equals(userID) select f);
            if( usr != null)
            {
                foreach (SessionCart f in usr)
                {
                    allTemp.Add(f);
                }
                return allTemp;
            }else
            {
                return null;
            }
            
        }

        public int addSessionUser()
        {
            var sess = new SessionUser
            {
                some = 1,
            };
            db.SessionUsers.InsertOnSubmit(sess);
            try
            {
                db.SubmitChanges();
                return sess.Id;
            }catch(Exception ex)
            {
                return 0;
            }
        }
        // done 
        public bool deleteTempAll()
        {
            throw new NotImplementedException();
        }
        //done 
        public int SearchTempCart(int furnID, int userid)
        {
            var nums = (from u in db.SessionCarts where u.tempUser.Equals(userid) && u.furID.Equals(furnID) select u).FirstOrDefault();
            if (nums != null)
            {
                int num = Convert.ToInt16(nums.Quantity);
                if (num == 0)
                {
                    return 0;
                }
                else
                {
                    return num;
                }
            }
            else
            {
                return -1;
            }
        }
        public int editRegOder(int useId, int Odernum)
        {
            var odr = (from f in db.Oders where f.UserID.Equals(useId) && f.ReferenceNumber.Equals(Odernum) select f);
            int num =2 ;
            foreach(Oder o in odr)
            {
                o.Status = "Paid";
                try
                {
                    db.SubmitChanges();
                   num =1 ;
                }
                catch(Exception ex)
                {
                    ex.GetBaseException();
                    num = 0;
                }
            }
            return num;
        }
        // done 
        public int editTempDelete(int useId, int furID, int num)
        {
            throw new NotImplementedException();
        }
        //done 
        public bool deleteTempCartFurniture(int useId, int furID)
        {
            var deletedFurn = (from f in db.SessionCarts where f.tempUser.Equals(useId) && f.furID.Equals(furID) select f).FirstOrDefault();
            db.SessionCarts.DeleteOnSubmit(deletedFurn);
            if (deletedFurn != null)
            {
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //done
        public bool editTempQuantity(int userId, int furID, int num)
        {
            var quantity = (from c in db.SessionCarts where c.furID.Equals(furID) && c.tempUser.Equals(userId) select c).FirstOrDefault();
            quantity.Quantity = num;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public List<InteriorTable> liestDesigns(string category)
        {
            throw new NotImplementedException();
        }

        public int editTempCart(int useId, int furID, int num)
        {
            var quantity = (from f in db.SessionCarts where f.furID.Equals(furID) && f.tempUser.Equals(useId) select f).FirstOrDefault();
            quantity.Quantity = num + 1;
            try
            {
                db.SubmitChanges();
                return Convert.ToInt16(quantity);
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return 0;
            }
        }
        // ____________________________Reports____________________________________________
        //________________________________________________________________________________
        //________________________________________________________________________________
        public List<UserTable> listRegisteredUsers(string dates)
        {
            if( dates == "")
            {
                var allusers = new List<UserTable>();
                dynamic usr = (from f in db.UserTables where f.Active.Equals(1) select f);
                foreach (UserTable f in usr)
                {
                    allusers.Add(f);
                }
                return allusers;
            }else
            {
                var allusers = new List<UserTable>();
                dynamic usr = (from f in db.UserTables where f.Active.Equals(1) &&f.Date.Equals(dates) select f);
                foreach (UserTable f in usr)
                {
                    allusers.Add(f);
                }
                return allusers;
            }
            
        }
        //       Temps users
        public List<SessionUser> listRegisteredTempUsers()
        {
            var allusers = new List<SessionUser>();
            dynamic usr = (from f in db.SessionUsers select f);
            foreach (SessionUser f in usr)
            {
                allusers.Add(f);
            }
            return allusers;
        }
        //        Listing information about users 
        public List<UserTable> getAbautUsers(int id)
        {
            var allDesigns = new List<UserTable>();
            dynamic prod = (from p in db.UserTables where p.Id.Equals(id) select p).FirstOrDefault();
            allDesigns.Add(prod);
            return allDesigns;
        }
        //        Listing all registers  users who bought something from the wepsite 
        public List<UserTable> getRecCustomers(string dates)
        {
            var userId = new List<UserTable>();

            if (dates != "")
            {
                dynamic ur = (from c in db.UserTables where c.TotalMoney >0   orderby c.TotalMoney ascending select c);
                foreach(UserTable o in ur)
                {
                    userId.Add(o);

                }
                return userId;
            }
            else
            {
                dynamic ur = (from c in db.UserTables where c.TotalMoney > 0 orderby c.TotalMoney descending select c);
                foreach (UserTable o in ur)
                {
                    userId.Add(o);
                }
                return userId;
            }


        }

        public int getPoints(int id)
        {
            var point = (from i in db.UserTables where i.Id.Equals(id) select i).FirstOrDefault();
            if( point != null)
            {
                return Convert.ToInt16(point.Points);
            }
            else
            {
                return  0;
            }
        }

        public List<Oder> listAllOders(string condtion)
        {
            var alloders = new List<Oder>();
            if( condtion == "")
            {
                dynamic of = (from i in db.Oders orderby i.Dates descending select i);
                foreach (Oder cc in of)
                {
                    alloders.Add(cc);
                }
            }
            else
            {
                dynamic of = (from i in db.Oders where i.Status.Equals(condtion) orderby i.Dates descending select i);
                foreach (Oder cc in of)
                {
                    alloders.Add(cc);
                }
            }
            return alloders;
        }

        public List<OdersByTempUser> listAllTempOders(string condtion)
        {
            var alloders = new List<OdersByTempUser>();
            if (condtion == "")
            {
                dynamic of = (from i in db.OdersByTempUsers orderby i.Dates descending select i);
                foreach (OdersByTempUser cc in of)
                {
                    alloders.Add(cc);
                }
            }
            else
            {
                dynamic of = (from i in db.OdersByTempUsers where i.Status.Equals(condtion) orderby i.Dates descending select i);
                foreach (OdersByTempUser cc in of)
                {
                    alloders.Add(cc);
                }
            }
            return alloders;
        }

        public List<FurnitureTable> listAllFunitures(string cat, string room)
        {
            var Allfuniture = new List<FurnitureTable>();
            if(cat=="" && room == "")
            {
                dynamic fur = (from f in db.FurnitureTables where f.Quantity > 0 select f);
                foreach(FurnitureTable f in fur )
                {
                    Allfuniture.Add(f);
                }
                return Allfuniture;
            }else if( cat !="" && room == "")
            {
                dynamic fur = (from f in db.FurnitureTables where f.Quantity > 0 && f.Category.Equals(cat) select f);
                foreach (FurnitureTable f in fur)
                {
                    Allfuniture.Add(f);
                }
                return Allfuniture;
            }
            else if( cat =="" && room !="")
            {
                dynamic fur = (from f in db.FurnitureTables where f.Quantity >0 && f.RoomType.Equals(room) select f);
                foreach (FurnitureTable f in fur)
                {
                    Allfuniture.Add(f);
                }
                return Allfuniture;
            }
            else
            {
                dynamic fur = (from f in db.FurnitureTables where f.Quantity > 0 && f.RoomType.Equals(room) && f.Category.Equals(cat) select f);
                foreach (FurnitureTable f in fur)
                {
                    Allfuniture.Add(f);
                }
                return Allfuniture;
            }
        }

        public bool addnewInvoice(classInvoice c)
        {
            var newInvoice = new InvoiceTable
            {
                UserID = c.urID ,
                TotalPrice =c.totalprice ,
                Tax = c.tax ,
                CartTotal=c.carttotal,
                Discount = c.discount ,
                PointApply =c.points ,
                Date = DateTime.Now,
                Reference =c.refNum
            };
            db.InvoiceTables.InsertOnSubmit(newInvoice);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool addnewInvoiceItems(clsOders c)
        {
            var newItems = new InvoiceItme
            {
                InvoiceID = c.refNum,
                Quant = c.quant,
                furID = c.furID,
               
            };
            db.InvoiceItmes.InsertOnSubmit(newItems);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public List<InvoiceTable> listAllInvoice(string condtion,int usrId)
        {
            var allInvoice = new List<InvoiceTable>();
            if( condtion =="" && usrId !=0)
            {
                dynamic inv = (from i in db.InvoiceTables where i.UserID.Equals(usrId) orderby i.Date descending select i);
                foreach(InvoiceTable i in inv)
                {
                    allInvoice.Add(i);
                }
            }
            else  if ( condtion =="" && usrId == 0)
            {
                dynamic inv = (from i in db.InvoiceTables select i);
                foreach (InvoiceTable i in inv)
                {
                    allInvoice.Add(i);
                }
                
            }
            else{
                dynamic inv = (from i in db.InvoiceTables where i.Reference.Equals(condtion) select i).FirstOrDefault();
                allInvoice.Add(inv);

            }
            return allInvoice;
        }

        public List<InvoiceItme> listIvoiceItems(int condtion)
        {
            var allItems = new List<InvoiceItme>();
                dynamic inv = (from i in db.InvoiceItmes where i.InvoiceID.Equals(condtion) select i);
                foreach (InvoiceItme i in inv)
                {
                    allItems.Add(i);
                }
            return allItems;
        }

        public bool DeleteInterior(int id,int num)
        {
            var interior = (from c in db.InteriorTables where c.Id.Equals(id) select c).FirstOrDefault();
            interior.Available = num;
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
            
        }

        
    }
}
