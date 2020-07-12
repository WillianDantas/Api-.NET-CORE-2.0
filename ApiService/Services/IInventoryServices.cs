using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Models;

namespace ApiService.Services
{
    interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
    }
}
