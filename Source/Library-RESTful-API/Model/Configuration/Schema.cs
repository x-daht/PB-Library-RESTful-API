namespace Model.Configuration;

/// <summary>
/// Model scheme type
/// </summary>
internal enum Schema
{
    /// <summary>
    /// Database Owner [dbo] | SQL Server default schema
    /// </summary>
    dbo,
    /// <summary>
    /// Development Schema
    /// </summary>
    dev,
    /// <summary>
    /// Production Schema
    /// </summary>
    pro
}