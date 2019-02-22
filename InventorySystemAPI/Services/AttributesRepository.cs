using InventorySystemAPI.Entity;
using InventorySystemAPI.Interfaces;
using InventorySystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Services
{
    public class AttributesRepository : IAttributesRepository
    {
        private readonly StockContext _context;

        public AttributesRepository(StockContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAttribute(int attribute_id)
        {
            await _context.Database.OpenConnectionAsync();

            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {

                cmd.CommandText = "deleteAttribute";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@attribute_id", attribute_id));

                using (var reader = await cmd.ExecuteReaderAsync())
                {

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            var responses = reader["SUCCESS"].ToString();
                            if (responses == "1")
                                return true;
                            else
                                return false;
                        }
                    }
                }
            }

            return false;
        }
    }
}
