using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Data.Interfaces
{
    public interface ISaveableControl
    {
        Task<bool> PerformSave(bool isAddMode);
        Task<bool> PerformArchive(int id);
        void UpdateUIState(bool isAddMode);
        int GetCurrentId();
        void ClearControls();
        void LoadById(int id);
    }
}
