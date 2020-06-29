namespace LibraryManagementFunctionTest.Model
{
    public class UserManagementAdmin
    {
        public int Id;
        public string Name;
        public string Number;
        public string Roles;

        public static string[] GetRoles(string role)
        {
            return role.Split('|');
        }
    }
}
