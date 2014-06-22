using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using System.Linq;
using System.Text;


namespace entityBDD
{
    public partial class Eleves
    {

        public String getEleveById(int id)
        {
            using (var con = new EntityConnection("name=Entities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM Entities.Eleves as st where st.numEleve="+id;
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        var b = rdr.GetString(1);
                        return b.ToString();
                    }
                }
            }
            return "FUCKKKKKK";
        }

        public String getFirstEleves()
        {
            using (var con = new EntityConnection("name=Entities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM Entities.Eleves as st where st.numEleve=1";
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        int a = rdr.GetInt32(0);
                        var b = rdr.GetString(1);
                        return b.ToString();
                    }
                }
            }
            return "FUCKKKKKK";
        }
    }
}
