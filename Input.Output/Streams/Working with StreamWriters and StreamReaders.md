Working with StreamWriters and StreamReaders

The StreamWriter and StreamReader classes are useful whenever you need to read or write character-based
data (e.g., strings). Both work by default with Unicode characters; however, you can change this by supplying
a properly configured System.Text.Encoding object reference.

Core Members of TextWriter
Member Meaning in Life
Close() This method closes the writer and frees any associated resources. In the process, the
buffer is automatically flushed (again, this member is functionally equivalent to calling
the Dispose() method).
Flush() This method clears all buffers for the current writer and causes any buffered data to be
written to the underlying device; however, it does not close the writer.
NewLine This property indicates the newline constant for the derived writer class. The default
line terminator for the Windows OS is a carriage return, followed by a line feed (\r\n).
Write()
WriteAsync()
This overloaded method writes data to the text stream without a newline constant.
WriteLine()
WriteLineAsync()



it defines the additional AutoFlush property. When set to true, this property forces
StreamWriter to flush all data every time you perform a write operation. Be aware that you can gain better
performance by setting AutoFlush to false, provided you always call Close() when you finish writing with a
StreamWriter.


