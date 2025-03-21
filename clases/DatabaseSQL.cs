using System;
using System.Collections.Generic;
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

        public async Task<JsonArray> QueryJson(string query)
        {
            var results = new JsonArray();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    await connection.OpenAsync();
                    using (var command = new SqlCommand(query, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));                          
                            var item = new JsonObject()
                            {
                                [reader.GetInt32(0)] = reader.GetString(1),
                            };
                            results.Add(item);
                        }
                    }
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
