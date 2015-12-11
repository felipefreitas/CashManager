using CashManager.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManager.APPLICATION.Services.Commons.Interfaces
{
    public interface ISecurity
    {
        User CurrentUser { get; set; }
    }
}
