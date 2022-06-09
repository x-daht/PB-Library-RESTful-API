namespace Model.Configuration;

/// <summary>
/// Base schema of the model configuration
/// </summary>
internal abstract class BaseSchema
{
    protected string _schema;

    protected BaseSchema(Schema schema) => _schema = schema.ToString();
}