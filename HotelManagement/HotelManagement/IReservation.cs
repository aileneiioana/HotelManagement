using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication
{
    public interface IReservation
    {
        int ResId { get; set; }
        string Client { get; set; }
        Nullable<int> Room { get; set; }
        string DateIn { get; set; }
        string DateOut { get; set; }


    }
}