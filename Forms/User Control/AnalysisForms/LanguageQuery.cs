using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control.AnalysisForms
{
    public partial class LanguageQuery : UserControl, IAnalysisParameterControl
    {
        public LanguageQuery()
        {
            InitializeComponent();
        }

        public AnalysisContext GetParameters()
        {
            return new AnalysisContext
            {
                Parameters = new Dictionary<string, object>
                {
                    ["NaturalLanguageQuery"] = query_tb.Text.Trim()
                }
            };
        }

        public void Reset()
        {
            query_tb.Clear();
        }
    }
}
