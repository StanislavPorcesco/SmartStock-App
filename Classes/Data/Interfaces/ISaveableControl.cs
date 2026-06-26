using System.Threading.Tasks;

namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Outcome of a save attempt, so the hosting form (BaseAddInstance) can react without
    /// double-messaging:
    ///   • Success — saved; host shows the success confirmation.
    ///   • Handled — failed, but the control already showed a specific message
    ///               (validation error, caught DB error). Host shows nothing.
    ///   • Failed  — failed without a control-level message; host shows a generic error.
    /// </summary>
    public enum SaveOutcome
    {
        Success,
        Handled,
        Failed
    }

    public interface ISaveableControl
    {
        Task<SaveOutcome> PerformSave(bool isAddMode);
        Task<bool> PerformArchive(int id);
        void UpdateUIState(bool isAddMode);
        int GetCurrentId();
        void ClearControls();
        void LoadById(int id);
    }
}
