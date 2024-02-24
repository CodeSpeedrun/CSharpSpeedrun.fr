Using a Stand-Alone Discard (New 7.0)

var _ = new Timer(
timeCB, // The TimerCallback delegate object.
null, // Any info to pass into the called method
// (null for no info).
0, // Amount of time to wait before starting
//(in milliseconds).
1000); // Interval of time between calls
//(in milliseconds).

