using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Workers = new HashSet<Worker>();
        }

        public short PshiftId { get; set; }
        public string? ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public byte DayOff1 { get; set; }
        public byte DayOff2 { get; set; }
        public short MonMin { get; set; }
        public short TueMin { get; set; }
        public short WedMin { get; set; }
        public short ThuMin { get; set; }
        public short FriMin { get; set; }
        public short SatMin { get; set; }
        public short SunMin { get; set; }
        public short LateIn { get; set; }
        public short EarlyIn { get; set; }
        public short EarlyOut { get; set; }
        public short LateOut { get; set; }
        public short OverTimeMin { get; set; }
        public short MinHrs { get; set; }
        public bool HasBreak { get; set; }
        public short BreakMin { get; set; }
        public short HalfDayBreakMin { get; set; }
        public bool Gzdays { get; set; }
        public bool OpenShift { get; set; }
        public bool RoundOffWorkMin { get; set; }
        public bool SubtractOtfromWork { get; set; }
        public bool SubtractEifromWork { get; set; }
        public bool AddEiinOt { get; set; }
        public bool PresentAtIn { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
