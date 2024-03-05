Number Handling with JsonSerializer

JsonNumberHandling Enum Values
Enum Value Meaning in Life
Strict (0) Numbers are read from numbers and written as numbers.
Quotes are not allowed nor are they generated.
AllowReadingFromString (1) Numbers can be read from number or string tokens.
WriteAsString (2) Numbers are written as JSON strings (with quotes).
AllowNamedFloatingPointLiterals (4) The Nan, Infinity, and -Infinity string tokens can be
read, and Single and Double values will be written as their
corresponding JSON string representations.

For example, if you
want to read strings (and numbers) and write numbers as strings, you use the following option setting:
JsonSerializerOptions options = new()
{
...
NumberHandling = JsonNumberHandling.AllowReadingFromString & JsonNumberHandling.
WriteAsString
};
With this change, the JSON created for the Car class is as follows:
{
"canFly": true,
"canSubmerge": false,
"theRadio": {
"hasTweeters": true,
"hasSubWoofers": false,
"stationPresets": [
"89.3",
"105.1",
"97.1"
],
"radioId": "XF-552RR6"
},
"isHatchBack": false
}
Table 20-14. JsonNumberHandling Enum Values
Enum Value Meaning in Life
Strict (0) Numbers are read from numbers and written as numbers.
Quotes are not allowed nor are they generated.
AllowReadingFromString (1) Numbers can be read from number or string tokens.
WriteAsString (2) Numbers are written as JSON strings (with quotes).
AllowNamedFloatingPointLiterals (4) The Nan, Infinity, and -Infinity string tokens can be
read, and Single and Double values will be written as their
corresponding JSON string


