using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoJo.JoJoMart.Common.EntityFramework
{
    public class AuditedDbContext<T> : DbContext where T : DbContext
    {
    }
}
