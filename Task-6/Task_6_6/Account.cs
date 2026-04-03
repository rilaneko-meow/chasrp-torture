namespace Organization
{
    class Account
    {
        public int Id;
        public string? Login = "";
        public string? FullName = "";
        public int Age;
        public AccessRightsType AccessRights;

        public Account() => Age = 18;
        public Account(int id, string? login, string? full_name, int age, AccessRightsType access)
        {
            Id = Math.Abs(id);
            Login = login;
            FullName = full_name;
            Age = (18 <= age) && (age <= 100) ? age : 18;
            AccessRights = access;
        }
        
        public bool IsAdmin() => AccessRights == AccessRightsType.Admin;
        public bool IsManager() => AccessRights == AccessRightsType.Manager;
        public bool IsEmployee() => AccessRights == AccessRightsType.Employee;
        public bool IsGuest() => AccessRights == AccessRightsType.Guest;

        public override string ToString() =>
        $"ID: {Id}\nЛогин: {Login}\nФИО: {FullName}\nВозраст: {Age}\nПрава доступа:{GetAccessRightsType()}";
        public bool IsAdult() => Age >= 18;

        public string? GetAccessRightsType() => AccessRights switch
        {
            AccessRightsType.Admin => "Администратор",
            AccessRightsType.Manager => "Менеджер",
            AccessRightsType.Employee => "Сотрудник",
            AccessRightsType.Guest => "Гость",
            _ => "Ошибка"
        };
    }
}