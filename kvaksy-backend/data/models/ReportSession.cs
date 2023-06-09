﻿namespace kvaksy_backend.Data.Models
{
    public class ReportSession
    {
        public Guid Id { get; set; }
        public bool Finished { get; set; }
        public DateTime CreatedAt { get; set; }

        public Guid ReportId { get; set; }
        public Report Report { get; set; }

        public ICollection<ImageUrl> ImageUrls { get; set; }

        public ReportSession()
        {
            Id = Guid.NewGuid();
            Finished = false;
            CreatedAt = DateTime.Now;
            ImageUrls = new List<ImageUrl>();
            Report = new Report();
        }
        public ReportSession(Guid id, bool finished, DateTime createdAt, Report report)
        {
            Id = id;
            Finished = finished;
            CreatedAt = createdAt;
            Report = report;
            ImageUrls = new List<ImageUrl>();
        }
    }
}
