using System;
using System.Collections.Generic;

namespace QueueSimulation
{
    // Core Class 1: Ticket (Work Item)
    public enum TicketState
    {
        Backlog,
        InProgress,
        WaitingForReview,
        InReview,
        WaitingForRework,
        InRework,
        Completed
    }

    public class Ticket
    {
        public int Id { get; set; }
        public TicketState State { get; set; } = TicketState.Backlog;
        public DateTime CreatedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int AssignedDeveloperId { get; set; }
        
        // Timing
        public TimeSpan EstimatedCodingTime { get; set; } = TimeSpan.FromDays(1); // 1 day baseline
        public DateTime? CodingStartTime { get; set; }
        public DateTime? CodingEndTime { get; set; }
        
        // Quality tracking
        public bool RequiresRework { get; set; }
        public int ReworkCycles { get; set; } = 0;
        
        // Helper properties
        public TimeSpan? LeadTime => CompletedAt.HasValue && StartedAt.HasValue ? 
            CompletedAt.Value - StartedAt.Value : null;
            
        public TimeSpan? CodingTime => CodingEndTime.HasValue && CodingStartTime.HasValue ?
            CodingEndTime.Value - CodingStartTime.Value : null;

        public override string ToString() => $"Ticket {Id} [{State}]";
    }
}
