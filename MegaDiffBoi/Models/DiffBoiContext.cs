using System;

using Microsoft.EntityFrameworkCore;

namespace MegaDiffBoi.Models
{
    public class DiffBoiContext : DbContext
    {
        public DiffBoiContext(DbContextOptions<DiffBoiContext> options) : base(options)
        {
        }

        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

    public class Paragraph
    {
        public int ID { get; set; }
        public string Page { get; set; }
        public string Query { get; set; }
    }

    public class Entry
    {
        public int ID { get; set; }
        public int ParagraphID { get; set; }
        public Paragraph Paragraph { get; set; }

        public string Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
