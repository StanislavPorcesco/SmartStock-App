namespace SmartStock.Classes.Utils
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Centralizes user-facing field-validation feedback so every Add/Modify form reports
    /// input problems with the same title, icon, and phrasing style.
    ///
    /// Each <c>Require*</c> method is a guard clause: it returns <c>true</c> when the field
    /// is valid, or shows a uniform message and returns <c>false</c> when it isn't.
    /// </summary>
    public static class FormValidator
    {
        private const string ValidationTitle = "Validation Error";

        /// <summary>Shows a uniform field-validation warning.</summary>
        public static void ShowError(string message) =>
            MessageBox.Show(message, ValidationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        /// <summary>Shows a uniform database/exception error.</summary>
        public static void ShowDbError(Exception ex) =>
            MessageBox.Show($"A database error occurred: {ex.Message}", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>Required free-text field, with an optional minimum length.</summary>
        public static bool RequireText(string value, string fieldName, int minLength = 1)
        {
            value = value?.Trim() ?? string.Empty;

            if (value.Length == 0)
            {
                ShowError($"Please enter the {fieldName}.");
                return false;
            }

            if (value.Length < minLength)
            {
                ShowError($"{fieldName} must be at least {minLength} characters long.");
                return false;
            }

            return true;
        }

        /// <summary>Required combo/list selection (SelectedIndex must be ≥ 0).</summary>
        public static bool RequireSelection(int selectedIndex, string fieldName)
        {
            if (selectedIndex < 0)
            {
                ShowError($"Please select a {fieldName}.");
                return false;
            }

            return true;
        }

        /// <summary>Positive integer identifier (e.g. a referenced Product/Customer ID).</summary>
        public static bool RequireId(string text, string fieldName, out int value)
        {
            if (!int.TryParse(text?.Trim(), out value) || value <= 0)
            {
                ShowError($"Please enter a valid {fieldName}.");
                value = 0;
                return false;
            }

            return true;
        }

        /// <summary>Optional positive-integer id — empty is allowed; if filled it must be valid.</summary>
        public static bool RequireOptionalId(string text, string fieldName, out int? value)
        {
            value = null;
            text = text?.Trim() ?? string.Empty;
            if (text.Length == 0) return true;

            if (!int.TryParse(text, out int parsed) || parsed <= 0)
            {
                ShowError($"Please enter a valid {fieldName}.");
                return false;
            }

            value = parsed;
            return true;
        }

        /// <summary>Date that must not be later than today.</summary>
        public static bool RequireNotFuture(DateTime value, string fieldName)
        {
            if (value.Date > DateTime.Today)
            {
                ShowError($"{fieldName} cannot be in the future.");
                return false;
            }

            return true;
        }

        /// <summary>Integer field, optionally constrained to &gt; 0 or ≥ 0.</summary>
        public static bool RequireInt(string text, string fieldName, out int value,
                                      bool positiveOnly = false, bool nonNegative = false)
        {
            if (!int.TryParse(text?.Trim(), out value))
            {
                ShowError($"Please enter a valid number for {fieldName}.");
                value = 0;
                return false;
            }

            if (positiveOnly && value <= 0)
            {
                ShowError($"{fieldName} must be greater than zero.");
                return false;
            }

            if (nonNegative && value < 0)
            {
                ShowError($"{fieldName} cannot be negative.");
                return false;
            }

            return true;
        }

        /// <summary>Decimal field, optionally constrained to &gt; 0 or ≥ 0.</summary>
        public static bool RequireDecimal(string text, string fieldName, out decimal value,
                                          bool positiveOnly = false, bool nonNegative = false)
        {
            if (!decimal.TryParse(text?.Trim(), out value))
            {
                ShowError($"Please enter a valid number for {fieldName}.");
                value = 0m;
                return false;
            }

            if (positiveOnly && value <= 0)
            {
                ShowError($"{fieldName} must be greater than zero.");
                return false;
            }

            if (nonNegative && value < 0)
            {
                ShowError($"{fieldName} cannot be negative.");
                return false;
            }

            return true;
        }

        /// <summary>Required email — must be present and well-formed.</summary>
        public static bool RequireEmail(string value)
        {
            value = value?.Trim() ?? string.Empty;

            if (value.Length == 0)
            {
                ShowError("Please enter the email address.");
                return false;
            }

            if (!value.Contains('@') || !value.Contains('.'))
            {
                ShowError("Please enter a valid email address.");
                return false;
            }

            return true;
        }

        /// <summary>Optional email — only validated when the user typed something.</summary>
        public static bool ValidateOptionalEmail(string value)
        {
            value = value?.Trim() ?? string.Empty;
            if (value.Length == 0) return true;

            if (!value.Contains('@') || !value.Contains('.'))
            {
                ShowError("Please enter a valid email address.");
                return false;
            }

            return true;
        }
    }
}
