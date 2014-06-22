using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using System.Linq;
using System.Text;


namespace entityBDD
{
    public partial class Eleve
    {
        public Eleve getEleveById(int id)
        {
            Eleve eleve = new Eleve();
            using (var con = new EntityConnection("name=EcolesEntities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM EcolesEntities.Eleve as st where st.numEleve=" + id;
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {

                        //var b = rdr.GetString(1);
                        //var b = rdr.GetString(1) + " " + rdr.GetString(2) + " ";
                        eleve.numEleve = id;
                        eleve.nomEleve = rdr.GetString(1);
                        eleve.motDePasse = rdr.GetString(2);

                    }
                }
            }
            return eleve;
        }
        public ArrayList getEleves()
        {
            ArrayList listEleves = new ArrayList();
            using (var con = new EntityConnection("name=EcolesEntities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM EcolesEntities.Eleve as st";
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        Eleve eleve = new Eleve();
                        Module module = new Module();
                        //var b = rdr.GetString(1);
                        //var b = rdr.GetString(1) + " " + rdr.GetString(2) + " ";
                        eleve.numEleve = rdr.GetInt32(0);
                        eleve.nomEleve = rdr.GetString(1);
                        eleve.motDePasse = rdr.GetString(2);
                        eleve.Module = (ICollection<Module>)module.getModulesByEleve(eleve.numEleve);
                        listEleves.Add(eleve);
                    }
                }
            }
            return listEleves;
        }
    }
}
