namespace FolderSecuringProject.Models
{
    public class FolderInfo
    {
        public string FolderPath { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordReinsertedHash { get; set; }
        public bool IsLocked { get; set; }
        
    }
}
