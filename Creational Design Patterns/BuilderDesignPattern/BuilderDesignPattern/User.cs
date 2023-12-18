using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class User
    {
        private string userId;
        private string userName;
        private string emailId;

        //Make private constroctor so it will not creat default constructor and we also do iniialization
        private User(UserBuilder builder)
        {
            this.userId = builder.userId;
            this.userName = builder.userName;
            this.emailId = builder.emailId;

        }


        public string getUserId()
        {
            return userId;
        }
        public string getUserName()
        {
            return userName;

        }
        public string getEmailId()
        {
            return emailId;
        }


        public override string ToString()
        {
            return this.userId + ": " +this.userName + ": " + this.emailId;
        }


        //Inner class 2 to creat object it is a static class
        public class UserBuilder
        {
            public string userId;
            public string userName;
            public string emailId;

            public UserBuilder()
            {

            }

            public UserBuilder setUserId(string userid)
            {
               
                this.userId = userid;
                return this;

            }

            public UserBuilder setuserName(string usernAme)
            {

                this.userName = usernAme;
                return this;

            }

            public UserBuilder setEmaliID(string emailid)
            {

                this.emailId = emailid;
                return this;    

            }


            // Build method to create the User instance
            public User Build()
            {
               User user = new User(this);
                return user;    
            }

        }

    }
}
