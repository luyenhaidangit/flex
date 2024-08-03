namespace Flex.Domain.SystemManagement.User.Entities
{
    public class TlProfiles
    {
        #region Properties
        public string TlId { get; set; }

        public string TlName { get; set; }

        public string? Pin { get; set; }
        #endregion

        #region Business
        public void Login()
        {
        }
        #endregion
    }
}