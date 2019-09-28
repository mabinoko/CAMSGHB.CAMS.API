using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class DBCams3context : DbContext
    {
        public DBCams3context()
        {
        }

        public DBCams3context(DbContextOptions<DBCams3context> options)
            : base(options)
        {
        }

        public virtual DbSet<Amphur> Amphur { get; set; }
        public virtual DbSet<AppChkTf2payment> AppChkTf2payment { get; set; }
        public virtual DbSet<AppChkTf3payment> AppChkTf3payment { get; set; }
        public virtual DbSet<AppChkTfpayment> AppChkTfpayment { get; set; }
        public virtual DbSet<AppChkTfpaymentMain> AppChkTfpaymentMain { get; set; }
        public virtual DbSet<AppChkTodlbbdetail> AppChkTodlbbdetail { get; set; }
        public virtual DbSet<AppChkTodlbdetail> AppChkTodlbdetail { get; set; }
        public virtual DbSet<AppChkTodlbldetail> AppChkTodlbldetail { get; set; }
        public virtual DbSet<AppChkTodpaymentMain> AppChkTodpaymentMain { get; set; }
        public virtual DbSet<AppChkTodudetail> AppChkTodudetail { get; set; }
        public virtual DbSet<AppChkTpayment> AppChkTpayment { get; set; }
        public virtual DbSet<AppChkTpaymentMain> AppChkTpaymentMain { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Appraisal> Appraisal { get; set; }
        public virtual DbSet<AppraisalInfoDetail> AppraisalInfoDetail { get; set; }
        public virtual DbSet<AppraisalJobType> AppraisalJobType { get; set; }
        public virtual DbSet<Appraisalnfo> Appraisalnfo { get; set; }
        public virtual DbSet<AppraisalOwner> AppraisalOwner { get; set; }
        public virtual DbSet<AppraisalStatus> AppraisalStatus { get; set; }
        public virtual DbSet<AppraisalTeam> AppraisalTeam { get; set; }
        public virtual DbSet<AppraisalTeamArea> AppraisalTeamArea { get; set; }
        public virtual DbSet<AppraisalValueInfo> AppraisalValueInfo { get; set; }
        public virtual DbSet<ApprisalConfirmPrice> ApprisalConfirmPrice { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<CollateralList> CollateralList { get; set; }
        public virtual DbSet<CollatReinfo> CollatReinfo { get; set; }
        public virtual DbSet<CollTypeCode> CollTypeCode { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompBranch> CompBranch { get; set; }
        public virtual DbSet<CompBranchArea> CompBranchArea { get; set; }
        public virtual DbSet<CondAssetOutdoor> CondAssetOutdoor { get; set; }
        public virtual DbSet<CustomerList> CustomerList { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DocumentList> DocumentList { get; set; }
        public virtual DbSet<Eject> Eject { get; set; }
        public virtual DbSet<FacilityList> FacilityList { get; set; }
        public virtual DbSet<FileImg> FileImg { get; set; }
        public virtual DbSet<LoanPurpose> LoanPurpose { get; set; }
        public virtual DbSet<MenuBank> MenuBank { get; set; }
        public virtual DbSet<MenuCompany> MenuCompany { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotifyAppraisalRequest> NotifyAppraisalRequest { get; set; }
        public virtual DbSet<Progress> Progress { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RoleMenuBank> RoleMenuBank { get; set; }
        public virtual DbSet<RoleMenuCom> RoleMenuCom { get; set; }
        public virtual DbSet<RolePolicyBank> RolePolicyBank { get; set; }
        public virtual DbSet<RolePolicyCom> RolePolicyCom { get; set; }
        public virtual DbSet<RoundRobin> RoundRobin { get; set; }
        public virtual DbSet<RoundRobinComp> RoundRobinComp { get; set; }
        public virtual DbSet<RoundRobinInternal> RoundRobinInternal { get; set; }
        public virtual DbSet<SignName> SignName { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<Tambol> Tambol { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserBank> UserBank { get; set; }
        public virtual DbSet<UserBankRole> UserBankRole { get; set; }
        public virtual DbSet<UserCompany> UserCompany { get; set; }
        public virtual DbSet<UserCompRole> UserCompRole { get; set; }
        public virtual DbSet<UseType> UseType { get; set; }
        public virtual DbSet<SamplingLBFTDetail> SamplingLBFTDetail { get; set; }
        public virtual DbSet<SamplingUFTDetail> SamplingUFTDetail { get; set; }
        public virtual DbSet<SamplingworkBZP> SamplingworkBZP { get; set; }
        public virtual DbSet<SamplingworkFTMain> SamplingworkFTMain { get; set; }
        public virtual DbSet<SamplingworkLTF> SamplingworkLTF { get; set; }

        // Unable to generate entity type for table 'dbo.SamplingworkBZP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SamplingworkLTF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SamplingworkFTMain'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SamplingLBFTDetail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SamplingUFTDetail'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=207.148.69.13;Database=DBCams3;User ID=dbcams;Password=123456Ws");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amphur>(entity =>
            {
                entity.Property(e => e.AmphurId).HasColumnName("AmphurID");
            });

            modelBuilder.Entity<AppChkTf2payment>(entity =>
            {
                entity.HasKey(e => e.AppriId);

                entity.ToTable("AppChkTF2Payment");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Amphurid).HasColumnName("amphurid");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Appraisalmain).HasColumnName("appraisalmain");

                entity.Property(e => e.Appraisalno).HasColumnName("appraisalno");

                entity.Property(e => e.Appraisaltype).HasColumnName("appraisaltype");

                entity.Property(e => e.ApproveUserId).HasColumnName("ApproveUserID");

                entity.Property(e => e.AuthorizeId).HasColumnName("AuthorizeID");

                entity.Property(e => e.Authorizedocno).HasColumnName("authorizedocno");

                entity.Property(e => e.BankUserApproveId).HasColumnName("BankUserApproveID");

                entity.Property(e => e.CBuildingplan).HasColumnName("c_buildingplan");

                entity.Property(e => e.CheckNo).HasColumnName("Check_No");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.LandNo).HasColumnName("LandNO");

                entity.Property(e => e.Landarearai).HasColumnName("landarearai");

                entity.Property(e => e.Memberno).HasColumnName("memberno");

                entity.Property(e => e.Memberof).HasColumnName("memberof");

                entity.Property(e => e.Membertype).HasColumnName("membertype");

                entity.Property(e => e.Ngan).HasColumnName("ngan");

                entity.Property(e => e.Pbeam).HasColumnName("PBeam");

                entity.Property(e => e.Pconstruction).HasColumnName("PConstruction");

                entity.Property(e => e.Pdwc).HasColumnName("PDWC");

                entity.Property(e => e.Peutility).HasColumnName("PEUtility");

                entity.Property(e => e.Pfloor).HasColumnName("PFloor");

                entity.Property(e => e.Pfoundateion).HasColumnName("PFoundateion");

                entity.Property(e => e.Pframe).HasColumnName("PFrame");

                entity.Property(e => e.Powall).HasColumnName("POWall");

                entity.Property(e => e.Ppaint).HasColumnName("PPaint");

                entity.Property(e => e.Proof).HasColumnName("PRoof");

                entity.Property(e => e.Provinceid).HasColumnName("provinceid");

                entity.Property(e => e.Pscealing).HasColumnName("PScealing");

                entity.Property(e => e.Psroof).HasColumnName("PSRoof");

                entity.Property(e => e.Pswall).HasColumnName("PSWall");

                entity.Property(e => e.Pware).HasColumnName("PWARE");

                entity.Property(e => e.Pwframe).HasColumnName("PWFrame");

                entity.Property(e => e.Pwother).HasColumnName("PWOTHER");

                entity.Property(e => e.Pwutility).HasColumnName("PWUtility");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Tambonid).HasColumnName("tambonid");

                entity.Property(e => e.Wa).HasColumnName("wa");

                entity.Property(e => e.Wbeam).HasColumnName("WBeam");

                entity.Property(e => e.Wcealing).HasColumnName("WCealing");

                entity.Property(e => e.Wconstruction).HasColumnName("WConstruction");

                entity.Property(e => e.Wdwc).HasColumnName("WDWC");

                entity.Property(e => e.Weutility).HasColumnName("WEUtility");

                entity.Property(e => e.Wfloor).HasColumnName("WFloor");

                entity.Property(e => e.Wfoundation).HasColumnName("WFoundation");

                entity.Property(e => e.Wframe).HasColumnName("WFrame");

                entity.Property(e => e.Wowall).HasColumnName("WOWall");

                entity.Property(e => e.Wpaint).HasColumnName("WPaint");

                entity.Property(e => e.Wroof).HasColumnName("WRoof");

                entity.Property(e => e.Wsroof).HasColumnName("WSRoof");

                entity.Property(e => e.Wswall).HasColumnName("WSWall");

                entity.Property(e => e.Wware).HasColumnName("WWARE");

                entity.Property(e => e.Wwframe).HasColumnName("WWFrame");

                entity.Property(e => e.Wwother).HasColumnName("WWOTHER");

                entity.Property(e => e.Wwutility).HasColumnName("WWUtility");
            });

            modelBuilder.Entity<AppChkTf3payment>(entity =>
            {
                entity.HasKey(e => e.AppriId);

                entity.ToTable("AppChkTF3Payment");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Amphurid).HasColumnName("amphurid");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Appraisalmain).HasColumnName("appraisalmain");

                entity.Property(e => e.Appraisalno).HasColumnName("appraisalno");

                entity.Property(e => e.Appraisaltype).HasColumnName("appraisaltype");

                entity.Property(e => e.ApproveUserId).HasColumnName("ApproveUserID");

                entity.Property(e => e.AuthorizeId).HasColumnName("AuthorizeID");

                entity.Property(e => e.Authorizedocno).HasColumnName("authorizedocno");

                entity.Property(e => e.BankUserApproveId).HasColumnName("BankUserApproveID");

                entity.Property(e => e.CBuildingplan).HasColumnName("c_buildingplan");

                entity.Property(e => e.CheckNo).HasColumnName("Check_No");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.LandNo).HasColumnName("LandNO");

                entity.Property(e => e.Landarearai).HasColumnName("landarearai");

                entity.Property(e => e.Memberno).HasColumnName("memberno");

                entity.Property(e => e.Memberof).HasColumnName("memberof");

                entity.Property(e => e.Membertype).HasColumnName("membertype");

                entity.Property(e => e.Ngan).HasColumnName("ngan");

                entity.Property(e => e.Pconstruction).HasColumnName("PConstruction");

                entity.Property(e => e.Pdwc).HasColumnName("PDWC");

                entity.Property(e => e.Peutility).HasColumnName("PEUtility");

                entity.Property(e => e.Pfloor).HasColumnName("PFloor");

                entity.Property(e => e.Pfoundateion).HasColumnName("PFoundateion");

                entity.Property(e => e.Pframe).HasColumnName("PFrame");

                entity.Property(e => e.Ppaint).HasColumnName("PPaint");

                entity.Property(e => e.Provinceid).HasColumnName("provinceid");

                entity.Property(e => e.Pswall).HasColumnName("PSWall");

                entity.Property(e => e.Pwall).HasColumnName("PWall");

                entity.Property(e => e.Pwother).HasColumnName("PWOTHER");

                entity.Property(e => e.Pwutility).HasColumnName("PWUtility");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Tambonid).HasColumnName("tambonid");

                entity.Property(e => e.Wa).HasColumnName("wa");

                entity.Property(e => e.Wconstruction).HasColumnName("WConstruction");

                entity.Property(e => e.Wdwc).HasColumnName("WDWC");

                entity.Property(e => e.Weutility).HasColumnName("WEUtility");

                entity.Property(e => e.Wfloor).HasColumnName("WFloor");

                entity.Property(e => e.Wfoundation).HasColumnName("WFoundation");

                entity.Property(e => e.Wframe).HasColumnName("WFrame");

                entity.Property(e => e.Wpaint).HasColumnName("WPaint");

                entity.Property(e => e.Wswall).HasColumnName("WSWall");

                entity.Property(e => e.Wwall).HasColumnName("WWall");

                entity.Property(e => e.Wwother).HasColumnName("WWOTHER");

                entity.Property(e => e.Wwutility).HasColumnName("WWUtility");
            });

            modelBuilder.Entity<AppChkTfpayment>(entity =>
            {
                entity.HasKey(e => e.AppriId);

                entity.ToTable("AppChkTFPayment");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.Aano).HasColumnName("AANo");
            });

            modelBuilder.Entity<AppChkTfpaymentMain>(entity =>
            {
                entity.ToTable("AppChkTFPaymentMain");

                entity.Property(e => e.AppChkTfpaymentMainId).HasColumnName("AppChkTFPaymentMainId");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Amphurid).HasColumnName("amphurid");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.CBuildingplan).HasColumnName("c_buildingplan");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.LandNo).HasColumnName("LandNO");

                entity.Property(e => e.Landarearai).HasColumnName("landarearai");

                entity.Property(e => e.LdateAppointment).HasColumnName("LDateAppointment");

                entity.Property(e => e.LdateSurvey).HasColumnName("LDateSurvey");

                entity.Property(e => e.Ngan).HasColumnName("ngan");

                entity.Property(e => e.Provinceid).HasColumnName("provinceid");

                entity.Property(e => e.Tambonid).HasColumnName("tambonid");

                entity.Property(e => e.Totalwithdraw).HasColumnName("totalwithdraw");

                entity.Property(e => e.Userjobsnow).HasColumnName("userjobsnow");

                entity.Property(e => e.Wa).HasColumnName("wa");
            });

            modelBuilder.Entity<AppChkTodlbbdetail>(entity =>
            {
                entity.HasKey(e => e.AppriLbdetailId);

                entity.ToTable("AppChkTODLBBDetail");

                entity.Property(e => e.AppriLbdetailId).HasColumnName("AppriLBDetailId");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.BuildingPlan).HasColumnName("building_plan");
            });

            modelBuilder.Entity<AppChkTodlbdetail>(entity =>
            {
                entity.HasKey(e => e.AppriId);

                entity.ToTable("AppChkTODLBDetail");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.ApproveUserId).HasColumnName("ApproveUserID");

                entity.Property(e => e.BankUserApproveId).HasColumnName("BankUserApproveID");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.SurveyUserId).HasColumnName("SurveyUserID");
            });

            modelBuilder.Entity<AppChkTodlbldetail>(entity =>
            {
                entity.HasKey(e => e.AppriLbdetailId);

                entity.ToTable("AppChkTODLBLDetail");

                entity.Property(e => e.AppriLbdetailId).HasColumnName("AppriLBDetailId");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.UtilityP).HasColumnName("utility_p");
            });

            modelBuilder.Entity<AppChkTodpaymentMain>(entity =>
            {
                entity.ToTable("AppChkTODPaymentMain");

                entity.Property(e => e.AppChkTodpaymentMainId).HasColumnName("AppChkTODPaymentMainId");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.AllocatorId).HasColumnName("AllocatorID");

                entity.Property(e => e.Amphurid).HasColumnName("amphurid");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.LdateAppointment).HasColumnName("LDateAppointment");

                entity.Property(e => e.LdateSurvey).HasColumnName("LDateSurvey");

                entity.Property(e => e.Provinceid).HasColumnName("provinceid");

                entity.Property(e => e.Road).HasColumnName("ROAD");

                entity.Property(e => e.Soi).HasColumnName("SOI");

                entity.Property(e => e.Tambonid).HasColumnName("tambonid");

                entity.Property(e => e.Userjobsnow).HasColumnName("userjobsnow");
            });

            modelBuilder.Entity<AppChkTodudetail>(entity =>
            {
                entity.HasKey(e => e.AppriId);

                entity.ToTable("AppChkTODUDetail");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.ApprisalUserId).HasColumnName("ApprisalUserID");

                entity.Property(e => e.BankUserApproveId).HasColumnName("BankUserApproveID");

                entity.Property(e => e.CheckUnitBresult).HasColumnName("check_UnitBResult");

                entity.Property(e => e.CheckUnitDresult).HasColumnName("check_UnitDResult");

                entity.Property(e => e.CheckUnitFresult).HasColumnName("check_UnitFResult");

                entity.Property(e => e.CheckUnitLresult).HasColumnName("check_UnitLResult");

                entity.Property(e => e.CheckUnitOther).HasColumnName("check_UnitOther");

                entity.Property(e => e.CheckUnitUlist).HasColumnName("check_UnitUList");

                entity.Property(e => e.CheckUnitUresult).HasColumnName("check_UnitUResult");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.DateBsurvey).HasColumnName("DateBSurvey");

                entity.Property(e => e.SurveyUserId).HasColumnName("SurveyUserID");
            });

            modelBuilder.Entity<AppChkTpayment>(entity =>
            {
                entity.HasKey(e => e.AppChkTfpaymentId);

                entity.ToTable("AppChkTPayment");

                entity.Property(e => e.AppChkTfpaymentId).HasColumnName("AppChkTFPaymentID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Appraisalmain).HasColumnName("appraisalmain");

                entity.Property(e => e.Appraisalno).HasColumnName("appraisalno");

                entity.Property(e => e.Appraisaltype).HasColumnName("appraisaltype");

                entity.Property(e => e.AppriId).HasColumnName("AppriID");

                entity.Property(e => e.ApproveUserId).HasColumnName("ApproveUserID");

                entity.Property(e => e.Approvepaymentno).HasColumnName("approvepaymentno");

                entity.Property(e => e.AuthorizeId).HasColumnName("AuthorizeID");

                entity.Property(e => e.Authorizedocno).HasColumnName("authorizedocno");

                entity.Property(e => e.BankUserApproveId).HasColumnName("BankUserApproveID");

                entity.Property(e => e.CBuildingplan).HasColumnName("c_buildingplan");

                entity.Property(e => e.ChangeIncDec).HasColumnName("change_inc_dec");

                entity.Property(e => e.ChangeOther).HasColumnName("change_other");

                entity.Property(e => e.CheckNo).HasColumnName("Check_No");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DeedNs03).HasColumnName("Deed_NS03");

                entity.Property(e => e.DeedNs03No).HasColumnName("Deed_NS03_NO");

                entity.Property(e => e.Memberno).HasColumnName("memberno");

                entity.Property(e => e.Memberof).HasColumnName("memberof");

                entity.Property(e => e.Membertype).HasColumnName("membertype");

                entity.Property(e => e.NoOfFloor).HasColumnName("No_Of_Floor");

                entity.Property(e => e.Pconstruction).HasColumnName("PConstruction");

                entity.Property(e => e.Pdwc).HasColumnName("PDWC");

                entity.Property(e => e.Pfloor).HasColumnName("PFloor");

                entity.Property(e => e.Pfoundateion).HasColumnName("PFoundateion");

                entity.Property(e => e.Pframe).HasColumnName("PFrame");

                entity.Property(e => e.Ppaint).HasColumnName("PPaint");

                entity.Property(e => e.Proof).HasColumnName("PRoof");

                entity.Property(e => e.Psroof).HasColumnName("PSRoof");

                entity.Property(e => e.Putility).HasColumnName("PUtility");

                entity.Property(e => e.Pwall).HasColumnName("PWall");

                entity.Property(e => e.ResultConstruc).HasColumnName("resultConstruc");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Totalwithdraw).HasColumnName("totalwithdraw");

                entity.Property(e => e.Wconstruction).HasColumnName("WConstruction");

                entity.Property(e => e.Wdwc).HasColumnName("WDWC");

                entity.Property(e => e.Wfloor).HasColumnName("WFloor");

                entity.Property(e => e.Wfoundation).HasColumnName("WFoundation");

                entity.Property(e => e.Wframe).HasColumnName("WFrame");

                entity.Property(e => e.Wpaint).HasColumnName("WPaint");

                entity.Property(e => e.Wroof).HasColumnName("WRoof");

                entity.Property(e => e.Wsroof).HasColumnName("WSRoof");

                entity.Property(e => e.Wutility).HasColumnName("WUtility");

                entity.Property(e => e.Wwall).HasColumnName("WWall");
            });

            modelBuilder.Entity<AppChkTpaymentMain>(entity =>
            {
                entity.HasKey(e => e.AppChkTfpaymentMainId);

                entity.ToTable("AppChkTPaymentMain");

                entity.Property(e => e.AppChkTfpaymentMainId).HasColumnName("AppChkTFPaymentMainID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.Apno).HasColumnName("APNO");

                entity.Property(e => e.CBuildingplan).HasColumnName("c_buildingplan");

                entity.Property(e => e.ChangeIncDec).HasColumnName("change_inc_dec");

                entity.Property(e => e.ChangeOther).HasColumnName("change_other");

                entity.Property(e => e.Chktermtype).HasColumnName("chktermtype");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DeedNs03).HasColumnName("Deed_NS03");

                entity.Property(e => e.DeedNs03No).HasColumnName("Deed_NS03_NO");

                entity.Property(e => e.LdateAppointment).HasColumnName("LDateAppointment");

                entity.Property(e => e.LdateSurvey).HasColumnName("LDateSurvey");

                entity.Property(e => e.NoOfFloor).HasColumnName("No_Of_Floor");

                entity.Property(e => e.Totalwithdraw).HasColumnName("totalwithdraw");

                entity.Property(e => e.Userjobsnow).HasColumnName("userjobsnow");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.AppointmentsId).HasColumnName("AppointmentsID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CreateByUserId).HasColumnName("CreateByUserID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<Appraisal>(entity =>
            {
                entity.HasIndex(e => e.AdminEx);

                entity.HasIndex(e => e.ApprComp);

                entity.HasIndex(e => e.ApprCompBranch);

                entity.HasIndex(e => e.AssessmentEx);

                entity.HasIndex(e => e.AssessmentIn);

                entity.HasIndex(e => e.CommanderIn);

                entity.HasIndex(e => e.LeadIn);

                entity.HasIndex(e => e.ProgressStatus);

                entity.HasIndex(e => e.SeniorIn);

                entity.HasIndex(e => e.SignNameEx);

                entity.HasIndex(e => e.SurveyEx);

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.ApplId).HasColumnName("ApplID");

                entity.Property(e => e.ApprComp)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ApprId).HasColumnName("ApprID");

                entity.Property(e => e.AppraisalFlowGroup).HasColumnName("Appraisal_FlowGroup");

                entity.Property(e => e.AppraisalJobType).HasColumnName("Appraisal_JobType");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.Property(e => e.CollTypeCode).HasColumnName("COLL_TYPE_CODE");

                entity.Property(e => e.Dec).HasColumnName("DEC");

                entity.Property(e => e.DeccontactNo).HasColumnName("DECContactNo");

                entity.Property(e => e.DecofficerCode).HasColumnName("DECOfficerCode");

                entity.Property(e => e.DecofficerName).HasColumnName("DECOfficerName");

                entity.Property(e => e.GhbStaffId).HasColumnName("GHB_STAFF_ID");

                entity.Property(e => e.LoanStatusCode).HasColumnName("LOAN_STATUS_CODE");

                entity.Property(e => e.OwnershipUserId).HasColumnName("OwnershipUserID");

                entity.Property(e => e.ProgressStatus).HasMaxLength(255);

                entity.Property(e => e.SumTotalCollat).HasColumnName("sumTotalCollat");

                entity.Property(e => e.SumTotalCollatAfter).HasColumnName("sumTotalCollatAfter");

                entity.Property(e => e.SumTotalCollatBefore).HasColumnName("sumTotalCollatBefore");

                entity.HasOne(d => d.AdminExNavigation)
                    .WithMany(p => p.AppraisalAdminExNavigation)
                    .HasForeignKey(d => d.AdminEx);

                entity.HasOne(d => d.ApprCompNavigation)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.ApprComp);

                entity.HasOne(d => d.ApprCompBranchNavigation)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.ApprCompBranch);

                entity.HasOne(d => d.AssessmentExNavigation)
                    .WithMany(p => p.AppraisalAssessmentExNavigation)
                    .HasForeignKey(d => d.AssessmentEx);

                entity.HasOne(d => d.AssessmentInNavigation)
                    .WithMany(p => p.AppraisalAssessmentInNavigation)
                    .HasForeignKey(d => d.AssessmentIn);

                entity.HasOne(d => d.CommanderInNavigation)
                    .WithMany(p => p.AppraisalCommanderInNavigation)
                    .HasForeignKey(d => d.CommanderIn);

                entity.HasOne(d => d.LeadInNavigation)
                    .WithMany(p => p.AppraisalLeadInNavigation)
                    .HasForeignKey(d => d.LeadIn);

                entity.HasOne(d => d.ProgressStatusNavigation)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.ProgressStatus);

                entity.HasOne(d => d.SeniorInNavigation)
                    .WithMany(p => p.AppraisalSeniorInNavigation)
                    .HasForeignKey(d => d.SeniorIn);

                entity.HasOne(d => d.SignNameExNavigation)
                    .WithMany(p => p.AppraisalSignNameExNavigation)
                    .HasForeignKey(d => d.SignNameEx);

                entity.HasOne(d => d.SurveyExNavigation)
                    .WithMany(p => p.AppraisalSurveyExNavigation)
                    .HasForeignKey(d => d.SurveyEx);
            });

            modelBuilder.Entity<AppraisalInfoDetail>(entity =>
            {
                entity.HasIndex(e => e.AppraisalnfoId);

                entity.Property(e => e.AppraisalInfoDetailId).HasColumnName("AppraisalInfoDetailID");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AppraisalnfoId).HasColumnName("AppraisalnfoID");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.List).HasColumnName("list");

                entity.Property(e => e.NoList).HasColumnName("no_list");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Appraisalnfo)
                    .WithMany(p => p.AppraisalInfoDetail)
                    .HasForeignKey(d => d.AppraisalnfoId);
            });

            modelBuilder.Entity<AppraisalJobType>(entity =>
            {
                entity.Property(e => e.AppraisalJobTypeId).HasColumnName("Appraisal_JobTypeID");

                entity.Property(e => e.AppraisalJobType1).HasColumnName("Appraisal_JobType");

                entity.Property(e => e.AppraisalJobTypeName).HasColumnName("Appraisal_JobTypeName");
            });

            modelBuilder.Entity<Appraisalnfo>(entity =>
            {
                entity.HasKey(e => e.AppraisalInfoId);

                entity.HasIndex(e => e.CollateralListId)
                    .IsUnique();

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.Amount2).HasColumnName("amount2");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.AppraisedPrice).HasColumnName("appraised_price");

                entity.Property(e => e.BuildingPrice).HasColumnName("building_price");

                entity.Property(e => e.BuildingPriceBefore).HasColumnName("building_price_before");

                entity.Property(e => e.BuildingpriceAfterDepreciation).HasColumnName("buildingprice_after_depreciation");

                entity.Property(e => e.ChkDeedCompare).HasColumnName("chkDeedCompare");

                entity.Property(e => e.CollateralListId).HasColumnName("CollateralListID");

                entity.Property(e => e.ConstructionResult1).HasColumnName("construction_result1");

                entity.Property(e => e.Coordinatesfrom).HasColumnName("coordinatesfrom");

                entity.Property(e => e.DegenerativeCondition).HasColumnName("degenerative_condition");

                entity.Property(e => e.DepreciationPerYear).HasColumnName("depreciation_per_year");

                entity.Property(e => e.DetCollatId).HasColumnName("DetCollatID");

                entity.Property(e => e.ElectricityOver100Mnote).HasColumnName("ElectricityOver100MNote");

                entity.Property(e => e.Guarantee).HasColumnName("guarantee");

                entity.Property(e => e.Guarantee2).HasColumnName("guarantee2");

                entity.Property(e => e.HostCollatId).HasColumnName("HostCollatID");

                entity.Property(e => e.InTheMunicipality).HasColumnName("in_the_municipality");

                entity.Property(e => e.LandAssessment).HasColumnName("land_assessment");

                entity.Property(e => e.LandPrice).HasColumnName("land_price");

                entity.Property(e => e.Notpainted).HasColumnName("notpainted");

                entity.Property(e => e.Number2).HasColumnName("number2");

                entity.Property(e => e.NumberOfFloors).HasColumnName("number_of_floors");

                entity.Property(e => e.OtherBuildings).HasColumnName("other_buildings");

                entity.Property(e => e.OtherDetail1).HasColumnName("other_detail1");

                entity.Property(e => e.OtherDetail2).HasColumnName("other_detail2");

                entity.Property(e => e.OtherInfringement).HasColumnName("other_infringement");

                entity.Property(e => e.OtherMunicipality).HasColumnName("other_municipality");

                entity.Property(e => e.PriceIncluding).HasColumnName("price_including");

                entity.Property(e => e.ResidentialArea).HasColumnName("residential_area");

                entity.Property(e => e.SumAcceptPrice).HasColumnName("sumAcceptPrice");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TypeOfCollateral).HasColumnName("type_of_collateral");

                entity.Property(e => e.WaterGroundwater).HasColumnName("Water_Groundwater");

                entity.Property(e => e.WithBuildingQty).HasColumnName("WithBuildingQTY");

                entity.HasOne(d => d.CollateralList)
                    .WithOne(p => p.Appraisalnfo)
                    .HasForeignKey<Appraisalnfo>(d => d.CollateralListId);
            });

            modelBuilder.Entity<AppraisalOwner>(entity =>
            {
                entity.HasKey(e => e.AppOwnId);

                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.AppOwnId).HasColumnName("AppOwnID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.AppraisalOwner)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<AppraisalStatus>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.AppraisalStatus)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<AppraisalTeam>(entity =>
            {
                entity.Property(e => e.AppraisalTeamId).HasColumnName("AppraisalTeamID");

                entity.Property(e => e.AppraisalTeamName).HasMaxLength(100);
            });

            modelBuilder.Entity<AppraisalTeamArea>(entity =>
            {
                entity.Property(e => e.AppraisalTeamAreaId).HasColumnName("AppraisalTeamAreaID");

                entity.Property(e => e.AppraisalTeamId)
                    .IsRequired()
                    .HasColumnName("AppraisalTeamID")
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppraisalValueInfo>(entity =>
            {
                entity.HasIndex(e => e.AdminEx);

                entity.HasIndex(e => e.ApprCompBranch);

                entity.HasIndex(e => e.AssessmentEx);

                entity.HasIndex(e => e.AssessmentIn);

                entity.HasIndex(e => e.CollateralListId);

                entity.HasIndex(e => e.CommanderIn);

                entity.HasIndex(e => e.LeadIn);

                entity.HasIndex(e => e.SeniorIn);

                entity.HasIndex(e => e.SignNameEx);

                entity.HasIndex(e => e.SurveyEx);

                entity.Property(e => e.AppraisalValueInfoId).HasColumnName("AppraisalValueInfoID");

                entity.Property(e => e.ApprId).HasColumnName("ApprID");

                entity.Property(e => e.AvofBuildingLease).HasColumnName("AVOfBuildingLease");

                entity.Property(e => e.AvofLandLease).HasColumnName("AVOfLandLease");

                entity.Property(e => e.AvofOrigBuilding).HasColumnName("AVOfOrigBuilding");

                entity.Property(e => e.BankEmpId).HasColumnName("BankEmpID");

                entity.Property(e => e.CollateralListId).HasColumnName("CollateralListID");

                entity.Property(e => e.DetCollatId).HasColumnName("DetCollatID");

                entity.Property(e => e.HostCollatId).HasColumnName("HostCollatID");

                entity.Property(e => e.ReviewAv3m).HasColumnName("ReviewAV3M");

                entity.Property(e => e.ReviewAv3mrem).HasColumnName("ReviewAV3MRem");

                entity.Property(e => e.ReviewAvlt3m).HasColumnName("ReviewAVLT3M");

                entity.Property(e => e.ReviewAvlt3mrem).HasColumnName("ReviewAVLT3MRem");

                entity.HasOne(d => d.AdminExNavigation)
                    .WithMany(p => p.AppraisalValueInfoAdminExNavigation)
                    .HasForeignKey(d => d.AdminEx);

                entity.HasOne(d => d.ApprCompBranchNavigation)
                    .WithMany(p => p.AppraisalValueInfo)
                    .HasForeignKey(d => d.ApprCompBranch);

                entity.HasOne(d => d.AssessmentExNavigation)
                    .WithMany(p => p.AppraisalValueInfoAssessmentExNavigation)
                    .HasForeignKey(d => d.AssessmentEx);

                entity.HasOne(d => d.AssessmentInNavigation)
                    .WithMany(p => p.AppraisalValueInfoAssessmentInNavigation)
                    .HasForeignKey(d => d.AssessmentIn);

                entity.HasOne(d => d.CollateralList)
                    .WithMany(p => p.AppraisalValueInfo)
                    .HasForeignKey(d => d.CollateralListId);

                entity.HasOne(d => d.CommanderInNavigation)
                    .WithMany(p => p.AppraisalValueInfoCommanderInNavigation)
                    .HasForeignKey(d => d.CommanderIn);

                entity.HasOne(d => d.LeadInNavigation)
                    .WithMany(p => p.AppraisalValueInfoLeadInNavigation)
                    .HasForeignKey(d => d.LeadIn);

                entity.HasOne(d => d.SeniorInNavigation)
                    .WithMany(p => p.AppraisalValueInfoSeniorInNavigation)
                    .HasForeignKey(d => d.SeniorIn);

                entity.HasOne(d => d.SignNameExNavigation)
                    .WithMany(p => p.AppraisalValueInfoSignNameExNavigation)
                    .HasForeignKey(d => d.SignNameEx);

                entity.HasOne(d => d.SurveyExNavigation)
                    .WithMany(p => p.AppraisalValueInfoSurveyExNavigation)
                    .HasForeignKey(d => d.SurveyEx);
            });

            modelBuilder.Entity<ApprisalConfirmPrice>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId)
                    .IsUnique();

                entity.Property(e => e.ApprisalConfirmPriceId).HasColumnName("ApprisalConfirmPriceID");

                entity.Property(e => e.Aano).HasColumnName("AANo");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.ChkwithGis).HasColumnName("ChkwithGIS");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.CollTypeCode).HasColumnName("COLL_TYPE_CODE");

                entity.Property(e => e.CompWithGis).HasColumnName("CompWithGIS");

                entity.Property(e => e.DepreciationSuitable).HasColumnName("depreciationSuitable");

                entity.HasOne(d => d.Appraisal)
                    .WithOne(p => p.ApprisalConfirmPrice)
                    .HasForeignKey<ApprisalConfirmPrice>(d => d.AppraisalId);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchId1).HasColumnName("BRANCH_ID");

                entity.Property(e => e.BranchName).HasColumnName("BRANCH_NAME");

                entity.Property(e => e.DecCode).HasColumnName("DEC_CODE");

                entity.Property(e => e.DecName).HasColumnName("DEC_NAME");

                entity.Property(e => e.DecSolId).HasColumnName("DEC_SOL_ID");

                entity.Property(e => e.DeptId).HasColumnName("DEPT_ID");

                entity.Property(e => e.DeptName).HasColumnName("DEPT_NAME");

                entity.Property(e => e.DivCode2014).HasColumnName("DIV_CODE_2014");

                entity.Property(e => e.DivisionCode).HasColumnName("DIVISION_CODE");

                entity.Property(e => e.DivisionId).HasColumnName("DIVISION_ID");

                entity.Property(e => e.DivisionName).HasColumnName("DIVISION_NAME");
            });

            modelBuilder.Entity<CollateralList>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.CollateralListId).HasColumnName("CollateralListID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.HostCollatId).HasColumnName("HostCollatID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.CollateralList)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<CollatReinfo>(entity =>
            {
                entity.ToTable("CollatREInfo");

                entity.HasIndex(e => e.CollateralListId)
                    .IsUnique();

                entity.Property(e => e.CollatReInfoId).HasColumnName("CollatReInfoID");

                entity.Property(e => e.CollateralListId).HasColumnName("CollateralListID");

                entity.HasOne(d => d.CollateralList)
                    .WithOne(p => p.CollatReinfo)
                    .HasForeignKey<CollatReinfo>(d => d.CollateralListId);
            });

            modelBuilder.Entity<CollTypeCode>(entity =>
            {
                entity.HasKey(e => e.CollTypeId);

                entity.Property(e => e.CollTypeId).HasColumnName("CollTypeID");

                entity.Property(e => e.CollTypeCode1).HasColumnName("COLL_TYPE_CODE");

                entity.Property(e => e.CollTypeName).HasColumnName("COLL_TYPE_NAME");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.RegionId);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddNo).HasMaxLength(150);

                entity.Property(e => e.Alley).HasMaxLength(100);

                entity.Property(e => e.AmphurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CifNo).HasColumnName("CIF_NO");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Road)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TambolCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.ViilageNo).HasMaxLength(100);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<CompBranch>(entity =>
            {
                entity.Property(e => e.CompBranchId).HasColumnName("CompBranchID");

                entity.Property(e => e.AddNo).HasMaxLength(150);

                entity.Property(e => e.Alley).HasMaxLength(100);

                entity.Property(e => e.AmphurCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName).HasMaxLength(150);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Road)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TambolCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.ViilageNo).HasMaxLength(100);
            });

            modelBuilder.Entity<CompBranchArea>(entity =>
            {
                entity.Property(e => e.CompBranchAreaId).HasColumnName("CompBranchAreaID");

                entity.Property(e => e.CompBranchId).HasColumnName("CompBranchID");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CondAssetOutdoor>(entity =>
            {
                entity.HasIndex(e => e.AppraisalInfoId);

                entity.Property(e => e.CondAssetOutdoorId)
                    .HasColumnName("CondAssetOutdoorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.HasOne(d => d.AppraisalInfo)
                    .WithMany(p => p.CondAssetOutdoor)
                    .HasForeignKey(d => d.AppraisalInfoId);
            });

            modelBuilder.Entity<CustomerList>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Cifname).HasColumnName("CIFName");

                entity.Property(e => e.Cifno).HasColumnName("CIFNo");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.CustomerList)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DepartName).HasMaxLength(100);
            });

            modelBuilder.Entity<DocumentList>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.DocumentListId).HasColumnName("DocumentListID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.ReqDocId).HasColumnName("ReqDocID");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.DocumentList)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<Eject>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId)
                    .IsUnique();

                entity.Property(e => e.EjectId).HasColumnName("EjectID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.HasOne(d => d.Appraisal)
                    .WithOne(p => p.Eject)
                    .HasForeignKey<Eject>(d => d.AppraisalId);
            });

            modelBuilder.Entity<FacilityList>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.FacilityListId).HasColumnName("FacilityListID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.FacilityList)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<FileImg>(entity =>
            {
                entity.HasKey(e => e.Imgid);

                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.Imgid).HasColumnName("imgid");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.FileUrl).HasColumnName("fileUrl");

                entity.Property(e => e.Hostdev).HasColumnName("hostdev");

                entity.Property(e => e.Hostpublish).HasColumnName("hostpublish");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Typefile).HasColumnName("typefile");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.FileImg)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<LoanPurpose>(entity =>
            {
                entity.Property(e => e.LoanPurposeId).HasColumnName("LoanPurposeID");
            });

            modelBuilder.Entity<MenuBank>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Child).HasMaxLength(5);

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MenuIcon).HasMaxLength(255);

                entity.Property(e => e.MenuLink).HasMaxLength(255);

                entity.Property(e => e.MenuName).HasMaxLength(150);

                entity.Property(e => e.UserRoleActive).HasMaxLength(30);
            });

            modelBuilder.Entity<MenuCompany>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Child).HasMaxLength(5);

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MenuIcon).HasMaxLength(255);

                entity.Property(e => e.MenuLink).HasMaxLength(255);

                entity.Property(e => e.MenuName).HasMaxLength(150);

                entity.Property(e => e.UserRoleActive).HasMaxLength(30);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKey")
                    .HasMaxLength(30);

                entity.Property(e => e.Apno).HasColumnName("APNo");

                entity.Property(e => e.ApplId).HasColumnName("ApplID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.UserCode).HasMaxLength(20);
            });

            modelBuilder.Entity<NotifyAppraisalRequest>(entity =>
            {
                entity.Property(e => e.Apikey).HasColumnName("APIKey");

                entity.Property(e => e.Apno).HasColumnName("APNo");

                entity.Property(e => e.Cctype).HasColumnName("CCType");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TransId).HasColumnName("TransID");
            });

            modelBuilder.Entity<Progress>(entity =>
            {
                entity.HasKey(e => e.ProgressCode);

                entity.Property(e => e.ProgressCode)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<RoleMenuBank>(entity =>
            {
                entity.HasKey(e => e.RoleMenuId);

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<RoleMenuCom>(entity =>
            {
                entity.HasKey(e => e.RoleMenuId);

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<RolePolicyBank>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllOwn).HasColumnName("All_Own");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(150);
            });

            modelBuilder.Entity<RolePolicyCom>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllOwn).HasColumnName("All_Own");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(150);
            });

            modelBuilder.Entity<RoundRobinComp>(entity =>
            {
                entity.HasKey(e => e.RoundRobinAreaId);

                entity.Property(e => e.RoundRobinAreaId).HasColumnName("RoundRobinAreaID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateRr).HasColumnName("StateRR");
            });

            modelBuilder.Entity<RoundRobinInternal>(entity =>
            {
                entity.HasIndex(e => e.AppraisalTeamId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.RoundRobinInternalId).HasColumnName("RoundRobinInternalID");

                entity.Property(e => e.AppraisalTeamId).HasColumnName("AppraisalTeamID");

                entity.Property(e => e.StateRr).HasColumnName("StateRR");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AppraisalTeam)
                    .WithMany(p => p.RoundRobinInternal)
                    .HasForeignKey(d => d.AppraisalTeamId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoundRobinInternal)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SignName>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.SignNameId).HasColumnName("SignNameID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.SignName)
                    .HasForeignKey(d => d.AppraisalId);
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasIndex(e => e.UserSurvayId);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.UserSurvayId).HasColumnName("UserSurvayID");

                entity.HasOne(d => d.UserSurvay)
                    .WithMany(p => p.Survey)
                    .HasForeignKey(d => d.UserSurvayId);
            });

            modelBuilder.Entity<Tambol>(entity =>
            {
                entity.Property(e => e.TambolId).HasColumnName("TambolID");
            });

            modelBuilder.Entity<UserBank>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AppraisalTeamId).HasColumnName("AppraisalTeamID");

                entity.Property(e => e.Brcode)
                    .HasColumnName("brcode")
                    .HasMaxLength(13);

                entity.Property(e => e.BrofficeCode)
                    .HasColumnName("brofficeCode")
                    .HasMaxLength(10);

                entity.Property(e => e.DepartId)
                    .HasColumnName("DepartID")
                    .HasMaxLength(5);

                entity.Property(e => e.FristName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.ParentUserId)
                    .HasColumnName("ParentUserID")
                    .HasMaxLength(10);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(100);
            });

            modelBuilder.Entity<UserBankRole>(entity =>
            {
                entity.HasKey(e => e.UserBankRoleGroup);

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserBankRole)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBankRole)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.BranchArea).HasMaxLength(13);

                entity.Property(e => e.BranchComp).HasMaxLength(13);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(13);

                entity.Property(e => e.DepartId)
                    .HasColumnName("DepartID")
                    .HasMaxLength(5);

                entity.Property(e => e.FristName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(100);
            });

            modelBuilder.Entity<UserCompRole>(entity =>
            {
                entity.HasKey(e => e.UserCompRoleGroup);

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId)
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserCompRole)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserCompRole)
                    .HasForeignKey<UserCompRole>(d => d.UserId);
            });

            modelBuilder.Entity<UseType>(entity =>
            {
                entity.Property(e => e.UseTypeId).HasColumnName("UseTypeID");

                entity.Property(e => e.UseName).HasMaxLength(150);
            });
        }
    }
}
