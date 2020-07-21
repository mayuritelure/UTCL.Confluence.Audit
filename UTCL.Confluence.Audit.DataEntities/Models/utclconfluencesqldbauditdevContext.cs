using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UTCL.Confluence.Audit.DataEntities.Models
{
    public partial class utclconfluencesqldbauditdevContext : DbContext
    {
        public utclconfluencesqldbauditdevContext()
        {
        }

        public utclconfluencesqldbauditdevContext(DbContextOptions<utclconfluencesqldbauditdevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditScheduleData> AuditScheduleData { get; set; }
        public virtual DbSet<BceauditQuestions> BceauditQuestions { get; set; }
        public virtual DbSet<BceauditReviewComments> BceauditReviewComments { get; set; }
        public virtual DbSet<BceauditorReviewDetails> BceauditorReviewDetails { get; set; }
        public virtual DbSet<BcemasterActionPlan> BcemasterActionPlan { get; set; }
        public virtual DbSet<BceobservationFiles> BceobservationFiles { get; set; }
        public virtual DbSet<MasterBcequestionCatagory> MasterBcequestionCatagory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=tcp:utcl-confluence-sql-server-dev.database.windows.net,1433;Initial Catalog=utcl-confluence-sql-db-audit-dev;Persist Security Info=False;User ID=utclsqladmin;Password=fhtydb$#%7332@3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditScheduleData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditArea)
                    .HasColumnName("Audit Area")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditCategory)
                    .HasColumnName("Audit Category")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditCategoryAuditCatagoryName)
                    .HasColumnName("Audit Category:Audit CatagoryName")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditStatus)
                    .HasColumnName("Audit  Status")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditType)
                    .HasColumnName("Audit Type")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditZone)
                    .HasColumnName("Audit Zone")
                    .HasMaxLength(255);

                entity.Property(e => e.AuditeeCommnet).HasColumnType("ntext");

                entity.Property(e => e.AuditeeDecission).HasMaxLength(255);

                entity.Property(e => e.Auditor).HasMaxLength(255);

                entity.Property(e => e.AuditorCommnet).HasColumnType("ntext");

                entity.Property(e => e.AuditorDecision).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrentUserName)
                    .HasColumnName("Current  UserName")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("Fiscal Year")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Level).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PageState).HasMaxLength(255);

                entity.Property(e => e.PersonnelInteractedWith).HasMaxLength(1000);

                entity.Property(e => e.Section).HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Team).HasMaxLength(255);

                entity.Property(e => e.TestRole)
                    .HasColumnName("Test Role")
                    .HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.TotalScore)
                    .HasColumnName("Total Score")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitId)
                    .HasColumnName("Unit ID")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitName)
                    .HasColumnName("Unit Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BceauditQuestions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCEAuditQuestions");

                entity.Property(e => e.ActivationFlag)
                    .HasColumnName("Activation Flag")
                    .HasMaxLength(255);

                entity.Property(e => e.Catagory).HasMaxLength(255);

                entity.Property(e => e.CatagoryId)
                    .HasColumnName("Catagory:ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Items).HasMaxLength(255);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.PhysicalCondition).HasColumnName("Physical Condition");

                entity.Property(e => e.SrNo).HasColumnName("SR NO");
            });

            modelBuilder.Entity<BceauditReviewComments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCEAuditReviewComments");

                entity.Property(e => e.AuditId)
                    .HasColumnName("Audit ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BehaviourOfi).HasColumnName("Behaviour OFI");

                entity.Property(e => e.BehaviourStrength).HasColumnName("Behaviour Strength");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.NewActionPlanUrl)
                    .HasColumnName("NewActionPlan URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Ofi).HasColumnName("OFI");

                entity.Property(e => e.PhysicalOfi).HasColumnName("Physical OFI");

                entity.Property(e => e.PhysicalStrength).HasColumnName("Physical Strength");

                entity.Property(e => e.ReviewItemId)
                    .HasColumnName("Review Item ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemOfi).HasColumnName("System OFI");

                entity.Property(e => e.SystemStrength).HasColumnName("System Strength");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<BceauditorReviewDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCEAuditorReviewDetails");

                entity.Property(e => e.AuditId)
                    .HasColumnName("Audit ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BehaviourScore).HasColumnName("Behaviour Score");

                entity.Property(e => e.ContentType)
                    .HasColumnName("Content Type")
                    .HasMaxLength(4000);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.PhysicalConditionScore).HasColumnName("PhysicalCondition Score");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("Question ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemScore).HasColumnName("System Score");

                entity.Property(e => e.TitleTitle)
                    .HasColumnName("Title (Title)")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BcemasterActionPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCEMasterActionPlan");

                entity.Property(e => e.ActionTaken).HasColumnName("Action Taken");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("Assigned To")
                    .HasMaxLength(100);

                entity.Property(e => e.AuditId)
                    .HasColumnName("AuditID")
                    .HasMaxLength(255);

                entity.Property(e => e.Auditor).HasMaxLength(255);

                entity.Property(e => e.BehaviourOfi).HasColumnName("BehaviourOFI");

                entity.Property(e => e.BehaviourStrength).HasColumnType("ntext");

                entity.Property(e => e.Complete).HasColumnName("% Complete");

                entity.Property(e => e.CompletionDate)
                    .HasColumnName("Completion Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.Ofi).HasColumnName("OFI");

                entity.Property(e => e.Outcome).HasMaxLength(255);

                entity.Property(e => e.PhysicalOfi).HasColumnName("PhysicalOFI");

                entity.Property(e => e.Predecessors).HasMaxLength(4000);

                entity.Property(e => e.Priority).HasMaxLength(255);

                entity.Property(e => e.QueryString).HasMaxLength(255);

                entity.Property(e => e.RequiredActivity)
                    .HasColumnName("Required Activity")
                    .HasMaxLength(255);

                entity.Property(e => e.ReviewCommentId)
                    .HasColumnName("Review Comment ID")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.SystemOfi).HasColumnName("SystemOFI");

                entity.Property(e => e.TaskGroup)
                    .HasColumnName("Task Group")
                    .HasMaxLength(100);

                entity.Property(e => e.Team).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<BceobservationFiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCEObservationFiles");

                entity.Property(e => e.AuditId)
                    .HasColumnName("Audit ID")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("Category ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.OfiFile)
                    .HasColumnName("OFI File")
                    .HasMaxLength(255);

                entity.Property(e => e.StrengthFile)
                    .HasColumnName("Strength File")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleTitle)
                    .HasColumnName("Title (Title)")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterBcequestionCatagory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasterBCEQuestionCatagory");

                entity.Property(e => e.ActivationFlag)
                    .HasColumnName("Activation Flag")
                    .HasMaxLength(255);

                entity.Property(e => e.CatagoryId).HasColumnName("Catagory ID");

                entity.Property(e => e.CatagoryName)
                    .HasColumnName("Catagory Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryQuestionCount).HasColumnName("Category Question Count");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created By")
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified By")
                    .HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
