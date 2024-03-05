The Abstract Stream Class

In the world of I/O manipulation, a stream
represents a chunk of data flowing between a source and a destination. Streams provide a common way to
interact with a sequence of bytes, regardless of what kind of device (e.g., file, network connection, or printer)
stores or displays the bytes in question.


The concept of a stream is not limited to file I/O. To be sure, the .NET Core libraries provide stream
access to networks, memory locations, and other stream-centric abstractions.

Stream descendants represent data as a raw stream of bytes; therefore, working directly with
raw streams can be quite cryptic. Some Stream-derived types support seeking, which refers to the process
of obtaining and adjusting the current position in the stream.


Abstract Stream Members
Member Meaning in Life
CanRead
CanWrite
CanSeek
Determines whether the current stream supports reading, seeking, and/or writing.
Close() Closes the current stream and releases any resources (such as sockets and file handles)
associated with the current stream. Internally, this method is aliased to the Dispose()
method; therefore, closing a stream is functionally equivalent to disposing a stream.
Flush() Updates the underlying data source or repository with the current state of the buffer and
then clears the buffer. If a stream does not implement a buffer, this method does nothing.
Length Returns the length of the stream in bytes.
Position Determines the position in the current stream.
Read()
ReadByte()
ReadAsync()
Reads a sequence of bytes (or a single byte) from the current stream and advances the
current position in the stream by the number of bytes read.
Seek() Sets the position in the current stream.
SetLength() Sets the length of the current stream.
Write()
WriteByte()
WriteAsync()
Writes a sequence of bytes (or a single byte) to the current stream and advances the
current position in this stream by the number of bytes written.


