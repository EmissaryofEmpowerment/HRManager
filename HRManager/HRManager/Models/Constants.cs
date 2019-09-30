using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManager.Models
{
    public class Constants
    {
        public enum Department
        {
            Human_Resources, Production, Accounts_Payable,
            Accounts_Receivable, Distribution, Administrative,
            Sales, Service, Information_Technology, Records
        }

        public enum Employment_Status
        {
Owner, Hired, Suspended, Terminated, Partner
}
        public enum Shift
        {
            Day, Night, Graveyard
        }

        public enum PermissionLevel
        {
            Low /*Read-only*/, Medium /*Create New*/,
            High/*Update, Delete, etc.*/
        }
    }
}
