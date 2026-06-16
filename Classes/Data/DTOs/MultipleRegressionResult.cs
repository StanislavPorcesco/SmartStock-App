namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// Rezultatul unei regresii liniare multiple OLS: y = β₀ + β₁·x₁ + … + β_k·x_k.
    /// Modelul: vânzări ~ intercept + factori externi (fără termen de timp explicit,
    /// pentru a evita multicoliniaritatea temperatură↔timp). Vezi
    /// docs/ANALYSIS_MODULE_REVIEW.md, secțiunea „Regresie multiplă".
    /// </summary>
    public sealed class MultipleRegressionResult
    {
        /// <summary>False dacă XᵀX e (aproape) singulară sau n &lt; p+1 → apelantul face fallback.</summary>
        public bool IsValid { get; set; }

        /// <summary>Coeficienții β₀..β_{p-1} (β₀ = intercept).</summary>
        public double[] Coefficients { get; set; } = System.Array.Empty<double>();

        /// <summary>(XᵀX)⁻¹ (p×p) — necesară pentru intervalele de predicție.</summary>
        public double[,] XtXInverse { get; set; } = new double[0, 0];

        public double RSquared { get; set; }
        public double AdjustedRSquared { get; set; }

        /// <summary>Eroarea standard a estimării: SEE = √(SSres / (n − p)).</summary>
        public double StandardError { get; set; }

        /// <summary>Statistica F pentru semnificația globală a regresiei.</summary>
        public double FStatistic { get; set; }

        /// <summary>p-value asociat testului F (semnificativ dacă &lt; 0.05).</summary>
        public double FPValue { get; set; }

        /// <summary>Erorile standard per coeficient: SE(βⱼ) = SEE·√((XᵀX)⁻¹ⱼⱼ).</summary>
        public double[] CoefficientStdErrors { get; set; } = System.Array.Empty<double>();

        /// <summary>Statistici t per coeficient: βⱼ / SE(βⱼ).</summary>
        public double[] CoefficientTStats { get; set; } = System.Array.Empty<double>();

        /// <summary>p-value bilateral per coeficient (df = n − p).</summary>
        public double[] CoefficientPValues { get; set; } = System.Array.Empty<double>();

        public int N { get; set; }       // observații
        public int P { get; set; }       // parametri (intercept + regresori)

        /// <summary>
        /// Predicție punctuală: ŷ = x₀ · β, unde x₀ = [1, valori factori].
        /// </summary>
        public double Predict(double[] xRow)
        {
            double sum = 0;
            for (int j = 0; j < Coefficients.Length; j++)
                sum += Coefficients[j] * xRow[j];
            return sum;
        }

        /// <summary>
        /// Termenul de leverage h = x₀ᵀ (XᵀX)⁻¹ x₀ pentru benzile de încredere/predicție.
        /// </summary>
        public double Leverage(double[] xRow)
        {
            int p = xRow.Length;
            double h = 0;
            for (int i = 0; i < p; i++)
            {
                double row = 0;
                for (int j = 0; j < p; j++)
                    row += xRow[j] * XtXInverse[j, i];
                h += row * xRow[i];
            }
            return h;
        }
    }
}
