/// <summary>
/// Enumeración con los tipos de usuario de la aplicación
/// </summary>
public enum TipoCliente 
{
    /// <summary>
    /// Accede a todas las opciones de la aplicación
    /// </summary>
    Administrador = 1,
    /// <summary>
    /// Solo puede acceder a la facturación y realización
    /// </summary>
    Cliente = 2,
    /// <summary>
    /// Solo puede acceder a los reportes
    /// </summary>
    Reporteador = 3
}