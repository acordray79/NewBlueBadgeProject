using BBShop.Data;
using BBShop.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBShop.Service
{
    public class AdminService
    {
        
        public bool CreateAdmin(AdminCreate model)
        {
            var entity =
                new BBShopAdmin()
                {
                    CustomerID = model.CustomerID
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.BBShopAdmins.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<AdminList> GetCustomer()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .BBShopAdmins
                        .Select(
                            e =>
                                new AdminList
                                {
                                    AdminID = e.AdminID,
                                    CustomerID = e.CustomerID
                                }
                        );

                return query.ToArray();
            }
        }
        public AdminDetail GetAdminByID(int adminID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .BBShopAdmins
                        .Single(e => e.AdminID == adminID);
                return
                    new AdminDetail
                    {
                        AdminID = entity.AdminID,
                        CustomerID = entity.CustomerID
                    };
            }
        }
        public bool UpdateAdmin(AdminUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .BBShopAdmins
                        .Single(e => e.AdminID == model.AdminID);
                entity.CustomerID = model.CustomerID;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteAdmin(int adminId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .BBShopAdmins
                        .Single(e => e.AdminID == adminId);

                ctx.BBShopAdmins.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
