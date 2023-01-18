using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication
{
    public interface IRoom
    {
       int RoomId { get; set; }
       string RoomType { get; set; }
       string RoomPhone { get; set; }
       string RoomFree { get; set; }


    }
}