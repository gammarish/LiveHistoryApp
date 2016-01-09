using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace LiveHistory.Common
{
    public class ResultType
    {
        #region Properties

        public Boolean Result { get; set; }
        public String UserMessage { get; set; }
        public String Exception { get; set; }
        public String LogMessage { get; set; }

        public List<string> Errors { get; set; }
        public List<string> Warnings { get; set; }
        public dynamic ViewBag { get; set; }

        public bool Succeded
        {
            get
            {
                return (this.Errors == null || !this.Errors.Any())
                    && (this.Warnings == null || !this.Warnings.Any());
            }
        }

        #endregion

        #region Constructors

        public ResultType(Boolean result = true)
        {
            this.Result = result;
            this.UserMessage = String.Empty;
            this.Exception = String.Empty;
            this.Errors = new List<string>();
            this.Warnings = new List<string>();
            this.ViewBag = new ExpandoObject();
        }

        public ResultType(Boolean result, String userMessage, String logMessage = "")
        {
            this.Result = result;
            this.UserMessage = userMessage;
            this.LogMessage = logMessage;
        }

        public ResultType(Boolean result, String userMessage, String logMessage, String exception)
        {
            this.Result = result;
            this.UserMessage = userMessage;
            this.Exception = exception;
            this.LogMessage = logMessage;
        }

        public ResultType(String logMessage)
        {
            this.LogMessage = logMessage;
            this.Errors = new List<string>();
            this.Warnings = new List<string>();
            this.ViewBag = new ExpandoObject();
        }
        #endregion

        public Boolean HasException
        {
            get
            {
                return !String.IsNullOrEmpty(Exception);
            }
        }

        public static implicit operator bool(ResultType obj)
        {
            return obj.Result;
        }
    }

    public class ResultType<T> : ResultType
    {
        public T Value { get; set; }

        #region Constructors

        public ResultType()
            : base()
        {
        }

        public ResultType(Boolean result, String userMessage, String logMessage = "")
            : base(result, userMessage, logMessage)
        {
        }

        public ResultType(Boolean result, String userMessage, String logMessage, String exception)
            : base(result, userMessage, exception)
        {
        }


        public ResultType(T Value)
            : base()
        {
            this.Value = Value;
        }

        public ResultType(T Value, String logMessage, bool result = true)
            : base(logMessage)
        {
            this.Value = Value;
            this.Result = result;
        }

        #endregion
    }
}