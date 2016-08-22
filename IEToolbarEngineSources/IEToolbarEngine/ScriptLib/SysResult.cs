using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptLib
{

    public class ErrorModel
    {
        private String _errorCode;
	
	    private String _errorMsg;

        public String errorCode
        {
            set{_errorCode = value;}
            get{return _errorCode;}
        }
	
	    public String errorMsg
        {
            set { _errorMsg = value; }
            get { return _errorMsg; }
        }
    }

    public class SysResult
    {
        private string _resultType;
        private string _resultCode;
        private string _resultMsg;

        /// <summary>
        /// 出单员ID
        /// </summary>
        private int _insuranceWriterId;
        
        private List<ErrorModel> listError;


        public SysResult()
        {
            errors = new List<ErrorModel>();
        }

        public string resultType
        {
            set { _resultType = value; }
            get { return _resultType; }
        }

        public string resultCode
        {
            set { _resultCode = value; }
            get { return _resultCode; }
        }

        public string resultMsg
        {
            set { _resultMsg = value; }
            get { return _resultMsg; }
        }

       public List<ErrorModel> errors
        {
            set { this.listError = value; }
            get { return this.listError; }
        }

       public int InsuranceWriterId
       {
           get { return _insuranceWriterId; }
           set { _insuranceWriterId = value; }
       }
    }
}
