namespace SmartStock.Classes.Utils
{
    /// <summary>
    /// Role-based access control. Single source of truth for what each role may do,
    /// keyed off <see cref="SessionManager.CurrentUser"/>.Role ("Admin" | "Manager" | "Operator").
    ///
    /// FAIL-CLOSED: an unknown/null/typo role is treated as the most restrictive (Operator),
    /// so a missing privilege locks a user OUT rather than granting access by accident.
    ///
    /// Privilege matrix (see also the spec in docs):
    ///                                   Operator  Manager  Admin
    ///   ModifyForms (non-User)             ✓        ✓       ✓
    ///   ModifyUser / FilterUsers           ✗        ✗       ✓
    ///   SearchForm (non-User filters)      ✓        ✓       ✓
    ///   AnalyzeForm                        ✗        ✓       ✓
    ///   Settings · Theme + Enable Logging  ✓        ✓       ✓
    ///   Settings · Currency Symbol         ✗        ✓       ✓
    ///   Settings · File Paths              ✗        ✓       ✓
    ///   Settings · Automated Reporting     ✗        ✓       ✓
    ///   Settings · External Factors        ✗        ✓       ✓
    ///   Settings · AI Provider+Temperature ✗        ✓       ✓
    ///   Settings · AI API Key (view/edit)  ✗        ✗       ✓
    ///   Settings · Advanced Logging        ✗        ✓       ✓
    /// </summary>
    public static class PermissionService
    {
        private static string Role => SessionManager.CurrentUser?.Role ?? "Operator";

        public static bool IsAdmin   => Role == "Admin";
        public static bool IsManager => Role == "Manager";

        // Convenience: Manager-or-higher (everything an Operator-restricted feature opens up to).
        private static bool ManagerOrAdmin => IsAdmin || IsManager;

        // ── Navigation ──────────────────────────────────────────────────────────
        public static bool CanAccessAnalyze => ManagerOrAdmin;     // Operator: no access
        public static bool CanManageUsers   => IsAdmin;            // "User" entity in Modify/Search selectors

        // ── SettingsForm sections ───────────────────────────────────────────────
        public static bool CanEditCurrencySymbol    => ManagerOrAdmin; // Operator: hidden
        public static bool CanAccessFilePaths        => ManagerOrAdmin;
        public static bool CanAccessReporting        => ManagerOrAdmin;
        public static bool CanAccessExternalFactors  => ManagerOrAdmin;
        public static bool CanAccessAiSettings       => ManagerOrAdmin; // AI Provider + Temperature
        public static bool CanViewApiKey             => IsAdmin;        // Manager: cannot view/edit the key
        public static bool CanAccessAdvancedLogging  => ManagerOrAdmin; // Operator: only "Enable Logging"
        // Theme selection and the "Enable Logging" checkbox are available to every role.
    }
}
