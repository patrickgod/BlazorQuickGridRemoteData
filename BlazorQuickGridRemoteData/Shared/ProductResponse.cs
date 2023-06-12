using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorQuickGridRemoteData.Shared
{
    public record struct ProductResponse(List<Product> Products, int Count);
}
