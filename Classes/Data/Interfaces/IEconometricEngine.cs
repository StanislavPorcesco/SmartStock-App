using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Interfață pentru motorul econometric care efectuează analize statistice.
    /// Responsabilă pentru calculul corelațiilor, analiza tendințelor și evaluarea modelelor.
    /// </summary>
    public interface IEconometricEngine
    {
        /// <summary>
        /// Calculează corelația între vânzări și factori externi.
        /// </summary>
        /// <param name="sales">Lista valorilor de vânzări</param>
        /// <param name="factors">Lista valorilor factorilor externi</param>
        /// <returns>Valoarea corelației (între -1 și 1)</returns>
        decimal CalculateCorrelation(List<decimal> sales, List<decimal> factors);

        /// <summary>
        /// Analizează corelația dintre vânzări și factori externi pe serii DEJA ALINIATE pe dată.
        /// Apelantul (Facade) este responsabil de alinierea pe bucket-uri de aceeași dată.
        /// </summary>
        /// <param name="alignedSales">Vânzări aliniate pe dată cu factorii</param>
        /// <param name="alignedFactors">Valori de impact ale factorilor, aliniate pe dată cu vânzările</param>
        /// <returns>Corelația Pearson, p-value bilateral (t-test, df=n-2) și nr. de perechi</returns>
        (decimal Correlation, decimal PValue, int N) AnalyzeFactorCorrelation(
            List<decimal> alignedSales,
            List<decimal> alignedFactors);

        /// <summary>
        /// Returnează multiplicatorul pentru intervalele de confidență/predicție OLS:
        /// valoarea critică t-Student bilaterală t_{α/2, df} pentru nivelul de încredere dat.
        /// Pentru SEE estimat din reziduuri, t este corect (nu z normal), esențial la eșantioane mici.
        /// </summary>
        /// <param name="confidencePercent">Nivelul de încredere (ex. 95)</param>
        /// <param name="df">Gradele de libertate (n - 2 pentru regresie liniară simplă)</param>
        decimal GetConfidenceMultiplier(int confidencePercent, int df);

        /// <summary>
        /// Regresie liniară multiplă OLS: y = β₀ + Σ βⱼ·xⱼ (intercept + regresori daţi).
        /// Foloseşte ecuaţiile normale β = (XᵀX)⁻¹Xᵀy şi păstrează (XᵀX)⁻¹ pentru
        /// intervalele de predicţie. Întoarce IsValid=false dacă XᵀX e (aproape)
        /// singulară sau dacă nu sunt suficiente observaţii (n &lt; p+1).
        /// </summary>
        /// <param name="response">Variabila dependentă y (ex. vânzări zilnice agregate).</param>
        /// <param name="regressors">Coloanele regresorilor, fiecare aliniată pe dată cu y.</param>
        MultipleRegressionResult FitMultipleRegression(
            List<decimal> response,
            List<List<decimal>> regressors);

        /// <summary>
        /// Obține analiza tendințelor pentru un produs specific.
        /// Incluzând trend liniar, sezonalitate și anomalii.
        /// </summary>
        /// <param name="productId">ID-ul produsului pentru care se efectuează analiza</param>
        /// <param name="factors">Factori externi deja pregătiți/filtrați (opțional)</param>
        /// <param name="startDate">Data de început a intervalului de analiză (opțional)</param>
        /// <param name="endDate">Data de sfârșit a intervalului de analiză (opțional)</param>
        /// <returns>Task cu analiza tendințelor</returns>
        Task<EconometricModel> GetTrendAnalysisAsync(
            int productId,
            List<ExternalFactor>? factors = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            List<decimal>? aggregatedSales = null);
    }
}
