static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string str = "";
        if (id != null) {
            str += $"[{id}] - ";
        }
        str += name;
        
        if (department == null) {
           str += $" - OWNER";
        } else {
            str += $" - {department.ToUpper()}";
        }
        
        return str;
    }
}
