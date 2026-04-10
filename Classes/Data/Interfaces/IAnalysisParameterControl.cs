using SmartStock.Classes.Data.DTOs;

namespace SmartStock.Classes.Data.Interfaces
{
    public interface IAnalysisParameterControl
    {
        AnalysisContext GetParameters();
        void Reset();
    }
}
