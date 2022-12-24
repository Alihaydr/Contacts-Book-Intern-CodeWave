using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTest.Module
{
    public class Data
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        private string pic;

        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }
        

        public Data(int id, string firstname, string middlename, string lastname, string phone, string email, String pic)
        {
            this.id = id;
            this.firstName = firstname;
            this.middleName = middlename;
            this.lastName = lastname;
            this.phone = phone;
            this.email = email;
            this.pic = pic;

        }


        public override string ToString()
        {
            String tstr = id + "|" + firstName + "|" + middleName + "|" + lastName + "|" + phone + "|" + email + "|" + pic;
            return tstr;
        }

    }
}
