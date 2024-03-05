Serializing and Deserialization with System.Text.Json

use this
formatter to persist the public state of a given object as JSON.

Select Attributes of the System.text.Json.Serialization Namespace
.NET Attribute Meaning in Life
[JsonIgnore] The property will be ignored.
[JsonInclude] The member will be included.
[JsonPropertyName] Specifies the property name to be used when serializing/deserializing a member.
This is commonly used to resolve character casing issues.
[JsonConstructor] Indicates the constructor that should be used when deserializing JSON back into
an object graph.

