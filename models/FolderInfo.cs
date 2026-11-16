namespace FolderSecuringProject.Models
{
    public class FolderInfo
    {
        public string FolderPath { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordReinserted { get; set; }
        public bool IsLocked { get; set; }
        
    }
}
