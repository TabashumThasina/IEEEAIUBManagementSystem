using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace demoproject
{
    class User
    {
        private string fname, lname, Gender, AIUB_ID, IEEE_ID, pass, Dept, email, contact, MemberShipType, Type;
        private DateTime DOB = new DateTime();

        public User()
        {

        }
        public User(string ID)
        {
            this.AIUB_ID = ID;
        }

        public string FName
        {
            set { this.fname = value; }
            get { return this.fname; }
        }
        public string LName
        {
            set { this.lname = value; }
            get { return this.lname; }
        }
        public string gender
        {
            set { this.Gender = value; }
            get { return this.Gender; }
        }
        public string AID
        {
            set { this.AIUB_ID = value; }
            get { return this.AIUB_ID; }
        }
        public string IID
        {
            set { this.IEEE_ID = value; }
            get { return this.IEEE_ID; }
        }
        public string Password
        {
            set { this.pass = value; }
            get { return this.pass; }
        }
        public string Department
        {
            set { this.Dept = value; }
            get { return this.Dept; }
        }
        public string type
        {
            set { this.Type = value; }
            get { return this.Type; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Contact
        {
            set { this.contact = value; }
            get { return this.contact; }
        }
        public string MemberType
        {
            set { this.MemberShipType = value; }
            get { return this.MemberShipType; }
        }
        public DateTime Date_OF_Birth
        {
            set { this.DOB = value; }
            get { return this.DOB; }
        }

    }
}
