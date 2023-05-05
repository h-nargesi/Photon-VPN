using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public partial class RdContext : DbContext
{
    public RdContext()
    {
    }

    public RdContext(DbContextOptions<RdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<Ap> Aps { get; set; }

    public virtual DbSet<ApAction> ApActions { get; set; }

    public virtual DbSet<ApConnectionSetting> ApConnectionSettings { get; set; }

    public virtual DbSet<ApLoad> ApLoads { get; set; }

    public virtual DbSet<ApProfile> ApProfiles { get; set; }

    public virtual DbSet<ApProfileEntry> ApProfileEntries { get; set; }

    public virtual DbSet<ApProfileExit> ApProfileExits { get; set; }

    public virtual DbSet<ApProfileExitApProfileEntry> ApProfileExitApProfileEntries { get; set; }

    public virtual DbSet<ApProfileExitCaptivePortal> ApProfileExitCaptivePortals { get; set; }

    public virtual DbSet<ApProfileExitSetting> ApProfileExitSettings { get; set; }

    public virtual DbSet<ApProfileSetting> ApProfileSettings { get; set; }

    public virtual DbSet<ApProfileSpecific> ApProfileSpecifics { get; set; }

    public virtual DbSet<ApStation> ApStations { get; set; }

    public virtual DbSet<ApSystem> ApSystems { get; set; }

    public virtual DbSet<ApUptmHistory> ApUptmHistories { get; set; }

    public virtual DbSet<ApWifiSetting> ApWifiSettings { get; set; }

    public virtual DbSet<AppliedFupComponent> AppliedFupComponents { get; set; }

    public virtual DbSet<ArMeshDailySummary> ArMeshDailySummaries { get; set; }

    public virtual DbSet<ArNodeIbssConnection> ArNodeIbssConnections { get; set; }

    public virtual DbSet<ArNodeStation> ArNodeStations { get; set; }

    public virtual DbSet<ArNodeUptmHistory> ArNodeUptmHistories { get; set; }

    public virtual DbSet<AutoDevice> AutoDevices { get; set; }

    public virtual DbSet<Check> Checks { get; set; }

    public virtual DbSet<Cloud> Clouds { get; set; }

    public virtual DbSet<CloudAdmin> CloudAdmins { get; set; }

    public virtual DbSet<CloudSetting> CloudSettings { get; set; }

    public virtual DbSet<CoaRequest> CoaRequests { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<DataCollector> DataCollectors { get; set; }

    public virtual DbSet<DataCollectorOtp> DataCollectorOtps { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DynamicClient> DynamicClients { get; set; }

    public virtual DbSet<DynamicClientRealm> DynamicClientRealms { get; set; }

    public virtual DbSet<DynamicClientSetting> DynamicClientSettings { get; set; }

    public virtual DbSet<DynamicClientState> DynamicClientStates { get; set; }

    public virtual DbSet<DynamicDetail> DynamicDetails { get; set; }

    public virtual DbSet<DynamicDetailCtc> DynamicDetailCtcs { get; set; }

    public virtual DbSet<DynamicDetailLanguage> DynamicDetailLanguages { get; set; }

    public virtual DbSet<DynamicDetailMobile> DynamicDetailMobiles { get; set; }

    public virtual DbSet<DynamicDetailPrelogin> DynamicDetailPrelogins { get; set; }

    public virtual DbSet<DynamicDetailSocialLogin> DynamicDetailSocialLogins { get; set; }

    public virtual DbSet<DynamicDetailTransKey> DynamicDetailTransKeys { get; set; }

    public virtual DbSet<DynamicDetailTranslation> DynamicDetailTranslations { get; set; }

    public virtual DbSet<DynamicPage> DynamicPages { get; set; }

    public virtual DbSet<DynamicPair> DynamicPairs { get; set; }

    public virtual DbSet<DynamicPhoto> DynamicPhotos { get; set; }

    public virtual DbSet<DynamicPhotoTranslation> DynamicPhotoTranslations { get; set; }

    public virtual DbSet<EmailHistory> EmailHistories { get; set; }

    public virtual DbSet<EmailMessage> EmailMessages { get; set; }

    public virtual DbSet<ForwardLookup> ForwardLookups { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Hardware> Hardwares { get; set; }

    public virtual DbSet<HardwareRadio> HardwareRadios { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<MacAlias> MacAliases { get; set; }

    public virtual DbSet<MacUsage> MacUsages { get; set; }

    public virtual DbSet<Mesh> Meshes { get; set; }

    public virtual DbSet<MeshDailySummary> MeshDailySummaries { get; set; }

    public virtual DbSet<MeshEntry> MeshEntries { get; set; }

    public virtual DbSet<MeshExit> MeshExits { get; set; }

    public virtual DbSet<MeshExitCaptivePortal> MeshExitCaptivePortals { get; set; }

    public virtual DbSet<MeshExitMeshEntry> MeshExitMeshEntries { get; set; }

    public virtual DbSet<MeshExitSetting> MeshExitSettings { get; set; }

    public virtual DbSet<MeshSetting> MeshSettings { get; set; }

    public virtual DbSet<MeshSpecific> MeshSpecifics { get; set; }

    public virtual DbSet<Na> Nas { get; set; }

    public virtual DbSet<NaRealm> NaRealms { get; set; }

    public virtual DbSet<NaSetting> NaSettings { get; set; }

    public virtual DbSet<NaState> NaStates { get; set; }

    public virtual DbSet<Network> Networks { get; set; }

    public virtual DbSet<NewAccounting> NewAccountings { get; set; }

    public virtual DbSet<Node> Nodes { get; set; }

    public virtual DbSet<NodeAction> NodeActions { get; set; }

    public virtual DbSet<NodeConnectionSetting> NodeConnectionSettings { get; set; }

    public virtual DbSet<NodeIbssConnection> NodeIbssConnections { get; set; }

    public virtual DbSet<NodeIbssConnectionsDaily> NodeIbssConnectionsDailies { get; set; }

    public virtual DbSet<NodeLoad> NodeLoads { get; set; }

    public virtual DbSet<NodeMeshEntry> NodeMeshEntries { get; set; }

    public virtual DbSet<NodeMeshExit> NodeMeshExits { get; set; }

    public virtual DbSet<NodeMpSetting> NodeMpSettings { get; set; }

    public virtual DbSet<NodeNeighbor> NodeNeighbors { get; set; }

    public virtual DbSet<NodeScan> NodeScans { get; set; }

    public virtual DbSet<NodeSetting> NodeSettings { get; set; }

    public virtual DbSet<NodeStation> NodeStations { get; set; }

    public virtual DbSet<NodeStationsDaily> NodeStationsDailies { get; set; }

    public virtual DbSet<NodeSystem> NodeSystems { get; set; }

    public virtual DbSet<NodeUptmHistory> NodeUptmHistories { get; set; }

    public virtual DbSet<NodeWifiSetting> NodeWifiSettings { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OpenvpnClient> OpenvpnClients { get; set; }

    public virtual DbSet<OpenvpnServer> OpenvpnServers { get; set; }

    public virtual DbSet<OpenvpnServerClient> OpenvpnServerClients { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PermanentUser> PermanentUsers { get; set; }

    public virtual DbSet<PermanentUserLog> PermanentUserLogs { get; set; }

    public virtual DbSet<PermanentUserNotification> PermanentUserNotifications { get; set; }

    public virtual DbSet<PermanentUserOtp> PermanentUserOtps { get; set; }

    public virtual DbSet<PermanentUserPlan> PermanentUserPlans { get; set; }

    public virtual DbSet<PermanentUserSetting> PermanentUserSettings { get; set; }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<PptpClient> PptpClients { get; set; }

    public virtual DbSet<PredefinedCommand> PredefinedCommands { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileComponent> ProfileComponents { get; set; }

    public virtual DbSet<ProfileFupComponent> ProfileFupComponents { get; set; }

    public virtual DbSet<Radacct> Radaccts { get; set; }

    public virtual DbSet<Radcheck> Radchecks { get; set; }

    public virtual DbSet<Radgroupcheck> Radgroupchecks { get; set; }

    public virtual DbSet<Radgroupreply> Radgroupreplies { get; set; }

    public virtual DbSet<Radippool> Radippools { get; set; }

    public virtual DbSet<Radpostauth> Radpostauths { get; set; }

    public virtual DbSet<Radreply> Radreplies { get; set; }

    public virtual DbSet<Radusergroup> Radusergroups { get; set; }

    public virtual DbSet<Realm> Realms { get; set; }

    public virtual DbSet<RegistrationRequest> RegistrationRequests { get; set; }

    public virtual DbSet<ReverseLookup> ReverseLookups { get; set; }

    public virtual DbSet<RollingLastDay> RollingLastDays { get; set; }

    public virtual DbSet<RollingLastHour> RollingLastHours { get; set; }

    public virtual DbSet<RollingLastNinetyDay> RollingLastNinetyDays { get; set; }

    public virtual DbSet<RollingLastSevenDay> RollingLastSevenDays { get; set; }

    public virtual DbSet<RollingLastSixtyDay> RollingLastSixtyDays { get; set; }

    public virtual DbSet<RollingLastThirtyDay> RollingLastThirtyDays { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleEntry> ScheduleEntries { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SmsHistory> SmsHistories { get; set; }

    public virtual DbSet<SocialLoginUser> SocialLoginUsers { get; set; }

    public virtual DbSet<SocialLoginUserRealm> SocialLoginUserRealms { get; set; }

    public virtual DbSet<Softflow> Softflows { get; set; }

    public virtual DbSet<TempFlowLog> TempFlowLogs { get; set; }

    public virtual DbSet<TempProxyLog> TempProxyLogs { get; set; }

    public virtual DbSet<TempReport> TempReports { get; set; }

    public virtual DbSet<Timezone> Timezones { get; set; }

    public virtual DbSet<TopUp> TopUps { get; set; }

    public virtual DbSet<TopUpTransaction> TopUpTransactions { get; set; }

    public virtual DbSet<UnknownDynamicClient> UnknownDynamicClients { get; set; }

    public virtual DbSet<UnknownNode> UnknownNodes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserSsid> UserSsids { get; set; }

    public virtual DbSet<UserStat> UserStats { get; set; }

    public virtual DbSet<UserStatsDaily> UserStatsDailies { get; set; }

    public virtual DbSet<UsersAccess> UsersAccesses { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=37.32.9.55;uid=photon;pwd=znf42CYfWhA3st7w;database=rd;Convert Zero Datetime=True", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.12-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("accounts");

            entity.HasIndex(e => e.PermanentUserId, "permanent_user_id").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.PermanentUser).WithOne(p => p.Account)
                .HasForeignKey<Account>(d => d.PermanentUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("accounts_ibfk_1");
        });

        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("actions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action1)
                .HasDefaultValueSql("'execute'")
                .HasColumnType("enum('execute')")
                .HasColumnName("action");
            entity.Property(e => e.Command)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("command");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId)
                .HasColumnType("int(10)")
                .HasColumnName("na_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("alerts")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Acknowledged)
                .HasColumnType("datetime")
                .HasColumnName("acknowledged");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Detected)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("detected");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Resolved)
                .HasColumnType("datetime")
                .HasColumnName("resolved");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Ap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("aps")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.ConfigFetched)
                .HasColumnType("datetime")
                .HasColumnName("config_fetched");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EnableAlerts)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_alerts");
            entity.Property(e => e.EnableOverviews)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_overviews");
            entity.Property(e => e.EnableSchedules).HasColumnName("enable_schedules");
            entity.Property(e => e.Gateway)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','lan','3g','wifi','wifi_static','wifi_ppp','wifi_pppoe','wan_static','wan_ppp','wan_pppoe')")
                .HasColumnName("gateway");
            entity.Property(e => e.Hardware)
                .HasMaxLength(255)
                .HasColumnName("hardware");
            entity.Property(e => e.LanGw)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_gw");
            entity.Property(e => e.LanIp)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_ip");
            entity.Property(e => e.LanProto)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_proto");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.LastContactFromIp)
                .HasMaxLength(255)
                .HasColumnName("last_contact_from_ip");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OnPublicMaps).HasColumnName("on_public_maps");
            entity.Property(e => e.PhotoFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("photo_file_name");
            entity.Property(e => e.RebootFlag).HasColumnName("reboot_flag");
            entity.Property(e => e.ScheduleId)
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<ApAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_actions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'execute'")
                .HasColumnType("enum('execute','execute_and_reply')")
                .HasColumnName("action");
            entity.Property(e => e.ApId)
                .HasColumnType("int(10)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Command)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("command");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Reply)
                .HasColumnType("text")
                .HasColumnName("reply");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ApConnectionSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_connection_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Grouping)
                .HasMaxLength(25)
                .HasColumnName("grouping");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(40)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ApLoad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_loads")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Load1)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_1");
            entity.Property(e => e.Load2)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_2");
            entity.Property(e => e.Load3)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_3");
            entity.Property(e => e.MemFree)
                .HasColumnType("int(11)")
                .HasColumnName("mem_free");
            entity.Property(e => e.MemTotal)
                .HasColumnType("int(11)")
                .HasColumnName("mem_total");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.SystemTime)
                .HasMaxLength(255)
                .HasColumnName("system_time");
            entity.Property(e => e.Uptime)
                .HasMaxLength(255)
                .HasColumnName("uptime");
        });

        modelBuilder.Entity<ApProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profiles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EnableAlerts)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_alerts");
            entity.Property(e => e.EnableOverviews)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_overviews");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ApProfileEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Accounting)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("accounting");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.AuthSecret)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("auth_secret");
            entity.Property(e => e.AuthServer)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("auth_server");
            entity.Property(e => e.AutoNasid).HasColumnName("auto_nasid");
            entity.Property(e => e.ChkMaxassoc).HasColumnName("chk_maxassoc");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DefaultKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("'12345678'")
                .HasColumnName("default_key");
            entity.Property(e => e.DefaultVlan)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(10)")
                .HasColumnName("default_vlan");
            entity.Property(e => e.DynamicVlan).HasColumnName("dynamic_vlan");
            entity.Property(e => e.Encryption)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','wep','psk','psk2','wpa','wpa2','ppsk')")
                .HasColumnName("encryption");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'both'")
                .HasColumnType("enum('both','two','five','five_upper','five_lower')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Isolate).HasColumnName("isolate");
            entity.Property(e => e.Macfilter)
                .HasDefaultValueSql("'disable'")
                .HasColumnType("enum('disable','allow','deny')")
                .HasColumnName("macfilter");
            entity.Property(e => e.Maxassoc)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(6)")
                .HasColumnName("maxassoc");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Nasid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("nasid");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.SpecialKey)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("special_key");
        });

        modelBuilder.Entity<ApProfileExit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_exits")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.AutoDynamicClient).HasColumnName("auto_dynamic_client");
            entity.Property(e => e.AutoLoginPage).HasColumnName("auto_login_page");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Dns1)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dns_1");
            entity.Property(e => e.Dns2)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dns_2");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Gateway)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("gateway");
            entity.Property(e => e.Ipaddr)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("ipaddr");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Netmask)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("netmask");
            entity.Property(e => e.OpenvpnServerId)
                .HasColumnType("int(11)")
                .HasColumnName("openvpn_server_id");
            entity.Property(e => e.Proto)
                .HasDefaultValueSql("'dhcp'")
                .HasColumnType("enum('static','dhcp','dhcpv6')")
                .HasColumnName("proto");
            entity.Property(e => e.RealmList)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("realm_list");
            entity.Property(e => e.Type)
                .HasColumnType("enum('bridge','tagged_bridge','nat','captive_portal','openvpn_bridge','tagged_bridge_l3')")
                .HasColumnName("type");
            entity.Property(e => e.Vlan)
                .HasColumnType("int(4)")
                .HasColumnName("vlan");
        });

        modelBuilder.Entity<ApProfileExitApProfileEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_exit_ap_profile_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_entry_id");
            entity.Property(e => e.ApProfileExitId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_exit_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<ApProfileExitCaptivePortal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_exit_captive_portals")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileExitId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_exit_id");
            entity.Property(e => e.ApProfileExitUpstreamId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_exit_upstream_id");
            entity.Property(e => e.CoovaOptional)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("coova_optional");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Dns1)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("dns1");
            entity.Property(e => e.Dns2)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("dns2");
            entity.Property(e => e.DnsManual).HasColumnName("dns_manual");
            entity.Property(e => e.Dnsdesk).HasColumnName("dnsdesk");
            entity.Property(e => e.Dnsparanoia).HasColumnName("dnsparanoia");
            entity.Property(e => e.MacAuth).HasColumnName("mac_auth");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ProxyAuthPassword)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_auth_password");
            entity.Property(e => e.ProxyAuthUsername)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_auth_username");
            entity.Property(e => e.ProxyEnable).HasColumnName("proxy_enable");
            entity.Property(e => e.ProxyIp)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_ip");
            entity.Property(e => e.ProxyPort)
                .HasDefaultValueSql("'3128'")
                .HasColumnType("int(11)")
                .HasColumnName("proxy_port");
            entity.Property(e => e.Radius1)
                .HasMaxLength(128)
                .HasColumnName("radius_1");
            entity.Property(e => e.Radius2)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("radius_2");
            entity.Property(e => e.RadiusNasid)
                .HasMaxLength(128)
                .HasColumnName("radius_nasid");
            entity.Property(e => e.RadiusSecret)
                .HasMaxLength(128)
                .HasColumnName("radius_secret");
            entity.Property(e => e.SoftflowdEnabled).HasColumnName("softflowd_enabled");
            entity.Property(e => e.SwapOctets).HasColumnName("swap_octets");
            entity.Property(e => e.UamSecret)
                .HasMaxLength(255)
                .HasColumnName("uam_secret");
            entity.Property(e => e.UamUrl)
                .HasMaxLength(255)
                .HasColumnName("uam_url");
            entity.Property(e => e.Uamanydns).HasColumnName("uamanydns");
            entity.Property(e => e.WalledGarden)
                .HasMaxLength(255)
                .HasColumnName("walled_garden");
        });

        modelBuilder.Entity<ApProfileExitSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_exit_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileExitId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_exit_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ApProfileSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.Country)
                .HasMaxLength(5)
                .HasDefaultValueSql("'US'")
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EnableSchedules).HasColumnName("enable_schedules");
            entity.Property(e => e.GwAutoReboot)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("gw_auto_reboot");
            entity.Property(e => e.GwAutoRebootTime)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("gw_auto_reboot_time");
            entity.Property(e => e.GwDhcpTimeout)
                .HasDefaultValueSql("'120'")
                .HasColumnType("int(5)")
                .HasColumnName("gw_dhcp_timeout");
            entity.Property(e => e.GwUsePrevious)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("gw_use_previous");
            entity.Property(e => e.HeartbeatDeadAfter)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("heartbeat_dead_after");
            entity.Property(e => e.HeartbeatInterval)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("heartbeat_interval");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("password_hash");
            entity.Property(e => e.ReportAdvEnable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("report_adv_enable");
            entity.Property(e => e.ReportAdvFull)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_full");
            entity.Property(e => e.ReportAdvLight)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_light");
            entity.Property(e => e.ReportAdvProto)
                .HasDefaultValueSql("'http'")
                .HasColumnType("enum('https','http')")
                .HasColumnName("report_adv_proto");
            entity.Property(e => e.ReportAdvSampling)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_sampling");
            entity.Property(e => e.ScheduleId)
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
            entity.Property(e => e.Syslog1Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog1_ip");
            entity.Property(e => e.Syslog1Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog1_port");
            entity.Property(e => e.Syslog2Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog2_ip");
            entity.Property(e => e.Syslog2Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog2_port");
            entity.Property(e => e.Syslog3Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog3_ip");
            entity.Property(e => e.Syslog3Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog3_port");
            entity.Property(e => e.TzName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'America/New York'")
                .HasColumnName("tz_name");
            entity.Property(e => e.TzValue)
                .HasMaxLength(128)
                .HasDefaultValueSql("'EST5EDT,M3.2.0,M11.1.0'")
                .HasColumnName("tz_value");
            entity.Property(e => e.VlanEnable).HasColumnName("vlan_enable");
            entity.Property(e => e.VlanEnd)
                .HasDefaultValueSql("'101'")
                .HasColumnType("int(10)")
                .HasColumnName("vlan_end");
            entity.Property(e => e.VlanList)
                .HasMaxLength(255)
                .HasDefaultValueSql("'100'")
                .HasColumnName("vlan_list");
            entity.Property(e => e.VlanRangeOrList)
                .HasDefaultValueSql("'range'")
                .HasColumnType("enum('range','list')")
                .HasColumnName("vlan_range_or_list");
            entity.Property(e => e.VlanStart)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(10)")
                .HasColumnName("vlan_start");
        });

        modelBuilder.Entity<ApProfileSpecific>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_profile_specifics")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ApStation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_stations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.ApId, "idx_ap_stations_ap_id");

            entity.HasIndex(e => e.ApProfileEntryId, "idx_ap_stations_ap_profile_entry_id");

            entity.HasIndex(e => e.Modified, "idx_ap_stations_modified");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApProfileEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_entry_id");
            entity.Property(e => e.Authenticated)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authenticated");
            entity.Property(e => e.Authorized)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authorized");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Mfp)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("mfp");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Preamble)
                .HasMaxLength(255)
                .HasColumnName("preamble");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("tinyint(3)")
                .HasColumnName("radio_number");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.RxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_packets");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(11)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.SignalNow)
                .HasColumnType("int(11)")
                .HasColumnName("signal_now");
            entity.Property(e => e.TdlsPeer)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("tdls_peer");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
            entity.Property(e => e.TxFailed)
                .HasColumnType("int(11)")
                .HasColumnName("tx_failed");
            entity.Property(e => e.TxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_packets");
            entity.Property(e => e.TxRetries)
                .HasColumnType("int(11)")
                .HasColumnName("tx_retries");
            entity.Property(e => e.WmmWme)
                .HasColumnType("tinyint(2)")
                .HasColumnName("wmm_wme");
        });

        modelBuilder.Entity<ApSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_systems")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ApUptmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_uptm_histories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApState).HasColumnName("ap_state");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ReportDatetime)
                .HasColumnType("datetime")
                .HasColumnName("report_datetime");
            entity.Property(e => e.StateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("state_datetime");
        });

        modelBuilder.Entity<ApWifiSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ap_wifi_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<AppliedFupComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("applied_fup_components")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ProfileFupComponentId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_fup_component_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ArMeshDailySummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ar_mesh_daily_summaries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_ar_mesh_daily_summaries_mesh_id");

            entity.HasIndex(e => new { e.MeshId, e.TheDate }, "idx_ar_mesh_daily_summaries_mesh_id_the_date").IsUnique();

            entity.HasIndex(e => e.MeshName, "idx_ar_mesh_daily_summaries_mesh_name");

            entity.HasIndex(e => e.TheDate, "idx_ar_mesh_daily_summaries_the_date");

            entity.HasIndex(e => e.TreeTagId, "idx_ar_mesh_daily_summaries_tree_tag_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.MaxClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_clients");
            entity.Property(e => e.MaxDualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_dual_radios");
            entity.Property(e => e.MaxLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_lv_nodes");
            entity.Property(e => e.MaxLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_lv_nodes_down");
            entity.Property(e => e.MaxNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes");
            entity.Property(e => e.MaxNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes_down");
            entity.Property(e => e.MaxNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes_up");
            entity.Property(e => e.MaxSingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_single_radios");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.MinClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_clients");
            entity.Property(e => e.MinDualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_dual_radios");
            entity.Property(e => e.MinLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_lv_nodes");
            entity.Property(e => e.MinLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_lv_nodes_down");
            entity.Property(e => e.MinNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes");
            entity.Property(e => e.MinNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes_down");
            entity.Property(e => e.MinNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes_up");
            entity.Property(e => e.MinSingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_single_radios");
            entity.Property(e => e.TheDate).HasColumnName("the_date");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<ArNodeIbssConnection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ar_node_ibss_connections")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Mac, "idx_ar_node_ibss_connections_mac");

            entity.HasIndex(e => e.Modified, "idx_ar_node_ibss_connections_modified");

            entity.HasIndex(e => e.NodeId, "idx_ar_node_ibss_connections_node_id");

            entity.HasIndex(e => e.StationNodeId, "idx_ar_node_ibss_connections_station_node_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Authenticated)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("authenticated");
            entity.Property(e => e.Authorized)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("authorized");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.InactiveTime)
                .HasColumnType("int(11)")
                .HasColumnName("inactive_time");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Mfp)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("MFP");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Preamble)
                .HasDefaultValueSql("'long'")
                .HasColumnType("enum('long','short')")
                .HasColumnName("preamble");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.RxExtraInfo)
                .HasMaxLength(255)
                .HasColumnName("rx_extra_info");
            entity.Property(e => e.RxPackets)
                .HasColumnType("int(11)")
                .HasColumnName("rx_packets");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(11)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.SignalNow)
                .HasColumnType("int(11)")
                .HasColumnName("signal_now");
            entity.Property(e => e.StationNodeId)
                .HasColumnType("int(11)")
                .HasColumnName("station_node_id");
            entity.Property(e => e.TdlsPeer)
                .HasMaxLength(255)
                .HasColumnName("tdls_peer");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
            entity.Property(e => e.TxExtraInfo)
                .HasMaxLength(255)
                .HasColumnName("tx_extra_info");
            entity.Property(e => e.TxFailed)
                .HasColumnType("int(11)")
                .HasColumnName("tx_failed");
            entity.Property(e => e.TxPackets)
                .HasColumnType("int(11)")
                .HasColumnName("tx_packets");
            entity.Property(e => e.TxRetries)
                .HasColumnType("int(11)")
                .HasColumnName("tx_retries");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
            entity.Property(e => e.WmmWme)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("WMM_WME");
        });

        modelBuilder.Entity<ArNodeStation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ar_node_stations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Mac, "idx_ar_node_stations_mac");

            entity.HasIndex(e => e.MeshEntryId, "idx_ar_node_stations_mesh_entry_id");

            entity.HasIndex(e => e.Modified, "idx_ar_node_stations_modified");

            entity.HasIndex(e => e.NodeId, "idx_ar_node_stations_node_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Authenticated)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("authenticated");
            entity.Property(e => e.Authorized)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("authorized");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.InactiveTime)
                .HasColumnType("int(11)")
                .HasColumnName("inactive_time");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.MeshEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_entry_id");
            entity.Property(e => e.Mfp)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("MFP");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Preamble)
                .HasDefaultValueSql("'long'")
                .HasColumnType("enum('long','short')")
                .HasColumnName("preamble");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.RxExtraInfo)
                .HasMaxLength(255)
                .HasColumnName("rx_extra_info");
            entity.Property(e => e.RxPackets)
                .HasColumnType("int(11)")
                .HasColumnName("rx_packets");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(11)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.SignalNow)
                .HasColumnType("int(11)")
                .HasColumnName("signal_now");
            entity.Property(e => e.TdlsPeer)
                .HasMaxLength(255)
                .HasColumnName("tdls_peer");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
            entity.Property(e => e.TxExtraInfo)
                .HasMaxLength(255)
                .HasColumnName("tx_extra_info");
            entity.Property(e => e.TxFailed)
                .HasColumnType("int(11)")
                .HasColumnName("tx_failed");
            entity.Property(e => e.TxPackets)
                .HasColumnType("int(11)")
                .HasColumnName("tx_packets");
            entity.Property(e => e.TxRetries)
                .HasColumnType("int(11)")
                .HasColumnName("tx_retries");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
            entity.Property(e => e.WmmWme)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("WMM_WME");
        });

        modelBuilder.Entity<ArNodeUptmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("ar_node_uptm_histories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_ar_node_uptm_histories_modified");

            entity.HasIndex(e => e.NodeId, "idx_ar_node_uptm_histories_node_id");

            entity.HasIndex(e => e.NodeState, "idx_ar_node_uptm_histories_node_state");

            entity.HasIndex(e => e.ReportDatetime, "idx_ar_node_uptm_histories_report_datetime");

            entity.HasIndex(e => e.StateDatetime, "idx_ar_node_uptm_histories_state_datetime");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.NodeState).HasColumnName("node_state");
            entity.Property(e => e.ReportDatetime)
                .HasColumnType("datetime")
                .HasColumnName("report_datetime");
            entity.Property(e => e.StateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("state_datetime");
        });

        modelBuilder.Entity<AutoDevice>(entity =>
        {
            entity.HasKey(e => e.Mac).HasName("PRIMARY");

            entity
                .ToTable("auto_devices")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Check>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("checks")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Cloud>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("clouds")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Lat)
                .HasPrecision(11, 8)
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasPrecision(11, 8)
                .HasColumnName("lng");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<CloudAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cloud_admins")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<CloudSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cloud_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CloudId, "idx_cloud_settings_cloud_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<CoaRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("coa_requests")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AvpJson)
                .HasColumnType("text")
                .HasColumnName("avp_json");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.MultipleGateways).HasColumnName("multiple_gateways");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.RequestType)
                .HasDefaultValueSql("'coa'")
                .HasColumnType("enum('coa','pod')")
                .HasColumnName("request_type");
            entity.Property(e => e.Result)
                .HasColumnType("text")
                .HasColumnName("result");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("countries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Alpha2Code)
                .HasMaxLength(2)
                .HasColumnName("alpha_2_code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DataCollector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("data_collectors")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("birthday");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("company");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.CpMac)
                .HasMaxLength(36)
                .HasColumnName("cp_mac");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Custom1)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("custom1");
            entity.Property(e => e.Custom2)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("custom2");
            entity.Property(e => e.Custom3)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("custom3");
            entity.Property(e => e.Dn)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("dn");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailOptIn).HasColumnName("email_opt_in");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasDefaultValueSql("'not_recorded'")
                .HasColumnType("enum('male','female','not_recorded')")
                .HasColumnName("gender");
            entity.Property(e => e.IsMobile).HasColumnName("is_mobile");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("last_name");
            entity.Property(e => e.Mac)
                .HasMaxLength(36)
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Nasid)
                .HasMaxLength(255)
                .HasColumnName("nasid");
            entity.Property(e => e.Phone)
                .HasMaxLength(36)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.PhoneOptIn).HasColumnName("phone_opt_in");
            entity.Property(e => e.PublicIp)
                .HasMaxLength(36)
                .HasColumnName("public_ip");
            entity.Property(e => e.Room)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("room");
            entity.Property(e => e.Ssid)
                .HasMaxLength(255)
                .HasColumnName("ssid");
        });

        modelBuilder.Entity<DataCollectorOtp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("data_collector_otps")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataCollectorId)
                .HasColumnType("int(11)")
                .HasColumnName("data_collector_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'otp_awaiting'")
                .HasColumnType("enum('otp_awaiting','otp_confirmed')")
                .HasColumnName("status");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("devices")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataCap)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_cap");
            entity.Property(e => e.DataCapType)
                .HasDefaultValueSql("'soft'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("data_cap_type");
            entity.Property(e => e.DataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_used");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.LastAcceptNas)
                .HasMaxLength(128)
                .HasColumnName("last_accept_nas");
            entity.Property(e => e.LastAcceptTime)
                .HasColumnType("datetime")
                .HasColumnName("last_accept_time");
            entity.Property(e => e.LastRejectMessage)
                .HasMaxLength(255)
                .HasColumnName("last_reject_message");
            entity.Property(e => e.LastRejectNas)
                .HasMaxLength(128)
                .HasColumnName("last_reject_nas");
            entity.Property(e => e.LastRejectTime)
                .HasColumnType("datetime")
                .HasColumnName("last_reject_time");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PercDataUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_data_used");
            entity.Property(e => e.PercTimeUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_time_used");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Profile)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("profile");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.Realm)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.TimeCap)
                .HasColumnType("int(12)")
                .HasColumnName("time_cap");
            entity.Property(e => e.TimeCapType)
                .HasDefaultValueSql("'soft'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("time_cap_type");
            entity.Property(e => e.TimeUsed)
                .HasColumnType("int(12)")
                .HasColumnName("time_used");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
        });

        modelBuilder.Entity<DynamicClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_clients")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Calledstationid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("calledstationid");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DailyDataLimitActive).HasColumnName("daily_data_limit_active");
            entity.Property(e => e.DailyDataLimitAmount)
                .HasDefaultValueSql("'1.000'")
                .HasColumnType("float(14,3)")
                .HasColumnName("daily_data_limit_amount");
            entity.Property(e => e.DailyDataLimitCap)
                .HasDefaultValueSql("'hard'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("daily_data_limit_cap");
            entity.Property(e => e.DailyDataLimitResetHour)
                .HasColumnType("int(3)")
                .HasColumnName("daily_data_limit_reset_hour");
            entity.Property(e => e.DailyDataLimitResetMinute)
                .HasColumnType("int(3)")
                .HasColumnName("daily_data_limit_reset_minute");
            entity.Property(e => e.DailyDataLimitUnit)
                .HasDefaultValueSql("'mb'")
                .HasColumnType("enum('kb','mb','gb','tb')")
                .HasColumnName("daily_data_limit_unit");
            entity.Property(e => e.DailyDataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("daily_data_used");
            entity.Property(e => e.DataLimitActive).HasColumnName("data_limit_active");
            entity.Property(e => e.DataLimitAmount)
                .HasDefaultValueSql("'1.000'")
                .HasColumnType("float(14,3)")
                .HasColumnName("data_limit_amount");
            entity.Property(e => e.DataLimitCap)
                .HasDefaultValueSql("'hard'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("data_limit_cap");
            entity.Property(e => e.DataLimitResetHour)
                .HasColumnType("int(3)")
                .HasColumnName("data_limit_reset_hour");
            entity.Property(e => e.DataLimitResetMinute)
                .HasColumnType("int(3)")
                .HasColumnName("data_limit_reset_minute");
            entity.Property(e => e.DataLimitResetOn)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(3)")
                .HasColumnName("data_limit_reset_on");
            entity.Property(e => e.DataLimitUnit)
                .HasDefaultValueSql("'mb'")
                .HasColumnType("enum('kb','mb','gb','tb')")
                .HasColumnName("data_limit_unit");
            entity.Property(e => e.DataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_used");
            entity.Property(e => e.DefaultKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("'12345678'")
                .HasColumnName("default_key");
            entity.Property(e => e.DefaultVlan)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(10)")
                .HasColumnName("default_vlan");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.LastContactIp)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("last_contact_ip");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Monitor)
                .HasDefaultValueSql("'off'")
                .HasColumnType("enum('off','heartbeat','socket')")
                .HasColumnName("monitor");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.OnPublicMaps).HasColumnName("on_public_maps");
            entity.Property(e => e.PhotoFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("photo_file_name");
            entity.Property(e => e.SessionAutoClose).HasColumnName("session_auto_close");
            entity.Property(e => e.SessionDeadTime)
                .HasDefaultValueSql("'3600'")
                .HasColumnType("int(5)")
                .HasColumnName("session_dead_time");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("timezone");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasDefaultValueSql("'other'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<DynamicClientRealm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_client_realms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicClientId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_client_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
        });

        modelBuilder.Entity<DynamicClientSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_client_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicClientId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_client_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<DynamicClientState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_client_states")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicClientId).HasColumnName("dynamic_client_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<DynamicDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_details")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AutoSuffix)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("auto_suffix");
            entity.Property(e => e.AutoSuffixCheck).HasColumnName("auto_suffix_check");
            entity.Property(e => e.AvailableLanguages)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("available_languages");
            entity.Property(e => e.Cell)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .HasColumnName("cell");
            entity.Property(e => e.ChilliJsonUnavailable).HasColumnName("chilli_json_unavailable");
            entity.Property(e => e.ChilliUseChap).HasColumnName("chilli_use_chap");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.ConnectCheck).HasColumnName("connect_check");
            entity.Property(e => e.ConnectDelay)
                .HasColumnType("int(3)")
                .HasColumnName("connect_delay");
            entity.Property(e => e.ConnectOnly).HasColumnName("connect_only");
            entity.Property(e => e.ConnectSuffix)
                .HasMaxLength(50)
                .HasDefaultValueSql("'nasid'")
                .IsFixedLength()
                .HasColumnName("connect_suffix");
            entity.Property(e => e.ConnectUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("connect_username");
            entity.Property(e => e.CoovaDesktopUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("coova_desktop_url");
            entity.Property(e => e.CoovaMobileUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("coova_mobile_url");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CtcEmailOptIn).HasColumnName("ctc_email_opt_in");
            entity.Property(e => e.CtcEmailOptInTxt)
                .HasMaxLength(200)
                .HasDefaultValueSql("'Send Promotional Email'")
                .HasColumnName("ctc_email_opt_in_txt");
            entity.Property(e => e.CtcPhoneOptIn).HasColumnName("ctc_phone_opt_in");
            entity.Property(e => e.CtcPhoneOptInTxt)
                .HasMaxLength(200)
                .HasDefaultValueSql("'Send Promotional SMS'")
                .HasColumnName("ctc_phone_opt_in_txt");
            entity.Property(e => e.CtcRequireEmail).HasColumnName("ctc_require_email");
            entity.Property(e => e.CtcResupplyEmailInterval)
                .HasColumnType("int(4)")
                .HasColumnName("ctc_resupply_email_interval");
            entity.Property(e => e.DefaultLanguage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("default_language");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .HasColumnName("fax");
            entity.Property(e => e.IconFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("icon_file_name");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.LostPassword).HasColumnName("lost_password");
            entity.Property(e => e.LostPasswordMethod)
                .HasDefaultValueSql("'email'")
                .HasColumnType("enum('email','sms')")
                .HasColumnName("lost_password_method");
            entity.Property(e => e.MikrotikDesktopUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mikrotik_desktop_url");
            entity.Property(e => e.MikrotikMobileUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mikrotik_mobile_url");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NameColour)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name_colour");
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.RedirectCheck).HasColumnName("redirect_check");
            entity.Property(e => e.RedirectUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("redirect_url");
            entity.Property(e => e.RegAutoAdd).HasColumnName("reg_auto_add");
            entity.Property(e => e.RegAutoSuffix)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("reg_auto_suffix");
            entity.Property(e => e.RegAutoSuffixCheck).HasColumnName("reg_auto_suffix_check");
            entity.Property(e => e.RegEmail).HasColumnName("reg_email");
            entity.Property(e => e.RegMacCheck).HasColumnName("reg_mac_check");
            entity.Property(e => e.RegOtpEmail).HasColumnName("reg_otp_email");
            entity.Property(e => e.RegOtpSms).HasColumnName("reg_otp_sms");
            entity.Property(e => e.RegisterUsers).HasColumnName("register_users");
            entity.Property(e => e.SecondsPerSlide)
                .HasDefaultValueSql("'30'")
                .HasColumnType("int(3)")
                .HasColumnName("seconds_per_slide");
            entity.Property(e => e.ShowLogo)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show_logo");
            entity.Property(e => e.ShowName)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("show_name");
            entity.Property(e => e.ShowScreenDelay)
                .HasColumnType("int(4)")
                .HasColumnName("show_screen_delay");
            entity.Property(e => e.SlideshowCheck).HasColumnName("slideshow_check");
            entity.Property(e => e.SlideshowEnforceSeconds)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(4)")
                .HasColumnName("slideshow_enforce_seconds");
            entity.Property(e => e.SlideshowEnforceWatching)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("slideshow_enforce_watching");
            entity.Property(e => e.SocialEnable).HasColumnName("social_enable");
            entity.Property(e => e.SocialTempPermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("social_temp_permanent_user_id");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("street");
            entity.Property(e => e.StreetNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("street_no");
            entity.Property(e => e.TCCheck).HasColumnName("t_c_check");
            entity.Property(e => e.TCUrl)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("t_c_url");
            entity.Property(e => e.Theme)
                .HasMaxLength(200)
                .HasDefaultValueSql("'Default'")
                .IsFixedLength()
                .HasColumnName("theme");
            entity.Property(e => e.TownSuburb)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("town_suburb");
            entity.Property(e => e.Url)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.UsageRefreshInterval)
                .HasDefaultValueSql("'120'")
                .HasColumnType("int(3)")
                .HasColumnName("usage_refresh_interval");
            entity.Property(e => e.UsageShowCheck)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("usage_show_check");
            entity.Property(e => e.UserLoginCheck)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("user_login_check");
            entity.Property(e => e.VoucherLoginCheck).HasColumnName("voucher_login_check");
        });

        modelBuilder.Entity<DynamicDetailCtc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_ctcs")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CiAddress).HasColumnName("ci_address");
            entity.Property(e => e.CiAddressRequired).HasColumnName("ci_address_required");
            entity.Property(e => e.CiBirthday).HasColumnName("ci_birthday");
            entity.Property(e => e.CiBirthdayRequired).HasColumnName("ci_birthday_required");
            entity.Property(e => e.CiCity).HasColumnName("ci_city");
            entity.Property(e => e.CiCityRequired).HasColumnName("ci_city_required");
            entity.Property(e => e.CiCompany).HasColumnName("ci_company");
            entity.Property(e => e.CiCompanyRequired).HasColumnName("ci_company_required");
            entity.Property(e => e.CiCountry).HasColumnName("ci_country");
            entity.Property(e => e.CiCountryRequired).HasColumnName("ci_country_required");
            entity.Property(e => e.CiCustom1).HasColumnName("ci_custom1");
            entity.Property(e => e.CiCustom1Required).HasColumnName("ci_custom1_required");
            entity.Property(e => e.CiCustom1Txt)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Custom One'")
                .IsFixedLength()
                .HasColumnName("ci_custom1_txt");
            entity.Property(e => e.CiCustom2).HasColumnName("ci_custom2");
            entity.Property(e => e.CiCustom2Required).HasColumnName("ci_custom2_required");
            entity.Property(e => e.CiCustom2Txt)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Custom Two'")
                .IsFixedLength()
                .HasColumnName("ci_custom2_txt");
            entity.Property(e => e.CiCustom3).HasColumnName("ci_custom3");
            entity.Property(e => e.CiCustom3Required).HasColumnName("ci_custom3_required");
            entity.Property(e => e.CiCustom3Txt)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Custom Three'")
                .IsFixedLength()
                .HasColumnName("ci_custom3_txt");
            entity.Property(e => e.CiEmail).HasColumnName("ci_email");
            entity.Property(e => e.CiEmailOptIn).HasColumnName("ci_email_opt_in");
            entity.Property(e => e.CiEmailOptInTxt)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Send Promotional Email'")
                .IsFixedLength()
                .HasColumnName("ci_email_opt_in_txt");
            entity.Property(e => e.CiEmailOtp).HasColumnName("ci_email_otp");
            entity.Property(e => e.CiEmailRequired).HasColumnName("ci_email_required");
            entity.Property(e => e.CiFirstName).HasColumnName("ci_first_name");
            entity.Property(e => e.CiFirstNameRequired).HasColumnName("ci_first_name_required");
            entity.Property(e => e.CiGender).HasColumnName("ci_gender");
            entity.Property(e => e.CiGenderRequired).HasColumnName("ci_gender_required");
            entity.Property(e => e.CiLastName).HasColumnName("ci_last_name");
            entity.Property(e => e.CiLastNameRequired).HasColumnName("ci_last_name_required");
            entity.Property(e => e.CiPhone).HasColumnName("ci_phone");
            entity.Property(e => e.CiPhoneOptIn).HasColumnName("ci_phone_opt_in");
            entity.Property(e => e.CiPhoneOptInTxt)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Send Promotional SMS'")
                .IsFixedLength()
                .HasColumnName("ci_phone_opt_in_txt");
            entity.Property(e => e.CiPhoneOtp).HasColumnName("ci_phone_otp");
            entity.Property(e => e.CiPhoneRequired).HasColumnName("ci_phone_required");
            entity.Property(e => e.CiResupplyInterval)
                .HasColumnType("int(4)")
                .HasColumnName("ci_resupply_interval");
            entity.Property(e => e.CiRoom).HasColumnName("ci_room");
            entity.Property(e => e.CiRoomRequired).HasColumnName("ci_room_required");
            entity.Property(e => e.ConnectCheck).HasColumnName("connect_check");
            entity.Property(e => e.ConnectDelay)
                .HasColumnType("int(3)")
                .HasColumnName("connect_delay");
            entity.Property(e => e.ConnectOnly).HasColumnName("connect_only");
            entity.Property(e => e.ConnectSuffix)
                .HasMaxLength(50)
                .HasDefaultValueSql("'nasid'")
                .IsFixedLength()
                .HasColumnName("connect_suffix");
            entity.Property(e => e.ConnectUsername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("connect_username");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CustInfoCheck).HasColumnName("cust_info_check");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<DynamicDetailLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_languages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(5)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.IsoCode)
                .HasMaxLength(2)
                .HasColumnName("iso_code");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Rtl).HasColumnName("rtl");
        });

        modelBuilder.Entity<DynamicDetailMobile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_mobiles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AndroidContent)
                .HasDefaultValueSql("''")
                .HasColumnType("text")
                .HasColumnName("android_content");
            entity.Property(e => e.AndroidEnable).HasColumnName("android_enable");
            entity.Property(e => e.AndroidHref)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("android_href");
            entity.Property(e => e.AndroidText)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("android_text");
            entity.Property(e => e.AppleContent)
                .HasDefaultValueSql("''")
                .HasColumnType("text")
                .HasColumnName("apple_content");
            entity.Property(e => e.AppleEnable).HasColumnName("apple_enable");
            entity.Property(e => e.AppleHref)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("apple_href");
            entity.Property(e => e.AppleText)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("apple_text");
            entity.Property(e => e.Content)
                .HasDefaultValueSql("''")
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.MobileOnly).HasColumnName("mobile_only");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<DynamicDetailPrelogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_prelogins")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Mac)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Nasid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasid");
        });

        modelBuilder.Entity<DynamicDetailSocialLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_social_logins")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.RecordInfo).HasColumnName("record_info");
            entity.Property(e => e.Secret)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("secret");
            entity.Property(e => e.SpecialKey)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("special_key");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'voucher'")
                .HasColumnType("enum('voucher','user')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<DynamicDetailTransKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_trans_keys")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(5)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasDefaultValueSql("-1")
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DynamicDetailTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_detail_translations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailLanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_language_id");
            entity.Property(e => e.DynamicDetailTransKeyId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_trans_key_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<DynamicPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_pages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.DynamicDetailLanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_language_id");
            entity.Property(e => e.Language)
                .HasMaxLength(20)
                .HasDefaultValueSql("'en'")
                .HasColumnName("language");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<DynamicPair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_pairs")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("priority");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<DynamicPhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_photos")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Title, "title");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.BackgroundColor)
                .HasMaxLength(7)
                .HasDefaultValueSql("'ffffff'")
                .HasColumnName("background_color");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DynamicDetailId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_id");
            entity.Property(e => e.FileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("file_name");
            entity.Property(e => e.Fit)
                .HasDefaultValueSql("'stretch_to_fit'")
                .HasColumnType("enum('stretch_to_fit','horizontal','vertical','original','dynamic')")
                .HasColumnName("fit");
            entity.Property(e => e.IncludeDescription)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("include_description");
            entity.Property(e => e.IncludeTitle)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("include_title");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.SlideDuration)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(4)")
                .HasColumnName("slide_duration");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
        });

        modelBuilder.Entity<DynamicPhotoTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dynamic_photo_translations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DynamicDetailLanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_detail_language_id");
            entity.Property(e => e.DynamicPhotoId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_photo_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<EmailHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("email_histories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Reason)
                .HasMaxLength(25)
                .HasColumnName("reason");
            entity.Property(e => e.Recipient)
                .HasMaxLength(100)
                .HasColumnName("recipient");
        });

        modelBuilder.Entity<EmailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("email_messages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("message");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Title)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<ForwardLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("forward_lookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Fqdn)
                .HasMaxLength(255)
                .HasColumnName("fqdn");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("ip");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("groups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Hardware>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("hardwares")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.ForAp)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("for_ap");
            entity.Property(e => e.ForMesh)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("for_mesh");
            entity.Property(e => e.FwId)
                .HasMaxLength(20)
                .HasColumnName("fw_id");
            entity.Property(e => e.Lan)
                .HasMaxLength(20)
                .HasColumnName("lan");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .HasColumnName("model");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PhotoFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'hardware.png'")
                .HasColumnName("photo_file_name");
            entity.Property(e => e.RadioCount)
                .HasColumnType("tinyint(2)")
                .HasColumnName("radio_count");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
            entity.Property(e => e.Wan)
                .HasMaxLength(20)
                .HasDefaultValueSql("'eth1'")
                .HasColumnName("wan");
        });

        modelBuilder.Entity<HardwareRadio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("hardware_radios")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ap)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("ap");
            entity.Property(e => e.Band)
                .HasDefaultValueSql("'2g'")
                .HasColumnType("enum('2g','5g')")
                .HasColumnName("band");
            entity.Property(e => e.BeaconInt)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(11)")
                .HasColumnName("beacon_int");
            entity.Property(e => e.Config)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("config");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.Distance)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(7)")
                .HasColumnName("distance");
            entity.Property(e => e.HardwareId)
                .HasColumnType("int(11)")
                .HasColumnName("hardware_id");
            entity.Property(e => e.HtCapab)
                .HasMaxLength(255)
                .HasColumnName("ht_capab");
            entity.Property(e => e.IncludeBeaconInt).HasColumnName("include_beacon_int");
            entity.Property(e => e.IncludeDistance).HasColumnName("include_distance");
            entity.Property(e => e.Mesh)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("mesh");
            entity.Property(e => e.Mode)
                .HasDefaultValueSql("'n'")
                .HasColumnType("enum('a','g','n','ac','ax')")
                .HasColumnName("mode");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("tinyint(2)")
                .HasColumnName("radio_number");
            entity.Property(e => e.Txpower)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("txpower");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'20'")
                .HasColumnType("enum('20','40','80','160')")
                .HasColumnName("width");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("languages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(5)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.IsoCode)
                .HasMaxLength(2)
                .HasColumnName("iso_code");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Rtl).HasColumnName("rtl");
        });

        modelBuilder.Entity<MacAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mac_aliases")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("alias");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Mac)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<MacUsage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mac_usages")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataCap)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_cap");
            entity.Property(e => e.DataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_used");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.TimeCap)
                .HasColumnType("int(12)")
                .HasColumnName("time_cap");
            entity.Property(e => e.TimeUsed)
                .HasColumnType("int(12)")
                .HasColumnName("time_used");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Mesh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("meshes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_meshes_modified");

            entity.HasIndex(e => e.Name, "idx_meshes_name");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bssid)
                .HasMaxLength(32)
                .HasColumnName("bssid");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EnableAlerts)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_alerts");
            entity.Property(e => e.EnableOverviews)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_overviews");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Ssid)
                .HasMaxLength(32)
                .HasColumnName("ssid");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<MeshDailySummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_daily_summaries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_mesh_daily_summaries_mesh_id");

            entity.HasIndex(e => new { e.MeshId, e.TheDate }, "idx_mesh_daily_summaries_mesh_id_the_date").IsUnique();

            entity.HasIndex(e => e.MeshName, "idx_mesh_daily_summaries_mesh_name");

            entity.HasIndex(e => e.TheDate, "idx_mesh_daily_summaries_the_date");

            entity.HasIndex(e => e.TreeTagId, "idx_mesh_daily_summaries_tree_tag_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.MaxClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_clients");
            entity.Property(e => e.MaxDualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_dual_radios");
            entity.Property(e => e.MaxLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_lv_nodes");
            entity.Property(e => e.MaxLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_lv_nodes_down");
            entity.Property(e => e.MaxNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes");
            entity.Property(e => e.MaxNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes_down");
            entity.Property(e => e.MaxNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_nodes_up");
            entity.Property(e => e.MaxSingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("max_single_radios");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.MinClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_clients");
            entity.Property(e => e.MinDualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_dual_radios");
            entity.Property(e => e.MinLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_lv_nodes");
            entity.Property(e => e.MinLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_lv_nodes_down");
            entity.Property(e => e.MinNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes");
            entity.Property(e => e.MinNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes_down");
            entity.Property(e => e.MinNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_nodes_up");
            entity.Property(e => e.MinSingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("min_single_radios");
            entity.Property(e => e.TheDate).HasColumnName("the_date");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<MeshEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_mesh_entries_mesh_id");

            entity.HasIndex(e => e.Name, "idx_mesh_entries_name");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Accounting)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("accounting");
            entity.Property(e => e.ApplyToAll).HasColumnName("apply_to_all");
            entity.Property(e => e.AuthSecret)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("auth_secret");
            entity.Property(e => e.AuthServer)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("auth_server");
            entity.Property(e => e.AutoNasid).HasColumnName("auto_nasid");
            entity.Property(e => e.ChkMaxassoc).HasColumnName("chk_maxassoc");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DefaultKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("'12345678'")
                .HasColumnName("default_key");
            entity.Property(e => e.DefaultVlan)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(10)")
                .HasColumnName("default_vlan");
            entity.Property(e => e.DynamicVlan).HasColumnName("dynamic_vlan");
            entity.Property(e => e.Encryption)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','wep','psk','psk2','wpa','wpa2','ppsk')")
                .HasColumnName("encryption");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'both'")
                .HasColumnType("enum('both','two','five','five_upper','five_lower')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Isolate).HasColumnName("isolate");
            entity.Property(e => e.Macfilter)
                .HasDefaultValueSql("'disable'")
                .HasColumnType("enum('disable','allow','deny')")
                .HasColumnName("macfilter");
            entity.Property(e => e.Maxassoc)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(6)")
                .HasColumnName("maxassoc");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Nasid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("nasid");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.SpecialKey)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("special_key");
        });

        modelBuilder.Entity<MeshExit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_exits")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_mesh_exits_mesh_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AutoDetect).HasColumnName("auto_detect");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Dns1)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dns_1");
            entity.Property(e => e.Dns2)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dns_2");
            entity.Property(e => e.Gateway)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("gateway");
            entity.Property(e => e.Ipaddr)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("ipaddr");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.Netmask)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("netmask");
            entity.Property(e => e.OpenvpnServerId)
                .HasColumnType("int(11)")
                .HasColumnName("openvpn_server_id");
            entity.Property(e => e.Proto)
                .HasDefaultValueSql("'dhcp'")
                .HasColumnType("enum('static','dhcp','dhcpv6')")
                .HasColumnName("proto");
            entity.Property(e => e.Type)
                .HasColumnType("enum('bridge','tagged_bridge','nat','captive_portal','openvpn_bridge','tagged_bridge_l3')")
                .HasColumnName("type");
            entity.Property(e => e.Vlan)
                .HasColumnType("int(4)")
                .HasColumnName("vlan");
        });

        modelBuilder.Entity<MeshExitCaptivePortal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_exit_captive_portals")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshExitId, "idx_mesh_exit_captive_portals_mesh_exit_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CoovaOptional)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("coova_optional");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Dns1)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("dns1");
            entity.Property(e => e.Dns2)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("dns2");
            entity.Property(e => e.DnsManual).HasColumnName("dns_manual");
            entity.Property(e => e.Dnsdesk).HasColumnName("dnsdesk");
            entity.Property(e => e.Dnsparanoia).HasColumnName("dnsparanoia");
            entity.Property(e => e.MacAuth).HasColumnName("mac_auth");
            entity.Property(e => e.MeshExitId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_id");
            entity.Property(e => e.MeshExitUpstreamId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_upstream_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ProxyAuthPassword)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_auth_password");
            entity.Property(e => e.ProxyAuthUsername)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_auth_username");
            entity.Property(e => e.ProxyEnable).HasColumnName("proxy_enable");
            entity.Property(e => e.ProxyIp)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("proxy_ip");
            entity.Property(e => e.ProxyPort)
                .HasDefaultValueSql("'3128'")
                .HasColumnType("int(11)")
                .HasColumnName("proxy_port");
            entity.Property(e => e.Radius1)
                .HasMaxLength(128)
                .HasColumnName("radius_1");
            entity.Property(e => e.Radius2)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("radius_2");
            entity.Property(e => e.RadiusNasid)
                .HasMaxLength(128)
                .HasColumnName("radius_nasid");
            entity.Property(e => e.RadiusSecret)
                .HasMaxLength(128)
                .HasColumnName("radius_secret");
            entity.Property(e => e.SoftflowdEnabled).HasColumnName("softflowd_enabled");
            entity.Property(e => e.SwapOctets).HasColumnName("swap_octets");
            entity.Property(e => e.UamSecret)
                .HasMaxLength(255)
                .HasColumnName("uam_secret");
            entity.Property(e => e.UamUrl)
                .HasMaxLength(255)
                .HasColumnName("uam_url");
            entity.Property(e => e.Uamanydns).HasColumnName("uamanydns");
            entity.Property(e => e.WalledGarden)
                .HasMaxLength(255)
                .HasColumnName("walled_garden");
        });

        modelBuilder.Entity<MeshExitMeshEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_exit_mesh_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshEntryId, "idx_mesh_exit_mesh_entries_mesh_entry_id");

            entity.HasIndex(e => e.MeshExitId, "idx_mesh_exit_mesh_entries_mesh_exit_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MeshEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_entry_id");
            entity.Property(e => e.MeshExitId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<MeshExitSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_exit_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MeshExitId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MeshSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_mesh_settings_mesh_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AggregatedOgms)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("aggregated_ogms");
            entity.Property(e => e.ApIsolation).HasColumnName("ap_isolation");
            entity.Property(e => e.Bonding).HasColumnName("bonding");
            entity.Property(e => e.BridgeLoopAvoidance).HasColumnName("bridge_loop_avoidance");
            entity.Property(e => e.Connectivity)
                .HasDefaultValueSql("'mesh_point'")
                .HasColumnType("enum('IBSS','mesh_point')")
                .HasColumnName("connectivity");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DistributedArpTable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("distributed_arp_table");
            entity.Property(e => e.Encryption).HasColumnName("encryption");
            entity.Property(e => e.EncryptionKey)
                .HasMaxLength(63)
                .HasDefaultValueSql("''")
                .HasColumnName("encryption_key");
            entity.Property(e => e.Fragmentation)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("fragmentation");
            entity.Property(e => e.GwSelClass)
                .HasDefaultValueSql("'20'")
                .HasColumnType("int(10)")
                .HasColumnName("gw_sel_class");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.OrigInterval)
                .HasDefaultValueSql("'1000'")
                .HasColumnType("int(10)")
                .HasColumnName("orig_interval");
        });

        modelBuilder.Entity<MeshSpecific>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("mesh_specifics")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_mesh_specifics_mesh_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Na>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nas")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Nasname, "nasname");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Community)
                .HasMaxLength(50)
                .HasColumnName("community");
            entity.Property(e => e.ConnectionType)
                .HasDefaultValueSql("'direct'")
                .HasColumnType("enum('direct','openvpn','pptp','dynamic')")
                .HasColumnName("connection_type");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasDefaultValueSql("'RADIUS Client'")
                .HasColumnName("description");
            entity.Property(e => e.DynamicAttribute)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dynamic_attribute");
            entity.Property(e => e.DynamicValue)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("dynamic_value");
            entity.Property(e => e.HeartbeatDeadAfter)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("heartbeat_dead_after");
            entity.Property(e => e.IgnoreAcct).HasColumnName("ignore_acct");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Monitor)
                .HasDefaultValueSql("'off'")
                .HasColumnType("enum('off','ping','heartbeat')")
                .HasColumnName("monitor");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.Nasname)
                .HasMaxLength(128)
                .HasColumnName("nasname");
            entity.Property(e => e.OnPublicMaps).HasColumnName("on_public_maps");
            entity.Property(e => e.PhotoFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("photo_file_name");
            entity.Property(e => e.PingInterval)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("ping_interval");
            entity.Property(e => e.Ports)
                .HasColumnType("int(5)")
                .HasColumnName("ports");
            entity.Property(e => e.RecordAuth).HasColumnName("record_auth");
            entity.Property(e => e.Secret)
                .HasMaxLength(60)
                .HasDefaultValueSql("'secret'")
                .HasColumnName("secret");
            entity.Property(e => e.Server)
                .HasMaxLength(64)
                .HasColumnName("server");
            entity.Property(e => e.SessionAutoClose).HasColumnName("session_auto_close");
            entity.Property(e => e.SessionDeadTime)
                .HasDefaultValueSql("'3600'")
                .HasColumnType("int(5)")
                .HasColumnName("session_dead_time");
            entity.Property(e => e.Shortname)
                .HasMaxLength(32)
                .HasColumnName("shortname");
            entity.Property(e => e.Timezone)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("timezone");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasDefaultValueSql("'other'")
                .HasColumnName("type");
        });

        modelBuilder.Entity<NaRealm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("na_realms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId)
                .HasColumnType("int(11)")
                .HasColumnName("na_id");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
        });

        modelBuilder.Entity<NaSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("na_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId)
                .HasColumnType("int(11)")
                .HasColumnName("na_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NaState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("na_states")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId).HasColumnName("na_id");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<Network>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("networks")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Lat)
                .HasPrecision(11, 8)
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasPrecision(11, 8)
                .HasColumnName("lng");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.SiteId)
                .HasColumnType("int(11)")
                .HasColumnName("site_id");
        });

        modelBuilder.Entity<NewAccounting>(entity =>
        {
            entity.HasKey(e => e.Mac).HasName("PRIMARY");

            entity
                .ToTable("new_accountings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Node>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nodes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.LastContact, "idx_nodes_last_contact");

            entity.HasIndex(e => e.Mac, "idx_nodes_mac");

            entity.HasIndex(e => e.MeshId, "idx_nodes_mesh_id");

            entity.HasIndex(e => e.Modified, "idx_nodes_modified");

            entity.HasIndex(e => e.Name, "idx_nodes_name");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bootcycle)
                .HasColumnType("int(11)")
                .HasColumnName("bootcycle");
            entity.Property(e => e.ConfigFetched)
                .HasColumnType("datetime")
                .HasColumnName("config_fetched");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EnableAlerts)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_alerts");
            entity.Property(e => e.EnableOverviews)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable_overviews");
            entity.Property(e => e.EnableSchedules).HasColumnName("enable_schedules");
            entity.Property(e => e.Gateway)
                .HasDefaultValueSql("'none'")
                .HasColumnType("enum('none','lan','3g','wifi','wifi_static','wifi_ppp','wifi_pppoe','wan_static','wan_ppp','wan_pppoe')")
                .HasColumnName("gateway");
            entity.Property(e => e.Hardware)
                .HasMaxLength(255)
                .HasColumnName("hardware");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("ip");
            entity.Property(e => e.LanGw)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_gw");
            entity.Property(e => e.LanIp)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_ip");
            entity.Property(e => e.LanProto)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lan_proto");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.LastContactFromIp)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("last_contact_from_ip");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Mac).HasColumnName("mac");
            entity.Property(e => e.Mesh0)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("mesh0");
            entity.Property(e => e.Mesh0Channel)
                .HasColumnType("int(3)")
                .HasColumnName("mesh0_channel");
            entity.Property(e => e.Mesh0FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("mesh0_frequency_band");
            entity.Property(e => e.Mesh0Txpower)
                .HasColumnType("int(3)")
                .HasColumnName("mesh0_txpower");
            entity.Property(e => e.Mesh1)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("mesh1");
            entity.Property(e => e.Mesh1Channel)
                .HasColumnType("int(3)")
                .HasColumnName("mesh1_channel");
            entity.Property(e => e.Mesh1FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("mesh1_frequency_band");
            entity.Property(e => e.Mesh1Txpower)
                .HasColumnType("int(3)")
                .HasColumnName("mesh1_txpower");
            entity.Property(e => e.Mesh2)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("mesh2");
            entity.Property(e => e.Mesh2Channel)
                .HasColumnType("int(3)")
                .HasColumnName("mesh2_channel");
            entity.Property(e => e.Mesh2FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("mesh2_frequency_band");
            entity.Property(e => e.Mesh2Txpower)
                .HasColumnType("int(3)")
                .HasColumnName("mesh2_txpower");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.RebootFlag).HasColumnName("reboot_flag");
            entity.Property(e => e.ScheduleId)
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
        });

        modelBuilder.Entity<NodeAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_actions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_node_actions_modified");

            entity.HasIndex(e => e.NodeId, "idx_node_actions_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'execute'")
                .HasColumnType("enum('execute','execute_and_reply')")
                .HasColumnName("action");
            entity.Property(e => e.Command)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("command");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(10)")
                .HasColumnName("node_id");
            entity.Property(e => e.Reply)
                .HasColumnType("text")
                .HasColumnName("reply");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<NodeConnectionSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_connection_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Grouping)
                .HasMaxLength(25)
                .HasColumnName("grouping");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Value)
                .HasMaxLength(40)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NodeIbssConnection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_ibss_connections")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NodeId, "idx_node_ibss_connections_node_id");

            entity.HasIndex(e => e.StationNodeId, "idx_node_ibss_connections_station_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Authenticated)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authenticated");
            entity.Property(e => e.Authorized)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authorized");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.IfMac)
                .HasMaxLength(17)
                .HasColumnName("if_mac");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.Mfp)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("mfp");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Preamble)
                .HasMaxLength(255)
                .HasColumnName("preamble");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("tinyint(3)")
                .HasColumnName("radio_number");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.RxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_packets");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(11)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.SignalNow)
                .HasColumnType("int(11)")
                .HasColumnName("signal_now");
            entity.Property(e => e.StationNodeId)
                .HasColumnType("int(11)")
                .HasColumnName("station_node_id");
            entity.Property(e => e.TdlsPeer)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("tdls_peer");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
            entity.Property(e => e.TxFailed)
                .HasColumnType("int(11)")
                .HasColumnName("tx_failed");
            entity.Property(e => e.TxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_packets");
            entity.Property(e => e.TxRetries)
                .HasColumnType("int(11)")
                .HasColumnName("tx_retries");
            entity.Property(e => e.WmmWme)
                .HasColumnType("tinyint(2)")
                .HasColumnName("wmm_wme");
        });

        modelBuilder.Entity<NodeIbssConnectionsDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_ibss_connections_dailies")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.IfMac)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("if_mac");
            entity.Property(e => e.Mac)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("mac");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("int(2)")
                .HasColumnName("radio_number");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(6)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(6)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.StationNodeId)
                .HasColumnType("int(11)")
                .HasColumnName("station_node_id");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(6)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
        });

        modelBuilder.Entity<NodeLoad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_loads")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_node_loads_modified");

            entity.HasIndex(e => e.NodeId, "idx_node_loads_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Load1)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_1");
            entity.Property(e => e.Load2)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_2");
            entity.Property(e => e.Load3)
                .HasColumnType("float(2,2)")
                .HasColumnName("load_3");
            entity.Property(e => e.MemFree)
                .HasColumnType("int(11)")
                .HasColumnName("mem_free");
            entity.Property(e => e.MemTotal)
                .HasColumnType("int(11)")
                .HasColumnName("mem_total");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.SystemTime)
                .HasMaxLength(255)
                .HasColumnName("system_time");
            entity.Property(e => e.Uptime)
                .HasMaxLength(255)
                .HasColumnName("uptime");
        });

        modelBuilder.Entity<NodeMeshEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_mesh_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshEntryId, "idx_node_mesh_entries_mesh_entry_id");

            entity.HasIndex(e => e.NodeId, "idx_node_mesh_entries_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MeshEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_entry_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
        });

        modelBuilder.Entity<NodeMeshExit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_mesh_exits")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshExitId, "idx_node_mesh_exits_mesh_exit_id");

            entity.HasIndex(e => e.NodeId, "idx_node_mesh_exits_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.MeshExitId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
        });

        modelBuilder.Entity<NodeMpSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_mp_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NodeId, "idx_node_mp_settings_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NodeNeighbor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_neighbors")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Gateway, "idx_node_neighbors_gateway");

            entity.HasIndex(e => e.Modified, "idx_node_neighbors_modified");

            entity.HasIndex(e => e.NeighborId, "idx_node_neighbors_neighbor_id");

            entity.HasIndex(e => e.NodeId, "idx_node_neighbors_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Gateway)
                .HasDefaultValueSql("'no'")
                .HasColumnType("enum('yes','no')")
                .HasColumnName("gateway");
            entity.Property(e => e.Hwmode)
                .HasMaxLength(5)
                .HasDefaultValueSql("'11g'")
                .IsFixedLength()
                .HasColumnName("hwmode");
            entity.Property(e => e.Metric)
                .HasPrecision(6, 4)
                .HasColumnName("metric");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NeighborId)
                .HasColumnType("int(11)")
                .HasColumnName("neighbor_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
        });

        modelBuilder.Entity<NodeScan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_scans")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.ScanData)
                .HasColumnType("text")
                .HasColumnName("scan_data");
        });

        modelBuilder.Entity<NodeSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshId, "idx_node_settings_mesh_id");

            entity.HasIndex(e => e.Modified, "idx_node_settings_modified");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AllPower)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("all_power");
            entity.Property(e => e.ClientKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("'radiusdesk'")
                .HasColumnName("client_key");
            entity.Property(e => e.Country)
                .HasMaxLength(5)
                .HasDefaultValueSql("'US'")
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.EnableSchedules).HasColumnName("enable_schedules");
            entity.Property(e => e.EthBrChk).HasColumnName("eth_br_chk");
            entity.Property(e => e.EthBrForAll)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("eth_br_for_all");
            entity.Property(e => e.EthBrWith)
                .HasColumnType("int(11)")
                .HasColumnName("eth_br_with");
            entity.Property(e => e.FiveChan)
                .HasDefaultValueSql("'44'")
                .HasColumnType("int(3)")
                .HasColumnName("five_chan");
            entity.Property(e => e.GwAutoReboot)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("gw_auto_reboot");
            entity.Property(e => e.GwAutoRebootTime)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("gw_auto_reboot_time");
            entity.Property(e => e.GwDhcpTimeout)
                .HasDefaultValueSql("'120'")
                .HasColumnType("int(5)")
                .HasColumnName("gw_dhcp_timeout");
            entity.Property(e => e.GwUsePrevious)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("gw_use_previous");
            entity.Property(e => e.HeartbeatDeadAfter)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("heartbeat_dead_after");
            entity.Property(e => e.HeartbeatInterval)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("heartbeat_interval");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("password_hash");
            entity.Property(e => e.Power)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(3)")
                .HasColumnName("power");
            entity.Property(e => e.ReportAdvEnable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("report_adv_enable");
            entity.Property(e => e.ReportAdvFull)
                .HasDefaultValueSql("'600'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_full");
            entity.Property(e => e.ReportAdvLight)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_light");
            entity.Property(e => e.ReportAdvProto)
                .HasDefaultValueSql("'http'")
                .HasColumnType("enum('https','http')")
                .HasColumnName("report_adv_proto");
            entity.Property(e => e.ReportAdvSampling)
                .HasDefaultValueSql("'60'")
                .HasColumnType("int(5)")
                .HasColumnName("report_adv_sampling");
            entity.Property(e => e.ScheduleId)
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
            entity.Property(e => e.Syslog1Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog1_ip");
            entity.Property(e => e.Syslog1Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog1_port");
            entity.Property(e => e.Syslog2Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog2_ip");
            entity.Property(e => e.Syslog2Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog2_port");
            entity.Property(e => e.Syslog3Ip)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("syslog3_ip");
            entity.Property(e => e.Syslog3Port)
                .HasMaxLength(10)
                .HasDefaultValueSql("'514'")
                .HasColumnName("syslog3_port");
            entity.Property(e => e.TwoChan)
                .HasDefaultValueSql("'6'")
                .HasColumnType("int(3)")
                .HasColumnName("two_chan");
            entity.Property(e => e.TzName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'America/New York'")
                .HasColumnName("tz_name");
            entity.Property(e => e.TzValue)
                .HasMaxLength(128)
                .HasDefaultValueSql("'EST5EDT,M3.2.0,M11.1.0'")
                .HasColumnName("tz_value");
            entity.Property(e => e.VlanEnable).HasColumnName("vlan_enable");
            entity.Property(e => e.VlanEnd)
                .HasDefaultValueSql("'101'")
                .HasColumnType("int(10)")
                .HasColumnName("vlan_end");
            entity.Property(e => e.VlanList)
                .HasMaxLength(255)
                .HasDefaultValueSql("'100'")
                .HasColumnName("vlan_list");
            entity.Property(e => e.VlanRangeOrList)
                .HasDefaultValueSql("'range'")
                .HasColumnType("enum('range','list')")
                .HasColumnName("vlan_range_or_list");
            entity.Property(e => e.VlanStart)
                .HasDefaultValueSql("'100'")
                .HasColumnType("int(10)")
                .HasColumnName("vlan_start");
        });

        modelBuilder.Entity<NodeStation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_stations")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshEntryId, "idx_node_stations_mesh_entry_id");

            entity.HasIndex(e => e.Modified, "idx_node_stations_modified");

            entity.HasIndex(e => e.NodeId, "idx_node_stations_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Authenticated)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authenticated");
            entity.Property(e => e.Authorized)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("authorized");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.Mac)
                .HasMaxLength(17)
                .HasColumnName("mac");
            entity.Property(e => e.MeshEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_entry_id");
            entity.Property(e => e.Mfp)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("mfp");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Preamble)
                .HasMaxLength(255)
                .HasColumnName("preamble");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("tinyint(3)")
                .HasColumnName("radio_number");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.RxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_packets");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(11)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.SignalNow)
                .HasColumnType("int(11)")
                .HasColumnName("signal_now");
            entity.Property(e => e.TdlsPeer)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("tdls_peer");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(11)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
            entity.Property(e => e.TxFailed)
                .HasColumnType("int(11)")
                .HasColumnName("tx_failed");
            entity.Property(e => e.TxPackets)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_packets");
            entity.Property(e => e.TxRetries)
                .HasColumnType("int(11)")
                .HasColumnName("tx_retries");
            entity.Property(e => e.WmmWme)
                .HasColumnType("tinyint(2)")
                .HasColumnName("wmm_wme");
        });

        modelBuilder.Entity<NodeStationsDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_stations_dailies")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FrequencyBand)
                .HasDefaultValueSql("'two'")
                .HasColumnType("enum('two','five_lower','five_upper')")
                .HasColumnName("frequency_band");
            entity.Property(e => e.Mac)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("mac");
            entity.Property(e => e.MeshEntryId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_entry_id");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.NodeStationId)
                .HasColumnType("int(11)")
                .HasColumnName("node_station_id");
            entity.Property(e => e.RadioNumber)
                .HasColumnType("int(2)")
                .HasColumnName("radio_number");
            entity.Property(e => e.RxBitrate)
                .HasColumnType("int(6)")
                .HasColumnName("rx_bitrate");
            entity.Property(e => e.RxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("rx_bytes");
            entity.Property(e => e.SignalAvg)
                .HasColumnType("int(6)")
                .HasColumnName("signal_avg");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.TxBitrate)
                .HasColumnType("int(6)")
                .HasColumnName("tx_bitrate");
            entity.Property(e => e.TxBytes)
                .HasColumnType("bigint(20)")
                .HasColumnName("tx_bytes");
        });

        modelBuilder.Entity<NodeSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_systems")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_node_systems_modified");

            entity.HasIndex(e => e.Name, "idx_node_systems_name");

            entity.HasIndex(e => e.NodeId, "idx_node_systems_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NodeUptmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_uptm_histories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "idx_node_uptm_histories_modified");

            entity.HasIndex(e => e.NodeId, "idx_node_uptm_histories_node_id");

            entity.HasIndex(e => e.NodeState, "idx_node_uptm_histories_node_state");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.NodeState).HasColumnName("node_state");
            entity.Property(e => e.ReportDatetime)
                .HasColumnType("datetime")
                .HasColumnName("report_datetime");
            entity.Property(e => e.StateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("state_datetime");
        });

        modelBuilder.Entity<NodeWifiSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("node_wifi_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NodeId, "idx_node_wifi_settings_node_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("notifications")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NotificationDatetime, "idx_notification_datetime");

            entity.HasIndex(e => e.IsResolved, "idx_notification_is_resolved");

            entity.HasIndex(e => e.ItemId, "idx_notification_item_id");

            entity.HasIndex(e => e.ItemTable, "idx_notification_item_table");

            entity.HasIndex(e => e.NotificationCode, "idx_notification_notification_code");

            entity.HasIndex(e => e.NotificationType, "idx_notification_notification_type");

            entity.HasIndex(e => e.Modified, "idx_notifications_modified");

            entity.HasIndex(e => e.Severity, "idx_notifications_severity");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasColumnName("description");
            entity.Property(e => e.IsResolved).HasColumnName("is_resolved");
            entity.Property(e => e.ItemId)
                .HasColumnType("int(11)")
                .HasColumnName("item_id");
            entity.Property(e => e.ItemTable)
                .HasMaxLength(64)
                .HasColumnName("item_table");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NotificationCode)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("notification_code");
            entity.Property(e => e.NotificationDatetime)
                .HasColumnType("datetime")
                .HasColumnName("notification_datetime");
            entity.Property(e => e.NotificationType)
                .HasMaxLength(32)
                .HasDefaultValueSql("'network'")
                .HasColumnName("notification_type");
            entity.Property(e => e.Severity)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("severity");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(64)
                .HasColumnName("short_description");
        });

        modelBuilder.Entity<OpenvpnClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("openvpn_clients")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId)
                .HasColumnType("int(11)")
                .HasColumnName("na_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Peer1)
                .HasColumnType("int(3)")
                .HasColumnName("peer1");
            entity.Property(e => e.Peer2)
                .HasColumnType("int(3)")
                .HasColumnName("peer2");
            entity.Property(e => e.Subnet)
                .HasColumnType("int(3)")
                .HasColumnName("subnet");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<OpenvpnServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("openvpn_servers")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CaCrt)
                .HasColumnType("text")
                .HasColumnName("ca_crt");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.ConfigPreset)
                .HasMaxLength(100)
                .HasDefaultValueSql("'default'")
                .HasColumnName("config_preset");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(40)
                .HasColumnName("ip_address");
            entity.Property(e => e.LocalRemote)
                .HasDefaultValueSql("'local'")
                .HasColumnType("enum('local','remote')")
                .HasColumnName("local_remote");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Port)
                .HasColumnType("int(6)")
                .HasColumnName("port");
            entity.Property(e => e.Protocol)
                .HasDefaultValueSql("'udp'")
                .HasColumnType("enum('udp','tcp')")
                .HasColumnName("protocol");
            entity.Property(e => e.VpnBridgeStartAddress)
                .HasMaxLength(40)
                .HasColumnName("vpn_bridge_start_address");
            entity.Property(e => e.VpnGatewayAddress)
                .HasMaxLength(40)
                .HasColumnName("vpn_gateway_address");
            entity.Property(e => e.VpnMask)
                .HasMaxLength(40)
                .HasColumnName("vpn_mask");
        });

        modelBuilder.Entity<OpenvpnServerClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("openvpn_server_clients")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApProfileExitId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_exit_id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(40)
                .HasColumnName("ip_address");
            entity.Property(e => e.LastContactToServer)
                .HasColumnType("datetime")
                .HasColumnName("last_contact_to_server");
            entity.Property(e => e.MeshApProfile)
                .HasDefaultValueSql("'mesh'")
                .HasColumnType("enum('mesh','ap_profile')")
                .HasColumnName("mesh_ap_profile");
            entity.Property(e => e.MeshExitId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_exit_id");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.OpenvpnServerId)
                .HasColumnType("int(11)")
                .HasColumnName("openvpn_server_id");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PRIMARY");

            entity.ToTable("packages");

            entity.HasIndex(e => e.PlanId, "plan_id");

            entity.Property(e => e.ProfileId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.PlanId)
                .HasColumnType("int(11)")
                .HasColumnName("plan_id");

            entity.HasOne(d => d.Plan).WithMany(p => p.Packages)
                .HasForeignKey(d => d.PlanId)
                .HasConstraintName("packages_ibfk_1");

            entity.HasOne(d => d.Profile).WithOne(p => p.Package)
                .HasForeignKey<Package>(d => d.ProfileId)
                .HasConstraintName("packages_ibfk_2");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("payments");

            entity.HasIndex(e => e.PermanentUserId, "permanent_user_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(255)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankName)
                .HasMaxLength(255)
                .HasColumnName("bank_name");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.TrnsactionId)
                .HasMaxLength(24)
                .HasColumnName("trnsaction_id");
            entity.Property(e => e.Value)
                .HasPrecision(16)
                .HasColumnName("value");

            entity.HasOne(d => d.PermanentUser).WithMany(p => p.Payments)
                .HasForeignKey(d => d.PermanentUserId)
                .HasConstraintName("payments_ibfk_1");
        });

        modelBuilder.Entity<PermanentUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("permanent_users")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.AuthType)
                .HasMaxLength(128)
                .HasDefaultValueSql("'sql'")
                .HasColumnName("auth_type");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataCap)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_cap");
            entity.Property(e => e.DataCapType)
                .HasDefaultValueSql("'soft'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("data_cap_type");
            entity.Property(e => e.DataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_used");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("from_date");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.LastAcceptNas)
                .HasMaxLength(128)
                .HasColumnName("last_accept_nas");
            entity.Property(e => e.LastAcceptTime)
                .HasColumnType("datetime")
                .HasColumnName("last_accept_time");
            entity.Property(e => e.LastRejectMessage)
                .HasMaxLength(255)
                .HasColumnName("last_reject_message");
            entity.Property(e => e.LastRejectNas)
                .HasMaxLength(128)
                .HasColumnName("last_reject_nas");
            entity.Property(e => e.LastRejectTime)
                .HasColumnType("datetime")
                .HasColumnName("last_reject_time");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PercDataUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_data_used");
            entity.Property(e => e.PercTimeUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_time_used");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Profile)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("profile");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.Realm)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.StaticIp)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("static_ip");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
            entity.Property(e => e.TimeCap)
                .HasColumnType("int(12)")
                .HasColumnName("time_cap");
            entity.Property(e => e.TimeCapType)
                .HasDefaultValueSql("'soft'")
                .HasColumnType("enum('hard','soft')")
                .HasColumnName("time_cap_type");
            entity.Property(e => e.TimeUsed)
                .HasColumnType("int(12)")
                .HasColumnName("time_used");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("to_date");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.TrackAcct)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("track_acct");
            entity.Property(e => e.TrackAuth).HasColumnName("track_auth");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<PermanentUserLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("permanent_user_logs");

            entity.HasIndex(e => e.PermanentUserId, "permanent_user_id");

            entity.HasIndex(e => e.Witer, "witer");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Color)
                .HasColumnType("int(11)")
                .HasColumnName("color");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Witer)
                .HasColumnType("int(11)")
                .HasColumnName("witer");

            entity.HasOne(d => d.PermanentUser).WithMany(p => p.PermanentUserLogs)
                .HasForeignKey(d => d.PermanentUserId)
                .HasConstraintName("permanent_user_logs_ibfk_1");

            entity.HasOne(d => d.WiterNavigation).WithMany(p => p.PermanentUserLogs)
                .HasForeignKey(d => d.Witer)
                .HasConstraintName("permanent_user_logs_ibfk_2");
        });

        modelBuilder.Entity<PermanentUserNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("permanent_user_notifications")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .HasColumnName("address_2");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Increment)
                .HasDefaultValueSql("'10'")
                .HasColumnType("int(3)")
                .HasColumnName("increment");
            entity.Property(e => e.LastNotification)
                .HasColumnType("datetime")
                .HasColumnName("last_notification");
            entity.Property(e => e.LastValue)
                .HasColumnType("int(3)")
                .HasColumnName("last_value");
            entity.Property(e => e.Method)
                .HasDefaultValueSql("'email'")
                .HasColumnType("enum('whatsapp','email','sms')")
                .HasColumnName("method");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Start)
                .HasDefaultValueSql("'80'")
                .HasColumnType("int(3)")
                .HasColumnName("start");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'daily'")
                .HasColumnType("enum('daily','usage')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<PermanentUserOtp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("permanent_user_otps")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'otp_awaiting'")
                .HasColumnType("enum('otp_awaiting','otp_confirmed')")
                .HasColumnName("status");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<PermanentUserPlan>(entity =>
        {
            entity.HasKey(e => new { e.PermanentUserId, e.ValidTime })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("permanent_user_plan");

            entity.HasIndex(e => e.ProfileId, "profile_id");

            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.ValidTime)
                .HasColumnType("datetime")
                .HasColumnName("valid_time");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.OverridePrice)
                .HasPrecision(16)
                .HasColumnName("override_price");
            entity.Property(e => e.Periods)
                .HasColumnType("int(11)")
                .HasColumnName("periods");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");

            entity.HasOne(d => d.PermanentUser).WithMany(p => p.PermanentUserPlans)
                .HasForeignKey(d => d.PermanentUserId)
                .HasConstraintName("permanent_user_plan_ibfk_1");

            entity.HasOne(d => d.Profile).WithMany(p => p.PermanentUserPlans)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("permanent_user_plan_ibfk_2");
        });

        modelBuilder.Entity<PermanentUserSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("permanent_user_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("plans");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Color)
                .HasColumnType("int(11)")
                .HasColumnName("color");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ImageFile)
                .HasColumnType("text")
                .HasColumnName("image_file");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Price)
                .HasPrecision(16)
                .HasColumnName("price");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<PptpClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pptp_clients")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("ip");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NaId)
                .HasColumnType("int(11)")
                .HasColumnName("na_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<PredefinedCommand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("predefined_commands")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'execute'")
                .HasColumnType("enum('execute','execute_and_reply')")
                .HasColumnName("action");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Command)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("command");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("profiles")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ProfileComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("profile_components")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ProfileFupComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("profile_fup_components")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'block'")
                .HasColumnType("enum('increase_speed','decrease_speed','block')")
                .HasColumnName("action");
            entity.Property(e => e.ActionAmount)
                .HasColumnType("int(10)")
                .HasColumnName("action_amount");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataAmount)
                .HasColumnType("int(10)")
                .HasColumnName("data_amount");
            entity.Property(e => e.DataUnit)
                .HasDefaultValueSql("'mb'")
                .HasColumnType("enum('mb','gb')")
                .HasColumnName("data_unit");
            entity.Property(e => e.IfCondition)
                .HasDefaultValueSql("'day_usage'")
                .HasColumnType("enum('day_usage','week_usage','month_usage','time_of_day')")
                .HasColumnName("if_condition");
            entity.Property(e => e.IpPool)
                .HasMaxLength(255)
                .HasColumnName("ip_pool");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.TimeEnd)
                .HasMaxLength(255)
                .HasColumnName("time_end");
            entity.Property(e => e.TimeStart)
                .HasMaxLength(255)
                .HasColumnName("time_start");
        });

        modelBuilder.Entity<Radacct>(entity =>
        {
            entity.HasKey(e => e.Radacctid).HasName("PRIMARY");

            entity
                .ToTable("radacct")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Acctinterval, "acctinterval");

            entity.HasIndex(e => e.Acctsessionid, "acctsessionid");

            entity.HasIndex(e => e.Acctsessiontime, "acctsessiontime");

            entity.HasIndex(e => e.Acctstarttime, "acctstarttime");

            entity.HasIndex(e => e.Acctstoptime, "acctstoptime");

            entity.HasIndex(e => e.Acctuniqueid, "acctuniqueid").IsUnique();

            entity.HasIndex(e => e.Framedipaddress, "framedipaddress");

            entity.HasIndex(e => e.Nasidentifier, "nasidentifier");

            entity.HasIndex(e => e.Nasipaddress, "nasipaddress");

            entity.HasIndex(e => e.Username, "username");

            entity.Property(e => e.Radacctid)
                .HasColumnType("bigint(21)")
                .HasColumnName("radacctid");
            entity.Property(e => e.Acctauthentic)
                .HasMaxLength(32)
                .HasColumnName("acctauthentic");
            entity.Property(e => e.Acctinputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctinputoctets");
            entity.Property(e => e.Acctinterval)
                .HasColumnType("int(12)")
                .HasColumnName("acctinterval");
            entity.Property(e => e.Acctoutputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctoutputoctets");
            entity.Property(e => e.Acctsessionid)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("acctsessionid");
            entity.Property(e => e.Acctsessiontime)
                .HasColumnType("int(12) unsigned")
                .HasColumnName("acctsessiontime");
            entity.Property(e => e.Acctstartdelay)
                .HasColumnType("int(12)")
                .HasColumnName("acctstartdelay");
            entity.Property(e => e.Acctstarttime)
                .HasColumnType("datetime")
                .HasColumnName("acctstarttime");
            entity.Property(e => e.Acctstopdelay)
                .HasColumnType("int(12)")
                .HasColumnName("acctstopdelay");
            entity.Property(e => e.Acctstoptime)
                .HasColumnType("datetime")
                .HasColumnName("acctstoptime");
            entity.Property(e => e.Acctterminatecause)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("acctterminatecause");
            entity.Property(e => e.Acctuniqueid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("acctuniqueid");
            entity.Property(e => e.Acctupdatetime)
                .HasColumnType("datetime")
                .HasColumnName("acctupdatetime");
            entity.Property(e => e.Calledstationid)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("calledstationid");
            entity.Property(e => e.Callingstationid)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("callingstationid");
            entity.Property(e => e.ConnectinfoStart)
                .HasMaxLength(50)
                .HasColumnName("connectinfo_start");
            entity.Property(e => e.ConnectinfoStop)
                .HasMaxLength(50)
                .HasColumnName("connectinfo_stop");
            entity.Property(e => e.Framedipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("framedipaddress");
            entity.Property(e => e.Framedprotocol)
                .HasMaxLength(32)
                .HasColumnName("framedprotocol");
            entity.Property(e => e.Groupname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("groupname");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.Nasipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("nasipaddress");
            entity.Property(e => e.Nasportid)
                .HasMaxLength(15)
                .HasColumnName("nasportid");
            entity.Property(e => e.Nasporttype)
                .HasMaxLength(32)
                .HasColumnName("nasporttype");
            entity.Property(e => e.Realm)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.Servicetype)
                .HasMaxLength(32)
                .HasColumnName("servicetype");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Xascendsessionsvrkey)
                .HasMaxLength(20)
                .HasColumnName("xascendsessionsvrkey");
        });

        modelBuilder.Entity<Radcheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radcheck")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Username, "FK_radcheck_ref_vouchers");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("attribute");
            entity.Property(e => e.Op)
                .HasMaxLength(2)
                .HasDefaultValueSql("'=='")
                .IsFixedLength()
                .HasColumnName("op");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Value)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Radgroupcheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radgroupcheck")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Groupname, "groupname").HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("attribute");
            entity.Property(e => e.Comment)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Groupname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("groupname");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Op)
                .HasMaxLength(2)
                .HasDefaultValueSql("'=='")
                .IsFixedLength()
                .HasColumnName("op");
            entity.Property(e => e.Value)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Radgroupreply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radgroupreply")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Groupname, "groupname").HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("attribute");
            entity.Property(e => e.Comment)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Groupname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("groupname");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Op)
                .HasMaxLength(2)
                .HasDefaultValueSql("'='")
                .IsFixedLength()
                .HasColumnName("op");
            entity.Property(e => e.Value)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Radippool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radippool")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Framedipaddress, "framedipaddress");

            entity.HasIndex(e => new { e.Nasipaddress, e.PoolKey, e.Framedipaddress }, "radippool_nasip_poolkey_ipaddress");

            entity.HasIndex(e => new { e.PoolName, e.ExpiryTime }, "radippool_poolname_expire");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Calledstationid)
                .HasMaxLength(30)
                .HasColumnName("calledstationid");
            entity.Property(e => e.Callingstationid)
                .HasMaxLength(30)
                .HasColumnName("callingstationid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.ExpiryTime)
                .HasColumnType("datetime")
                .HasColumnName("expiry_time");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.Framedipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("framedipaddress");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.Nasipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("nasipaddress");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.PoolKey)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("pool_key");
            entity.Property(e => e.PoolName)
                .HasMaxLength(30)
                .HasColumnName("pool_name");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Radpostauth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radpostauth")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Authdate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("authdate");
            entity.Property(e => e.Nasname)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("nasname");
            entity.Property(e => e.Pass)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pass");
            entity.Property(e => e.Realm)
                .HasMaxLength(64)
                .HasColumnName("realm");
            entity.Property(e => e.Reply)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("reply");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Radreply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radreply")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Username, "FK_radreply_ref_vouchers");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Attribute)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("attribute");
            entity.Property(e => e.Op)
                .HasMaxLength(2)
                .HasDefaultValueSql("'='")
                .IsFixedLength()
                .HasColumnName("op");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Value)
                .HasMaxLength(253)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Radusergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("radusergroup")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Username, "username").HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Groupname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("groupname");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("priority");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Realm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("realms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cell)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .HasColumnName("cell");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("city");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("facebook");
            entity.Property(e => e.GooglePlus)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("google_plus");
            entity.Property(e => e.IconFileName)
                .HasMaxLength(128)
                .HasDefaultValueSql("'logo.png'")
                .HasColumnName("icon_file_name");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("linkedin");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(14)
                .HasDefaultValueSql("''")
                .HasColumnName("phone");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("street");
            entity.Property(e => e.StreetNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("street_no");
            entity.Property(e => e.Suffix)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("suffix");
            entity.Property(e => e.SuffixDevices).HasColumnName("suffix_devices");
            entity.Property(e => e.SuffixPermanentUsers).HasColumnName("suffix_permanent_users");
            entity.Property(e => e.SuffixVouchers).HasColumnName("suffix_vouchers");
            entity.Property(e => e.TCContent)
                .HasColumnType("text")
                .HasColumnName("t_c_content");
            entity.Property(e => e.TCTitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("t_c_title");
            entity.Property(e => e.TownSuburb)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("town_suburb");
            entity.Property(e => e.Twitter)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("twitter");
            entity.Property(e => e.Url)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Youtube)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("youtube");
        });

        modelBuilder.Entity<RegistrationRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("registration_requests")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailSent)
                .HasColumnType("datetime")
                .HasColumnName("email_sent");
            entity.Property(e => e.Expire)
                .HasColumnType("datetime")
                .HasColumnName("expire");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.RegistrationCode).HasColumnName("registration_code");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'not_allocated'")
                .HasColumnType("enum('not_allocated','allocated','email_sent','verified','registration_completed','expired')")
                .HasColumnName("state");
            entity.Property(e => e.TokenKey).HasColumnName("token_key");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<ReverseLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("reverse_lookups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Fqdn)
                .HasMaxLength(255)
                .HasColumnName("fqdn");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasColumnName("ip");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
        });

        modelBuilder.Entity<RollingLastDay>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_day")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_day_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_day_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<RollingLastHour>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_hour")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_hour_tree_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_hour_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<RollingLastNinetyDay>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_ninety_days")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_ninety_days_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_ninety_days_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<RollingLastSevenDay>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_seven_days")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_seven_days_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_seven_days_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<RollingLastSixtyDay>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_sixty_days")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_sixty_days_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_sixty_days_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<RollingLastThirtyDay>(entity =>
        {
            entity.HasKey(e => e.MeshId).HasName("PRIMARY");

            entity
                .ToTable("rolling_last_thirty_days")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.MeshName, "idx_rolling_last_thirty_days_mesh_name");

            entity.HasIndex(e => e.TreeTagId, "idx_rolling_last_thirty_days_tree_tag_id");

            entity.Property(e => e.MeshId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.DualRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("dual_radios");
            entity.Property(e => e.MeshName).HasColumnName("mesh_name");
            entity.Property(e => e.NdwnBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_beg_remove_secs");
            entity.Property(e => e.NdwnDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_down_seconds");
            entity.Property(e => e.NdwnEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_end_add_secs");
            entity.Property(e => e.NdwnUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("ndwn_up_seconds");
            entity.Property(e => e.NupBegRemoveSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_beg_remove_secs");
            entity.Property(e => e.NupDownSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_down_seconds");
            entity.Property(e => e.NupEndAddSecs)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_end_add_secs");
            entity.Property(e => e.NupUpSeconds)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("float(14,2)")
                .HasColumnName("nup_up_seconds");
            entity.Property(e => e.SingleRadios)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("single_radios");
            entity.Property(e => e.TotBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_bytes");
            entity.Property(e => e.TotClients)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_clients");
            entity.Property(e => e.TotLvNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes");
            entity.Property(e => e.TotLvNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_lv_nodes_down");
            entity.Property(e => e.TotNodes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes");
            entity.Property(e => e.TotNodesDown)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_down");
            entity.Property(e => e.TotNodesUp)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_nodes_up");
            entity.Property(e => e.TotRxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_rx_bytes");
            entity.Property(e => e.TotTxBytes)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("tot_tx_bytes");
            entity.Property(e => e.TreeTagId)
                .HasColumnType("int(11)")
                .HasColumnName("tree_tag_id");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedules")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<ScheduleEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("schedule_entries")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Command)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("command");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.EventTime)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("event_time");
            entity.Property(e => e.Fr).HasColumnName("fr");
            entity.Property(e => e.Mo).HasColumnName("mo");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.PredefinedCommandId)
                .HasColumnType("int(11)")
                .HasColumnName("predefined_command_id");
            entity.Property(e => e.Sa).HasColumnName("sa");
            entity.Property(e => e.ScheduleId)
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
            entity.Property(e => e.Su).HasColumnName("su");
            entity.Property(e => e.Th).HasColumnName("th");
            entity.Property(e => e.Tu).HasColumnName("tu");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'command'")
                .HasColumnType("enum('predefined_command','command')")
                .HasColumnName("type");
            entity.Property(e => e.We).HasColumnName("we");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sites")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Lat)
                .HasPrecision(11, 8)
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasPrecision(11, 8)
                .HasColumnName("lng");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SmsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sms_histories")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Reason)
                .HasMaxLength(25)
                .HasColumnName("reason");
            entity.Property(e => e.Recipient)
                .HasMaxLength(100)
                .HasColumnName("recipient");
            entity.Property(e => e.Reply)
                .HasMaxLength(255)
                .HasColumnName("reply");
            entity.Property(e => e.SmsProvider)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(2)")
                .HasColumnName("sms_provider");
        });

        modelBuilder.Entity<SocialLoginUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("social_login_users")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasDefaultValueSql("'male'")
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("image");
            entity.Property(e => e.LastConnectTime)
                .HasColumnType("datetime")
                .HasColumnName("last_connect_time");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("last_name");
            entity.Property(e => e.Locale)
                .HasMaxLength(5)
                .HasDefaultValueSql("''")
                .HasColumnName("locale");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Provider)
                .HasDefaultValueSql("'Facebook'")
                .HasColumnType("enum('Facebook','Google','Twitter')")
                .HasColumnName("provider");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
            entity.Property(e => e.Uid)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<SocialLoginUserRealm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("social_login_user_realms")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.SocialLoginUserId)
                .HasColumnType("int(11)")
                .HasColumnName("social_login_user_id");
        });

        modelBuilder.Entity<Softflow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("softflows")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DstIp)
                .HasMaxLength(64)
                .HasColumnName("dst_ip");
            entity.Property(e => e.DstPort)
                .HasColumnType("int(11)")
                .HasColumnName("dst_port");
            entity.Property(e => e.DynamicClientId)
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_client_id");
            entity.Property(e => e.Finish)
                .HasColumnType("datetime")
                .HasColumnName("finish");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.OctIn)
                .HasColumnType("bigint(20)")
                .HasColumnName("oct_in");
            entity.Property(e => e.OctOut)
                .HasColumnType("bigint(20)")
                .HasColumnName("oct_out");
            entity.Property(e => e.PcktIn)
                .HasColumnType("int(11)")
                .HasColumnName("pckt_in");
            entity.Property(e => e.PcktOut)
                .HasColumnType("int(11)")
                .HasColumnName("pckt_out");
            entity.Property(e => e.Proto)
                .HasColumnType("int(11)")
                .HasColumnName("proto");
            entity.Property(e => e.SrcIp)
                .HasMaxLength(64)
                .HasColumnName("src_ip");
            entity.Property(e => e.SrcMac)
                .HasMaxLength(64)
                .HasColumnName("src_mac");
            entity.Property(e => e.SrcPort)
                .HasColumnType("int(11)")
                .HasColumnName("src_port");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TempFlowLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("temp_flow_logs")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.DstIp)
                .HasMaxLength(255)
                .HasColumnName("dst_ip");
            entity.Property(e => e.DstPort)
                .HasColumnType("int(11)")
                .HasColumnName("dst_port");
            entity.Property(e => e.Finish)
                .HasColumnType("datetime")
                .HasColumnName("finish");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.OctIn)
                .HasColumnType("int(11)")
                .HasColumnName("oct_in");
            entity.Property(e => e.OctOut)
                .HasColumnType("int(11)")
                .HasColumnName("oct_out");
            entity.Property(e => e.PcktIn)
                .HasColumnType("int(11)")
                .HasColumnName("pckt_in");
            entity.Property(e => e.PcktOut)
                .HasColumnType("int(11)")
                .HasColumnName("pckt_out");
            entity.Property(e => e.Proto)
                .HasColumnType("int(11)")
                .HasColumnName("proto");
            entity.Property(e => e.SrcIp)
                .HasMaxLength(255)
                .HasColumnName("src_ip");
            entity.Property(e => e.SrcMac)
                .HasMaxLength(255)
                .HasColumnName("src_mac");
            entity.Property(e => e.SrcPort)
                .HasColumnType("int(11)")
                .HasColumnName("src_port");
            entity.Property(e => e.Start)
                .HasColumnType("datetime")
                .HasColumnName("start");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TempProxyLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("temp_proxy_logs")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FullString)
                .HasColumnType("text")
                .HasColumnName("full_string");
            entity.Property(e => e.FullUrl)
                .HasColumnType("text")
                .HasColumnName("full_url");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("mac");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.SourceIp)
                .HasMaxLength(255)
                .HasColumnName("source_ip");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TempReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("temp_reports")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_id");
            entity.Property(e => e.ApProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("ap_profile_id");
            entity.Property(e => e.MeshId)
                .HasColumnType("int(11)")
                .HasColumnName("mesh_id");
            entity.Property(e => e.NodeId)
                .HasColumnType("int(11)")
                .HasColumnName("node_id");
            entity.Property(e => e.Report)
                .HasColumnType("text")
                .HasColumnName("report");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<Timezone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("timezones")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasColumnName("value");
        });

        modelBuilder.Entity<TopUp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("top_ups")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Data)
                .HasColumnType("bigint(11)")
                .HasColumnName("data");
            entity.Property(e => e.DaysToUse)
                .HasColumnType("int(11)")
                .HasColumnName("days_to_use");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'data'")
                .HasColumnType("enum('data','time','days_to_use')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<TopUpTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("top_up_transactions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'create'")
                .HasColumnType("enum('create','update','delete')")
                .HasColumnName("action");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NewValue)
                .HasMaxLength(30)
                .HasColumnName("new_value");
            entity.Property(e => e.OldValue)
                .HasMaxLength(30)
                .HasColumnName("old_value");
            entity.Property(e => e.PermanentUser)
                .HasMaxLength(255)
                .HasColumnName("permanent_user");
            entity.Property(e => e.PermanentUserId)
                .HasColumnType("int(11)")
                .HasColumnName("permanent_user_id");
            entity.Property(e => e.RadiusAttribute)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("radius_attribute");
            entity.Property(e => e.TopUpId)
                .HasColumnType("int(11)")
                .HasColumnName("top_up_id");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'data'")
                .HasColumnType("enum('data','time','days_to_use')")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<UnknownDynamicClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("unknown_dynamic_clients")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Calledstationid, "calledstationid").IsUnique();

            entity.HasIndex(e => e.Nasidentifier, "nasidentifier").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Calledstationid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("calledstationid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.LastContactIp)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("last_contact_ip");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
        });

        modelBuilder.Entity<UnknownNode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("unknown_nodes")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FirmwareKeyId)
                .HasColumnType("int(11)")
                .HasColumnName("firmware_key_id");
            entity.Property(e => e.FromIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("from_ip");
            entity.Property(e => e.Gateway)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("gateway");
            entity.Property(e => e.LastContact)
                .HasColumnType("datetime")
                .HasColumnName("last_contact");
            entity.Property(e => e.Mac)
                .HasMaxLength(255)
                .HasColumnName("mac");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.NewMode)
                .HasColumnType("enum('ap','mesh')")
                .HasColumnName("new_mode");
            entity.Property(e => e.NewModeStatus)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("new_mode_status");
            entity.Property(e => e.NewServer)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("new_server");
            entity.Property(e => e.NewServerProtocol)
                .HasColumnType("enum('https','http')")
                .HasColumnName("new_server_protocol");
            entity.Property(e => e.NewServerStatus)
                .HasDefaultValueSql("'awaiting'")
                .HasColumnType("enum('awaiting','fetched','replied')")
                .HasColumnName("new_server_status");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GroupId, "idx_users_group_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("group_id");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("language_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
            entity.Property(e => e.TimezoneId)
                .HasDefaultValueSql("'316'")
                .HasColumnType("int(11)")
                .HasColumnName("timezone_id");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_settings")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.UserId, "idx_user_settings_user_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<UserSsid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_ssids")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Ssidname, "idx_user_ssids_ssidname");

            entity.HasIndex(e => e.Username, "idx_user_ssids_username");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("priority");
            entity.Property(e => e.Ssidname)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("ssidname");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_stats")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.Callingstationid, e.Timestamp }, "us_callingstationid_timestamp");

            entity.HasIndex(e => new { e.Nasidentifier, e.Timestamp }, "us_nasidentifier_timestamp");

            entity.HasIndex(e => new { e.Realm, e.Timestamp }, "us_realm_timestamp");

            entity.HasIndex(e => new { e.Username, e.Timestamp }, "us_username_timestamp");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Acctinputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctinputoctets");
            entity.Property(e => e.Acctoutputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctoutputoctets");
            entity.Property(e => e.Callingstationid)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("callingstationid");
            entity.Property(e => e.Framedipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("framedipaddress");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.Nasipaddress)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("nasipaddress");
            entity.Property(e => e.RadacctId)
                .HasColumnType("int(11)")
                .HasColumnName("radacct_id");
            entity.Property(e => e.Realm)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserStatsDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_stats_dailies")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.Callingstationid, e.Timestamp }, "usd_callingstationid_timestamp");

            entity.HasIndex(e => new { e.Nasidentifier, e.Timestamp }, "usd_nasidentifier_timestamp");

            entity.HasIndex(e => new { e.Realm, e.Timestamp }, "usd_realm_timestamp");

            entity.HasIndex(e => new { e.Username, e.Timestamp }, "usd_username_timestamp");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Acctinputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctinputoctets");
            entity.Property(e => e.Acctoutputoctets)
                .HasColumnType("bigint(20)")
                .HasColumnName("acctoutputoctets");
            entity.Property(e => e.Callingstationid)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("callingstationid");
            entity.Property(e => e.Nasidentifier)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("nasidentifier");
            entity.Property(e => e.Realm)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.UserStatId)
                .HasColumnType("int(11)")
                .HasColumnName("user_stat_id");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<UsersAccess>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.EntityName })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("users_access");

            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.EntityName)
                .HasMaxLength(24)
                .HasColumnName("entity_name");

            entity.HasOne(d => d.User).WithMany(p => p.UsersAccesses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("users_access_ibfk_1");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("vouchers")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "ak_vouchers").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Batch)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("batch");
            entity.Property(e => e.CloudId)
                .HasColumnType("int(11)")
                .HasColumnName("cloud_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DataCap)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_cap");
            entity.Property(e => e.DataUsed)
                .HasColumnType("bigint(20)")
                .HasColumnName("data_used");
            entity.Property(e => e.Expire)
                .HasColumnType("datetime")
                .HasColumnName("expire");
            entity.Property(e => e.ExtraName)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_name");
            entity.Property(e => e.ExtraValue)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("extra_value");
            entity.Property(e => e.LastAcceptNas)
                .HasMaxLength(128)
                .HasColumnName("last_accept_nas");
            entity.Property(e => e.LastAcceptTime)
                .HasColumnType("datetime")
                .HasColumnName("last_accept_time");
            entity.Property(e => e.LastRejectMessage)
                .HasMaxLength(255)
                .HasColumnName("last_reject_message");
            entity.Property(e => e.LastRejectNas)
                .HasMaxLength(128)
                .HasColumnName("last_reject_nas");
            entity.Property(e => e.LastRejectTime)
                .HasColumnType("datetime")
                .HasColumnName("last_reject_time");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.PercDataUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_data_used");
            entity.Property(e => e.PercTimeUsed)
                .HasColumnType("int(6)")
                .HasColumnName("perc_time_used");
            entity.Property(e => e.Profile)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("profile");
            entity.Property(e => e.ProfileId)
                .HasColumnType("int(11)")
                .HasColumnName("profile_id");
            entity.Property(e => e.Realm)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("realm");
            entity.Property(e => e.RealmId)
                .HasColumnType("int(11)")
                .HasColumnName("realm_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'new'")
                .HasColumnType("enum('new','used','depleted','expired')")
                .HasColumnName("status");
            entity.Property(e => e.TimeCap)
                .HasColumnType("int(12)")
                .HasColumnName("time_cap");
            entity.Property(e => e.TimeUsed)
                .HasColumnType("int(12)")
                .HasColumnName("time_used");
            entity.Property(e => e.TimeValid)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("time_valid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
