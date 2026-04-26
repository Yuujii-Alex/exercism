static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(' ');
		return logLine.Substring(index).Trim();
    }

    public static string LogLevel(string logLine)
    {
		int firstIndex = logLine.IndexOf('[');
		int lastIndex = logLine.IndexOf("]");
		return logLine.Substring(firstIndex + 1, lastIndex - 1).ToLower().Trim();
	}

	public static string Reformat(string logLine)
    {
		int firstIndex = logLine.IndexOf("[") + 1;
		int lastIndex = logLine.IndexOf("]") - 1;
		int index = logLine.IndexOf(' ');
		return $"{logLine.Substring(index).Trim()} ({logLine.Substring(firstIndex,lastIndex).ToLower()})";
	}
}
