namespace Action.Common.Events
{
    public class UserRejected : IRejectedEvent
    {

        protected UserRejected() { }

        public UserRejected(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }

        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }
    }
}