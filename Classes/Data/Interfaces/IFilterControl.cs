namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Interfață pentru UserControls de filtrare.
    /// Standardizează comportamentul controalelor de filtrare din aplicație.
    /// </summary>
    public interface IFilterControl
    {
        /// <summary>
        /// Eveniment declanșat când se schimbă criteriile de filtrare.
        /// </summary>
        event Action FilterChanged;

        /// <summary>
        /// Obține datele filtrate conform criteriilor setate în UserControl.
        /// </summary>
        /// <returns>Obiectul cu datele filtrate (tipul depinde de implementare)</returns>
        object GetFilteredData();

        /// <summary>
        /// Resetează filtrele la valorile lor implicite.
        /// </summary>
        void ResetFilters();
    }
}
