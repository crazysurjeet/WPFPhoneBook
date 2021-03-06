﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPFPhonebook.Model
{
    public abstract class BasePerson : IDataErrorInfo
    {
        public string this[string PropertyName]
        {
            get
            {
                string result = string.Empty;
                switch (PropertyName)
                {
                    case "FName":
                        if (string.IsNullOrEmpty(FName))
                            result = "First name is required";
                        break;
                    case "ContactNo":
                        if (string.IsNullOrEmpty(ContactNo))
                            result = "ContactNo is required";
                        break;
                    case "EmailId":
                        if (string.IsNullOrEmpty(EmailId))
                            result = "EmailId is required";
                        break;
                }
                return result;
            }
        }
        static readonly string[] ValidateProperties={ "FName", "ContactNo", "EmailId" };
        public bool IsValid
        {
            get
            {
                foreach(var property in ValidateProperties)
                {
                    if (!string.IsNullOrEmpty(this[property]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Country Country { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }

        public string Error
        {
            get { return null; }
        }
    }
    public enum Gender { Male, Female, Others}
    public enum Country { India, UnitedStates, Canada};

}
