using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Duru.Library;
using Duru.UI.Data.Entities.Enums;

namespace Duru.UI.Data.Entities;

[Table("Room", Schema = "Duru")]
public class Room : CommonBase
{
    private int _roomId;
    private int _capacity;
    private int _floor;
    private RoomStatus _roomStatus;
    private RoomType _roomType;

    [Required]
    [Key]
    public int RoomId
    {
        get => _roomId;
        set
        {
            _roomId = value;
            RaisePropertyChanged("RoomId");
        }
    }
    
    [Required]
    public int Capacity
    {
        get => _capacity;
        set
        {
            _capacity = value;
            RaisePropertyChanged("Capacity");
        }
    }

    public int Floor
    {
        get => _floor;
        set
        {
            _floor = value;
            RaisePropertyChanged("Floor");
        }
    }

    public RoomStatus RoomStatus
    {
        get => _roomStatus;
        set
        {
            _roomStatus = value;
            RaisePropertyChanged("RoomStatus");
        }
    }

    public RoomType RoomType
    {
        get => _roomType;
        set
        {
            _roomType = value;
            RaisePropertyChanged("RoomType");
        }
    }
}



