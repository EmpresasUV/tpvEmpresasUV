using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace tpvEmpresasUV
{
    class dbSQL
    {
        private string Hostname { get; set; } = "DC-CONTABLE";
        private string DbUser { get; set; } = "sa";
        private string DbPass { get; set; } = "Promo1002##";
        private string DbName { get; set; } = "dbEmpresasUV";
        private string InstanceName { get; set; } = "COMPAC";
        private int PortNumber { get; set; } = 0;
        private string ConnectionString { get; set; } = string.Empty;

        public dbSQL()
        {
            try
            {
                this.ConnectionString = "Server=" + this.Hostname + "\\" + this.InstanceName + ";Database=" + this.DbName + ";User Id=" + this.DbUser + ";Password=" + this.DbPass + ";Encrypt=True;TrustServerCertificate=True;";
            }
            catch (SqlException SQLex)
            {
                new appExeption(SQLex);
            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }
        }

        public JsonObject QueryJson(string query)
        {
            var results = new JsonObject();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        var keyIndex = 0;
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                var item = new JsonObject();
                                // Iterate over each of the fields (columns) in the datareader's current record
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    //Debug.WriteLine("El campo {0} es de tipo {1} y posée el valor {2}", reader.GetName(i), reader.GetDataTypeName(i), reader[i].ToString());                               

                                    item.Add(reader.GetName(i).ToString(), reader[i].ToString());
                                }
                                
                                results.Add(keyIndex.ToString(), item);
                                keyIndex++;
                            }
                        }

                    }
                    Debug.WriteLine(results);
                }
            }
            catch (SqlException SQLex)
            {
                new appExeption(SQLex);
            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }

            return results;
            
        }






    }
}
