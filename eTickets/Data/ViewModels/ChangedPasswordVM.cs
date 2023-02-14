using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class ChangedPasswordVM
    {
        public string PasswordNow { get; set; }
        public string PasswordNew { get; set; }
        public string NhaplaiPassword { get; set; }
    }
}
