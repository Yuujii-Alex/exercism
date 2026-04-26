using System.Runtime.CompilerServices;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => str[(str.IndexOf(delimiter) + delimiter.Length)..];

	public static string SubstringBetween(this string str, string str1, string str2) => str[(str.IndexOf(str1) + str1.Length)..str.IndexOf(str2)].Trim();

	public static string Message(this string str) => str.SubstringAfter(":");

	public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}