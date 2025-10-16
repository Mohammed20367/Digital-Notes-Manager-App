using Microsoft.EntityFrameworkCore;

namespace Digital_Notes_Manager_App.Models
{
    public partial class DigitalNotesDbContext : DbContext
    {
        public DigitalNotesDbContext()
        {
        }

        public DigitalNotesDbContext(DbContextOptions<DigitalNotesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<Reminder> Reminders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MOHAMMED_NASSER;Database=DigitalNotesDB;Trusted_Connection=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("User_PK");
                entity.ToTable("User");

                entity.HasIndex(e => e.Username).IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");
                entity.Property(e => e.Username).HasMaxLength(50);
                entity.Property(e => e.UserPassword).HasMaxLength(255);
            });

            // Category
            //modelBuilder.Entity<Category>(entity =>
            //{
            //    entity.HasKey(e => e.CategoryId).HasName("Category_PK");
            //    entity.ToTable("Category");

            //    entity.HasIndex(e => e.CategoryName).IsUnique();

            //    entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            //    entity.Property(e => e.CategoryName).HasMaxLength(50);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.Categories)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .HasConstraintName("Category_User_FK");
            //});
            // Category
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("Category_PK");
                entity.ToTable("Category");

              
                entity.HasIndex(e => new { e.CategoryName, e.UserId }).IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Category_User_FK");
            });


            // Note
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NoteId).HasName("Note_PK");
                entity.ToTable("Note");

                entity.Property(e => e.NoteId).HasColumnName("NoteID");
                entity.Property(e => e.Title).HasMaxLength(100);
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Note_User_FK");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Note_Category_FK");
            });

            // Reminder
            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasKey(e => e.ReminderId).HasName("Reminder_PK");
                entity.ToTable("Reminder");

                entity.Property(e => e.ReminderId).HasColumnName("ReminderID");
                entity.Property(e => e.ReminderDate).HasColumnType("datetime");
                entity.Property(e => e.IsNotified).HasDefaultValue(false);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Reminder_Note_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
