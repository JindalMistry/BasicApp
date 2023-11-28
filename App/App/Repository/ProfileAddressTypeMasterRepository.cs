using App.Common;
using App.IRepository;
using Dapper;
using System.Data;

namespace App.Repository
{
    public class ProfileAddressTypeMasterRepository : IProfileAddressTypeMaster
    {
        public List<dynamic> GetList(int ClientSerNo)
        {
            try
            {
                var con = ConnectDb.GetConnection("InnkeyPMS");
                if (con != null)
                {
                    if(con.State == ConnectionState.Closed) { con.Open(); }
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@ClientSerNo", ClientSerNo);
                    List<dynamic> res = SqlMapper.Query(con, "GetAddressTypeMasterData", param: para, commandType: CommandType.StoredProcedure).ToList();
                    if(con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                    return res;
                }
            }
            catch(Exception ex)
            {
                //throw ex;
            }
            return new List<dynamic>();
        }
    }
}
