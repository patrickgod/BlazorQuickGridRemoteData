using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorQuickGridRemoteData.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
