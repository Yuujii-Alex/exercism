static class LogLine
{
	// this is a C# 8.0 range operator, it takes the substring starting from the index of ":" + 1 to the end of the string, and then trims any leading or trailing whitespace.
	public static string Message(string logLine) => logLine[(logLine.IndexOf(":") + 1)..].Trim(); 

	// this is a C# 8.0 range operator, it takes the substring starting from index 1 to the index of "]", and then converts it to lowercase.
	public static string LogLevel(string logLine) => logLine[1..logLine.IndexOf("]")].ToLower();

	// this is a C# 8.0 interpolated string, it calls the Message and LogLevel methods to format the log line as specified.
	public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
