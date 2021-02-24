using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1xamarinforms.Services
{
    public interface InterfaceAlertServices
    {
        Task AlertAsync(String name);

        Task AlartEmpty();
        Task NavegationRegister();

        Task AlertEmpyRegister(string name);

        Task AlertPassword();

        Task ConfirmEmpty();
    }
}
