using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using System.Linq;
using System.Data;

namespace entityBDD
{
    public partial class Module
    {
         public Module getModulesById(int id)
         {
             Module module = new Module();
             using (var con = new EntityConnection("name=EcolesEntities"))
             {
                 con.Open();
                 EntityCommand cmd = con.CreateCommand();
                 cmd.CommandText = "SELECT VALUE st FROM EcolesEntities.module as st where st.numModule=" + id;
                 using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                 {
                     while (rdr.Read())
                     {

                         //var b = rdr.GetString(1);
                         //var b = rdr.GetString(1) + " " + rdr.GetString(2) + " ";
                         module.numModule = id;
                         module.nomModule = rdr.GetString(1);
                         module.nbMatiere = rdr.GetInt32(2);

                     }
                 }
             }
             return module;
         }
    }
}
