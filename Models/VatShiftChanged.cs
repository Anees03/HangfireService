using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VatShiftChanged
    {
        public int PshiftChangedId { get; set; }
        public short SunMin { get; set; }
        public string? ChangedShiftDesc { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public short ShiftId { get; set; }
        public TimeSpan StartTime { get; set; }
        public byte DayOff1 { get; set; }
        public byte DayOff2 { get; set; }
        public short MonMin { get; set; }
        public short TueMin { get; set; }
        public short WedMin { get; set; }
        public short ThuMin { get; set; }
        public short FriMin { get; set; }
        public short SatMin { get; set; }
        public short MinHrs { get; set; }
        public int? UserId { get; set; }
        public short? LateIn { get; set; }
        public short? EarlyIn { get; set; }
        public short? EarlyOut { get; set; }
        public short? LateOut { get; set; }
        public short? OverTimeMin { get; set; }
        public bool? HasBreak { get; set; }
        public short? BreakMin { get; set; }
        public short? HalfDayBreakMin { get; set; }
        public string? DayOff1Name { get; set; }
        public string? DayOff2Name { get; set; }
        public string? ShiftName { get; set; }
    }
}
