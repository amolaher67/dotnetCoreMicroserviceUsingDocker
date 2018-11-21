using System;

namespace Action.Common.Exceptions
{
    public class ActionException : Exception
    {
        public string Code { get; }

        public ActionException()
        {
        }

        public ActionException(string code)
        {
            Code = code;
        }

        public ActionException(string message, params object[] args) : this(string.Empty, message, args)
        {
        }

        public ActionException(string code, string message, params object[] args) : this(null, code, message, args)
        {
        }

        public ActionException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public ActionException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}