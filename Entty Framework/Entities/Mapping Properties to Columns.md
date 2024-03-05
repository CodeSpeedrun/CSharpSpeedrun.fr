Mapping Properties to Columns

private string _color = "Gold";
public string Color
{
get => _color;
set => _color = value;
}

For backing fields, EF Core is expecting the backing field to be named using one of the following
conventions (in order of precedence):
• _<camel-cased property name>
• _<property name>
• m_<camel-cased property name>
• m_<property name>


