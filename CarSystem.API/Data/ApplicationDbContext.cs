using CarSystem.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarSystem.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<DamageLicense> DamageLicenses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<LicenseClass> LicenseClasses { get; set; }
        public DbSet<LostLicense> LostLicenses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RenewalLicense> RenewalLicenses { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<WritingTest> WrittenTests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Admin>()
                .HasOne(u => u.User) 
                .WithMany() // With many with no parameter configure that the User don't have navigation property on the other side
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasOne(a => a.EditedBy)
                .WithMany(ad => ad.Admins)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(ap => ap.Applications)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId);

            modelBuilder.Entity<Admin>()
                .HasMany(da => da.DamageLicenses)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(dr => dr.Drivers)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(l => l.Licenses)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(lc => lc.LicenseClasses)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(ll => ll.LostLicenses)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Admin>()
            //    .HasMany(n => n.Nationalities)
            //    .WithOne(ad => ad.EditedBy)
            //    .HasForeignKey(fk => fk.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(op => op.Options)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(q => q.Questions)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(re => re.RenewalLicenses)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(t => t.Tests)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(wt => wt.WrittenTests)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Admin>()
                .HasMany(u => u.Users)
                .WithOne(ad => ad.EditedBy)
                .HasForeignKey(fk => fk.AdminId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Application>()
                .HasOne(u => u.User)
                .WithMany(ap => ap.Applications)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Application>()
                .HasMany(da => da.DamageLicenses)
                .WithOne(ap => ap.Application)
                .HasForeignKey(fk => fk.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Application>()
                .HasMany(l => l.Licenses)
                .WithOne(ap => ap.Application)
                .HasForeignKey(fk => fk.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Application>()
                .HasMany(ll => ll.LostLicenses)
                .WithOne(ap => ap.Application)
                .HasForeignKey(fk => fk.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Application>()
                .HasMany(rl => rl.RenewalLicenses)
                .WithOne(ap => ap.Application)
                .HasForeignKey(fk => fk.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Application>()
                .HasMany(t => t.Tests)
                .WithOne(ap => ap.Application)
                .HasForeignKey(fk => fk.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict);


            
            modelBuilder.Entity<DamageLicense>()
                .HasOne(l => l.License)
                .WithMany(da => da.DamageLicenses)
                .HasForeignKey(fk => fk.LicenseId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Driver>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Driver>()
                .HasMany(l => l.OwnedLicenses)
                .WithOne(d => d.Driver)
                .HasForeignKey(fk => fk.DriverId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<License>()
                .HasMany(ll => ll.LostLicenses)
                .WithOne(l => l.License)
                .HasForeignKey(fk => fk.LicenseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<License>()
                .HasMany(rl => rl.RenewalLicenses)
                .WithOne(l => l.License)
                .HasForeignKey(fk => fk.LicenseId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Nationality>()
                .HasMany(p => p.People)
                .WithOne(n => n.Nationality) 
                .HasForeignKey(fk => fk.NationalityId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Option>()
                .HasOne(op => op.Question)
                .WithMany(p => p.Options)
                .HasForeignKey(fk => fk.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Question>()
                .HasMany(q => q.Options)
                .WithOne(pt => pt.Question)
                .HasForeignKey(fk => fk.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Question>()
                .HasOne(tc => tc.TestCategory)
                .WithMany()
                .HasForeignKey(fk => fk.TestCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
              


            modelBuilder.Entity<Test>()
                .HasOne(tc => tc.TestCategory)
                .WithMany()
                .HasForeignKey(fk => fk.TestCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Test>()
                .HasMany(wt => wt.WrittenTests)
                .WithOne(t => t.Test)
                .HasForeignKey(fk => fk.TestId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Test>()
                .HasMany(vt => vt.VisionTests)
                .WithOne(t => t.Test)
                .HasForeignKey(fk => fk.TestId)
                .OnDelete(DeleteBehavior.Restrict);


            //modelBuilder.Entity<Application>()
            //    .HasOne(u => u.User)
            //    .WithMany(ua => ua.Applications)
            //    .HasForeignKey(fk => fk.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasOne(a => a.EditedBy)
            //    .WithMany(ea => ea.Applications)
            //    .HasForeignKey(fk => fk.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(d => d.DamageLicenses)
            //    .WithOne(a => a.Appliction)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(l => l.Licenses)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(ll => ll.LostLicenses)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(pt => pt.PracticalTests)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(rl => rl.RenewalLicenses)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(vt => vt.VisionTests)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Application>()
            //    .HasMany(wt => wt.WritingTests)
            //    .WithOne(a => a.Application)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>()
            //    .HasOne(p => p.Person)
            //    .WithMany()
            //    .HasForeignKey(fk => fk.PersonId)
            //    .OnDelete(DeleteBehavior.Restrict);


            //modelBuilder.Entity<PracticalTest>()
            //    .HasOne(a => a.Application)
            //    .WithMany(pt => pt.PracticalTests)
            //    .HasForeignKey(fk => fk.ApplicationId)
            //    .OnDelete(DeleteBehavior.Restrict);


            //modelBuilder.Entity<Admin>()
            //    .HasOne(a => a.EditedBy)
            //    .WithMany()
            //    .HasForeignKey(fk => fk.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>()
            //    .HasOne(e => e.EditedBy)
            //    .WithMany()
            //    .HasForeignKey(fk => fk.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Admin>()
            //    .HasMany(u => u.Users)
            //    .WithOne(a => a.EditedBy)
            //    .HasForeignKey(fk => fk.AdminId)
            //    .OnDelete(DeleteBehavior.Restrict);



        }
    }

    
}
