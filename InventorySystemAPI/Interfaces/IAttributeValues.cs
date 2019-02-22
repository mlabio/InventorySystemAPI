using InventorySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventorySystemAPI.Services;

namespace InventorySystemAPI.Interfaces
{
    public interface IAttributeValues
    {
        Task<List<Attribute_value>> GetAllAttributeValuesById(int attribute_id);
    }
}
