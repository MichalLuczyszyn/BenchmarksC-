using System;
using System.Collections.Generic;

namespace Dapper.Tests.Performance;


[LinqToDB.Mapping.Table(Name = "Segments")]
public class Segment
{
    public Segment(short numberOfRooms, short segmentState, int studentHouseId, string createdBy, DateTime createdAt, short entryStatus)
    {
        NumberOfRooms = numberOfRooms;
        SegmentState = segmentState;
        CreatedBy = createdBy;
        StudentHouseId = studentHouseId;
        CreatedAt = createdAt;
        EntryStatus = entryStatus;
    }

    [LinqToDB.Mapping.PrimaryKey, LinqToDB.Mapping.Identity]
    public int Id { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short NumberOfRooms { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short SegmentState  { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public string CreatedBy { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public DateTime CreatedAt { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short OrderNumber { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public int StudentHouseId { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short EntryStatus { get;  set; }
    
    public ICollection<Room> Rooms { get; set; }
}


[LinqToDB.Mapping.Table(Name = "Rooms")]
public class Room
{
    [LinqToDB.Mapping.PrimaryKey, LinqToDB.Mapping.Identity]
    public int Id { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short Number{ get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short CurrentNumberOfResidents  { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short MaximumNumberOfResidents { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short RoomStatus { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public int SegmentId { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public string CreatedBy { get;  set; }
}
