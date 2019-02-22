using InventorySystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemAPI.Interfaces
{
    public interface IAttributesRepository
    {
        Task<bool> DeleteAttribute(int attribute_id);
    }
}
