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
using InventorySystemAPI.Helpers;

namespace InventorySystemAPI.Services
{
    public class AttributeValues : IAttributeValues
    {
        private readonly StockContext _context;

        public AttributeValues(StockContext context)
        {
            _context = context;
        }

        public async Task<List<Attribute_value>> GetAllAttributeValuesById(int attribute_id)
        {

            await _context.Database.OpenConnectionAsync();


            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {

                cmd.CommandText = "getAllAttributeValuesbyId";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@attribute_id", attribute_id));

                using (var reader = await cmd.ExecuteReaderAsync())
                {

                    if (reader.HasRows)
                    {
                        var responses = await reader.MapToList<Attribute_value>();

                        return responses;
                    }
                }
            }

            return null;

        }
    }
}
